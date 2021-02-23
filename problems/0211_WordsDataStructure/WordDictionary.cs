namespace Quiz {
    public class WordDictionary {

        private class Node {

            public bool IsWord;
            
            public readonly Node[] Nodes = new Node[26];

        }

        private Node m_Root;
    
        public void AddWord(string word) {
            ref Node current = ref m_Root;

            for (int ptr = 0; ptr < word.Length; ptr++) {
                if (current == null) {
                    current = new Node();
                }

                current = ref current.Nodes[word[ptr] - 'a'];
            }
            
            if (current == null) {
                current = new Node();
            }

            current.IsWord = true;
        }
    
        public bool Search(string word) {
            Node search(Node node, int ptr) {
                if (node == null) {
                    return null;
                }

                if (ptr >= word.Length) {
                    return node;
                }

                if (node.Nodes == null) {
                    return null;
                }

                while (node != null && ptr < word.Length) {
                    if (node.Nodes == null) {
                        return null;
                    }
                    
                    int c = word[ptr];
                    if (c == '.') {
                        for (int index = 0; index < node.Nodes.Length; index++) {
                            Node found = search(node.Nodes[index], ptr + 1);
                            if (found != null) {
                                if (found.IsWord) {
                                    return found;
                                }
                            }
                        }

                        return null;
                    } else {
                        node = node.Nodes[c - 'a'];
                        ptr++;
                    }
                } 

                return node;
            }

            Node result = search(m_Root, 0);
            
            return result != null && result.IsWord;
        }
        
    }
}