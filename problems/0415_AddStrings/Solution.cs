using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public string AddStrings(string num1, string num2) {
            int ai = num1.Length - 1;
            int bi = num2.Length - 1;
            int k = 0;
            
            Stack<char> result = new Stack<char>();
            
            while (ai >= 0 || bi >= 0 || k > 0) {
                int c1 = ai >= 0 ? num1[ai--] - '0' : 0;
                int c2 = bi >= 0 ? num2[bi--] - '0' : 0;
            
                k += c1 + c2;

                result.Push((char)(k % 10 + '0'));

                k /= 10;
            }
        
            return new string(result.ToArray());
        }
        
   }
}