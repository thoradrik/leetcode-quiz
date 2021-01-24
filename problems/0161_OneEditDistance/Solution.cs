namespace Quiz {
    public class Solution {
        
        public bool IsOneEditDistance(string s, string t) {
            int distance = s.Length - t.Length;
            if (distance < -1 || distance > 1) {
                return false;
            } else {
                return IsOneEditDistance(s, 0, s.Length - 1, t, 0, t.Length - 1);
            }
        }
        
        public bool IsOneEditDistance(string s, int s_start, int s_end, string t, int t_start, int t_end) {
            while (s_start <= s_end && t_start <= t_end && s[s_start] == t[t_start]) {
                s_start++;
                t_start++;
            }
            
            while (s_start <= s_end && t_start <= t_end && s[s_end] == t[t_end]) {
                s_end--;
                t_end--;
            }

            int s_len = s_end - s_start + 1;
            int t_len = t_end - t_start + 1;
            if (s_len > 1 || t_len > 1) {
                return false;
            } else if (s_len == 0) {
                return t_len == 1;
            } else {
                return true;
            }
        }
        
    }
}