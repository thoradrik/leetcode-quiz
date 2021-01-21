namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.NthSuperUglyNumber, 10, IntArray("[2,3,5]"), 12);
            Test.Check(solution.NthSuperUglyNumber, 12, IntArray("[2,7,13,19]"), 32);
            Test.Check(solution.NthSuperUglyNumber, 1000, IntArray("[2,3,5,7,11,13]"), 1341988864);
        }

    }
}