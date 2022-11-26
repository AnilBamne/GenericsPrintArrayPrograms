using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genricsPrograms
{
    public class PrintArray
    {
        //method prints array of integers
        public static void toPrint(int[] inputArray)
        {
            foreach (int element in inputArray) // 1, 2, 3, 4, 5
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n-----------");
        }
        //method prints array of double

        public static void toPrint(double[] inputArray)
        {
            foreach (double element in inputArray)//1.1, 2.2, 3.3, 4.4
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n-----------");
        }
        //method prints array of charecters

        public static void toPrint(char[] inputArray)
        {
            foreach (char element in inputArray) //'H', 'E', 'L', 'L', 'O'
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n-----------");
        }
    }
}
