using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        private class TrieNode : Dictionary<char, TrieNode> {

            public int WordLength;

        }

        private readonly TrieNode m_TrieRoot = new TrieNode();

        public int[][] IndexPairs(string text, string[] words) {
            foreach (string word in words) {
                var current = m_TrieRoot;

                foreach (char c in word) {
                    if (!current.TryGetValue(c, out var node)) {
                        node = new TrieNode();
                        current.Add(c, node);
                    }

                    current = node;
                }

                current.WordLength = word.Length;
            }

            var pairs = new List<int[]>();

            for (var start = 0; start < text.Length; start++) {
                var node = m_TrieRoot;

                for (int i = start; i < text.Length; i++) {
                    if (node.TryGetValue(text[i], out node)) {
                        if (node.WordLength > 0) {
                            pairs.Add(new[] { start, start + node.WordLength - 1 });
                        }
                    } else {
                        break;
                    }
                }
            }

            return pairs.ToArray();
        }

    }
}
