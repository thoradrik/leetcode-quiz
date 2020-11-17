using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz {
    public class Solution {
        
        public IList<IList<string>> FindLadders(string begin_word, string end_word, IList<string> words_list) {
            Dictionary<Key, Node> node_map = new Dictionary<Key, Node>();

            foreach (string word in words_list) {
                node_map[new Key(word)] = new Node { Word = word };
            }
            
            Node begin_node = new Node { Word = begin_word, Begin = true, PathIndex = 1 };
            node_map[new Key(begin_word)] = begin_node;

            Node end_node = new Node { Word = end_word, End = true };
            node_map[new Key(end_word)] = end_node;

            Key[] words = node_map.Keys.ToArray();
            BuildRelations(words, node_map);

            Node[] nodes = node_map.Values.ToArray();
            BuildPathNR(nodes);

            HashSet<string> hs = new HashSet<string>(words_list);
            
            List<IList<string>> result = new List<IList<string>>();
            
            foreach (List<string> path in CollectPaths(end_node)) {
                foreach (string item in path) {
                    if (!hs.Contains(item) && item != begin_word) {
                        goto skip_path;
                    }
                }

                result.Add(path);
                
            skip_path:
                ;
            }
            
            return result;
        }
        
        public class Node {

            public string Word;

            public bool Begin;

            public bool End;

            public Node[] Related;

            public int PathIndex;

            public override string ToString() {
                StringBuilder sb = new StringBuilder();

                if (Related != null) {
                    for (int index = 0; index < Related.Length; index++) {
                        if (index > 0) {
                            sb.Append(",");
                        }

                        Node related_node = Related[index];

                        sb.Append(related_node.Word);
                    }
                }

                return (Begin ? "^ " : "") + (End ? "$ " : "") + Word + "("+ PathIndex +") -> [" + sb + "]";
            }

        }

        private class Key : IEquatable<Key> {

            public Key(string s) {
                m_Chars = s.ToCharArray();
            }

            private Key(char[] s) {
                m_Chars = s;
            }

            private char[] m_Chars;

            public char this[int index] {
                get { return m_Chars[index]; }
                set { m_Chars[index] = value; }
            }

            public bool Equals(Key other) {
                for (int i = 0; i < m_Chars.Length; i++) {
                    if (m_Chars[i] != other.m_Chars[i]) {
                        return false;
                    }
                }
                return true;
            }

            public override int GetHashCode() {
                int h = 0;
                for (int i = 0; i < m_Chars.Length; i++) {
                    h ^= m_Chars[i];
                    h = h * 10;
                }
                return h;
            }

            public int Length {
                get { return m_Chars.Length; }
            }

            public Key Clone() {
                char[] clone = new char[m_Chars.Length];
                Array.Copy(m_Chars, clone, m_Chars.Length);
                return new Key(clone);
            }

        }
        
        private void BuildRelations(Key[] words, Dictionary<Key, Node> map) {
            List<Node>[] relations = new List<Node>[words.Length];

            for (int w = 0; w < words.Length; w++) {
                relations[w] = new List<Node>();

                Key mut = words[w].Clone();

                for (int i = 0; i < mut.Length; i++) {
                    char o = mut[i];
                    
                    for (char c = 'a'; c <= 'z'; c++) {
                        if (c != o) {
                            mut[i] = c;

                            Node related;
                            if (map.TryGetValue(mut, out related)) {
                                relations[w].Add(related);
                            }
                        }
                    }    
                    
                    mut[i] = o;
                }
            }

            for (int w = 0; w < words.Length; w++) {
                map[words[w]].Related = relations[w].ToArray();
            }
        }
        
        private void BuildPathNR(Node[] nodes) {
            int index = 1;
            
            bool was_ops;
            do {
                was_ops = false;
                
                for (int i = 0; i < nodes.Length; i++) {
                    Node node = nodes[i];

                    if (node.PathIndex == index) {
                        for (int r = 0; r < node.Related.Length; r++) {
                            Node related_node = node.Related[r];

                            if (related_node.PathIndex <= 0 || related_node.PathIndex > node.PathIndex + 1) {
                                related_node.PathIndex = node.PathIndex + 1;
                                was_ops = true;
                            }
                        }
                    }
                }

                index++;
            } while (was_ops);
        }
        
        private IEnumerable<List<string>> CollectPaths(Node node) {
            if (node.Begin) {
                yield return new List<string> {node.Word};
            } else {
                for (int index = 0; index < node.Related.Length; index++) {
                    Node related_node = node.Related[index];
                    
                    if (related_node.PathIndex == node.PathIndex - 1) {
                        foreach (List<string> path in CollectPaths(related_node)) {
                            path.Add(node.Word);
                            yield return path;
                        }
                    }
                }
            }
        }
        
    }
}