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
        
        public int HammingDistance(int x, int y) {
            return BitCount(x ^ y);
        }
        
    }
}