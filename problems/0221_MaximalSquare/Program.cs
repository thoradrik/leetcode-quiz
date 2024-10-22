namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.MaximalSquare, Char2Array("[[\"0\"]]"), 0);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"1\"]]"), 0);

            Test.Check(solution.MaximalSquare, Char2Array("[[\"0\",\"0\"],[\"0\",\"0\"]]"), 0);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"1\",\"0\"],[\"0\",\"0\"]]"), 1);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"1\",\"1\"],[\"0\",\"0\"]]"), 1);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"1\",\"1\"],[\"1\",\"0\"]]"), 1);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"0\",\"1\"],[\"1\",\"0\"]]"), 1);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"1\",\"1\"],[\"1\",\"1\"]]"), 4);

            Test.Check(solution.MaximalSquare, Char2Array("[[\"0\",\"0\",\"0\"],[\"0\",\"0\",\"0\"]]"), 0);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"1\",\"0\",\"0\"],[\"0\",\"0\",\"0\"]]"), 1);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"1\",\"0\",\"0\"],[\"1\",\"0\",\"0\"]]"), 1);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"1\",\"1\",\"0\"],[\"1\",\"0\",\"0\"]]"), 1);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"1\",\"1\",\"0\"],[\"1\",\"1\",\"0\"]]"), 4);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"1\",\"1\",\"1\"],[\"1\",\"1\",\"1\"]]"), 4);

            Test.Check(solution.MaximalSquare, Char2Array("[[\"0\",\"0\",\"0\"],[\"0\",\"1\",\"0\"],[\"0\",\"0\",\"0\"]]"), 1);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"0\",\"0\",\"0\"],[\"0\",\"1\",\"1\"],[\"0\",\"0\",\"0\"]]"), 1);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"0\",\"0\",\"0\"],[\"0\",\"1\",\"1\"],[\"0\",\"1\",\"0\"]]"), 1);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"0\",\"0\",\"0\"],[\"0\",\"1\",\"1\"],[\"0\",\"1\",\"1\"]]"), 4);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"1\",\"1\",\"0\"],[\"0\",\"1\",\"1\"],[\"0\",\"1\",\"1\"]]"), 4);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"1\",\"1\",\"0\"],[\"1\",\"1\",\"1\"],[\"0\",\"1\",\"1\"]]"), 4);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"1\",\"1\",\"1\"],[\"1\",\"1\",\"1\"],[\"0\",\"1\",\"1\"]]"), 4);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"1\",\"1\",\"1\"],[\"1\",\"1\",\"1\"],[\"1\",\"1\",\"1\"]]"), 9);

            Test.Check(solution.MaximalSquare, Char2Array("[[\"1\",\"0\",\"1\",\"0\",\"0\"],[\"1\",\"0\",\"1\",\"1\",\"1\"],[\"1\",\"1\",\"1\",\"1\",\"1\"],[\"1\",\"0\",\"0\",\"1\",\"0\"]]"), 4);
            Test.Check(solution.MaximalSquare, Char2Array("[[\"1\",\"1\",\"1\",\"1\",\"0\"],[\"1\",\"1\",\"1\",\"1\",\"0\"],[\"1\",\"1\",\"1\",\"1\",\"1\"],[\"1\",\"1\",\"1\",\"1\",\"1\"],[\"0\",\"0\",\"1\",\"1\",\"1\"]]"), 16);

        }

    }
}
