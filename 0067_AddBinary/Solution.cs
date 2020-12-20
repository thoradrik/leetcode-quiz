using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public string AddBinary(string a, string b) {
            int ai = a.Length - 1;
            int bi = b.Length - 1;
            int k = 0;
            
            Stack<char> result = new Stack<char>();
            
            while (ai >= 0 || bi >= 0 || k > 0) {
                int c1 = ai >= 0 ? a[ai--] - '0' : 0;
                int c2 = bi >= 0 ? b[bi--] - '0' : 0;
            
                k += c1 + c2;
            
                result.Push(k % 2 == 1 ? '1' : '0');

                k >>= 1;
            }
        
            return new string(result.ToArray());
        }
        
   }
}