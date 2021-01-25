namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.MinDistance, "", "a", 1);
            Test.Check(solution.MinDistance, "", "aa", 2);
            Test.Check(solution.MinDistance, "a", "", 1);
            Test.Check(solution.MinDistance, "a", "b", 1);
            Test.Check(solution.MinDistance, "a", "ab", 1);
            Test.Check(solution.MinDistance, "aa", "ab", 1);
            Test.Check(solution.MinDistance, "aab", "ab", 1);
            Test.Check(solution.MinDistance, "aaba", "ab", 2);
            Test.Check(solution.MinDistance, "aaba", "abba", 1);
            Test.Check(solution.MinDistance, "aaba", "abbb", 2);
            Test.Check(solution.MinDistance, "aaa", "bbb", 3);
            Test.Check(solution.MinDistance, "aaa", "bbba", 3);
            Test.Check(solution.MinDistance, "aaa", "bbbaa", 3);
            
            Test.Check(solution.MinDistance, "abc", "cba", 2);
            Test.Check(solution.MinDistance, "abcd", "cba", 3);
            Test.Check(solution.MinDistance, "abcd", "cbad", 2);
            Test.Check(solution.MinDistance, "abcdu", "cbady", 3);
            Test.Check(solution.MinDistance, "kabcdu", "cbady", 4);
            
            Test.Check(solution.MinDistance, "horse", "ros", 3);
            Test.Check(solution.MinDistance, "intention", "execution", 5);
            Test.Check(solution.MinDistance, "pneumonoultramicroscopicsilicovolcanoconiosis", "ultramicroscopically", 27);
            Test.Check(solution.MinDistance, "distance", "springbok", 9);
        }

    }
}