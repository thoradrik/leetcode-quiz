namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Trie trie = new Trie();
            
            trie.Insert("apple");
            
            Test.Check(trie.Search, "a", false);
            Test.Check(trie.Search, "ap", false);
            Test.Check(trie.Search, "app", false);
            Test.Check(trie.Search, "appl", false);
            Test.Check(trie.Search, "apple", true);
            Test.Check(trie.Search, "apply", false);
            Test.Check(trie.Search, "apples", false);

            Test.Check(trie.StartsWith, "a", true);
            Test.Check(trie.StartsWith, "ap", true);
            Test.Check(trie.StartsWith, "app", true);
            Test.Check(trie.StartsWith, "appl", true);
            Test.Check(trie.StartsWith, "apple", true);
            Test.Check(trie.StartsWith, "apply", false);
            Test.Check(trie.StartsWith, "apples", false);
            
            Test.Check(trie.Search, "app", false);
            Test.Check(trie.StartsWith, "app", true);

            trie.Insert("app");
            
            Test.Check(trie.Search, "app", true);
        }

    }
}