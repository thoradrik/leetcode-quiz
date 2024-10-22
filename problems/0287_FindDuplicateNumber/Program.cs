namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.FindDuplicate, IntArray("[1,1]"), 1);
            Test.Check(solution.FindDuplicate, IntArray("[1,2,1]"), 1);
            Test.Check(solution.FindDuplicate, IntArray("[1,2,2]"), 2);
            Test.Check(solution.FindDuplicate, IntArray("[1,2,2,3]"), 2);
            Test.Check(solution.FindDuplicate, IntArray("[1,2,3,3]"), 3);
            Test.Check(solution.FindDuplicate, IntArray("[3,2,1,1,4]"), 1);
            Test.Check(solution.FindDuplicate, IntArray("[7,7,6,5,4,3,2,1]"), 7);
            Test.Check(solution.FindDuplicate, IntArray("[2,2,2,2,2]"), 2);
            Test.Check(solution.FindDuplicate, IntArray("[1,2,3,4,5,5]"), 5);
        }

    }
}
