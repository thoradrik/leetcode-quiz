namespace Quiz {
    public class Solution {

        private int[] m_Nums;
        
        private int[] m_Maxes;
        
        public int LengthOfLIS(int[] nums) {
            m_Nums = nums;
            m_Maxes = new int[nums.Length];

            int max_seq = 0;
            
            for (int i = m_Nums.Length - 1; i >= 0; i--) {
                int path = FindMaxSeq(i);
                if (path > max_seq) {
                    max_seq = path;
                }
            }

            return max_seq;
        }

        public int FindMaxSeq(int e_i) {
            if (m_Maxes[e_i] > 0) {
                return m_Maxes[e_i];
            }
            
            int max_path = 0;
            
            for (int i = e_i + 1; i < m_Nums.Length; i++) {
                if (m_Nums[i] > m_Nums[e_i]) {
                    int path = FindMaxSeq(i);    
                    if (path > max_path) {
                        max_path = path;
                    }
                }
            }

            int result = max_path + 1;
            
            m_Maxes[e_i] = result;
        
            return result;
        }

    }
}