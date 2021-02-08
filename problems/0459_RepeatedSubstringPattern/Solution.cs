using System;

namespace Quiz {
    public class Solution {
        
        public bool RepeatedSubstringPattern(string s) {
            if (s.Length <= 1) {
                return false;
            }

            for (int len = 1; len <= s.Length / 2; len++) {
                if (s.Length % len == 0) {
                    ReadOnlySpan<char> sample = s.AsSpan(0, len);
                
                    for (int i = len; i < s.Length; i += len) {
                        ReadOnlySpan<char> test = s.AsSpan(i, len);

                        if (!MemoryExtensions.Equals(sample, test, StringComparison.Ordinal)) {
                            goto next_length;
                        }
                    }

                    return true;
                    
                next_length:
                
                    ;
                }
            }
            
            return false;
        }
        
    }
}