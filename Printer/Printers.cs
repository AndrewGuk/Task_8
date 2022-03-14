namespace Printers
{
    public class Printer
    {
        public string value { get; set; }
        public Printer(string value)
        {
            this.value = value;
            Print(value);
        }
        public virtual void Print(string value) 
        {
            Console.ResetColor();
            Console.WriteLine(value);
        }
        
    }
    public class GreenPrinter : Printer
    {
        public  GreenPrinter(string value):base(value)
        {
        }
        public override void Print(string value)
         {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
            Console.ResetColor();
         }
    }
    public class BluePrinter : Printer 
    {
        public BluePrinter(string value) : base(value)
        {
        }
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
    public class Room
    {
        public string value { get; set; }
        public Printer printer { get; set; }
        public Room(Printer printer, string value)
        {
            this.printer = printer;
            this.value= value;
        }
        
        public void MakeThisLazyPrinterWork(string value)
        {
            //printer.Print(value);
            Printer printer = new Printer(this.value);
            printer.Print(value);
        }
        public void ChangePrinter(Printer printer, string value)
        {
            printer.Print(value);
        }

    }
}