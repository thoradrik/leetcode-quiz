namespace Quiz;

public class Solution {
    public int RomanToInt(string s) {
        var result = 0;

        var str = s.AsSpan();
        while (str.Length > 0) {
            if (TryToken(ref str, "CM")) {
                result += 900;
            } else if (TryToken(ref str, "CD")) {
                result += 400;
            } else if (TryToken(ref str, "XC")) {
                result += 90;
            } else if (TryToken(ref str, "XL")) {
                result += 40;
            } else if (TryToken(ref str, "IX")) {
                result += 9;
            } else if (TryToken(ref str, "IV")) {
                result += 4;
            } else if (TryToken(ref str, "M")) {
                result += 1000;
            } else if (TryToken(ref str, "D")) {
                result += 500;
            } else if (TryToken(ref str, "C")) {
                result += 100;
            } else if (TryToken(ref str, "L")) {
                result += 50;
            } else if (TryToken(ref str, "X")) {
                result += 10;
            } else if (TryToken(ref str, "V")) {
                result += 5;
            } else if (TryToken(ref str, "I")) {
                result += 1;
            } else {
                throw new Exception("Invalid token");
            }
        }

        return result;
    }

    private bool TryToken(ref ReadOnlySpan<char> s, ReadOnlySpan<char> template) {
        if (s.Length >= template.Length && s.StartsWith(template)) {
            s = s.Slice(template.Length);
            return true;
        }

        return false;
    }
}
