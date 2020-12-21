namespace Quiz {
    public class Solution {
        
        public int TrailingZeroes(int n) {
            int count = 0;
            
            for (int i = 0; i <= n; i++) {
                int num = i;

                while (num > 0 && num % 5 == 0) {
                    count++;
                    num /= 5;
                }
            }

            return count;
        }

    }
}