namespace CoreOfficeERP.Common
{
    public static class ApiEndpoints
    {
        public const string CreatePackingSlip = "packingslip";
        public const string GetVisitor = "visitor";
        public const string GetStockItemsByBarcode = "stock/barcode";
        public const string GetPackingSlipNumber = "packingslip/number";
        public const string GetPackingSlipsByVisitor = "packingslip/billing-packingslips";

        public const string GetActiveFinancialYear = "financeyears/active";

        /// Delivery Challan
        public const string CreateDeliveryChallan = "deliverychallan";
        public const string CreateDeliveryChallanReturn = "deliverychallan/delivery-challan/return";
        public const string GetDeliveryChallReturnDetail = "deliverychallan/delivery-challan/for-return";

        /// Tally
        public const string GetTallyConfig="TallyConfig";
        public const string CreateTallyProcessLog = "TallyProcess/savetallyprocess";
        public const string GetTallyProcessLogByCompanyId = "TallyProcess/tallyprocess";
        public const string GetTallyProcessLogByPurchaseRef = "TallyProcess/tallyprocess";
        public const string GetTallyPurchase = "TallyTransaction/purchase";
    }
}
