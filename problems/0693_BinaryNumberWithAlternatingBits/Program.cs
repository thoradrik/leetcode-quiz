namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.HasAlternatingBits, 0b0, true);
            Test.Check(solution.HasAlternatingBits, 0b1, true);
            Test.Check(solution.HasAlternatingBits, 0b10, true);
            Test.Check(solution.HasAlternatingBits, 0b11, false);
            Test.Check(solution.HasAlternatingBits, 0b110, false);
            Test.Check(solution.HasAlternatingBits, 0b101, true);
            Test.Check(solution.HasAlternatingBits, 0b1011, false);
            Test.Check(solution.HasAlternatingBits, 0b1010, true);
            Test.Check(solution.HasAlternatingBits, 0b1110, false);
            Test.Check(solution.HasAlternatingBits, 0b101010, true);
            Test.Check(solution.HasAlternatingBits, 0b101011, false);
            Test.Check(solution.HasAlternatingBits, 0b1010101, true);
            Test.Check(solution.HasAlternatingBits, 0b1110101, false);
            Test.Check(solution.HasAlternatingBits, 0b10110101, false);
            Test.Check(solution.HasAlternatingBits, 0b101010101, true);
        }

    }
}
