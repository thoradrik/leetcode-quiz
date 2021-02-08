namespace Quiz {
    public class Solution {
        
        public bool CanPermutePalindrome(string s) {
            int[] counts = new int[256];
            
            for (int i = 0; i < s.Length; i++) {
                counts[s[i]]++;
            }

            int odds = 0;
            
            for (int i = 0; i < counts.Length; i++) {
                if (counts[i] % 2 == 1) {
                    odds++;
                }
            }

            return odds < 2;
        }
        
    }
}