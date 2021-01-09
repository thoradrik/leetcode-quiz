namespace Quiz {
    public class Solution {
        
        public bool IsMonotonic(int[] A) {
            int direction = 0;
            
            for (int i = 1; i < A.Length; i++) {
                int a_prev = A[i - 1];
                int a_i = A[i];
                if (a_prev != a_i) {
                    if (a_prev < a_i) {
                        if (direction > 0) {
                            return false;
                        } else {
                            direction = -1;
                        }
                    } else {
                        if (direction < 0) {
                            return false;
                        } else {
                            direction = 1;
                        }
                    }
                }
            }

            return true;
        }
        
    }
}