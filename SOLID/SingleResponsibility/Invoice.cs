namespace SingleResponsibility
{
    public class Invoice
    {
        public IEnumerable<LineItem> LineItems { get; set; }
        public string Vendor { get; set; }
        public string Vendee { get; set; }
        public float Total { get; set; }

        public Invoice(IEnumerable<LineItem> lineItems, string vendor, string vendee, float total)
        {
            LineItems = lineItems;
            Vendor = vendor;
            Vendee = vendee;
            Total = CalculateTotal();
        }

        public float CalculateTotal()
        {
            float total = 0;
            foreach (var lineItem in LineItems)
            {
                total += lineItem.Price * lineItem.Count * (1 + lineItem.TaxRate);
            }

            return total;
        }

        //public void Display()
        //{
        //    Console.WriteLine($"Vendor: {Vendor}");
        //    Console.WriteLine($"Vendee: {Vendee}");
        //    Console.WriteLine($"Total: {Total}");
        //}

        //public void SaveToPdf()
        //{
        //    Console.WriteLine("Saving to pdf");
        //}
    }
}
