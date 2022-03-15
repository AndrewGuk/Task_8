namespace Printers
{
    public abstract class Printer
    {
        public string value { get; set; }
        public Printer()
        {
            value = "none";
        }
        public Printer(string value)
        {
            this.value = value;
        }
        public virtual void Print(string value)
        {
        }
    }
}