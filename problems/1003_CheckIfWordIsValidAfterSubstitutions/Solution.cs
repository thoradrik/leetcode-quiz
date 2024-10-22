using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public bool IsValid(string s) {
            var stack = new Stack<char>();

            foreach (char c in s) {
                if (c != 'c') {
                    stack.Push(c);
                } else if (!stack.TryPop(out char b) || b != 'b' || !stack.TryPop(out char a) || a != 'a') {
                    return false;
                }
            }

            return stack.Count == 0;
        }

    }
}
