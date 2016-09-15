using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortNS
{
    class CompareObj<T>:IComparer<T>
    {
        public int Compare(T x, T y)
        {
            return (new CaseInsensitiveComparer()).Compare(x, y);
        }
    }
}
