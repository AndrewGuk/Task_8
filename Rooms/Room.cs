using Printers;

namespace Rooms
{
    public class Room
    {
        public string value { get; set; }
        public Printer printer { get; set; }
        public void MakeThisLazyPrinterWork(string value)
        {
            printer.Print(value);
        }
        public void ChangePrinter(Printer printer)
        {
            printer.Print(value);
        }
    }
}