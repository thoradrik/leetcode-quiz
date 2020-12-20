namespace Quiz {
    public class Solution {

        /*
         
        private static Dictionary<int, bool> m_Map = new Dictionary<int, bool> {
            { 1, true },
            { 10, true },
            { 100, true }
        };
        
        public bool IsHappy(int n) {
            if (m_Map.TryGetValue(n, out bool result)) {
                return result;
            }

            m_Map[n] = false;
            
            int k = n;
            int s = 0;
            while (k > 0) {
                int r = k % 10;
                s += r * r;
                k /= 10;
            }

            if (IsHappy(s)) {
                m_Map[n] = true;
                return true;
            } else {
                return false;
            }
        }
        
        */
        
        public bool IsHappy(int n) {
            while (true) {
                if (n == 1) {
                    return true;
                } else if (n == 4) {
                    return false;
                }

                int k = n;
                int s = 0;
                while (k > 0) {
                    int r = k % 10;
                    s += r * r;
                    k /= 10;
                }

                n = s;
            }
        }
        
    }
}