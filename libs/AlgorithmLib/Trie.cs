namespace AlgorithmLib;

public class Trie {

    private class TrieNode : Dictionary<char, TrieNode> {

        public bool IsWord;

    }

    private readonly TrieNode m_TrieRoot = new TrieNode();
        
    public void Insert(string s) {
        TrieNode current = m_TrieRoot;

        foreach (char c in s) {
            if (!current.TryGetValue(c, out TrieNode node)) {
                node = new TrieNode();
                current.Add(c, node);
            }

            current = node;
        }

        current.IsWord = true;
    }

    private bool TryFindNode(string s, out TrieNode node) {
        node = m_TrieRoot;
            
        foreach (char c in s) {
            if (!node.TryGetValue(c, out node)) {
                return false;
            }
        }
            
        return true;
    }

    public bool Search(string s) {
        return TryFindNode(s, out TrieNode node) && node.IsWord;
    }
    
    public bool StartsWith(string s) {
        return TryFindNode(s, out TrieNode node);
    }
        
}