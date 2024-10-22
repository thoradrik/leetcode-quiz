namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.RemoveVowels, "", "");
            Test.Check(solution.RemoveVowels, "a", "");
            Test.Check(solution.RemoveVowels, "A", "");
            Test.Check(solution.RemoveVowels, "Ab", "b");
            Test.Check(solution.RemoveVowels, "Yb", "Yb");
            Test.Check(solution.RemoveVowels, "aeiou", "");
            Test.Check(solution.RemoveVowels, "leetcodeisacommunityforcoders", "ltcdscmmntyfrcdrs");
        }

    }
}