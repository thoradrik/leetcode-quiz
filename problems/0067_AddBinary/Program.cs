namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.AddBinary, "0", "0", "0");
            Test.Check(solution.AddBinary, "0", "1", "1");
            Test.Check(solution.AddBinary, "1", "0", "1");
            Test.Check(solution.AddBinary, "1", "1", "10");
            Test.Check(solution.AddBinary, "10", "1", "11");
            Test.Check(solution.AddBinary, "0", "11", "11");
            Test.Check(solution.AddBinary, "11", "0", "11");
            Test.Check(solution.AddBinary, "1", "11", "100");
            Test.Check(solution.AddBinary, "11", "11", "110");
            Test.Check(solution.AddBinary, "1010", "1011", "10101");
            Test.Check(solution.AddBinary, "1010", "1", "1011");
            Test.Check(solution.AddBinary, "1000010001110100011010111000111", "1000010001110100011010111000111", "10000100011101000110101110001110");
        }

    }
}
