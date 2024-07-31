namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pdf = new PdfGenerator();
            var csv = new CsvGenerator();
            var exc = new ExcelGenerator();


            Console.WriteLine("### PDF ###");
            pdf.GenerateReport();

            Console.WriteLine("### CSV ###");
            csv.GenerateReport();

            Console.WriteLine("### EXCEL ###");
            exc.GenerateReport();

        }
    }
}
