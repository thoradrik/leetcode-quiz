using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public bool ValidateStackSequences(int[] pushed, int[] popped) {
            Stack<int> stack = new Stack<int>();

            int i = 0;
            
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