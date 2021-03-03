namespace Quiz {
    public class Solution {
        
        public bool ValidPalindrome(string s) {
            if (s.Length <= 2) {
                return true;
            }

            bool try_match_palindrome(int f_start, int f_end, out int r_start, out int r_end) {
                for (r_start = f_start, r_end = f_end; r_start < r_end; r_start++, r_end--) {
                    if (s[r_start] != s[r_end]) {
                        return false;
                    }
                }

                return true;
            }

            if (try_match_palindrome(0, s.Length - 1, out int start, out int end)) {
                return true;
            } else {
                return try_match_palindrome(start + 1, end, out int _, out int _) || try_match_palindrome(start, end - 1, out int _, out int _);
            }
        }
        
    }
} 