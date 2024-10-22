namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.MajorityElement, IntArray("[1]"), 1);
            Test.Check(solution.MajorityElement, IntArray("[1,2,2]"), 2);
            Test.Check(solution.MajorityElement, IntArray("[2,1,2,2]"), 2);
            Test.Check(solution.MajorityElement, IntArray("[1,1,1,3,2,1,2,5]"), 1);
            Test.Check(solution.MajorityElement, IntArray("[2,1,1,2,2,3,2,3,2]"), 2);
            Test.Check(solution.MajorityElement, IntArray("[2,1,3,1,3,3,2,3,2]"), 3);
            Test.Check(solution.MajorityElement, IntArray("[5,2,5,1,5,5,3,1,5,5,3,5,5,3,5,2,5,3,5,2]"), 5);
        }

    }
}
