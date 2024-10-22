namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new WordDictionary();

            solution.AddWord("apple");
            solution.AddWord("apply");
            solution.AddWord("door");
            solution.AddWord("poor");
            solution.AddWord("pool");
            solution.AddWord("bad");
            solution.AddWord("dad");
            solution.AddWord("mad");
            solution.AddWord("sad");
            solution.AddWord("pad");
            solution.AddWord("bar");
            solution.AddWord("man");
            solution.AddWord("pan");
            solution.AddWord("fan");
            solution.AddWord("dan");

            Test.Check(solution.Search, "apple", true);
            Test.Check(solution.Search, "apple.", false);
            Test.Check(solution.Search, ".pple.", false);
            Test.Check(solution.Search, ".p.le.", false);
            Test.Check(solution.Search, ".p.le", true);
            Test.Check(solution.Search, "apples", false);
            Test.Check(solution.Search, "pad", true);
            Test.Check(solution.Search, "bad", true);
            Test.Check(solution.Search, "ban", false);
            Test.Check(solution.Search, ".ad", true);
            Test.Check(solution.Search, "..d", true);
            Test.Check(solution.Search, ".a.", true);
            Test.Check(solution.Search, ".e.", false);
            Test.Check(solution.Search, "m..", true);
            Test.Check(solution.Search, "n..", false);
            Test.Check(solution.Search, "..n", true);
            Test.Check(solution.Search, "...", true);
        }

    }
}
