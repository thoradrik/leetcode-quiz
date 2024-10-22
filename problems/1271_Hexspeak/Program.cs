namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.ToHexspeak, "0", "O");
            Test.Check(solution.ToHexspeak, "1", "I");
            Test.Check(solution.ToHexspeak, "15", "F");
            Test.Check(solution.ToHexspeak, "16", "IO");
            Test.Check(solution.ToHexspeak, "31", "IF");
            Test.Check(solution.ToHexspeak, "255", "FF");
            Test.Check(solution.ToHexspeak, "257", "IOI");
            Test.Check(solution.ToHexspeak, "3", "ERROR");
            Test.Check(solution.ToHexspeak, "1025921126416", "EEDDAAIOIO");
        }

    }
}