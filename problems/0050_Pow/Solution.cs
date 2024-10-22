namespace Quiz {
    public class Solution {

        public double MyPow(double x, int n) {
            if (n < 0) {
                return 1.0 /  PowRec(x, - (long)n);
            } else {
                return PowRec(x, n);
            }
        }

        private double PowRec(double x, long n) {
            var a = 1.0;
            double b = x;

            while (n > 0) {
                if (n % 2 == 1) {
                    a = a * b;
                }

                b = b * b;

                n /= 2;
            }

            return a;
        }

    }
}
