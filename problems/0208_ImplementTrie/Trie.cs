using System.Collections.Generic;

namespace Quiz {
    public class Trie {

        private class Node : Dictionary<char, Node> {

            public bool IsWord;

        }

        private readonly Node m_Root = new Node();
        
        public void Insert(string word) {
            Node current = m_Root;

            foreach (char c in word) {
                if (!current.TryGetValue(c, out Node node)) {
                    node = new Node();
                    current.Add(c, node);
                }

                current = node;
            }

            current.IsWord = true;
        }

        private bool TryFindNode(string prefix, out Node node) {
            node = m_Root;
            
            foreach (char c in prefix) {
                if (!node.TryGetValue(c, out node)) {
                    return false;
                }
            }
            
            return true;
        }

        public bool Search(string word) {
            return TryFindNode(word, out Node node) && node.IsWord;
        }
    
        public bool StartsWith(string prefix) {
            return TryFindNode(prefix, out Node node);
        }
    }
}