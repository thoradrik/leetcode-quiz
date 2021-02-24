using System.Collections.Generic;

namespace AlgorithmLib {
    public class Trie {

        private class Node : Dictionary<char, Node> {

            public bool IsWord;

        }

        private readonly Node m_Root = new Node();
        
        public void Insert(string s) {
            Node current = m_Root;

            foreach (char c in s) {
                if (!current.TryGetValue(c, out Node node)) {
                    node = new Node();
                    current.Add(c, node);
                }

                current = node;
            }

            current.IsWord = true;
        }

        private bool TryFindNode(string s, out Node node) {
            node = m_Root;
            
            foreach (char c in s) {
                if (!node.TryGetValue(c, out node)) {
                    return false;
                }
            }
            
            return true;
        }

        public bool Search(string s) {
            return TryFindNode(s, out Node node) && node.IsWord;
        }
    
        public bool StartsWith(string s) {
            return TryFindNode(s, out Node node);
        }
        
    }
}