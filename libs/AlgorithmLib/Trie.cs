namespace AlgorithmLib {
    public class Trie {

        private class Node {

            public bool IsString;
            
            public readonly Node[] Nodes = new Node[26];

        }

        private Node m_Root;
        
        public void Insert(string s) {
            ref Node current = ref m_Root;

            for (int ptr = 0; ptr < s.Length; ptr++) {
                if (current == null) {
                    current = new Node();
                }

                current = ref current.Nodes[s[ptr] - 'a'];
            }
            
            if (current == null) {
                current = new Node();
            }

            current.IsString = true;
        }

        private bool TryFindNode(string word, out Node node) {
            node = m_Root;

            int ptr = 0;

            while (node != null && ptr < word.Length) {
                if (node.Nodes == null) {
                    node = null;
                    return false;
                }

                node = node.Nodes[word[ptr] - 'a'];
                
                ptr++;
            }

            return node != null;
        }

        public bool HasString(string s) {
            return TryFindNode(s, out Node node) && node.IsString;
        }
    
        public bool HasPrefix(string s) {
            return TryFindNode(s, out Node node);
        }
    }
}