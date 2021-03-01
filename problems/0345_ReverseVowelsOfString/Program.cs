namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.ReverseVowels, "", "");
            Test.Check(solution.ReverseVowels, "a", "a");
            Test.Check(solution.ReverseVowels, "b", "b");
            Test.Check(solution.ReverseVowels, "ab", "ab");
            Test.Check(solution.ReverseVowels, "abe", "eba");
            Test.Check(solution.ReverseVowels, "babe", "beba");
            Test.Check(solution.ReverseVowels, "ababe", "ebaba");
            Test.Check(solution.ReverseVowels, "abobe", "eboba");
            Test.Check(solution.ReverseVowels, "abobez", "ebobaz");
            Test.Check(solution.ReverseVowels, "abobezi", "ibeboza");
            
            Test.Check(solution.ReverseVowels, "aA", "Aa");
            Test.Check(solution.ReverseVowels, "Yo! Bottoms up, U.S. Motto, boy!", "Yo! Bottoms Up, u.S. Motto, boy!");
        }

    }
}