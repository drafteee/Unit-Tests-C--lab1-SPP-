using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortNS
{
    public class QuickSort<T>
    {
        private int amountGenericValues;
        private T[] arrayT;
        private CompareObj cObj = new CompareObj();
        public QuickSort(int amountOfNumbers)
        {
            amountGenericValues = amountOfNumbers;
        }

        public T[] GetTArray()
        {
            return arrayT;
        }

        public void QSort(T[] array, int l, int r)
        {            
            T temp;
            if (array.Length != 0)
            {
                T x = array[l + (r - l) / 2];
                //запись эквивалентна (l+r)/2, 
                //но не вызввает переполнения на больших данных
                int i = l;
                int j = r;
                //код в while обычно выносят в процедуру particle
                while (cObj.Compare(i, j)<=0)
                {
                    while (cObj.Compare(array[i],x)<0) i++;
                    while (cObj.Compare(array[j],x)>0) j--;
                    if (cObj.Compare(i, j)<=0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        i++;
                        j--;
                    }
                }
                if (cObj.Compare(i, r) < 0)
                    QSort(array, i, r);

                if (l < j)
                    QSort(array, l, j);

            }
            arrayT = array;

        }
    }
}
