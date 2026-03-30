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

        /// Sales Person
        public const string GetAllActiveSalesPersons = "saleperson/active";

        public const string CreateSupplier = "customer/mobile/create-supplier";

        // Invoices
        public const string GetDeliveryChallanForInvoice = "deliveryChallanToInvoice/delivery-challan/for-invoice";
        public const string CreateDeliveryChallanToinvoice = "deliveryChallanToInvoice";
        public const string CreateInvoice = "invoice";
    }
}

