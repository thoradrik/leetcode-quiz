using System;
using System.Diagnostics;

namespace Quiz {
    public class Solution {
        public bool JudgePoint24(int[] nums) {
            for (int a_i = 0; a_i < nums.Length; a_i++) {
                for (int b_i = 0; b_i < nums.Length; b_i++) {
                    if (b_i == a_i) continue;
                    for (int c_i = 0; c_i < nums.Length; c_i++) {
                        if (c_i == a_i || c_i == b_i) continue;
                        for (int d_i = 0; d_i < nums.Length; d_i++) {
                            if (d_i == a_i || d_i == b_i || d_i == c_i) continue;
                            if (CheckOps(nums[a_i], nums[b_i], nums[c_i], nums[d_i])) {
                                return true;
                            }
                        }                   
                    }
                }
            }
            return false;
        }

        private bool CheckOps(double a, double b, double c, double d) {
            for (int br_i = 0; br_i < BRACKETS.Length; br_i++) {
                Func<double, double, double, double, Func<double, double, double>, Func<double, double, double>, Func<double, double, double>, double> br = BRACKETS[br_i];
                for (int op1_i = 0; op1_i < OPS.Length; op1_i++) {
                    Func<double, double, double> op1 = OPS[op1_i];
                    for (int op2_i = 0; op2_i < OPS.Length; op2_i++) {
                        Func<double, double, double> op2 = OPS[op2_i];
                        for (int op3_i = 0; op3_i < OPS.Length; op3_i++) {
                            Func<double, double, double> op3 = OPS[op3_i];
                            double result = br(a, b, c, d, op1, op2, op3);
                            
                            if (Math.Abs(result - 24.0) < 0.0001) {
                                Debug.WriteLine(BRACKET_NAMES[br_i], a, b, c, d, OP_NAMES[op1_i], OP_NAMES[op2_i], OP_NAMES[op3_i], result);
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private static readonly Func<double, double, double> OP_ADD = (x, y) => x + y;
        private static readonly Func<double, double, double> OP_DEC = (x, y) => x - y;
        private static readonly Func<double, double, double> OP_DIV = (x, y) => x / y;
        private static readonly Func<double, double, double> OP_MUL = (x, y) => x * y;
        private static readonly Func<double, double, double>[] OPS = { OP_ADD, OP_DEC, OP_DIV, OP_MUL };
        private static readonly string[] OP_NAMES = { "+", "-", "/", "*" };
        
        private static Func<double, double, double, double, Func<double, double, double>, Func<double, double, double>, Func<double, double, double>, double>[] BRACKETS = {
            (a, b, c, d, op1, op2, op3) => op3(op2(op1(a, b), c), d),
            (a, b, c, d, op1, op2, op3) => op3(op1(a, op2(b, c)), d),
            (a, b, c, d, op1, op2, op3) => op2(op1(a, b), op3(c, d)),
            (a, b, c, d, op1, op2, op3) => op1(a, op3(op2(b, c), d)),
            (a, b, c, d, op1, op2, op3) => op1(a, op2(b, op3(c, d))),
        };
        private static readonly string[] BRACKET_NAMES = {
            "(({0} {4} {1}) {5} {2}) {6} {3} = {7:0.###}", 
            "({0} {4} ({1} {5} {2}) {6} {3} = {7:0.###}", 
            "({0} {4} {1}) {5} ({2} {6} {3}) = {7:0.###}", 
            "{0} {4} (({1} {5} {2}) {6} {3}) = {7:0.###}", 
            "{0} {4} ({1} {5} ({2} {6} {3})) = {7:0.###}" 
        };
        
    }
}