namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.MaxAreaOfIsland, Int2Array("[]"), 0);
            Test.Check(solution.MaxAreaOfIsland, Int2Array("[[]]"), 0);
            Test.Check(solution.MaxAreaOfIsland, Int2Array("[[0]]"), 0);
            Test.Check(solution.MaxAreaOfIsland, Int2Array("[[1]]"), 1);
            Test.Check(solution.MaxAreaOfIsland, Int2Array("[[0,0]]"), 0);
            Test.Check(solution.MaxAreaOfIsland, Int2Array("[[1,0]]"), 1);
            Test.Check(solution.MaxAreaOfIsland, Int2Array("[[1,1]]"), 2);
            Test.Check(solution.MaxAreaOfIsland, Int2Array("[[1],[1]]"), 2);
            Test.Check(solution.MaxAreaOfIsland, Int2Array("[[1,0],[0,0]]"), 1);
            Test.Check(solution.MaxAreaOfIsland, Int2Array("[[1,1],[0,0]]"), 2);
            Test.Check(solution.MaxAreaOfIsland, Int2Array("[[1,1],[0,1]]"), 3);
            Test.Check(solution.MaxAreaOfIsland, Int2Array("[[1,0],[0,1]]"), 1);
            Test.Check(solution.MaxAreaOfIsland, Int2Array("[[0,1],[1,0]]"), 1);
            Test.Check(solution.MaxAreaOfIsland, Int2Array("[[1,1],[1,1]]"), 4);
            Test.Check(solution.MaxAreaOfIsland, Int2Array("[[1,1,1,1,0],[1,1,0,1,0],[1,1,0,0,0],[0,0,0,0,0]]"), 9);
            Test.Check(solution.MaxAreaOfIsland, Int2Array("[[1,1,0,0,0],[1,1,0,0,0],[0,0,1,0,0],[0,0,0,1,1]]"), 4);
            Test.Check(solution.MaxAreaOfIsland, Int2Array("[[0,0,1,0,0,0,0,1,0,0,0,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,1,1,0,1,0,0,0,0,0,0,0,0],[0,1,0,0,1,1,0,0,1,0,1,0,0],[0,1,0,0,1,1,0,0,1,1,1,0,0],[0,0,0,0,0,0,0,0,0,0,1,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,0,0,0,0,0,0,1,1,0,0,0,0]]"), 6);
        }

    }
}