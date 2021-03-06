namespace Quiz {
    public class Solution {
    
        private int BitCount(int n) {
            int a1 = n & 0b01010101010101010101010101010101;
            int a2 = (n >> 1) & 0b01010101010101010101010101010101;
            int b = a1 + a2;
            int b1 = b & 0b00110011001100110011001100110011;
            int b2 = (b >> 2) & 0b00110011001100110011001100110011;
            int c = b1 + b2;
            int c1 = c & 0b00001111000011110000111100001111;
            int c2 = (c >> 4) & 0b00001111000011110000111100001111;
            int d = c1 + c2;
            int e1 = d & 0b00000000111111110000000011111111;
            int e2 = (d >> 8) & 0b00000000111111110000000011111111;
            int f = e1 + e2;
            int f1 = f & 0b00000000000000001111111111111111;
            int f2 = (f >> 16) & 0b00000000000000001111111111111111;
            return f1 + f2;
        }
        
        private const uint DE_BRUIJN_MAGIC = 0x06EB14F9;
        
        private static readonly uint[] DE_BRUIJN_TABLE = {
            0,  1, 16,  2, 29, 17,  3, 22, 30, 20, 18, 11, 13,  4,  7, 23,
            31, 15, 28, 21, 19, 10, 12,  6, 14, 27,  9,  5, 26,  8, 25, 24,
        };

        private uint HighestBitIndex(uint n) {
            return DE_BRUIJN_TABLE[(n * DE_BRUIJN_MAGIC) >> 27];
        }
        
        public bool IsPowerOfFour(int n) {
            if (BitCount(n) == 1) {
                uint index = HighestBitIndex((uint)n);
                return index % 2 == 0;
            } else {
                return false;
            }
        }

    }
}