namespace Quiz {
    public class Solution {

        public uint reverseBits(uint n) {
            uint result = 0;

            for (var i = 0; i < 32; i++) {
                result <<= 1;

                result += n % 2;

                n >>= 1;
            }

            return result;
        }

    }
}
