namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.IsMonotonic, IntArray("[1,2,2,3]"), true);
            Test.Check(solution.IsMonotonic, IntArray("[6,5,4,4]"), true);
            Test.Check(solution.IsMonotonic, IntArray("[1,3,5]"), true);
            Test.Check(solution.IsMonotonic, IntArray("[1,3,2]"), false);
            Test.Check(solution.IsMonotonic, IntArray("[1,2,4,5]"), true);
            Test.Check(solution.IsMonotonic, IntArray("[1,2,5,4]"), false);
            Test.Check(solution.IsMonotonic, IntArray("[1,1,1]"), true);
            Test.Check(solution.IsMonotonic, IntArray("[1,1,2]"), true);
            Test.Check(solution.IsMonotonic, IntArray("[1,2,1]"), false);
        }

    }
}