namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.MinDistance, "", "", 0);
            Test.Check(solution.MinDistance, "a", "", 1);
            Test.Check(solution.MinDistance, "", "b", 1);
            Test.Check(solution.MinDistance, "a", "b", 2);
            Test.Check(solution.MinDistance, "aa", "ba", 2);
            Test.Check(solution.MinDistance, "aa", "bac", 3);
            Test.Check(solution.MinDistance, "aac", "bac", 2);
            Test.Check(solution.MinDistance, "aa", "bb", 4);
            Test.Check(solution.MinDistance, "sea", "eat", 2);
            Test.Check(solution.MinDistance, "sea", "eatsea", 3);
            Test.Check(solution.MinDistance, "sea", "eatseaz", 4);
            Test.Check(solution.MinDistance, "seaz", "eatseaz", 3);
            Test.Check(solution.MinDistance, "beer", "cake", 6);
        }

    }
}