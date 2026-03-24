using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tally;
using TallyBridge;
namespace CoreOffice.Win.Modules.Admin
{
    public partial class TallySynchPurchase : Form
    {
        TallyBridge.TallyBridgeDll tb;
        public TallySynchPurchase()
        {
            InitializeComponent();
            tb = new TallyBridgeDll();
        }

        void btnStockCategory_Click(object sender, EventArgs e)
        {
            StockCategory stockCategory = new StockCategory();

            stockCategory.tallyCompanyName = "SHIV SAHAI BHAGWAN DAS SAREES PVT. LTD.(2025-26)";

            //This line is required only if the stock category is being altered or re-uploaded. 
            //During initial stock category creation, this line is not required.
            stockCategory.oldCategoryName = "Silk Sarees (TBT)";

            stockCategory.categoryName = "Silk Sarees (TBT)";

            //Alias of the stock category, if you wish to maintain; else you need not pass it
            stockCategory.categoryAlias = "";

            //Parent Category of this Stock Category
            //This parent category must already exist in Tally
            stockCategory.parentCategoryName = "";


            TallyResponse tallyResponse = null;
            tallyResponse = tb.DoTransferStockCategory(stockCategory);
            if (tallyResponse.errorCode != 0)
            {
                MessageBox.Show(tallyResponse.errorMsg, "Tally Bridge Tool");
            }
            else
            {
                MessageBox.Show("Stock Category uploaded successfully", "Tally Bridge Tool");
            }
        }



        void btnStockGroup_Click(object sender, EventArgs e)
        {
            StockGroup stockGroup = new StockGroup();
            StockGroupGstDetails gstDetails = null;
            StockGroupHsnDetails hsnDetails = null;

            stockGroup.tallyCompanyName = "SHIV SAHAI BHAGWAN DAS SAREES PVT. LTD.(2025-26)";

            //This line is required only if the stock group is being altered or re-uploaded. 
            //During initial stock group creation, this line is not required.
            stockGroup.oldGroupName = "9NX Designer (TBT)";

            stockGroup.groupName = "9NX Designer (TBT)";

            //Alias of the stock group, if you wish to maintain; else you need not pass it
            stockGroup.groupAlias = "";

            //Parent Group of this Stock Group
            //This group must already exist in Tally
            stockGroup.parentGroupName = "Sarees";
            stockGroup.isAddable = true;

            gstDetails = new StockGroupGstDetails();
            gstDetails.applicableFrom = DateTime.ParseExact("01-Jul-2017", "dd-MMM-yyyy", null);

            //The value for this must be a valid value as per the Tally dropdown, e.g. "Specify Details Here" or "As per Company/Stock Group"
            gstDetails.sourceOfGstDetails = "Specify Details Here";

            //The value for this must be a valid value as per the Tally dropdown, e.g.. "Exempt", "Nil Rated", or "Taxable"
            gstDetails.taxability = "Taxable";
            gstDetails.isReverseChargeApplicable = false;
            gstDetails.igstRate = 18;
            gstDetails.cgstRate = 9;
            gstDetails.sgstRate = 9;
            gstDetails.cessRate = 0;

            //The ArrayList arlGstDetails should be filled up with objects of type StockGroupGstDetails
            //It represents the Tax Rate History, and there should be 1 object for each date when the tax rate or other GST details were changed
            stockGroup.arlGstDetails.Add(gstDetails);

            gstDetails = new StockGroupGstDetails();
            gstDetails.applicableFrom = DateTime.ParseExact("01-Jan-2018", "dd-MMM-yyyy", null);
            gstDetails.sourceOfGstDetails = "Specify Details Here";
            gstDetails.taxability = "Taxable";
            gstDetails.isReverseChargeApplicable = false;
            gstDetails.igstRate = 12;
            gstDetails.cgstRate = 6;
            gstDetails.sgstRate = 6;
            gstDetails.cessRate = 0;
            stockGroup.arlGstDetails.Add(gstDetails);

            hsnDetails = new StockGroupHsnDetails();
            hsnDetails.applicableFrom = DateTime.ParseExact("01-Aug-2017", "dd-MMM-yyyy", null);

            //The value for this must be a valid value as per the Tally dropdown, e.g. "Specify Details Here" or "As per Company/Stock Group"
            hsnDetails.sourceOfHsnDetails = "Specify Details Here";
            hsnDetails.hsnCode = "540752";
            hsnDetails.hsnDescription = "SAREE";
            stockGroup.arlHsnDetails.Add(hsnDetails);


            TallyResponse tallyResponse = null;
            tallyResponse = tb.DoTransferStockGroup(stockGroup);
            if (tallyResponse.errorCode != 0)
            {
                MessageBox.Show(tallyResponse.errorMsg, "Tally Bridge Tool");
            }
            else
            {
                MessageBox.Show("Stock Group uploaded successfully", "Tally Bridge Tool");
            }
        }



        void btnStockItemMaster_Click(object sender, EventArgs e)
        {
            StockItem stockItem = new StockItem();
            StockItemGstDetails gstDetails = null;
            StockItemHsnDetails hsnDetails = null;

            stockItem.tallyCompanyName = "SHIV SAHAI BHAGWAN DAS SAREES PVT. LTD.(2025-26)";

            //This line is required only if the Stock Item is being altered or re-uploaded. 
            //During initial Stock Item creation, this line is not required, but even if given, its not a problem
            stockItem.oldItemName = "Saree1 (TBT)";

            stockItem.itemName = "Saree1 (TBT)";

            //You can map SKU code either in item alias or in part no.
            //Or, if you do not wish to maintain SKU code, you can leave both these fields blank
            stockItem.itemAlias = "A00001";
            stockItem.partNo = "P00001";

            //The unit master should already exist in Tally.
            stockItem.primaryUnitName = "Pcs";

            stockItem.description = "Enter description here, if required";
            stockItem.remarks = "Enter remarks here, if required";

            //The stock group should already exist in Tally
            //You can leave this blank, if you do not wish to maintain Stock Groups in Tally
            stockItem.stockGroupName = "Sarees";

            //The stock category should already exist in Tally
            //You can leave this blank if you do not wish to maintain Stock Categories in Tally
            //stockItem.stockCategoryName = "Stk Cat 1";

            stockItem.isGstApplicable = true;
            //Valid values: "Goods", "Services"
            stockItem.gstTypeOfSupply = "Goods";

            gstDetails = new StockItemGstDetails();
            gstDetails.applicableFrom = DateTime.ParseExact("01-Jul-2017", "dd-MMM-yyyy", null);

            //The value for this must be a valid value as per the Tally dropdown, e.g. "Specify Details Here" or "As per Company/Stock Group"
            gstDetails.sourceOfGstDetails = "Specify Details Here";

            //The value for this must be a valid value as per the Tally dropdown, e.g.. "Exempt", "Nil Rated", or "Taxable"
            gstDetails.taxability = "Taxable";
            gstDetails.isReverseChargeApplicable = false;
            gstDetails.igstRate = 18;
            gstDetails.cgstRate = 9;
            gstDetails.sgstRate = 9;
            gstDetails.cessRate = 0;

            //The ArrayList arlGstDetails should be filled up with objects of type StockItemGstDetails
            //It represents the Tax Rate History, and there should be 1 object for each date when the tax rate or other GST details were changed
            stockItem.arlGstDetails.Add(gstDetails);

            gstDetails = new StockItemGstDetails();
            gstDetails.applicableFrom = DateTime.ParseExact("01-Jan-2018", "dd-MMM-yyyy", null);
            gstDetails.sourceOfGstDetails = "Specify Details Here";
            gstDetails.taxability = "Taxable";
            gstDetails.isReverseChargeApplicable = false;
            gstDetails.igstRate = 12;
            gstDetails.cgstRate = 6;
            gstDetails.sgstRate = 6;
            gstDetails.cessRate = 0;
            stockItem.arlGstDetails.Add(gstDetails);

            hsnDetails = new StockItemHsnDetails();
            hsnDetails.applicableFrom = DateTime.ParseExact("01-Aug-2017", "dd-MMM-yyyy", null);

            //The value for this must be a valid value as per the Tally dropdown, e.g. "Specify Details Here" or "As per Company/Stock Group"
            hsnDetails.sourceOfHsnDetails = "Specify Details Here";
            hsnDetails.hsnCode = "540752";
            hsnDetails.hsnDescription = "SAREE";
            stockItem.arlHsnDetails.Add(hsnDetails);

            TallyResponse tallyResponse = null;
            tallyResponse = tb.DoTransferStockItem(stockItem);
            if (tallyResponse.errorCode != 0)
            {
                MessageBox.Show(tallyResponse.errorMsg, "Tally Bridge Tool");
            }
            else
            {
                MessageBox.Show("Stock Item uploaded successfully", "Tally Bridge Tool");
            }
        }


        void VendorGroup()
        {
            Group vendorGroup = new Group();

            vendorGroup.tallyCompanyName = "SHIV SAHAI BHAGWAN DAS SAREES PVT. LTD.(2025-26)";

            //This line is required only if the vendor group is being altered or re-uploaded. 
            //During initial vendor group creation, this line is not required.
            vendorGroup.oldGroupName = "B S Agency (BS)";

            vendorGroup.groupName = "B S Agency (BS)";

            //Alias of the vendor group, if you wish to maintain; else you need not pass it
            vendorGroup.groupAlias = "";

            //Parent Group of this Vendor Group
            //This group must already exist in Tally
            vendorGroup.parentGroupName = "Sundry Creditors";

            TallyResponse tallyResponse = null;
            tallyResponse = tb.DoTransferGroup(vendorGroup);
            if (tallyResponse.errorCode != 0)
            {
                MessageBox.Show(tallyResponse.errorMsg, "Tally Bridge Tool");
            }
            else
            {
                MessageBox.Show("Vendor Group uploaded successfully", "Tally Bridge Tool");
            }
        }


        void VendorMaster()
        {
            Ledger vendorLedger = new Ledger();

            vendorLedger.tallyCompanyName = "SHIV SAHAI BHAGWAN DAS SAREES PVT. LTD.(2025-26)";

            //This line is required only if the ledger is being altered or re-uploaded. 
            //During initial ledger creation, this line is not required.
            vendorLedger.oldLedgerName = "BS DESIGNER, SURAT (TBT)";

            vendorLedger.ledgerName = "BS DESIGNER, SURAT (TBT)";

            //Mailing Name of the vendor master
            vendorLedger.ledgerMailingName = "BS DESIGNER";

            //Alias of the vendor master, if you wish to maintain; else you need not pass it
            vendorLedger.ledgerAlias = "";

            //Parent Group of the Vendor Master
            //This group must already exist in Tally
            vendorLedger.parentGroupName = "B S Agency (BS)";

            vendorLedger.address = new string[2];
            vendorLedger.address[0] = "G-3335, MILLENIUM TEXTILE MARKET";
            vendorLedger.address[1] = "RING ROAD, Delhi";

            //State Name should be from the List of States available in Tally
            vendorLedger.state = "Delhi";
            vendorLedger.pinCode = "110006";

            //Country Name should be from the List of Countries available in Tally
            //and the spelling of the country should be identical as in Tally
            vendorLedger.country = "India";

            //vendorLedger.contactPerson = "Mr. X";
            vendorLedger.telephoneNo = "0261 22222222";
            vendorLedger.mobileNo = "9909091944";
            vendorLedger.isdCode = "+91";
            vendorLedger.faxNo = "0261 23333333";
            vendorLedger.email = "accounts@bspl.com";
            vendorLedger.emailCc = "manager@bspl.com";
            vendorLedger.website = "www.bspl.com";

            vendorLedger.gstin = "07ADFPY6443H1Z1";

            //Valid values as per Tally dropdown: "Regular", "Composition", "Unregistered/Consumer"
            vendorLedger.gstRegistrationType = "Regular";

            vendorLedger.panNo = "ADFPY6443H";

            //You can decide whether to maintain bill-wise details or not
            vendorLedger.maintainBillWiseDetails = true;
            vendorLedger.defaultCreditPeriod = "15 days";

            TallyResponse tallyResponse = null;
            tallyResponse = tb.DoTransferLedger(vendorLedger);
            if (tallyResponse.errorCode != 0)
            {
                MessageBox.Show(tallyResponse.errorMsg, "Tally Bridge Tool");
            }
            else
            {
                MessageBox.Show("Vendor Master uploaded successfully", "Tally Bridge Tool");
            }
        }
        private void ClearData()
        {
            txtVoucher.Text = string.Empty;           
          //  lbllrdate.Text = "NA";           
          //  dataGridView1.Rows.Clear();
           // dataGridView1.Refresh();
           // dataGridView1.Rows.Add(200);            

        }

        private void TallySynchPurchase_Load(object sender, EventArgs e)
        {

        }

        private void btnSynch_Click(object sender, EventArgs e)
        {
            VendorGroup();
            VendorMaster();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
