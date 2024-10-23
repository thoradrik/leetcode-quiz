namespace Quiz;

public class Solution {

    public int MaximumRemovals(string s, string p, int[] removable) {
        _s = s;
        _p = p;
        _removable = removable;
        return Find(0, _removable.Length);
    }

    private string _s;
    private string _p;
    private int[] _removable;

    private int Find(int lo, int hi) {
        if (lo >= hi) {
            return hi;
        }

        var mid = (lo + hi) / 2;

        var mid_a = Check(mid);
        var mid_b = Check(mid + 1);
        if (mid_a) {
            if (mid_b) {
                return Find(mid + 1, hi);
            }

            return mid;
        }

        if (mid_b) {
            return Find(mid + 1, hi);
        }

        return Find(lo, mid);
    }

    private bool Check(int count) {
        Span<char> variant = stackalloc char[_s.Length];

        _s.CopyTo(variant);

        for (var i = 0; i < count; i++) {
            variant[_removable[i]] = '_';
        }

        return Check(variant, _p);
    }

    private bool Check(ReadOnlySpan<char> s, ReadOnlySpan<char> p) {
        var si = 0;
        var pi = 0;

        while (si < s.Length && pi < p.Length) {
            if (s[si] == p[pi]) {
                pi++;
            }

            si++;
        }

        return pi == p.Length;
    }
}
