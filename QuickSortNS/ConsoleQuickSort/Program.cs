using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickSortNS;

namespace ConsoleQuickSort
{
    class Program
    {
        public static int[] GenericIntArray(int amountOfNumbers)
        {
            Random random = new Random();
            int[] arrayRandomValues = new int[amountOfNumbers];
            for (int i = 0; i < amountOfNumbers; i++)
            {
                arrayRandomValues[i] = random.Next(amountOfNumbers);
            }
            return arrayRandomValues;
        }
        static void Main(string[] args)
        {
            int amountOfNumbers = Convert.ToInt32(args[0]);
            QuickSort<int> sort = new QuickSort<int>(amountOfNumbers);

            int[] array = GenericIntArray(amountOfNumbers);

            sort.QSort(array,0, amountOfNumbers - 1);

            Console.Write("Sorted array:");
            for(int i = 0; i < amountOfNumbers; i++)
            {
                Console.Write(" {0}",Convert.ToString(array[i]));
            }

            Console.Read();
        }
    }
}
