namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.IsValid, "", true);
            Test.Check(solution.IsValid, "()", true);
            Test.Check(solution.IsValid, "(", false);
            Test.Check(solution.IsValid, ")", false);
            Test.Check(solution.IsValid, "())", false);
            Test.Check(solution.IsValid, "(())", true);
            Test.Check(solution.IsValid, "((())", false);
            Test.Check(solution.IsValid, "()[]", true);
            Test.Check(solution.IsValid, "()[]{}", true);
            Test.Check(solution.IsValid, "[(){}]", true);
            Test.Check(solution.IsValid, "[()({})[]]", true);
            Test.Check(solution.IsValid, "[({})({})[]]", true);
            Test.Check(solution.IsValid, "[({[]})({})[]]", true);
            Test.Check(solution.IsValid, "{[({[]})({})[]]}", true);
            Test.Check(solution.IsValid, "{[({[]})}({})[]]}", false);
        }

    }
}