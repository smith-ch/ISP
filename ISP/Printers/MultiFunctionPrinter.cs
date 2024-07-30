namespace PrinterManagement.Printers
{
    public class MultiFunctionPrinter : AbstractPrinter
    {
        public override void Scan(Document document)
        {
            Console.WriteLine("Scanning document: " + document.Name);
        }
    }
}
