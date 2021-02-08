using System;

namespace Quiz {
    public class Solution {

        public int StrStr(string haystack, string needle) => StrStr(haystack.AsSpan(), needle.AsSpan());

        public int StrStr(ReadOnlySpan<char> str, ReadOnlySpan<char> fragment) {
            if (str.Length < fragment.Length) {
                return -1;
            } else if (fragment.Length == 0) {
                return 0;
            }
            
            int n_hash = Hash(fragment, 0, fragment.Length);
            int h_hash = 0;
            
            for (int i = 0; i <= str.Length - fragment.Length; i++) {
                if (i <= 0) {
                    h_hash = Hash(str, 0, fragment.Length);
                } else {
                    h_hash = Hash(h_hash, str[i - 1], str[i + fragment.Length - 1]);
                }
                
                if (n_hash == h_hash) {
                    ReadOnlySpan<char> sample = str.Slice(i, fragment.Length);
                    if (MemoryExtensions.Equals(sample, fragment, StringComparison.Ordinal)) {
                        return i;
                    }
                }
            }
            
            return -1;
        }
        
        public static int Hash(ReadOnlySpan<char> input, int start, int length) {
            int hash = 17;
            
            for (int i = 0; i < length; i++) {
                hash ^= input[i + start];
            }
            
            return hash;
        }

        public static int Hash(int hash, int prev_char, int next_char) {
            return hash ^ prev_char ^ next_char;
        }

    }
}