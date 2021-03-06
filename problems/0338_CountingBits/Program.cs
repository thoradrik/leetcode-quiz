namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.CountBits, 0,  IntArray("[0]"));
            Test.Check(solution.CountBits, 1,  IntArray("[0,1]"));
            
            Test.Check(solution.CountBits, 2,  IntArray("[0,1,1]"));
            Test.Check(solution.CountBits, 3,  IntArray("[0,1,1,2]"));
            
            Test.Check(solution.CountBits, 4,  IntArray("[0,1,1,2,1]"));
            Test.Check(solution.CountBits, 5,  IntArray("[0,1,1,2,1,2]"));
            Test.Check(solution.CountBits, 6,  IntArray("[0,1,1,2,1,2,2]"));
            Test.Check(solution.CountBits, 7,  IntArray("[0,1,1,2,1,2,2,3]"));
            
            Test.Check(solution.CountBits, 8,  IntArray("[0,1,1,2,1,2,2,3,1]"));
            Test.Check(solution.CountBits, 9,  IntArray("[0,1,1,2,1,2,2,3,1,2]"));
            Test.Check(solution.CountBits, 10, IntArray("[0,1,1,2,1,2,2,3,1,2,2]"));
            Test.Check(solution.CountBits, 11, IntArray("[0,1,1,2,1,2,2,3,1,2,2,3]"));
            Test.Check(solution.CountBits, 12, IntArray("[0,1,1,2,1,2,2,3,1,2,2,3,2]"));
            Test.Check(solution.CountBits, 13, IntArray("[0,1,1,2,1,2,2,3,1,2,2,3,2,3]"));
            Test.Check(solution.CountBits, 14, IntArray("[0,1,1,2,1,2,2,3,1,2,2,3,2,3,3]"));
            Test.Check(solution.CountBits, 15, IntArray("[0,1,1,2,1,2,2,3,1,2,2,3,2,3,3,4]"));
        }

    }
}