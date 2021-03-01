using System.Text;

namespace Quiz {
    public class Solution {
        
        public string RemoveVowels(string s) {
            bool is_vowel(char c) => c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' ||  c == 'I' || c == 'o' || c == 'O' || c == 'u' || c == 'U';
            
            StringBuilder sb = new StringBuilder();

            foreach (char c in s) {
                if (!is_vowel(c)) {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
        
    }
}