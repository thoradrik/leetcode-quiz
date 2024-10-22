using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public bool IsValid(string s) {
            var stack = new Stack<char>();

            foreach (char c in s) {
                if (c == '(') {
                    stack.Push(')');
                } else if (c == '[') {
                    stack.Push(']');
                } else if (c == '{') {
                    stack.Push('}');
                } else if (stack.TryPop(out char p)) {
                    if (c != p) {
                        return false;
                    }
                } else {
                    return false;
                }
            }

            return stack.Count == 0;
        }

    }
}
