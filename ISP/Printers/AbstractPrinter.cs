

using PrinterManagement.Interfaces;

namespace PrinterManagement.Printers
{
    public abstract class AbstractPrinter : IPrint
    {
        public virtual void Print(Document document)
        {
            Console.WriteLine("Printing document: " + document.Name);
        }

        public virtual void Scan(Document document)
        {
            throw new NotImplementedException("This printer does not support scanning.");
        }
    }
}
