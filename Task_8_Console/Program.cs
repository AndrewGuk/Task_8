using System;
using static System.Console;
using Rooms;
using PrinterColors;
using MyFlag;

namespace Task_8
{
    class Program
    {
        public delegate void myDeligate();
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("\t\tHello,  this is the task 8" +
                "\n\tI worked with the default constructor.");

            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("We're using <Green> print:");
            var green = new GreenPrinter();
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("We didn't set parameters, we look at the result:");
            green.Print(green.value);
            ForegroundColor = ConsoleColor.DarkGreen;

            WriteLine("\tWe will pass the rest of the parameters.");

            var blue = new BluePrinter();
            StartProgram(ConsoleColor.Blue, blue, "Blue");

            var white = new WhitePrinter();
            StartProgram(ConsoleColor.White, white, "White");

            var red = new RedPrinter();
            StartProgram(ConsoleColor.Red, red, "Red");

            var cyan = new CyanPrinter();
            StartProgram(ConsoleColor.Cyan, cyan, "Cyan");

            var yellow = new YellowPrinter();
            StartProgram(ConsoleColor.Yellow, yellow, "Yellow");

            var gray = new GrayPrinter();
            StartProgram(ConsoleColor.Gray, gray, "Gray");

            var magenta = new MagentaPrinter();
            StartProgram(ConsoleColor.Magenta, magenta, "Magenta");

            WriteLine("\n\tMaking a lazy printer work in blue color(I like this color)");
            var room = new Room();
            room.printer = new BluePrinter();
            room.MakeThisLazyPrinterWork("Pracuj kurwa =) ");

            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("\tColor change demo:" +
                "\nPlease enter a test string (it will be white by default.):");
            ResetColor();
            string testString = ReadLine();
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("Pease, enter the color you want the line to be:");
            ResetColor();
            string userColor = ReadLine().ToLower();
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("\tYour string before:");
            ResetColor();
            WriteLine(testString);
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine($"\tConvert to {userColor} color:");

            switch (userColor)
            {
                case "blue":
                    ChangeCokorPrint(testString, blue);
                    break;
                case "green":
                    ChangeCokorPrint(testString, green);
                    break;
                case "red":
                    ChangeCokorPrint(testString, red);
                    break;
                case "white":
                    ChangeCokorPrint(testString, white);
                    break;
                case "cyan":
                    ChangeCokorPrint(testString, cyan);
                    break;
                case "magenta":
                    ChangeCokorPrint(testString, magenta);
                    break;
                case "gray":
                    ChangeCokorPrint(testString, gray);
                    break;
                case "yellow":
                    ChangeCokorPrint(testString, yellow);
                    break;
                default:
                    ForegroundColor = ConsoleColor.DarkGreen;
                    WriteLine("I do not know this color (let it be magenta)))");
                    ChangeCokorPrint(testString, magenta);
                    break;
            }

            var flag = new Flag();
            WriteLine();
            void StartProgram(ConsoleColor consoleColor, Printers.Printer obj, string color)
            {
                ForegroundColor = ConsoleColor.DarkBlue;
                WriteLine($"We're using <{color}> print:");
                obj.value = $"This is {color.ToLower()} text;";
                obj.Print(obj.value);
            }
            void ChangeCokorPrint(string value, Printers.Printer printer)
            {
                var x = new Room();
                x.value = value;
                x.ChangePrinter(printer);
            }
        }
    }
}