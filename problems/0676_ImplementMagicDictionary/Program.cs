namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            MagicDictionary solution = new MagicDictionary();

            solution.BuildDict(new[] { "h", "hh", "hal", "hello", "welly", "leetcode" });

            Test.Check(solution.Search, "hell", false);
            Test.Check(solution.Search, "hello", false);
            Test.Check(solution.Search, "hellow", false);
            
            Test.Check(solution.Search, "gello", true);
            Test.Check(solution.Search, "hhllo", true);
            Test.Check(solution.Search, "heplo", true);
            Test.Check(solution.Search, "helpo", true);
            Test.Check(solution.Search, "hellz", true);
            
            Test.Check(solution.Search, "hhllz", false);
            
            Test.Check(solution.Search, "leetcode", false);
            Test.Check(solution.Search, "leetcodz", true);
            Test.Check(solution.Search, "leetcade", true);
            Test.Check(solution.Search, "le3tcode", true);
            Test.Check(solution.Search, "lootcode", false);
        }

    }
}