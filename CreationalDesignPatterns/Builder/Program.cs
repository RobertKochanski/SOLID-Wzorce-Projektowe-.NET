namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new InvoiceBuilder();

            //builder.SetDate(new DateTime(2020, 1, 1));
            //builder.SetInvoiceNumber("A1");
            //builder.SetVendor("Google");
            //builder.SetVendee("Vendee");
            //builder.SetLineItems(new List<string>() { "Line item 1", "Line item 2" });

            //Invoice invoice = builder.Build();


            var invoice = builder.SetDate(new DateTime(2020, 1, 1))
                .SetInvoiceNumber("A1")
                .SetVendor("Google")
                .SetVendee("Vendee")
                .SetLineItems(new List<string>() { "Line item 1", "Line item 2" })
                .Build();


            Console.WriteLine(invoice.Vendor);
            Console.WriteLine(invoice.Vendee);
        }
    }
}
