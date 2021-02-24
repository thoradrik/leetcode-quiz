using System.Collections.Generic;

namespace Quiz {
    public class MagicDictionary {

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
    
        public void BuildDict(string[] dictionary) {
            foreach (string s in dictionary) {
                Insert(s);
            }
        }
        
        public bool Search(string searchWord) {
            Node search(Node node, int ptr, int replaces) {
                if (ptr < searchWord.Length) {
                    if (replaces > 0) {
                        foreach ((char key, Node child) in node) {
                            Node result = key == searchWord[ptr] ? search(child, ptr + 1, replaces) : search(child, ptr + 1, replaces - 1);

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

            return search(m_Root, 0, 1) != null;
        }
        
    }
}