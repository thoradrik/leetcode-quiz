namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.FindMaxAverage, IntArray("[1,2]"), 1, 2);
            Test.Check(solution.FindMaxAverage, IntArray("[1,2,2]"), 2, 2);
            Test.Check(solution.FindMaxAverage, IntArray("[1,2,2,4]"), 2, 3);
            Test.Check(solution.FindMaxAverage, IntArray("[1,12,-5,-6,50,3]"), 4, 12.75);
        }

    }
}
