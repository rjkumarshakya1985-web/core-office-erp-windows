namespace CoreOfficeERP.Common
{
    public static class ApiEndpoints
    {
        public const string CreatePackingSlip = "packingslip";
        public const string GetPackingSlipPendingList = "packingslip/table";
        public const string GetVisitor = "visitor";
        public const string GetStockItemsByBarcode = "stock/barcode";
        public const string GetPackingSlipNumber = "packingslip/number";
        public const string GetPackingSlipsByVisitor = "packingslip/billing-packingslips";

        public const string GetActiveFinancialYear = "financeyears/active";

        /// Delivery Challan
        public const string CreateDeliveryChallan = "deliverychallan";
        public const string GetDeliveryChallanDetail = "deliverychallan/delivery-challan";
        public const string CreateDeliveryChallanReturn = "deliverychallan/delivery-challan/return";
        public const string GetDeliveryChallReturnDetail = "deliverychallan/delivery-challan/for-return";
        public const string CancelDeliveryChallan = "deliverychallan/cancel";
        public const string GetDeliveryChallanList = "deliverychallan/table";


        /// Sales
        public const string PendingPackingSlipsForBill = "packingslip/pending-packing-slips-for-bill";

        /// Sales Person
        public const string GetAllActiveSalesPersons = "saleperson/active";

        public const string CreateSupplier = "customer/mobile/create-supplier";

        // Invoices
        public const string GetDeliveryChallanForInvoice = "deliveryChallanToInvoice/delivery-challan/for-invoice";
        public const string CreateDeliveryChallanToinvoice = "deliveryChallanToInvoice";
        public const string CreateInvoice = "invoice";
        public const string GetInvoice = "invoice";
        public const string CancelInvoice = "invoice/cancel";
        public const string GetInvoiceList = "invoice/table";
        public const string GetInvoiceStatusCount = "invoice/status-counts";


        /// Billing
        public const string PackingSlipPrint = "billingprint/packingslip";

        /// Tally
        public const string GetTallyConfig="TallyConfig";
        public const string GetTallyCompanies = "TallyConfig/companies";
        public const string CreateTallyProcessLog = "TallyProcess/savetallyprocess";
        public const string GetTallyProcessLogByCompanyId = "TallyProcess/tallyprocess";
        public const string GetTallyProcessLogByPurchaseRef = "TallyProcess/tallyprocess";
        public const string GetTallyPurchase = "TallyTransaction/purchase";
        public const string TallyDataUpdate = "TallyTransaction";
    }
}

