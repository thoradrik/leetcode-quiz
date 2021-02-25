using System.Collections.Generic;

namespace Quiz {
    public class WordFilter {

        private class Node : Dictionary<char, Node> {

            public int Index;

        }

        private readonly Node m_Root = new Node();
        
        public WordFilter(string[] words) {
            for (int index = 0; index < words.Length; index++) {
                string word = words[index];

                for (int i = 0; i < word.Length; i++) {
                    string form = word.Substring(i) + "\0" + word;
                    
                    Node current = m_Root;

                    foreach (char c in form) {
                        if (!current.TryGetValue(c, out Node node)) {
                            node = new Node();
                            current.Add(c, node);
                        }

                        current = node;
                        current.Index = index;
                    }
                }
            }
        }
    
        public int F(string prefix, string suffix) {
            Node current = m_Root;

            foreach (char c in suffix + "\0" + prefix) {
                if (!current.TryGetValue(c, out current)) {
                    return -1;
                }
            }

            return current.Index;
        }
        
    }
}