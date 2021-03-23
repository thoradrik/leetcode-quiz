namespace Quiz {
    public class Solution {
        
        public bool CheckRecord(string s) {
            int a_total = 0;
            int l_row = 0;
            
            for (int i = 0; i < s.Length; i++) {
                char c = s[i];
                if (c == 'P') {
                    l_row = 0;
                } else if (c == 'A') {
                    a_total++;
                    
                    if (a_total >= 2) {
                        return false;
                    } else {
                        l_row = 0;
                    }
                } else if (c == 'L') {
                    l_row++;
                    
                    if (l_row >= 3) {
                        return false;
                    }
                }
            }

            return true;
        }
        
    }
}