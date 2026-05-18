using CoreOfficeERP.Common.Extensions;
using CoreOfficeERP.Common.Hepler;
using CoreOfficeERP.Domain.Responses.Agent;
using CoreOfficeERP.Domain.Responses.Tally;
using CoreOfficeERP.Tally.Interfaces;
using System.Globalization;
using Tally;
using static System.Runtime.InteropServices.JavaScript.JSType;



// Alias for DLL
using TallyDll = TallyBridge;

namespace CoreOfficeERP.Tally.Services
{
    public class TallyPurchaseService : ITallyPurchaseService
    {
        private readonly TallyDll.TallyBridgeDll _tb;

        public TallyPurchaseService()
        {
            _tb = new TallyDll.TallyBridgeDll();
        }

        public TallyResponse CreateVendorGroup(AgentTableResponse agentTable, TallyConfigResponse config)
        {
            var group = new Group
            {
                //Valid Tally Company Name
                tallyCompanyName = config.Company.Name,

                //This line is required only if the vendor group is being altered or re-uploaded. 
                //During initial vendor group creation, this line is not required.
                oldGroupName = agentTable.TallyLedgerName ?? agentTable.Name,
                groupName = agentTable.Name,
                //Alias of the vendor group, if you wish to maintain; else you need not pass it
                groupAlias = "",
                parentGroupName = "Sundry Creditors"
            };

            return _tb.DoTransferGroup(group);
        }

        public TallyResponse CreateVendor(SupplierResponse supplier, TallyConfigResponse config)
        {
            Ledger vendorLedger = new Ledger();

         
            var ledger = new Ledger
            {
                tallyCompanyName = config.Company.Name,

                //This line is required only if the ledger is being altered or re-uploaded. 
                //During initial ledger creation, this line is not required.
                oldLedgerName = supplier.TallyLedgerName??supplier.Name,

                ledgerName = supplier.Name,

                //Mailing Name of the vendor master
                ledgerMailingName = supplier.Name,

                //Alias of the vendor master, if you wish to maintain; else you need not pass it
                ledgerAlias = "",

                //Parent Group of the Vendor Master
                //This group must already exist in Tally
                parentGroupName = supplier.AgentObj.Name,

                address = new string[2]
                {
                 supplier.Address,
                 supplier.City
                },
             
                //State Name should be from the List of States available in Tally
                state = supplier.State,
                pinCode = supplier.Pincode,

                //Country Name should be from the List of Countries available in Tally
                //and the spelling of the country should be identical as in Tally
                country = "India",

                //vendorLedger.contactPerson = "Mr. X";
                telephoneNo = supplier.Mobile,
                mobileNo =supplier.Mobile,
                isdCode = "+91",
                faxNo = "",
                email = supplier.Email,
                emailCc = supplier.Email,
                website = "",

                gstin = supplier.GstIn,

                //Valid values as per Tally dropdown: "Regular", "Composition", "Unregistered/Consumer"
                gstRegistrationType = supplier.RegType.ToTallyString(),

                panNo = supplier.PAN,

                //You can decide whether to maintain bill-wise details or not
                maintainBillWiseDetails = true,               
                defaultCreditPeriod = $"{supplier.CreditDays ?? 15} days"

            };

            return _tb.DoTransferLedger(ledger);
        }

        public TallyResponse CreateStockCategory(StockCategoryResponse category, TallyConfigResponse config)
        {

            var cat = new StockCategory
            {
               tallyCompanyName = config.Company.Name,
                //This line is required only if the stock category is being altered or re-uploaded. 
                //During initial stock category creation, this line is not required.
                oldCategoryName = category.TallyLedgerName?? category.Name,

               categoryName = category.Name,

               //Alias of the stock category, if you wish to maintain; else you need not pass it
               categoryAlias = "",

               //Parent Category of this Stock Category
               //This parent category must already exist in Tally
               parentCategoryName = "",
            
        };

            return _tb.DoTransferStockCategory(cat);
        }

        public TallyResponse CreateStockGroup(StockGroupResponse group, TallyConfigResponse config)
        {           
            var grp = new StockGroup
            {
                tallyCompanyName = config.Company.Name,

                //This line is required only if the stock group is being altered or re-uploaded. 
                //During initial stock group creation, this line is not required.
                oldGroupName = group.TallyLedgerName??group.Name,

                groupName = group.Name,

                //Alias of the stock group, if you wish to maintain; else you need not pass it
                groupAlias = "",

                //Parent Group of this Stock Group
                //This group must already exist in Tally
               // parentGroupName = "Sarees",
                isAddable = true,
            };
            if (!group.IsGstRule)
            {
                var gst = new StockGroupGstDetails
                {

                    applicableFrom = DateTime.ParseExact("01-Jul-2017", "dd-MMM-yyyy", CultureInfo.InvariantCulture),

                    //The value for this must be a valid value as per the Tally dropdown, e.g. "Specify Details Here" or "As per Company/Stock Group"
                    sourceOfGstDetails = "Specify Details Here",

                    //The value for this must be a valid value as per the Tally dropdown, e.g.. "Exempt", "Nil Rated", or "Taxable"
                    taxability = "Taxable",
                    isReverseChargeApplicable = false,

                    igstRate = group.GstValue,
                    cgstRate = group.GstValue / 2,
                    sgstRate = group.GstValue / 2

                };

                //The ArrayList arlGstDetails should be filled up with objects of type StockGroupGstDetails
                //It represents the Tax Rate History, and there should be 1 object for each date when the tax rate or other GST details were changed
                grp.arlGstDetails.Add(gst);
            }
            else
            {
                var gstSlab = new StockGroupGstDetails
                {
                    applicableFrom = DateTime.ParseExact("01-Jul-2017", "dd-MMM-yyyy", CultureInfo.InvariantCulture),
                    sourceOfGstDetails = "Specify Slab-Based Rates",
                    isSlabRateOnMrp = false
                };               
                foreach (var rule in group.GstRules)
                {
                    var gstSlabDetails = new StockGroupGstSlabDetails
                    {
                        taxability = "Taxable",

                        // if EndRange = 0 then it is last slab
                        toItemRate = rule.EndRange,

                        igstRate = rule.GstValue,

                        // divide GST equally
                        cgstRate = rule.GstValue / 2,

                        sgstRate = rule.GstValue / 2,

                        cessRate = 0
                    };

                    gstSlab.arlGstSlabDetails.Add(gstSlabDetails);                 
                    }
                // Add to group
                grp.arlGstDetails.Add(gstSlab);
               
            }
            var hsn = new StockGroupHsnDetails
            {            
               applicableFrom = DateTime.ParseExact("01-Aug-2017", "dd-MMM-yyyy", CultureInfo.InvariantCulture),

                //The value for this must be a valid value as per the Tally dropdown, e.g. "Specify Details Here" or "As per Company/Stock Group"
                sourceOfHsnDetails = "Specify Details Here",
                hsnCode = "540752",
                hsnDescription = group.Description,
            };
            grp.arlHsnDetails.Add(hsn);        
            return _tb.DoTransferStockGroup(grp);
        }
        public TallyResponse CreateStockItem(StockitemResponse item,TallyConfigResponse config, TallyPurchaseResponse data)
        {          

            StockItemGstDetails gstDetails;
            
            var si = new StockItem
            {

                tallyCompanyName = config.Company.Name,

                //This line is required only if the Stock Item is being altered or re-uploaded. 
                //During initial Stock Item creation, this line is not required, but even if given, its not a problem
                oldItemName = item.TallyLedgerName??item.ProductName,            
                itemName=item.ProductName,

                //You can map SKU code either in item alias or in part no.
                //Or, if you do not wish to maintain SKU code, you can leave both these fields blank
               // itemAlias = "A00001",
               // partNo = "P00001",

                //The unit master should already exist in Tally.
                primaryUnitName = "Pcs",

              //  description = "Enter description here, if required",
              //  remarks = "Enter remarks here, if required",

                //The stock group should already exist in Tally
                //You can leave this blank, if you do not wish to maintain Stock Groups in Tally
                stockGroupName = data.SaleVoucherPrint.CompanyName,

                //The stock category should already exist in Tally
                //You can leave this blank if you do not wish to maintain Stock Categories in Tally
                //stockItem.stockCategoryName = "Stk Cat 1";

                isGstApplicable = item.GstApplicable,
                //Valid values: "Goods", "Services"        
                gstTypeOfSupply = Helper.GetEnumDescription(item.GSTNature)
            };
            if (!item.IsGstRule)
            {
                gstDetails = new StockItemGstDetails
                {
                    applicableFrom = DateTime.ParseExact("01-Jul-2017", "dd-MMM-yyyy", CultureInfo.InvariantCulture),

                    //The value for this must be a valid value as per the Tally dropdown, e.g. "Specify Details Here" or "As per Company/Stock Group"
                    sourceOfGstDetails = "Specify Details Here",

                    //The value for this must be a valid value as per the Tally dropdown, e.g.. "Exempt", "Nil Rated", or "Taxable"
                    taxability = Helper.GetEnumDescription(item.GSTTaxability),
                    isReverseChargeApplicable = false,
                    igstRate = item.Gst,
                    cgstRate = item.Gst/2,
                    sgstRate = item.Gst / 2,
                    cessRate = 0
                };
                //The ArrayList arlGstDetails should be filled up with objects of type StockItemGstDetails
                //It represents the Tax Rate History, and there should be 1 object for each date when the tax rate or other GST details were changed
                si.arlGstDetails.Add(gstDetails);
            }
            else
            {
                //gstDetails = new StockItemGstDetails
                //{
                //    applicableFrom = DateTime.ParseExact("01-Jul-2017", "dd-MMM-yyyy", CultureInfo.InvariantCulture),

                //    //The value for this must be a valid value as per the Tally dropdown, e.g. "Specify Details Here" or "As per Company/Stock Group"
                //    sourceOfGstDetails = "Specify Details Here",

                //    //The value for this must be a valid value as per the Tally dropdown, e.g.. "Exempt", "Nil Rated", or "Taxable"
                //    taxability = "Taxable",
                //    isReverseChargeApplicable = false,
                //    igstRate = 12,
                //    cgstRate = 6,
                //    sgstRate = 6,
                //    cessRate = 0
                //};
                //The ArrayList arlGstDetails should be filled up with objects of type StockItemGstDetails
                //It represents the Tax Rate History, and there should be 1 object for each date when the tax rate or other GST details were changed
             //   si.arlGstDetails.Add(gstDetails);

                // 2nd GST Details (Slab-based from 01-Jul-2017)          
                gstDetails = new StockItemGstDetails
                {
                    applicableFrom = DateTime.ParseExact("01-Jul-2017", "dd-MMM-yyyy", CultureInfo.InvariantCulture),
                    sourceOfGstDetails = "Specify Slab-Based Rates",
                    isSlabRateOnMrp = false
                };
                foreach (var rule in item.GstRules)
                {
                    var gstSlabDetails = new StockItemGstSlabDetails
                    {
                        taxability = Helper.GetEnumDescription(item.GSTTaxability),

                        // if EndRange = 0 then it is last slab
                        toItemRate = rule.EndRange,

                        igstRate = rule.GstValue,

                        // divide GST equally
                        cgstRate = rule.GstValue / 2,

                        sgstRate = rule.GstValue / 2,

                        cessRate = 0
                    };

                    gstDetails.arlGstSlabDetails.Add(gstSlabDetails);
                }              

                si.arlGstDetails.Add(gstDetails);
                
           }
            var hsn = new StockItemHsnDetails
            {
                applicableFrom = DateTime.ParseExact("01-Aug-2017", "dd-MMM-yyyy", CultureInfo.InvariantCulture),

                //The value for this must be a valid value as per the Tally dropdown, e.g. "Specify Details Here" or "As per Company/Stock Group"
                sourceOfHsnDetails = "Specify Details Here",                
                hsnCode = item.HsnCode,
                hsnDescription = item.stockGroupName
            };
            si.arlHsnDetails.Add(hsn);            
            return _tb.DoTransferStockItem(si);
        }

        public TallyResponse CreatePurchaseVoucher(TallyPurchaseResponse data, TallyConfigResponse config, string sbillnumber)
        {
            DateTime dt1 = DateTime.ParseExact(data.SaleVoucherPrint.Date.ToString(), "dd-MMM-yy h:mm:ss tt", CultureInfo.InvariantCulture);
            string s = dt1.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            var invoice = new PurchaseVoucher
            {
                tallyCompanyName = config.Company.Name,
                companyGstin = config.Company.GSTIN,
                companyGstRegistrationName = "Uttar Pradesh Registration",
                companyGstRegistrationType = config.Company.GSTRegistrationType,
                companyGstState = config.Company.StateName,

                voucherForeignKey = data.SaleVoucherPrint.VoucherForeignkey,

                // If Tally API needs string:
                dtOfVoucher = DateTime.ParseExact(s, "dd/MM/yyyy", null),

                voucherTypeName = config.Purchase.MainLedger,
                typeOfVoucher = "Purchase",

                voucherNo = data.SaleVoucherPrint.Id.ToString(),
                reference = sbillnumber,
                referenceDate = DateTime.ParseExact(s, "dd/MM/yyyy", null),
                voucherIdentifier = data.SaleVoucherPrint.VoucherForeignkey,

                //  receiptDocNo = "Receipt Doc11",
                //  receiptDocDt = DateTime.Parse("31-Jan-2026"),

                //   despatchedThrough = "Desp Thru11",
                //   destination = "Some Destination",
                //   carrierName = "Carrier Name 123",
                //   billOfLadingNo = "RR1",
                //   billOfLadingDt = DateTime.Parse("30-Jan-2026"),
                //   vehicleNo = "Veh123",

                //   termsOfPayment = "30 days",
                //   otherReference = "Misc. Ref",

                partyLedgerName = data.SaleVoucherPrint.CompanyName,

                supplierName = data.SaleVoucherPrint.CompanyName,
                supplierMailingName = data.SaleVoucherPrint.CompanyName,
                supplierAddress = new string[]
                {
            data.SupplierResponse.Address
                },
                supplierState = data.SupplierResponse.State,
                supplierCountry = "India",
                supplierPincode = data.SupplierResponse.Pincode,
                supplierGstin = data.SupplierResponse.GstIn,
                supplierGstRegType = data.SupplierResponse.RegType.ToTallyString(),
                placeOfSupply = config.Company.StateName,

                consigneeName = config.Company.Name,
                consigneeMailingName = config.Company.Name,
                consigneeAddress = new string[]
                {
           config.Company.ConsigneeAddress,
            "E-Mail :"+config.Company.Email
                },
                consigneeState = config.Company.StateName,
                consigneeCountry = "India",
                consigneePincode = config.Company.PINCode,
                consigneeGstin = config.Company.GSTIN,

                narration = "",
                isInvoice = true,
                isOptional = false
            };

            // =========================
            // ITEM 1
            // =========================

            foreach (var stockItem in data.StockitemResponse)
            {


                var item = new InventoryEntry
                {
                    itemName = stockItem.ProductName,
                    isDeemedPositive = true,
                    actualQty = stockItem.Quantity,
                    billedQty = stockItem.Quantity,
                    qtyUnit = "Pcs", // or map if dynamic
                    rate = (decimal)stockItem.PurchasePrice,
                    rateUnit = "Pcs",
                    discountPerc = stockItem.Discount,
                    amount = -stockItem.DiscountAmount
                };

                // Batch Allocation
                item.arlBatchAllocations.Add(new BatchAllocation
                {
                    godownName = "Main Location",
                    actualQty = item.actualQty,
                    billedQty = item.billedQty,
                    amount = item.amount,
                    qtyUnit = item.qtyUnit
                });
                // Accounting Allocation
                item.arlAccountingAllocations.Add(new LedgerEntry
                {
                    ledgerName = config.Purchase.MainLedger,
                    ledgerAmount = item.amount
                });

                // Add to invoice
                invoice.arlInvEntries.Add(item);
            }
            var totalItemAmount = data.StockitemResponse.Sum(x => x.Total);
            var totalIGST = data.StockitemResponse.Sum(x => x.IGST);
            var totalCGST = data.StockitemResponse.Sum(x => x.CGST);
            var totalSGST = data.StockitemResponse.Sum(x => x.SGST);

            var totalDiscount = data.StockitemResponse.Sum(x => x.Discount > 0
                ? (x.Quantity * x.PurchasePrice * x.Discount / 100)
                : 0);
            // =========================
            // ACTUAL TOTAL
            // =========================
            var payableAmount = data.StockitemResponse.Sum(x => x.PayableAmount);
            decimal calculatedTotal = totalItemAmount
                      + totalIGST
                      + totalCGST
                      + totalSGST
                      - totalDiscount;
            // =========================
            // FINAL ROUNDED AMOUNT
            // Example:
            // 100.49 => 100
            // 100.50 => 101
            // =========================
            decimal roundedPayableAmount = Math.Round(
                calculatedTotal,
                0,
                MidpointRounding.AwayFromZero
            );
            // =========================
            // ROUND OFF DIFFERENCE
            // =========================
            decimal roundOff = Math.Round(
                roundedPayableAmount - calculatedTotal,
                2,
                MidpointRounding.AwayFromZero
            );


            // =========================
            // PARTY LEDGER
            // =========================
            var partyLedger = new LedgerEntry
            {

                ledgerName = data.SaleVoucherPrint.CompanyName,
                ledgerAmount = roundedPayableAmount,
                isDeemedPositive = false
            };

            partyLedger.arlBillAllocations.Add(new BillAllocation
            {
                billType = "New Ref",
                billName = invoice.reference,
                billAmount = partyLedger.ledgerAmount
               
            });

            invoice.arlLedgerEntries.Add(partyLedger);

            // =========================
            // DISCOUNT
            // =========================

            //    if (data.StockitemResponse.Sum(x => x.Discount > 0? (x.Quantity * x.PurchasePrice * x.Discount / 100): 0)>0)
            //    {
            //        var discountRate = data.StockitemResponse
            //.FirstOrDefault(x => x.Discount > 0)?.Discount ?? 0;
            //        invoice.arlLedgerEntries.Add(new LedgerEntry
            //        {
            //            ledgerName = "Discount on Purchase",
            //            appropriateFor = "GST",
            //            gstAppropriateTo = "Goods and Services",    
            //            ledEntryRate= -(decimal)discountRate,
            //            ledgerAmount = data.StockitemResponse.Sum(x => x.Discount > 0 ? (x.Quantity * x.PurchasePrice * x.Discount / 100) : 0),   // ✅ Positive (reduces purchase)
            //            isDeemedPositive = true
            //        });
            //    }


            // =========================
            // IGST
            // =========================
            if (data.StockitemResponse.Sum(x => x.IGST) > 0)
            {
                invoice.arlLedgerEntries.Add(new LedgerEntry
                {
                    ledgerName = config.Purchase.IGST, // Must match Tally
                    ledgerAmount = -data.StockitemResponse.Sum(x => x.IGST), // ✅ Negative (credit side)
                    isDeemedPositive = true
                });
            }
            // =========================
            // CGST
            // =========================
            if (data.StockitemResponse.Sum(x => x.CGST) > 0)
            {
                invoice.arlLedgerEntries.Add(new LedgerEntry
                {
                    ledgerName = config.Purchase.CGST, // Must match Tally
                    ledgerAmount = -data.StockitemResponse.Sum(x => x.CGST), // ✅ Negative (credit side)
                    isDeemedPositive = true
                });
            }
            // =========================
            // SGST
            // =========================
            if (data.StockitemResponse.Sum(x => x.SGST) > 0)
            {
                invoice.arlLedgerEntries.Add(new LedgerEntry
                {
                    ledgerName = config.Purchase.SGST, // Must match Tally
                    ledgerAmount = -data.StockitemResponse.Sum(x => x.SGST), // ✅ Negative (credit side)
                    isDeemedPositive = true
                });
            }
            // =========================
            // ROUND OFF LEDGER
            // =========================           
            if (roundOff != 0)
            {
                decimal ledgerAmount;
                bool isDeemedPositive;

                if (roundOff < 0)
                {
                    // Example:
                    // 5297.37 -> 5297
                    // Need (-)0.37 display

                    ledgerAmount = Math.Abs(roundOff); // +0.37
                    isDeemedPositive = true;
                }
                else
                {
                    // Example:
                    // 89920.95 -> 89921
                    // Need +0.05 display

                    ledgerAmount = -roundOff; // +0.05
                    isDeemedPositive = true;
                }

                invoice.arlLedgerEntries.Add(new LedgerEntry
                {
                    ledgerName = "Round Off",
                    ledgerAmount = ledgerAmount,
                    isDeemedPositive = isDeemedPositive
                });
            }           
            // =========================
            // FINAL CALL
            // =========================
            return _tb.DoTransferVoucher(invoice);

        }
    }
}