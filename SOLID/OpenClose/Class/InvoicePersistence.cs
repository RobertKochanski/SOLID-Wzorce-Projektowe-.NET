namespace OpenClose.Class
{
    internal class InvoicePersistence
    {
        private Invoice _invoice;
        private IInvoiceSaver _invoiceSaver;

        public InvoicePersistence(Invoice invoice, IInvoiceSaver invoiceSaver)
        {
            _invoice = invoice;
            _invoiceSaver = invoiceSaver;
        }

        public void Save()
        {
            _invoiceSaver.Save(_invoice);
        }
    }
}
