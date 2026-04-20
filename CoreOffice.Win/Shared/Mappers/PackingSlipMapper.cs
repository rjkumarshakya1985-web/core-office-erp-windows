using CoreOffice.Win.Shared.RDLCModels;
using CoreOfficeERP.Domain.Responses.PackingSlip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOffice.Win.Shared.Mappers
{
    public static class PackingSlipMapper
    {
        public static List<PackingSlipItemModel> ToItems(PackingSlipResponse data)
        {
            return data.Items.Select(x => new PackingSlipItemModel
        {
                Id=data.Id,
                SlipNumber=data.SlipNumber,
                Date=data.Date,
                VisitorName=data.VisitorName,               
                VisitorMobile=data.VisitorMobile,
                TotalPcs=data.TotalQuantity,
                GrandTotal=data.TotalAmount,
                ProductName=x.ProductName,
                BarCode=x.BarCode,
                Qty=x.Qty,
         //       GstValue=x.GstValue,
                SaleRate=x.SaleRate,
                TaxableAmount=x.TaxableAmount,
           //        Amount=x.Amount,
                Salesman=data.VisitorName,
                UserName=data.VisitorName,
                Department=data.VisitorName,
                SubDepartment=data.VisitorName

            }).ToList();
        }
    }
}
