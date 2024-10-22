using System.Collections.Generic;

namespace Quiz {
    public class WordFilter {

        private class TrieNode : Dictionary<char, TrieNode> {

            public int Index;

        }

        private readonly TrieNode m_TrieNode = new TrieNode();

        public WordFilter(string[] words) {
            for (var index = 0; index < words.Length; index++) {
                string word = words[index];

                for (var i = 0; i < word.Length; i++) {
                    string form = word.Substring(i) + "\0" + word;

                    var current = m_TrieNode;

                    foreach (char c in form) {
                        if (!current.TryGetValue(c, out var node)) {
                            node = new TrieNode();
                            current.Add(c, node);
                        }

                        current = node;
                        current.Index = index;
                    }
                }
            }
        }

        public int F(string prefix, string suffix) {
            var current = m_TrieNode;

            foreach (char c in suffix + "\0" + prefix) {
                if (!current.TryGetValue(c, out current)) {
                    return -1;
                }
            }

            return current.Index;
        }

    }
}
