using System.Threading;

namespace MyFlag
{
    public class Flag
    {
        string[,] array = new string[4, 20];
        string x = "  ";
        public Flag()
        {
            PrintFlaf(array, ConsoleColor.White, x);
            PrintFlaf(array, ConsoleColor.Red, x);
            PrintFlaf(array, ConsoleColor.White, x);
        }
        void PrintFlaf(string[,] array, ConsoleColor consoleColor, string x)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.BackgroundColor = consoleColor;
                    array[i, j] = x;
                    Console.Write(array[i, j]);
                    Console.ResetColor();
                    Thread.Sleep(30);
                }
                Console.WriteLine();
            }
        }
    }
}