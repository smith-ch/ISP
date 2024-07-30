namespace PrinterManagement.Interfaces
{
    public interface IPrint
    {
        void Print(Document document);
        void Scan(Document document);
    }
}
