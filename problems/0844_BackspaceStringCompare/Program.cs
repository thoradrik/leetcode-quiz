namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.BackspaceCompare, "", "", true);
            Test.Check(solution.BackspaceCompare, "#", "", true);
            Test.Check(solution.BackspaceCompare, "", "q", false);
            Test.Check(solution.BackspaceCompare, "", "q#", true);
            Test.Check(solution.BackspaceCompare, "s", "s", true);
            Test.Check(solution.BackspaceCompare, "s", "q", false);
            Test.Check(solution.BackspaceCompare, "ps#", "p", true);
            Test.Check(solution.BackspaceCompare, "ps#", "pk#", true);
            Test.Check(solution.BackspaceCompare, "ps#", "pk##", false);
            Test.Check(solution.BackspaceCompare, "ps#p", "pkp##p", true);
            Test.Check(solution.BackspaceCompare, "ps#pp##p", "pkp##p", true);
        }

    }
}