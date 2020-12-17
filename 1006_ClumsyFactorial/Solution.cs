namespace Quiz {
    public class Solution {

        private const int TRIVIAL_MAX = 5;
        
        private readonly int[] TRIVIAL1 = new int[TRIVIAL_MAX] {
            0,
            1,
            2 * 1,
            3 * 2 / 1,
            4 * 3 / 2 + 1
        };
        
        private readonly int[] TRIVIAL2 = new int[TRIVIAL_MAX] {
            0,
            - 1,
            - 2 * 1,
            - 3 * 2 / 1,
            - 4 * 3 / 2 + 1
        };
        
        public int Clumsy(int N) {
            int result = 0;

            if (N < TRIVIAL_MAX) {
                return TRIVIAL1[N];
            }
            
            for (int i = N; i >= 1; i -= 4) {
                if (i < TRIVIAL_MAX) {
                    result += TRIVIAL2[i];
                    break;
                } else {
                    if (i == N) {
                        result += i * (i - 1) / (i - 2) + (i - 3);
                    } else {
                        result -= i * (i - 1) / (i - 2) - (i - 3);
                    }
                }
            }

            return result;
        }

    }
}