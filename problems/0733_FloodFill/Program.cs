namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Print(solution.FloodFill, Int2Array("[]"), 0, 0, 1);
            Test.Print(solution.FloodFill, Int2Array("[[]]"), 0, 0, 1);
            Test.Print(solution.FloodFill, Int2Array("[[0]]"), 0, 0, 1);
            Test.Print(solution.FloodFill, Int2Array("[[1]]"), 0, 0, 2);
            Test.Print(solution.FloodFill, Int2Array("[[0,1],[1,1]]"), 0, 0, 2);
            Test.Print(solution.FloodFill, Int2Array("[[1,1],[1,1]]"), 0, 0, 2);
            Test.Print(solution.FloodFill, Int2Array("[[1,1,1],[1,0,1],[1,1,1]]"), 1, 1, 2);
            Test.Print(solution.FloodFill, Int2Array("[[1,1,1],[1,1,1],[1,1,1]]"), 1, 1, 2);
            Test.Print(solution.FloodFill, Int2Array("[[1,3,1],[1,3,1],[1,3,1]]"), 1, 1, 2);
            Test.Print(solution.FloodFill, Int2Array("[[1,3,1],[3,3,3],[1,3,1]]"), 1, 1, 2);
        }

    }
}
