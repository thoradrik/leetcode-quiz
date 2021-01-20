using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        private class Node {

            public string Name;
            
            public bool Delete;
            
            public Dictionary<string, Node> Children;

        }
        
        public IList<string> RemoveSubfolders(string[] folder) {
            void push(Node node, string path) {
                if (String.IsNullOrEmpty(path)) {
                    node.Delete = true;
                } else {
                    int index = path.IndexOf('/', 1);
                    string name = index > 0 ? path.Substring(0, index) : path;

                    if (node.Children == null) {
                        node.Children = new Dictionary<string, Node>();
                    }

                    if (!node.Children.TryGetValue(name, out Node child_node)) {
                        child_node = new Node {
                            Name = name
                        };
                        node.Children[name] = child_node;
                    }
                    
                    string least_path = index > 0 ? path.Substring(index) : String.Empty;
                    push(child_node, least_path);
                }
            }
            
            Node root = new Node();

            foreach (string f_path in folder) {
                push(root, f_path);
            }

            List<string> list = new List<string>();

            void pop(Node node, string parent_path) {
                string node_path = parent_path + node.Name;
                if (node.Delete) {
                    list.Add(node_path);
                } else {
                    foreach (KeyValuePair<string, Node> pair in node.Children) {
                        pop(pair.Value, node_path);
                    }
                }
            }
            
            pop(root, String.Empty);
            
            return list;
        }
    }
}