using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public string[] FindOcurrences(string text, string first, string second) {
            
            bool compare(int from_index, int length, string fragment) {
                if (length != fragment.Length) {
                    return false;
                }

                for (int i = 0, j = from_index; i < fragment.Length; i++, j++) {
                    if (fragment[i] != text[j]) {
                        return false;
                    }
                }

                return true;
            }

            List<string> list = new List<string>();

            int start_index = 0;
            do {
                int first_space_index = text.IndexOf(' ', start_index);
                if (first_space_index < 0) {
                    break;
                }

                if (!compare(start_index, first_space_index - start_index, first)) {
                    start_index = first_space_index + 1;
                    continue;
                }

                int second_space_index = text.IndexOf(' ', first_space_index + 1);
                if (second_space_index < 0) {
                    break;
                }

                if (!compare(first_space_index + 1, second_space_index - first_space_index - 1, second)) {
                    start_index = first_space_index + 1;
                    continue;
                }
                
                int end_index = text.IndexOf(' ', second_space_index + 1);
                if (end_index < 0) {
                    end_index = text.Length;
                }

                list.Add(text.Substring(second_space_index + 1, end_index - second_space_index - 1));
                
                start_index = first_space_index + 1;
            } while (true);

            return list.ToArray();
        }
        
    }
}