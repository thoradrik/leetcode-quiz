namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            // Test.Check(solution.IsMajorityElement, IntArray("[0]"), 5, false);
            // Test.Check(solution.IsMajorityElement, IntArray("[5]"), 5, true);
            // Test.Check(solution.IsMajorityElement, IntArray("[1,2]"), 2, false);
            Test.Check(solution.IsMajorityElement, IntArray("[1,2,2]"), 2, true);
            Test.Check(solution.IsMajorityElement, IntArray("[1,2,3]"), 5, false);
            Test.Check(solution.IsMajorityElement, IntArray("[1,2,3,4,5]"), 5, false);
            Test.Check(solution.IsMajorityElement, IntArray("[1,2,3,4,4,5]"), 4, false);
            Test.Check(solution.IsMajorityElement, IntArray("[1,2,3,4,4,4,5]"), 4, false);
            Test.Check(solution.IsMajorityElement, IntArray("[1,2,3,4,4,4,4,5]"), 4, false);
            Test.Check(solution.IsMajorityElement, IntArray("[1,2,3,4,4,4,4,4,5]"), 4, true);
            Test.Check(solution.IsMajorityElement, IntArray("[1,2,2,3,4,4,4,4,4,5]"), 4, false);
            Test.Check(solution.IsMajorityElement, IntArray("[1,2,2,3,4,4,4,4,4,4,5]"), 4, true);
            Test.Check(solution.IsMajorityElement, IntArray("[1,2,2,3,4,4,4,4,4,4,4,5]"), 4, true);
            Test.Check(solution.IsMajorityElement, IntArray("[1,2,2,3,3,4,4,4,4,4,4,4,5]"), 4, true);
            Test.Check(solution.IsMajorityElement, IntArray("[1,1,2,2,3,3,4,4,4,4,4,4,4,5]"), 4, false);
            Test.Check(solution.IsMajorityElement, IntArray("[1,1,1,1,2,2,3,3,4,4,4,4,4,4,4,5]"), 1, false);
            Test.Check(solution.IsMajorityElement, IntArray("[1,1,1,1,1,1,1,1,2,2,3,3,4,4,4,4,4,4,4,5]"), 1, false);
            Test.Check(solution.IsMajorityElement, IntArray("[1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,3,3,4,4,4,4,4,4,4,5]"), 1, true);
            Test.Check(solution.IsMajorityElement, IntArray("[1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,3,3,4,4,4,4,4,4,4,5]"), 5, false);
            Test.Check(solution.IsMajorityElement, IntArray("[1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,3,3,4,4,4,4,4,4,4,5,5,5,5]"), 5, false);
            Test.Check(solution.IsMajorityElement, IntArray("[1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,3,3,4,4,4,4,4,4,4,5,5,5,5,5,5,5,5,5,5]"), 5, false);
            Test.Check(solution.IsMajorityElement, IntArray("[1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,3,3,4,4,4,4,4,4,4,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5]"), 5, false);
            Test.Check(solution.IsMajorityElement, IntArray("[1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,3,3,4,4,4,4,4,4,4,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5]"), 5, false);
            Test.Check(solution.IsMajorityElement, IntArray("[1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,3,3,4,4,4,4,4,4,4,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5]"), 5, false);
            Test.Check(solution.IsMajorityElement, IntArray("[1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,3,3,4,4,4,4,4,4,4,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5]"), 5, true);
            Test.Check(solution.IsMajorityElement, IntArray("[1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,3,3,4,4,4,4,4,4,4,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5]"), 5, true);
        }

    }
}