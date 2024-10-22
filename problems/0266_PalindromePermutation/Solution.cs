namespace Quiz {
    public class Solution {

        public bool CanPermutePalindrome(string s) {
            var counts = new int[256];

            for (var i = 0; i < s.Length; i++) {
                counts[s[i]]++;
            }

            var odds = 0;

            for (var i = 0; i < counts.Length; i++) {
                if (counts[i] % 2 == 1) {
                    odds++;
                }
            }

            return odds < 2;
        }

    }
}
