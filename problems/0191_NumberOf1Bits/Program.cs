namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.HammingWeight, 0b00000000000000000000000000000000u, 0);
            Test.Check(solution.HammingWeight, 0b10000000000000000000000000000000u, 1);
            Test.Check(solution.HammingWeight, 0b01000000000000000000000000000000u, 1);
            Test.Check(solution.HammingWeight, 0b00100000000000000000000000000000u, 1);
            Test.Check(solution.HammingWeight, 0b00010000000000000000000000000000u, 1);
            Test.Check(solution.HammingWeight, 0b00000001000000000000000000000000u, 1);
            Test.Check(solution.HammingWeight, 0b00000000000100000000000000000000u, 1);
            Test.Check(solution.HammingWeight, 0b00000000000100000000000001000000u, 2);
            Test.Check(solution.HammingWeight, 0b10000000000000000010000000000001u, 3);
            Test.Check(solution.HammingWeight, 0b10000000000100000000000000000001u, 3);
            Test.Check(solution.HammingWeight, 0b10000000000100000000010000000001u, 4);
            Test.Check(solution.HammingWeight, 0b10000000000100000000010000010001u, 5);
            Test.Check(solution.HammingWeight, 0b10010000000100000000010000010001u, 6);
            Test.Check(solution.HammingWeight, 0b10010000000100000000010001010001u, 7);
            Test.Check(solution.HammingWeight, 0b10010000000100100000010001010001u, 8);
            Test.Check(solution.HammingWeight, 0b10010010000100100000010001010001u, 9);
            Test.Check(solution.HammingWeight, 0b10010010000100100100010001010001u, 10);
            Test.Check(solution.HammingWeight, 0b10010010000100100100010001010011u, 11);
            Test.Check(solution.HammingWeight, 0b10010010001100100100010001010011u, 12);
            Test.Check(solution.HammingWeight, 0b10010010001100100100010001011011u, 13);
            Test.Check(solution.HammingWeight, 0b10010110001100100100010001011011u, 14);
            Test.Check(solution.HammingWeight, 0b10010110001100100101010001011011u, 15);
            Test.Check(solution.HammingWeight, 0b11010110001100100101010001011011u, 16);
            Test.Check(solution.HammingWeight, 0b11010110001100101101010001011011u, 17);
            Test.Check(solution.HammingWeight, 0b11010110001101101101010001011011u, 18);
            Test.Check(solution.HammingWeight, 0b11010110001101101111010001011011u, 19);
            Test.Check(solution.HammingWeight, 0b11010110001101101111010101011011u, 20);
            Test.Check(solution.HammingWeight, 0b11010110001101101111010101011111u, 21);
            Test.Check(solution.HammingWeight, 0b11010110001101101111011101011111u, 22);
            Test.Check(solution.HammingWeight, 0b11010110101101101111011101011111u, 23);
            Test.Check(solution.HammingWeight, 0b11110110101101101111011101011111u, 24);
            Test.Check(solution.HammingWeight, 0b11110110101101101111011111011111u, 25);
            Test.Check(solution.HammingWeight, 0b11110111101101101111011111011111u, 26);
            Test.Check(solution.HammingWeight, 0b11111111101101101111011111011111u, 27);
            Test.Check(solution.HammingWeight, 0b11111111101101101111011111111111u, 28);
            Test.Check(solution.HammingWeight, 0b11111111101101101111111111111111u, 29);
            Test.Check(solution.HammingWeight, 0b11111111101111101111111111111111u, 30);
            Test.Check(solution.HammingWeight, 0b11111111101111111111111111111111u, 31);
            Test.Check(solution.HammingWeight, 0b11111111111111111111111111111111u, 32);
        }

    }
}
