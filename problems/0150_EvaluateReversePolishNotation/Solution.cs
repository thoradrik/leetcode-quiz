using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public int EvalRPN(string[] tokens) {
            var stack = new Stack<int>();

            for (var i = 0; i < tokens.Length; i++) {
                string token = tokens[i];
                if (token == "+" || token == "-" || token == "*" || token == "/") {
                    if (stack.TryPop(out int b) && stack.TryPop(out int a)) {
                        switch (token) {
                            case "+": stack.Push(a + b); break;
                            case "-": stack.Push(a - b); break;
                            case "*": stack.Push(a * b); break;
                            case "/": stack.Push(a / b); break;
                        }
                    } else {
                        throw new Exception("Got '" + token + "' token. But stack does not contains at least 2 numbers");
                    }
                } else if (Int32.TryParse(token, out int number)) {
                    stack.Push(number);
                } else {
                    throw new Exception("Got invalid token '" + token + "'");
                }
            }

            return stack.Pop();
        }

    }
}
