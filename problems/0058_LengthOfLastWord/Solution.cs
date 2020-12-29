namespace Quiz {
    public class Solution {
        
        public int LengthOfLastWord(string s) {
            int index = s.Length - 1;
            
            while (index >= 0 && s[index] == ' ') {
                index--;
            }

            int end = index;
            
            while (index >= 0 && s[index] != ' ') {
                index--;
            }

            int start = index;

            return end - start;
        }
        
    }
}