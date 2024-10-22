namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.FindPoisonedDuration, IntArray("[1,4]"), 2, 4);
            Test.Check(solution.FindPoisonedDuration, IntArray("[1,2]"), 2, 3);
            Test.Check(solution.FindPoisonedDuration, IntArray("[1,2]"), 10000000, 10000001);
            Test.Check(solution.FindPoisonedDuration, IntArray("[0,10000000]"), 10000000, 20000000);
            Test.Check(solution.FindPoisonedDuration, IntArray("[1,10000001]"), 10000000, 20000000);
            Test.Check(solution.FindPoisonedDuration, IntArray("[1,10000002]"), 10000000, 20000000);
        }

    }
}
