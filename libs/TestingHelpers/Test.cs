using System;
using System.Collections.Generic;
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

            
            Stopwatch stopwatch = Stopwatch.StartNew();
            
            TResult answer;
            try {
                answer = result();
            } catch (Exception ex) {
                Console.Write("  ");
                
                using (ConsoleIndicator.Exception()) {
                    Console.Write("!!! EXCEPTION !!!");
                }
                
                Console.WriteLine(" {0}", ex.Message);
                
                return;
            }

            stopwatch.Stop();
            
            if (CheckResult(answer, expected)) {
                Console.Write("  ");
                
                using (ConsoleIndicator.Passed()) {
                    Console.Write("PASSED");
                }
            } else {
                Console.Write("  ");

                using (ConsoleIndicator.Failed()) {
                    Console.Write("!!! FAILED !!!");
                }
            }
            
            Console.WriteLine(" [{0}ms] ANSWER {1} EXPECTED {2}", stopwatch.ElapsedMilliseconds, Value(answer), Value(expected));
        }

        private static bool CheckResult(object answer, object expected) {
            switch (answer) {
                case null: return expected == null;
                case string s_answer when expected is string s_expected: return s_answer == s_expected;
                case int[] ia_answer when expected is int[] ia_expected: return CheckArrayResult(ia_answer, ia_expected, (x, y) => x == y);
                case uint[] uia_answer when expected is uint[] uia_expected: return CheckArrayResult(uia_answer, uia_expected, (x, y) => x == y);
                case long[] la_answer when expected is long[] la_expected: return CheckArrayResult(la_answer, la_expected, (x, y) => x == y);
                case ulong[] ula_answer when expected is ulong[] ula_expected: return CheckArrayResult(ula_answer, ula_expected, (x, y) => x == y);
                case IList<int> il_answer when expected is IList<int> il_expected: return CheckListResult(il_answer, il_expected, (x, y) => x == y);
                case IList<uint> uil_answer when expected is IList<uint> uil_expected: return CheckListResult(uil_answer, uil_expected, (x, y) => x == y);
                case IList<long> ll_answer when expected is IList<long> ll_expected: return CheckListResult(ll_answer, ll_expected, (x, y) => x == y);
                case IList<ulong> ull_answer when expected is IList<ulong> ull_expected: return CheckListResult(ull_answer, ull_expected, (x, y) => x == y);
                case int i_answer when expected is int i_expected: return i_answer == i_expected;
                case uint ui_answer when expected is uint ui_expected: return ui_answer == ui_expected;
                case long l_answer when expected is long l_expected: return l_answer == l_expected;
                case ulong ul_answer when expected is ulong ul_expected: return ul_answer == ul_expected;
                case bool b_answer when expected is bool b_expected: return b_answer == b_expected;
                case float f_answer when expected is float f_expected: return Math.Abs(f_answer - f_expected) < Single.Epsilon;
                case double d_answer when expected is double d_expected: return Math.Abs(d_answer - d_expected) < Double.Epsilon;
                default: return answer.Equals(expected);
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

        private static bool CheckListResult<T>(IList<T> answer, IList<T> expected, Func<T, T, bool> comparison) {
            if (answer.Count != expected.Count) {
                return false;
            } 
            
            for (int i = 0; i < answer.Count; i++) {
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
            } else if (value is IList<int> il) {
                return JsonSerializer.Serialize(il);
            } else if (value is IList<uint> uil) {
                return JsonSerializer.Serialize(uil);
            } else if (value is IList<long> ll) {
                return JsonSerializer.Serialize(ll);
            } else if (value is IList<ulong> ull) {
                return JsonSerializer.Serialize(ull);
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