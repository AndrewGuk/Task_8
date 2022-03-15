namespace TEST
{
    public class Printer
    {
        public string value { get; set; }
        public Printer() 
        {
            this.value = "none";
        }
        public Printer(string value)
        {
            this.value=value;
        }

        public virtual void Print(string value)
        {
            Console.ResetColor();
            Console.WriteLine(this.value);
        }

    }
    public class GreenPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
    public class BluePrinter : Printer
    {
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
        //public Room(Printer printer, string value)
        //{
        //    this.printer = printer;
        //    this.value = value;
        //}
        

        public void MakeThisLazyPrinterWork(string value)
        {
            printer.Print(value);
            //this.printer.Print(value);
        }
        public void ChangePrinter(Printer printer)
        {
            printer.Print(this.value);
        }

    }
}