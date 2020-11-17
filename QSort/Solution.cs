using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public void QSort<T>(T[] array, Comparer<T> comparer) {
            QSort(array, comparer, 0, array.Length - 1);
        }
        
        public void QSort<T>(T[] a, Comparer<T> comparer, int lo, int hi) {
            if (lo < hi) {
                int p = (hi + lo) / 2;
                T a_p = a[p];

                int i = lo;
                int j = hi;

                while (i <= j) {
                    while (comparer.Compare(a[i], a_p) < 0) i++;
                    while (comparer.Compare(a[j], a_p) > 0) j--;
                
                    if (i <= j) {
                        T temp = a[i]; 
                        a[i] = a[j]; 
                        a[j] = temp;

                        i++; 
                        j--;
                    }
                }
            
                QSort(a, comparer, lo, j);
                QSort(a, comparer, i, hi);
            }
        }
        

    }
}