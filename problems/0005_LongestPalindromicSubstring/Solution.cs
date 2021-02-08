namespace Quiz {
    public class Solution {
        
        public string LongestPalindrome(string s) {
            string longest = null;
            
            void promote(int start, int end) {
                while (s[start] == s[end] && start > 0 && end < s.Length - 1) {
                    start--;
                    end++;
                }

                if (s[start] != s[end]) {
                    start++;
                    end--;
                }

                int length = end - start + 1;
                
                if (longest == null || length > longest.Length) {
                    longest = s.Substring(start, length);
                }
            }
            
            for (int i = 0; i < s.Length; i++) {
                if (i > 0) {
                    if (s[i - 1] == s[i]) {
                        promote(i - 1, i);
                    }
                }
                
                promote(i, i);
            }

            return longest;
        } 

    }
}