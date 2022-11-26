using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genricsPrograms
{
    public class PrintArray
    {
        //Genric method prints all array 
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray) 
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n-----------");
        }
    }
}
