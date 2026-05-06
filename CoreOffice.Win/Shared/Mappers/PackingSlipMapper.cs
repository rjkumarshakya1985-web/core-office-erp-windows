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
                VisitorName = data.VisitorName,
                VisitorMobile = data.VisitorMobile,
                TotalPcs = data.TotalQuantity,
                GrandTotal = data.TotalAmount,
                ProductName = x.ProductName,
                BarCode = x.Barcode,
                Qty = x.Quantity,

                SaleRate = x.Rate,
                TaxableAmount = x.TaxableAmount,

                Salesman = data.VisitorName,
                UserName = data.VisitorName,
                Department = data.VisitorName,
                SubDepartment = data.VisitorName

            }).ToList();
        }
    }
}
