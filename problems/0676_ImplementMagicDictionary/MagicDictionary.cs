using System.Collections.Generic;

namespace Quiz {
    public class MagicDictionary {

        private class TrieNode : Dictionary<char, TrieNode> {

            public bool IsWord;

        }

        private readonly TrieNode m_TrieRoot = new TrieNode();

        public void Insert(string s) {
            var current = m_TrieRoot;

            foreach (char c in s) {
                if (!current.TryGetValue(c, out var node)) {
                    node = new TrieNode();
                    current.Add(c, node);
                }

                current = node;
            }

            current.IsWord = true;
        }

        public void BuildDict(string[] dictionary) {
            foreach (string s in dictionary) {
                Insert(s);
            }
        }

        public bool Search(string searchWord) {
            TrieNode search(TrieNode node, int ptr, int replaces) {
                if (ptr < searchWord.Length) {
                    if (replaces > 0) {
                        foreach ((char key, var child) in node) {
                            var result = key == searchWord[ptr] ? search(child, ptr + 1, replaces) : search(child, ptr + 1, replaces - 1);

                            if (result != null) {
                                if (result.IsWord) {
                                    return result;
                                }
                            }
                        }
                    }

                    for (int index = ptr; index < searchWord.Length; index++) {
                        char c = searchWord[index];

                        if (!node.TryGetValue(c, out node)) {
                            return null;
                        }
                    }
                }

                if (replaces > 0) {
                    return null;
                }

                return node.IsWord ? node : null;
            }

            return search(m_TrieRoot, 0, 1) != null;
        }

    }
}
