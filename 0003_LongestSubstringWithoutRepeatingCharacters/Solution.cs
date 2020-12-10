using System;

namespace Quiz {
    public class Solution {
        
        public int LengthOfLongestSubstring(string s) {
            if (s.Length <= 0) {
                return 0;
            }
            
            int max_start = 0;
            int max_length = 0;
            
            bool[] map = new bool[256];

            int start = 0;
            int length = 1;
            map[s[start]] = true;                
                
            while (start + length < s.Length) {
                int k = start + length;
                
                if (map[s[k]]) {
                    if (length >= max_length) {
                        // Console.WriteLine("MAX: {0}", s.Substring(start, length));
                        max_start = start;
                        max_length = length;
                    }
                        
                    map[s[start]] = false;
                    start++;
                    
                    if (length > 0) {
                        length--;
                    }

                    goto next;
                }
                
                // Console.WriteLine("     {0}", s.Substring(start, length));
                
                map[s[k]] = true;
                length++;
            next: 
                ;
            }

            if (length > max_length) {
                // Console.WriteLine("MAX: {0}", s.Substring(start, length));
                max_start = start;
                max_length = length;
            }
            
            return max_length;
        }
        
    }
}