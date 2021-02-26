using System.Collections.Generic;

namespace Quiz {
    public class WordDictionary {

        private class TrieNode : Dictionary<char, TrieNode> {

            public bool IsWord;

        }

        private readonly TrieNode m_TrieRoot = new TrieNode();
    
        public void AddWord(string word) {
            TrieNode current = m_TrieRoot;

            foreach (char c in word) {
                if (!current.TryGetValue(c, out TrieNode node)) {
                    node = new TrieNode();
                    current.Add(c, node);
                }

                current = node;
            }

            current.IsWord = true;
        }
    
        public bool Search(string word) {
            TrieNode search(TrieNode node, int ptr) {
                if (node == null) {
                    return null;
                }

                if (ptr >= word.Length) {
                    return node;
                }
                
                while (node != null && ptr < word.Length) {
                    char c = word[ptr];
                    if (c == '.') {
                        foreach ((char key, TrieNode child) in node) {
                            TrieNode found = search(child, ptr + 1);
                            if (found != null) {
                                if (found.IsWord) {
                                    return found;
                                }
                            }
                        }

                        return null;
                    } else {
                        if (!node.TryGetValue(c, out node)) {
                            node = null;
                        }

                        ptr++;
                    }
                } 

                return node;
            }

            TrieNode result = search(m_TrieRoot, 0);
            
            return result != null && result.IsWord;
        }
        
    }
}