using PrinterManagement.Interfaces;
using PrinterManagement.Printers;

namespace PrinterManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Document doc = new Document { Name = "Smith", Description = "PDF DOCUMENT" };

            IPrint simplePrinter = new SimplePrinter();
            simplePrinter.Print(doc);

            MultiFunctionPrinter multiFunctionPrinter = new MultiFunctionPrinter();
            multiFunctionPrinter.Print(doc);
            multiFunctionPrinter.Scan(doc);
        }
    }
}
