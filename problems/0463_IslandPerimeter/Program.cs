namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.IslandPerimeter, Int2Array("[]"), 0);
            Test.Check(solution.IslandPerimeter, Int2Array("[[]]"), 0);
            Test.Check(solution.IslandPerimeter, Int2Array("[[0]]"), 0);
            Test.Check(solution.IslandPerimeter, Int2Array("[[1]]"), 4);
            Test.Check(solution.IslandPerimeter, Int2Array("[[0,0]]"), 0);
            Test.Check(solution.IslandPerimeter, Int2Array("[[1,0]]"), 4);
            Test.Check(solution.IslandPerimeter, Int2Array("[[0,1]]"), 4);
            Test.Check(solution.IslandPerimeter, Int2Array("[[1,1]]"), 6);
            Test.Check(solution.IslandPerimeter, Int2Array("[[0],[0]]"), 0);
            Test.Check(solution.IslandPerimeter, Int2Array("[[1],[0]]"), 4);
            Test.Check(solution.IslandPerimeter, Int2Array("[[0],[1]]"), 4);
            Test.Check(solution.IslandPerimeter, Int2Array("[[1],[1]]"), 6);
            Test.Check(solution.IslandPerimeter, Int2Array("[[0,0],[0,0]]"), 0);
            Test.Check(solution.IslandPerimeter, Int2Array("[[1,0],[0,0]]"), 1);
            Test.Check(solution.IslandPerimeter, Int2Array("[[1,1],[0,0]]"), 6);
            Test.Check(solution.IslandPerimeter, Int2Array("[[1,0],[1,0]]"), 6);
            Test.Check(solution.IslandPerimeter, Int2Array("[[1,1],[1,0]]"), 8);
            Test.Check(solution.IslandPerimeter, Int2Array("[[1,1],[0,1]]"), 8);
            Test.Check(solution.IslandPerimeter, Int2Array("[[1,0],[1,1]]"), 8);
            Test.Check(solution.IslandPerimeter, Int2Array("[[0,1],[1,1]]"), 8);
            Test.Check(solution.IslandPerimeter, Int2Array("[[1,1],[1,1]]"), 8);
            Test.Check(solution.IslandPerimeter, Int2Array("[[1,1],[1,1],[1,1]]"), 10);
            Test.Check(solution.IslandPerimeter, Int2Array("[[1,1],[0,1],[1,1]]"), 12);
            Test.Check(solution.IslandPerimeter, Int2Array("[[0,1,0,0],[1,1,1,0],[0,1,0,0],[1,1,0,0]]"), 16);
            Test.Check(solution.IslandPerimeter, Int2Array("[[0,1,0,0],[1,1,1,0],[0,1,0,0],[1,1,0,0]]"), 16);
        }

    }
}
