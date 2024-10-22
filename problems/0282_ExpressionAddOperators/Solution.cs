using System;
using System.Collections.Generic;
using System.Text;
using AlgorithmLib;

namespace Quiz {
    public class Solution {

        public IList<string> AddOperators(string num, int target) {
            if (num.Length == 0) {
                return Array.Empty<string>();
            } else if (num.Length == 1) {
                int n = Int32.Parse(num);
                if (n == target) {
                    return new[] { num };
                } else {
                    return Array.Empty<string>();
                }
            }

            Func<int, int, long?>[] op_func = {
                (a, b) => a + b,
                (a, b) => a - b,
                (a, b) => a * b,
                (a, b) =>  a > 0 ? (int?)a * 10 + b : null
            };

            string[] op_char = { "+", "-", "*", "" };

            var nums = new int[num.Length];
            for (var i = 0; i < num.Length; i++) {
                nums[i] = Int32.Parse(num.Substring(i, 1));
            }

            var list = new List<string>();

            CombinationGenerator.Generate(nums.Length - 1, new[] { 10, 11, 22, 33 }, ops => {
                var op_stack = new Stack<int>();
                var n_output = new Queue<int>();

                for (var i = 0; i < ops.Length; i++) {
                    n_output.Enqueue(nums[i]);

                    while (op_stack.TryPeek(out int op) && op / 10 >= ops[i] / 10){
                        n_output.Enqueue(op_stack.Pop());
                    }

                    op_stack.Push(ops[i]);
                }

                n_output.Enqueue(nums[^1]);

                while (op_stack.Count != 0) {
                    n_output.Enqueue(op_stack.Pop());
                }

                var stack = new Stack<int>();

                while (n_output.TryDequeue(out int n)) {
                    if (n < 10) {
                        stack.Push(n);
                    } else {
                        int b = stack.Pop();
                        int a = stack.Pop();
                        long? result = op_func[n % 10](a, b);
                        if (result == null) {
                            return;
                        } else if (result <= Int32.MinValue || result > Int32.MaxValue) {
                            return;
                        } else {
                            stack.Push((int)result.Value);
                        }
                    }
                }

                if (stack.Pop() == target) {
                    var sb = new StringBuilder();

                    for (var i = 0; i < ops.Length; i++) {
                        sb.Append(nums[i]);
                        string value = op_char[ops[i] % 10];
                        sb.Append(value);
                    }

                    sb.Append(nums[^1]);

                    list.Add(sb.ToString());
                }
            });

            return list.ToArray();
        }


    }
}
