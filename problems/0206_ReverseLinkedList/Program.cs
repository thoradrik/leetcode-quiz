namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.ReverseList, IntArray("[]"), IntArray("[]"));
            Test.Check(solution.ReverseList, IntArray("[1]"), IntArray("[1]"));
            Test.Check(solution.ReverseList, IntArray("[1,2]"), IntArray("[2,1]"));
            Test.Check(solution.ReverseList, IntArray("[1,2,3]"), IntArray("[3,2,1]"));
            Test.Check(solution.ReverseList, IntArray("[1,2,3,4]"), IntArray("[4,3,2,1]"));
            Test.Check(solution.ReverseList, IntArray("[1,2,3,4,5]"), IntArray("[5,4,3,2,1]"));
        }

    }

}