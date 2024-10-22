namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.IsPalindrome, 0, true);
            Test.Check(solution.IsPalindrome, 1, true);
            Test.Check(solution.IsPalindrome, -1, false);
            Test.Check(solution.IsPalindrome, 10, false);
            Test.Check(solution.IsPalindrome, 11, true);
            Test.Check(solution.IsPalindrome, -11, false);
            Test.Check(solution.IsPalindrome, 111, true);
            Test.Check(solution.IsPalindrome, 121, true);
            Test.Check(solution.IsPalindrome, 1211, false);
            Test.Check(solution.IsPalindrome, 1221, true);
            Test.Check(solution.IsPalindrome, 12321, true);
            Test.Check(solution.IsPalindrome, 12341, false);
            Test.Check(solution.IsPalindrome, 120341, false);
            Test.Check(solution.IsPalindrome, 124341, false);
            Test.Check(solution.IsPalindrome, 1243421, true);
            Test.Check(solution.IsPalindrome, -1243421, false);
            Test.Check(solution.IsPalindrome, 12430421, false);
            Test.Check(solution.IsPalindrome, 124303421, true);
        }

    }
}
