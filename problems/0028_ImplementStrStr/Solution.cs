namespace Quiz {
    public class Solution {
        
        public int StrStr(string haystack, string needle) {
            if (haystack.Length < needle.Length) {
                return -1;
            } else if (needle.Length == 0) {
                return 0;
            }

            int n_hash = Hash(needle, 0, needle.Length);
            int h_hash = 0;

            for (int i = 0; i <= haystack.Length - needle.Length; i++) {
                if (i <= 0) {
                    h_hash = Hash(haystack, 0, needle.Length);
                } else {
                    h_hash = Hash(h_hash, haystack[i - 1], haystack[i + needle.Length - 1]);
                }
                
                if (n_hash == h_hash) {
                    for (int j = 0; j < needle.Length; j++) {
                        if (haystack[i + j] != needle[j]) {
                            goto miss;
                        }
                    }
                    return i;
                miss: 
                    ;
                }
            }
            
            return -1;
        }
        
        public static int Hash(string input, int start, int length) {
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