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
}
