namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.ValidateStackSequences, IntArray("[]"), IntArray("[]"), true);
            Test.Check(solution.ValidateStackSequences, IntArray("[1]"), IntArray("[1]"), true);
            Test.Check(solution.ValidateStackSequences, IntArray("[1,2]"), IntArray("[2,1]"), true);
            Test.Check(solution.ValidateStackSequences, IntArray("[1,2]"), IntArray("[1,2]"), true);
            Test.Check(solution.ValidateStackSequences, IntArray("[1,2,3]"), IntArray("[1,2,3]"), true);
            Test.Check(solution.ValidateStackSequences, IntArray("[1,2,3]"), IntArray("[2,1,3]"), true);
            Test.Check(solution.ValidateStackSequences, IntArray("[1,2,3]"), IntArray("[2,3,1]"), true);
            Test.Check(solution.ValidateStackSequences, IntArray("[1,2,3]"), IntArray("[3,2,1]"), true);
            Test.Check(solution.ValidateStackSequences, IntArray("[1,2,3]"), IntArray("[1,3,2]"), true);
            Test.Check(solution.ValidateStackSequences, IntArray("[1,2,3]"), IntArray("[3,1,2]"), false);
            Test.Check(solution.ValidateStackSequences, IntArray("[1,2,3,4]"), IntArray("[1,2,3,4]"), true);
            Test.Check(solution.ValidateStackSequences, IntArray("[1,2,3,4]"), IntArray("[1,2,4,3]"), true);
            Test.Check(solution.ValidateStackSequences, IntArray("[1,2,3,4]"), IntArray("[1,3,2,4]"), true);
            Test.Check(solution.ValidateStackSequences, IntArray("[1,2,3,4]"), IntArray("[1,4,3,2]"), true);
            Test.Check(solution.ValidateStackSequences, IntArray("[1,2,3,4]"), IntArray("[4,3,2,1]"), true);
            Test.Check(solution.ValidateStackSequences, IntArray("[1,2,3,4,5]"), IntArray("[4,5,3,2,1]"), true);
            Test.Check(solution.ValidateStackSequences, IntArray("[1,2,3,4,5]"), IntArray("[4,3,5,1,2]"), false);
            Test.Check(solution.ValidateStackSequences, IntArray("[0,2,1]"), IntArray("[0,1,2]"), true);
        }

    }
}
