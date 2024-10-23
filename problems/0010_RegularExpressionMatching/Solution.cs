namespace Quiz;

public class Solution {

    public bool IsMatch(string s, string p) {
        var matcher = BuildMatcherChain(p);
        return matcher.TryMatch(s);
    }

    private abstract class Matcher {

        public Matcher Next { get; set; }

        public abstract bool TryMatch(ReadOnlySpan<char> str);

        protected bool TryMatchNext(ReadOnlySpan<char> str) {
            if (Next != null) {
                return Next.TryMatch(str);
            }

            return str.Length == 0;
        }
    }

    private class Start : Matcher {

        public override bool TryMatch(ReadOnlySpan<char> str) => TryMatchNext(str);

    }

    private Matcher BuildMatcherChain(ReadOnlySpan<char> pattern) {
        var start = new Start();
        Matcher matcher = start;

        while (pattern.Length > 0) {
            if (TryZeroOrMoreAnyChar(ref pattern, ref matcher)) {

            } else if (TryZeroOrMoreChars(ref pattern, ref matcher)) {

            } else if (TryAnyChar(ref pattern, ref matcher)) {

            } else if (TrySubstring(ref pattern, ref matcher)) {

            } else {
                throw new Exception("Invalid pattern");
            }
        }

        return start;
    }

    private class ZeroOrMoreAnyChar : Matcher {

        public override string ToString() => ".*";

        public override bool TryMatch(ReadOnlySpan<char> str) {
            for (var j = str.Length; j >= 0; j--) {
                var rest = str.Slice(j);
                if (TryMatchNext(rest)) {
                    return true;
                }
            }

            return false;
        }

    }

    private bool TryZeroOrMoreAnyChar(ref ReadOnlySpan<char> pattern, ref Matcher matcher) {
        if (pattern.Length <= 1) {
            return false;
        }

        if (pattern[0] == '.' && pattern[1] == '*') {
            ChainMatcher(ref matcher, new ZeroOrMoreAnyChar());
            pattern = pattern.Slice(2);
            return true;
        }

        return false;
    }

    private class ZeroOrMoreChars(char chr) : Matcher {

        public override string ToString() => $"{chr}*";

        public override bool TryMatch(ReadOnlySpan<char> str) {
            for (var i = 0; i <= str.Length; i++) {
                if (i >= str.Length || str[i] != chr) {
                    for (var j = i; j >= 0; j--) {
                        var rest = str.Slice(j);
                        if (TryMatchNext(rest)) {
                            return true;
                        }
                    }

                    return false;
                }
            }

            return false;
        }
    }

    private bool TryZeroOrMoreChars(ref ReadOnlySpan<char> pattern, ref Matcher matcher) {
        if (pattern.Length <= 1) {
            return false;
        }

        if (pattern[0] >= 'a' && pattern[0] <= 'z' && pattern[1] == '*') {
            ChainMatcher(ref matcher, new ZeroOrMoreChars(pattern[0]));
            pattern = pattern.Slice(2);
            return true;
        }

        return false;
    }

    private class AnyChar : Matcher {

        public override string ToString() => $".";

        public override bool TryMatch(ReadOnlySpan<char> str) {
            if (str.Length <= 0) {
                return false;
            }

            var rest = str.Slice(1);
            return TryMatchNext(rest);
        }
    }

    private bool TryAnyChar(ref ReadOnlySpan<char> pattern, ref Matcher matcher) {
        if (pattern.Length <= 0) {
            return false;
        }

        if (pattern[0] == '.') {
            ChainMatcher(ref matcher, new AnyChar());
            pattern = pattern.Slice(1);
            return true;
        }

        return false;
    }

    private class Substring : Matcher {

        public Substring(ReadOnlySpan<char> str) {
            _str = new string(str);
        }

        private readonly string _str;

        public override string ToString() => _str;

        public override bool TryMatch(ReadOnlySpan<char> str) {
            if (str.Length < _str.Length) {
                return false;
            }

            if (!str.StartsWith(_str)) {
                return false;
            }

            var rest = str.Slice(_str.Length);
            return TryMatchNext(rest);
        }
    }

    private bool TrySubstring(ref ReadOnlySpan<char> pattern, ref Matcher matcher) {
        if (pattern.Length <= 0) {
            return false;
        }

        for (var i = 0; i < pattern.Length; i++) {
            if (pattern[i] >= 'a' && pattern[i] <= 'z') {
                continue;
            }

            if (pattern[i] == '.' && i > 0) {
                ChainMatcher(ref matcher, new Substring(pattern.Slice(0, i)));
                pattern = pattern.Slice(i);
                return true;
            }

            if (pattern[i] == '*' && i > 1) {
                ChainMatcher(ref matcher, new Substring(pattern.Slice(0, i - 1)));
                pattern = pattern.Slice(i - 1);
                return true;
            }
        }

        ChainMatcher(ref matcher, new Substring(pattern));
        pattern = pattern.Slice(pattern.Length);
        return true;
    }

    private void ChainMatcher(ref Matcher matcher, Matcher next) {
        matcher.Next = next;
        matcher = next;
    }
}
