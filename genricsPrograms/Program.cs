using System;

namespace genricsPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Genrics Programs");
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            Console.WriteLine("Printing arrays using generic method");
            PrintArray.toPrint<int>(intArray);
            PrintArray.toPrint<double>(doubleArray);
            PrintArray.toPrint<char>(charArray);
        }
    }
}
