namespace Quiz;

public class Solution {
    public int LongestContinuousSubstring(string s) {
        var str = s.AsSpan();

        var length = new int[s.Length];

        var max = 0;

        for (var i = 0; i < str.Length; i++) {
            if (i > 0) {
                if (str[i] - str[i - 1] == 1) {
                    length[i] = length[i - 1] + 1;
                } else {
                    length[i] = 1;
                }
            } else {
                length[i] = 1;
            }

            max = Math.Max(max, length[i]);
        }

        return max;
    }
}
