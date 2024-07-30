namespace InterfaceSegregation
{
    internal class Canon : IPrinter, IFax
    {
        public void Fax(string content)
        {
            Console.WriteLine("Canon print grey");
        }

        public void PrintColor(string content)
        {
            Console.WriteLine("Canon print grey");
        }

        public void PrintGrey(string content)
        {
            Console.WriteLine("Canon print grey");
        }

        //public void Scan(string content)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
