namespace Quiz;

public class Solution {

    public bool IsMatch(string s, string p) {
        var dp = new bool?[s.Length + 1, p.Length + 1];

        var ss = s.AsSpan();
        var pp = p.AsSpan();
        return IsMatch(ref ss, 0, ref pp, 0, dp);
    }

    private bool IsMatch(ref ReadOnlySpan<char> s, int si, ref ReadOnlySpan<char> p, int pi, bool?[,] dp) {
        if (pi >= p.Length) {
            return si >= s.Length;
        }

        var d = dp[si, pi];
        if (d.HasValue) {
            return d.Value;
        }

        if (p[pi] == '*') {
            if (si < s.Length) {
                if (IsMatch(ref s, si + 1, ref p, pi + 1, dp) || IsMatch(ref s, si + 1, ref p, pi, dp)) {
                    dp[si, pi] = true;
                    return true;
                }
            }

            if (IsMatch(ref s, si, ref p, pi + 1, dp)) {
                dp[si, pi] = true;
                return true;
            }
        } else if (si < s.Length) {
            if (p[pi] == '?' || p[pi] == s[si]) {
                if (IsMatch(ref s, si + 1, ref p, pi + 1, dp)) {
                    dp[si, pi] = true;
                    return true;
                }
            }
        }

        dp[si, pi] = false;
        return false;
    }

}
