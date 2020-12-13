using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.Json;
using static System.String;

namespace Quiz {
    public static class Test {

        public static void Check<TArg, TResult>(Func<TArg, TResult> func, TArg arg, TResult expected) {
            Check(() => func(arg), new object[] { arg }, expected);
        }

        public static void Check<TArg1, TArg2, TResult>(Func<TArg1, TArg2, TResult> func, TArg1 arg1, TArg2 arg2, TResult expected) {
            Check(() => func(arg1, arg2), new object[] { arg1, arg2 }, expected);
        }

        public static void Check<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TResult expected) {
            Check(() => func(arg1, arg2, arg3), new object[] { arg1, arg2, arg3 }, expected);
        }

        public static void Check<TArg1, TArg2, TArg3, TArg4, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TResult expected) {
            Check(() => func(arg1, arg2, arg3, arg4), new object[] { arg1, arg2, arg3, arg4 }, expected);
        }

        private static void Check<TResult>(Func<TResult> result, object[] input, TResult expected) {
            Console.WriteLine("TEST {0}", Value(input));

            Console.Write("  ");
            
            Stopwatch stopwatch = Stopwatch.StartNew();
            
            TResult answer = result();
            
            stopwatch.Stop();
            
            if (CheckResult(answer, expected)) {
                using (ConsoleIndicator.Passed()) {
                    Console.Write("PASSED");
                }
            } else {
                using (ConsoleIndicator.Failed()) {
                    Console.Write("!!! FAILED !!!");
                }
            }
            
            Console.WriteLine(" [{0}ms] ANSWER {1} EXPECTED {2}", stopwatch.ElapsedMilliseconds, Value(answer), Value(expected));
        }

        private static bool CheckResult(object answer, object expected) {
            if (answer == null) {
                return expected == null;
            } else if (answer is string s_answer && expected is string s_expected) {
                return s_answer == s_expected;
            } else if (answer is int[] ia_answer && expected is int[] ia_expected) {
                return CheckArrayResult(ia_answer, ia_expected, (x, y) => x == y);
            } else if (answer is uint[] uia_answer && expected is uint[] uia_expected) {
                return CheckArrayResult(uia_answer, uia_expected, (x, y) => x == y);
            } else if (answer is long[] la_answer && expected is long[] la_expected) {
                return CheckArrayResult(la_answer, la_expected, (x, y) => x == y);
            } else if (answer is ulong[] ula_answer && expected is ulong[] ula_expected) {
                return CheckArrayResult(ula_answer, ula_expected, (x, y) => x == y);
            } else if (answer is int i_answer && expected is int i_expected) {
                return i_answer == i_expected;
            } else if (answer is uint ui_answer && expected is uint ui_expected) {
                return ui_answer == ui_expected;
            } else if (answer is long l_answer && expected is long l_expected) {
                return l_answer == l_expected;
            } else if (answer is ulong ul_answer && expected is ulong ul_expected) {
                return ul_answer == ul_expected;
            } else if (answer is bool b_answer && expected is bool b_expected) {
                return b_answer == b_expected;
            } else if (answer is float f_answer && expected is float f_expected) {
                return Math.Abs(f_answer - f_expected) < Single.Epsilon;
            } else if (answer is double d_answer && expected is double d_expected) {
                return Math.Abs(d_answer - d_expected) < Double.Epsilon;
            } else {
                return answer.Equals(expected);
            }
        }

        private static bool CheckArrayResult<T>(T[] answer, T[] expected, Func<T, T, bool> comparison) {
            if (answer.Length != expected.Length) {
                return false;
            } 
            
            for (int i = 0; i < answer.Length; i++) {
                if (!comparison(answer[i], expected[i])) {
                    return false;
                }

            }
           
            return true;
        }

        private static string Value(object value) {
            if (value == null) {
                return "(null)";
            } else if (value is object[] objs) {
                StringBuilder sb = new StringBuilder();
                
                for (int i = 0; i < objs.Length; i++) {
                    if (i > 0) {
                        sb.Append(" ");
                    }
                    
                    sb.Append(Value(objs[i]));
                }

                return sb.ToString();
            } else if (value is int[] ia) {
                return JsonSerializer.Serialize(ia);
            } else if (value is uint[] uia) {
                return JsonSerializer.Serialize(uia);
            } else if (value is long[] la) {
                return JsonSerializer.Serialize(la);
            } else if (value is ulong[] ula) {
                return JsonSerializer.Serialize(ula);
            } else if (value is string s) {
                return Format("\"{0}\"", s);
            } else if (value is IFormattable f) {
                return Format(CultureInfo.InvariantCulture, "{0}", f);
            } else {
                return value.ToString();
            }
        }

    }
}