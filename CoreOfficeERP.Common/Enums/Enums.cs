using System.ComponentModel;

namespace CoreOfficeERP.Common.Enums
{
    public enum RoleEnum
    {
        SuperAdmin = 1,
        Supplier = 2,
        Cashier = 3,
        PackingSlipOperator = 4,
        StockIncharge = 5
    }

    public enum ClientType
    {
        Web,
        Mobile,
        Windows
    }

    /// <summary>
    ///  Same Enum is used for both Customer and Visitor
    /// </summary>
    public enum CustomerTypeEnum
    {
        [Description("Whole Sale")]
        WholeSale = 1,
        [Description("Retail")]
        Retail = 2

    }
    public enum TallyProcessType
    {
        Purchase = 1,
        Sale = 2,
        PurchaseReturn = 3,
        SaleReturn = 4
    }
    public enum TallyProcessStep
    {
        VendorGroup = 1,
        VendorMaster = 2,
        CustomerGroup = 3,
        CustomerMaster = 4,
        StockCategory = 5,
        StockGroup = 6,
        StockItem = 7,
        PurchaseVoucher = 8,
        SaleVoucher = 9,
        PurchaseReturnVoucher = 10,
        SaleReturnVoucher = 11
    }

    public enum RegistrationTypeEnum
    {
        [Description("Regular")]
        Regular = 1,
        [Description("Composition")]
        Composition = 2,
        [Description("Unregistrated")]
        Unregistrated = 3
    }

    public enum DeliveryChallanStatusEnum
    {
        Created = 0,
        Dispatched = 1,
        PartiallyReturned = 2,
        FullyReturned = 3,
        Invoiced = 4,
        Cancelled = 6
    }
}
