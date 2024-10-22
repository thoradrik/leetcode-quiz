namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.LargestRectangleArea, IntArray("[]"), 0);
            Test.Check(solution.LargestRectangleArea, IntArray("[1]"), 1);
            Test.Check(solution.LargestRectangleArea, IntArray("[2,1]"), 2);
            Test.Check(solution.LargestRectangleArea, IntArray("[1,2]"), 2);
            Test.Check(solution.LargestRectangleArea, IntArray("[1,2,1]"), 3);
            Test.Check(solution.LargestRectangleArea, IntArray("[1,4,1]"), 4);
            Test.Check(solution.LargestRectangleArea, IntArray("[1,4,0,1,1]"), 4);
            Test.Check(solution.LargestRectangleArea, IntArray("[1,4,1,1,1]"), 5);
            Test.Check(solution.LargestRectangleArea, IntArray("[1,4,1,6,1]"), 6);
            Test.Check(solution.LargestRectangleArea, IntArray("[2,1,2]"), 3);
            Test.Check(solution.LargestRectangleArea, IntArray("[1,1,2]"), 3);
            Test.Check(solution.LargestRectangleArea, IntArray("[2,1,1]"), 3);
            Test.Check(solution.LargestRectangleArea, IntArray("[2,2,1]"), 4);
            Test.Check(solution.LargestRectangleArea, IntArray("[1,2,2]"), 4);
            Test.Check(solution.LargestRectangleArea, IntArray("[2,1,4]"), 4);
            Test.Check(solution.LargestRectangleArea, IntArray("[2,1,4,2]"), 4);
            Test.Check(solution.LargestRectangleArea, IntArray("[2,2,4,2]"), 8);
            Test.Check(solution.LargestRectangleArea, IntArray("[2,1,5,4,2]"), 8);
            Test.Check(solution.LargestRectangleArea, IntArray("[2,2,5,4,2]"), 10);
            Test.Check(solution.LargestRectangleArea, IntArray("[2,1,4,3]"), 6);
            Test.Check(solution.LargestRectangleArea, IntArray("[2,1,5,4,3]"), 9);
            Test.Check(solution.LargestRectangleArea, IntArray("[2,2,5,4,3]"), 10);
            Test.Check(solution.LargestRectangleArea, IntArray("[2,4,5,4,3]"), 12);
            
            Test.Check(solution.LargestRectangleArea, IntArray("[2,4,0,4,3]"), 6);
            
            Test.Check(solution.LargestRectangleArea, IntArray("[2,1,5,6,2,3]"), 10);
            Test.Check(solution.LargestRectangleArea, IntArray("[2,4]"), 4);
        }

    }
}