using System;

namespace Quiz {
    public class Solution {

        public int CalPoints(string[] ops) {
            var stack = new int[ops.Length];
            var ptr = 0;

            foreach (string op in ops) {
                if (op == "C") {
                    ptr--;
                } else {
                    if (op == "+") {
                        stack[ptr] = stack[ptr - 1] + stack[ptr - 2];
                    } else if (op == "D") {
                        stack[ptr] = stack[ptr - 1] * 2;
                    } else {
                        stack[ptr] = Int32.Parse(op);
                    }
                    ptr++;
                }
            }

            var sum = 0;

            for (var i = 0; i < ptr; i++) {
                sum += stack[i];
            }

            return sum;
        }

    }
}
