namespace Quiz {
    public class Trie {

        private class Node {

            public bool IsWord;
            
            public readonly Node[] Children = new Node[26];

        }

        private Node m_Root;
        
        public void Insert(string word) {
            ref Node current = ref m_Root;

            for (int ptr = 0; ptr < word.Length; ptr++) {
                if (current == null) {
                    current = new Node();
                }

                current = ref current.Children[word[ptr] - 'a'];
            }
            
            if (current == null) {
                current = new Node();
            }

            current.IsWord = true;
        }

        private bool TryFindNode(string word, out Node node) {
            node = m_Root;

            int ptr = 0;

            while (node != null && ptr < word.Length) {
                if (node.Children == null) {
                    node = null;
                    return false;
                }

                node = node.Children[word[ptr] - 'a'];
                
                ptr++;
            }

            return node != null;
        }

        public bool Search(string word) {
            return TryFindNode(word, out Node node) && node.IsWord;
        }
    
        public bool StartsWith(string prefix) {
            return TryFindNode(prefix, out Node node);
        }
    }
}