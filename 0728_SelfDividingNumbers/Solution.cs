using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public IList<int> SelfDividingNumbers(int left, int right) {
            List<int> list = new List<int>();
            
            for (int i = left; i <= right; i++) {
                int n = i;

                while (n > 0) {
                    int k = n % 10;
                    if (k == 0 || i % k != 0) {
                        goto next_i;
                    } 
                    n /= 10;
                }
                
                list.Add(i);
                
            next_i: 
                ;
            }

            return list;
        }

    }
}