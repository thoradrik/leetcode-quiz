namespace Quiz {
    public class Solution {

        public bool CheckRecord(string s) {
            var a_total = 0;
            var l_row = 0;

            for (var i = 0; i < s.Length; i++) {
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
