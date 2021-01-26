namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.NumIslands, Char2Array("[]"), 0);
            Test.Check(solution.NumIslands, Char2Array("[[]]"), 0);
            Test.Check(solution.NumIslands, Char2Array("[[\"0\"]]"), 0);
            Test.Check(solution.NumIslands, Char2Array("[[\"1\"]]"), 1);
            Test.Check(solution.NumIslands, Char2Array("[[\"0\",\"0\"]]"), 0);
            Test.Check(solution.NumIslands, Char2Array("[[\"1\",\"0\"]]"), 1);
            Test.Check(solution.NumIslands, Char2Array("[[\"1\",\"1\"]]"), 1);
            Test.Check(solution.NumIslands, Char2Array("[[\"1\"],[\"1\"]]"), 1);
            Test.Check(solution.NumIslands, Char2Array("[[\"1\",\"0\"],[\"0\",\"0\"]]"), 1);
            Test.Check(solution.NumIslands, Char2Array("[[\"1\",\"1\"],[\"0\",\"0\"]]"), 1);
            Test.Check(solution.NumIslands, Char2Array("[[\"1\",\"1\"],[\"0\",\"1\"]]"), 1);
            Test.Check(solution.NumIslands, Char2Array("[[\"1\",\"0\"],[\"0\",\"1\"]]"), 2);
            Test.Check(solution.NumIslands, Char2Array("[[\"0\",\"1\"],[\"1\",\"0\"]]"), 2);
            Test.Check(solution.NumIslands, Char2Array("[[\"1\",\"1\"],[\"1\",\"1\"]]"), 1);
            Test.Check(solution.NumIslands, Char2Array("[[\"1\",\"1\",\"1\",\"1\",\"0\"],[\"1\",\"1\",\"0\",\"1\",\"0\"],[\"1\",\"1\",\"0\",\"0\",\"0\"],[\"0\",\"0\",\"0\",\"0\",\"0\"]]"), 1);
            Test.Check(solution.NumIslands, Char2Array("[[\"1\",\"1\",\"0\",\"0\",\"0\"],[\"1\",\"1\",\"0\",\"0\",\"0\"],[\"0\",\"0\",\"1\",\"0\",\"0\"],[\"0\",\"0\",\"0\",\"1\",\"1\"]]"), 3);
        }

    }
}