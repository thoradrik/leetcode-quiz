using System.Collections.Generic;
using System.Text;

namespace Quiz {
    public class Solution {
        
        public string ReorderSpaces(string text) {
            var spaces = 0;

            var words = new List<(int,int)>();

            int word_start = -1;
            var word_length = 0;

            for (var i = 0; i < text.Length; i++) {
                if (text[i] == ' ') {
                    if (word_length > 0) {
                        words.Add((word_start, word_length));

                        word_start = -1;
                        word_length = 0;
                    }
                    
                    spaces++;
                } else {
                    if (word_length > 0) {
                        word_length++;
                    } else {
                        word_start = i;
                        word_length = 1;
                    }
                }
            }

            if (word_length > 0) {
                words.Add((word_start, word_length));
            }

            var sb = new StringBuilder(text.Length);

            if (words.Count > 1) {
                int gaps_count = words.Count - 1;
                int middle_spaces = spaces / gaps_count;
                int trailing_spaces = spaces % gaps_count;
                
                for (var index = 0; index < words.Count; index++) {
                    (int start, int length) = words[index];
                    if (index > 0) {
                        sb.Append(' ', middle_spaces);
                    }

                    sb.Append(text.Substring(start, length));
                }
                
                sb.Append(' ', trailing_spaces);
            } else {
                (int start, int length) = words[0];
                sb.Append(text.Substring(start, length));
                sb.Append(' ', spaces);
            }

            return sb.ToString();
        }
        
    }
}