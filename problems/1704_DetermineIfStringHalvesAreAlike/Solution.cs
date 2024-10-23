namespace Quiz;

public class Solution {
    public bool HalvesAreAlike(string s) {
        var str = s.AsSpan();
        var half = str.Length >> 1;
        return CountVowels(str[..half]) == CountVowels(str[half..]);
    }

    private int CountVowels(ReadOnlySpan<char> str) {
        var count = 0;

        for (var i = 0; i < str.Length; i++) {
            count += str[i] switch {
                'a' => 1,
                'e' => 1,
                'i' => 1,
                'o' => 1,
                'u' => 1,
                'A' => 1,
                'E' => 1,
                'I' => 1,
                'O' => 1,
                'U' => 1,
                _ => 0
            };
        }

        return count;
    }
}
