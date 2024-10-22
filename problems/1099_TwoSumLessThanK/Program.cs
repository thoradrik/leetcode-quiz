namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.TwoSumLessThanK, IntArray("[1]"), 1, -1);
            Test.Check(solution.TwoSumLessThanK, IntArray("[1,1]"), 2, -1);
            Test.Check(solution.TwoSumLessThanK, IntArray("[1,1]"), 3, 2);
            Test.Check(solution.TwoSumLessThanK, IntArray("[1,1]"), 3, 2);

            Test.Check(solution.TwoSumLessThanK, IntArray("[10,20,30]"), 15, -1);
            Test.Check(solution.TwoSumLessThanK, IntArray("[10,20,15,30]"), 15, -1);
            Test.Check(solution.TwoSumLessThanK, IntArray("[10,2,20,30]"), 15, 12);
            Test.Check(solution.TwoSumLessThanK, IntArray("[10,2,20,30,3]"), 15, 13);
            Test.Check(solution.TwoSumLessThanK, IntArray("[10,2,20,4,30,3]"), 15, 14);

            Test.Check(solution.TwoSumLessThanK, IntArray("[34,23,1,24,75,33,54,8]"), 60, 58);
            Test.Check(solution.TwoSumLessThanK, IntArray("[34,23,1,24,75,33,54,8,29,31]"), 60, 58);
            Test.Check(solution.TwoSumLessThanK, IntArray("[34,23,1,24,75,33,54,8,29,31,2,3,4,5,6]"), 60, 59);

        }

    }
}
