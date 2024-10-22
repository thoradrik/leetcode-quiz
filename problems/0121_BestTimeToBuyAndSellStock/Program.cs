namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.MaxProfit, IntArray("[1]"), 0);
            Test.Check(solution.MaxProfit, IntArray("[1,2]"), 1);
            Test.Check(solution.MaxProfit, IntArray("[1,2,3]"), 2);
            Test.Check(solution.MaxProfit, IntArray("[1,3,2]"), 2);
            Test.Check(solution.MaxProfit, IntArray("[2,4,2,1]"), 2);
            Test.Check(solution.MaxProfit, IntArray("[2,4,2,1,4]"), 3);
            Test.Check(solution.MaxProfit, IntArray("[7,1,5,3,6,4]"), 5);
            Test.Check(solution.MaxProfit, IntArray("[7,6,4,3,1]"), 0);
        }

    }
}
