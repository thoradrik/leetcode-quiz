namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.PlusOne, IntArray("[]"), IntArray("[]"));
            Test.Check(solution.PlusOne, IntArray("[0]"), IntArray("[1]"));
            Test.Check(solution.PlusOne, IntArray("[1]"), IntArray("[2]"));
            Test.Check(solution.PlusOne, IntArray("[9]"), IntArray("[1,0]"));
            Test.Check(solution.PlusOne, IntArray("[1,0]"), IntArray("[1,1]"));
            Test.Check(solution.PlusOne, IntArray("[1,9]"), IntArray("[2,0]"));
            Test.Check(solution.PlusOne, IntArray("[1,9,9]"), IntArray("[2,0,0]"));
            Test.Check(solution.PlusOne, IntArray("[9,9,9]"), IntArray("[1,0,0,0]"));
        }

    }
}
