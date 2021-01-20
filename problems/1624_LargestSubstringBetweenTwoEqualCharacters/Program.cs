namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.MaxLengthBetweenEqualCharacters, "a", -1);
            Test.Check(solution.MaxLengthBetweenEqualCharacters, "aa", 0);
            Test.Check(solution.MaxLengthBetweenEqualCharacters, "abca", 2);
            Test.Check(solution.MaxLengthBetweenEqualCharacters, "cbzxy", -1);
            Test.Check(solution.MaxLengthBetweenEqualCharacters, "cabbac", 4);
            Test.Check(solution.MaxLengthBetweenEqualCharacters, "cabcbac", 5);
            Test.Check(solution.MaxLengthBetweenEqualCharacters, "acabcbac", 5);
            Test.Check(solution.MaxLengthBetweenEqualCharacters, "acabccbac", 6);
            Test.Check(solution.MaxLengthBetweenEqualCharacters, "daacabccbac", 7);
            Test.Check(solution.MaxLengthBetweenEqualCharacters, "dcaacabccbac", 9);
        }

    }
}