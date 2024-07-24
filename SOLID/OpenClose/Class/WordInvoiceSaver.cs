namespace OpenClose.Class
{
    internal class WordInvoiceSaver : IInvoiceSaver
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine("Saving invoice to word file");
        }
    }
}
