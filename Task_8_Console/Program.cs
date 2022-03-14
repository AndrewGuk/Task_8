using System;
using static System.Console;
using Printers;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {

            var i = new GreenPrinter("asd");
            var f = new Printer("sada");
            var s = new BluePrinter("sdf");
            Room room = new Room(i,"fsd");
            //room.printer = i;
            room.MakeThisLazyPrinterWork("dfsf");
            //room.printer = f;
            room.MakeThisLazyPrinterWork("6544545");
            //room.printer = s;
            room.MakeThisLazyPrinterWork("dsgfgdf7878");
            room.value = "asdad";
            room.ChangePrinter(s, room.value);
            room.ChangePrinter(f, room.value);
            room.ChangePrinter(i, room.value);
        }
    }
}