namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.LargestTimeFromDigits, IntArray("[1,2,3,4]"), "23:41");
            Test.Check(solution.LargestTimeFromDigits, IntArray("[5,5,5,5]"), "");
            Test.Check(solution.LargestTimeFromDigits, IntArray("[0,0,0,0]"), "00:00");
            Test.Check(solution.LargestTimeFromDigits, IntArray("[0,0,1,0]"), "10:00");
            Test.Check(solution.LargestTimeFromDigits, IntArray("[5,2,3,9]"), "23:59");
        }

    }
}