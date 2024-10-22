using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public bool ValidateStackSequences(int[] pushed, int[] popped) {
            var stack = new Stack<int>();

            var i = 0;

            foreach (int push in pushed) {
                stack.Push(push);

                while (stack.TryPeek(out int peek) && i < popped.Length && peek == popped[i]) {
                    stack.Pop();
                    i++;
                }
            }

            return i == popped.Length;
        }

    }
}
