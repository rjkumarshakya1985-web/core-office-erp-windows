using CoreOffice.Win.Shared.RDLCModels;
using CoreOfficeERP.Domain.Responses.Print;

namespace CoreOffice.Win.Shared.Mappers
{
    public static class PackingSlipMapper
    {
        public static List<PackingSlipItemModel> ToItems(PackingSlipPrintResponse data)
        {
            return data.Items.Select(x => new PackingSlipItemModel
            {
                Id = data.Id,
                SlipNumber = data.PackingSlipNo,
                Date = data.Date,                
                VisitorName = data.Visitor?.Name ?? data.CustomerResponse?.Name,
                VisitorMobile = data.Visitor?.Mobile ?? data.CustomerResponse?.Mobile,
                TotalPcs = data.TotalQuantity,
                GrandTotal = data.TotalAmount,
                ProductName = x.ProductName,
                BarCode = x.Barcode,
                Qty = x.Quantity,

                SaleRate = x.Rate,
                Amount=x.Quantity*x.Rate,
                TaxableAmount = x.TaxableAmount,

                Salesman = data.SalesManName??"NA",
                UserName = "Saurabh",
                Department = data.Department??"NA",
                SubDepartment = data.Department??"NA",

            }).ToList();
        }
       
    }
}
