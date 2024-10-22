namespace Quiz {
    public class Solution {

        public string ReverseVowels(string s) {
            char[] chars = s.ToCharArray();

            bool is_vowel(char c) => c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' ||  c == 'I' || c == 'o' || c == 'O' || c == 'u' || c == 'U';

            var start = 0;
            int end = chars.Length - 1;

            do {
                while (start < chars.Length && !is_vowel(chars[start])) {
                    start++;
                }

                while (end > 0 && !is_vowel(chars[end])) {
                    end--;
                }

                if (start < end) {
                    ref char x = ref chars[start];
                    ref char y = ref chars[end];

                    x ^= y;
                    y ^= x;
                    x ^= y;

                    start++;
                    end--;
                } else {
                    break;
                }
            } while (start < end);

            return new string(chars);
        }

    }
}
