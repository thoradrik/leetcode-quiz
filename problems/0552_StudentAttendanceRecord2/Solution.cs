namespace Quiz {
    public class Solution {
        
        public int CheckRecord(int n) {
            long m = 1000000007;
            
            long a = 0;
            long l = 0;
            long a_l = 0;
            long ll = 0;
            long a_ll = 0;
            long p = 1;

            for (int i = 0; i < n; i++) {
                long new_a =
                    /* ....A + P */ a +
                    /* ...AL + P */ a_l +
                    /* ..ALL + P */ a_ll +
                    /* ....L + A */ l +
                    /* ...LL + A */ ll +
                    /* ..... + A */ p;
                long new_l = 
                    /* ..... + L */ p;
                long new_a_l = 
                    /* ..A.. + L */ a;
                long new_ll = 
                    /* ....L + L */ l;
                long new_a_ll = 
                    /* ...AL + L */ a_l;
                long new_p = 
                    /* ....L + P */ l +
                    /* ...LL + P */ ll +
                    /* ..... + P */ p;

                a = new_a % m;
                l = new_l % m;
                a_l = new_a_l % m;
                ll = new_ll % m;
                a_ll = new_a_ll % m;
                p = new_p % m;            
            }

            long result = (a + a_l + a_ll + l + ll + p) % m;

            return (int) result;
        }
        
    }
}