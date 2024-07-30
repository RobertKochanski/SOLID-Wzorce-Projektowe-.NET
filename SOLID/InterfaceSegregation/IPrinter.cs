namespace InterfaceSegregation
{
    public interface IPrinter
    {
        void PrintGrey(string content);
        void PrintColor(string content);
        //void Scan(string content);
        //void Fax(string content);
    }

    public interface IScanner
    {
        void Scan(string content);
    }

    public interface IFax
    {
        void Fax(string content);
    }
}
