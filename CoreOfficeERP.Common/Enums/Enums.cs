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
        WholeSale = 1,
        Retail = 2

    }
    public enum TallyProcessType
    {
        Purchase = 1,
        Sale = 2,
        PurchaseReturn = 3,
        SaleReturn = 4
    }
    public enum TallyProcessStepPurchase
    {
        VendorGroup = 1,
        VendorMaster = 2,        
        StockCategory = 3,
        StockGroup = 4,
        StockItem = 5,
        PurchaseVoucher = 6        
    }
    public enum GSTRegistrationType
    {
        Regular = 1,
        Composition = 2,
        Unregistered = 3
        
    }
}
