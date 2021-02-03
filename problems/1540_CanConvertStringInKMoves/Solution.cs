namespace Quiz {
    public class Solution {
        
        public bool CanConvertString(string s, string t, int k) {
            if (s.Length != t.Length) {
                return false;
            } else if (s.Length == 0) {
                return true;
            }

            int[] shifts = new int[26];
            
            for (int i = 1; i < shifts.Length; i++) {
                shifts[i] = k / 26;
            }
            
            for (int i = 1; i <= k % 26; i++) {
                shifts[i]++;
            }
            
            for (int i = 0; i < s.Length; i++) {
                int c_s = s[i];
                int c_t = t[i];
                
                if (c_s == c_t) {
                    continue;
                } 
                
                int delta = c_t - c_s;
                if (delta < 0) {
                    delta += 26;
                }

                shifts[delta]--;

                if (shifts[delta] < 0) {
                    return false;
                }
            }

            return true;
        }
        
    }
}