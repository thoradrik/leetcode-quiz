namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.IsPalindrome, "", true);
            Test.Check(solution.IsPalindrome, ".,", true);
            Test.Check(solution.IsPalindrome, "0p", false);
            Test.Check(solution.IsPalindrome, "a", true);
            Test.Check(solution.IsPalindrome, "aA", true);
            Test.Check(solution.IsPalindrome, "aAb", false);
            Test.Check(solution.IsPalindrome, "aAbaA", true);
            Test.Check(solution.IsPalindrome, "aA baA", true);
            Test.Check(solution.IsPalindrome, "aA ba A", true);
            Test.Check(solution.IsPalindrome, "aA ba A ;", true);
            Test.Check(solution.IsPalindrome, "aA ba A ; c", false);
            Test.Check(solution.IsPalindrome, "A man, a plan, a canal: Panama", true);
        }

    }
}