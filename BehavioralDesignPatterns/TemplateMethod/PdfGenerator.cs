namespace TemplateMethod
{
    public class PdfGenerator : Generator
    {
        protected override void GetData()
        {
            Console.WriteLine("Pdf get data");
        }

        protected override void GenerateFile()
        {
            Console.WriteLine("Generate Pdf file");
        }

        protected override void PrepareData()
        {
            Console.WriteLine("Prepare data for Pdf");
        }
    }
}
