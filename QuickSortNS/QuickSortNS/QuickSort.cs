using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortNS
{
    public class QuickSort
    {
        private int amountGenericValues;
        private int[] arrayRandomValues;
        public QuickSort(int amountOfNumbers)
        {
            amountGenericValues = amountOfNumbers;
            arrayRandomValues = new int[amountGenericValues];
        }

        public void GenericArray()
        {
            Random random = new Random();

            for(int i = 0; i < amountGenericValues; i++)
            {
                arrayRandomValues[i] = random.Next(amountGenericValues);
            }
        }

        public int[] GetArray()
        {
            return arrayRandomValues;
        }
        public void QSort(int[] array,int l,int r)
        {
            int temp;
            int x = array[l + (r - l) / 2];
            //запись эквивалентна (l+r)/2, 
            //но не вызввает переполнения на больших данных
            int i = l;
            int j = r;
            //код в while обычно выносят в процедуру particle
            while (i <= j)
            {
                while (array[i] < x) i++;
                while (array[j] > x) j--;
                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r)
                QSort(array,i, r);

            if (l < j)
                QSort(array,l, j);

            arrayRandomValues = array;
        }
    }
}
