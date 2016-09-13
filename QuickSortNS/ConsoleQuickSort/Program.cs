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
        static void Main(string[] args)
        {
            Console.Write("Input amount of numbers:");

            int amountOfNumbers = Convert.ToInt32(Console.ReadLine());
            QuickSort sort = new QuickSort(amountOfNumbers);

            sort.GenericArray();

            int[] array = sort.GetArray();

            sort.QSort(array,0, amountOfNumbers - 1);

            array = sort.GetArray();

            Console.Write("Sorted array:");
            for(int i = 0; i < amountOfNumbers; i++)
            {
                Console.Write(" {0}",Convert.ToString(array[i]));
            }

            Console.Read();
        }
    }
}
