using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using AlgorithmLib;
using static System.String;

namespace Quiz;

public static class Test {

    public static void Check<TArg, TResult>(Func<TArg, TResult> func, TArg arg, TResult expected) {
        Check(() => func(arg), [arg], expected);
    }

    public static void Check<TArg1, TArg2, TResult>(Func<TArg1, TArg2, TResult> func, TArg1 arg1, TArg2 arg2, TResult expected) {
        Check(() => func(arg1, arg2), [arg1, arg2], expected);
    }

    public static void Check<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TResult expected) {
        Check(() => func(arg1, arg2, arg3), [arg1, arg2, arg3], expected);
    }

    public static void Check<TArg1, TArg2, TArg3, TArg4, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TResult expected) {
        Check(() => func(arg1, arg2, arg3, arg4), [arg1, arg2, arg3, arg4], expected);
    }

    private static void Check<TResult>(Func<TResult> result, object[] input, TResult expected) {
        Console.WriteLine("TEST {0}", Value(input));

        var stopwatch = Stopwatch.StartNew();

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

    public static void Print<TArg, TResult>(Func<TArg, TResult> func, TArg arg) {
        Print(() => func(arg), [arg]);
    }

    public static void Print<TArg1, TArg2, TResult>(Func<TArg1, TArg2, TResult> func, TArg1 arg1, TArg2 arg2) {
        Print(() => func(arg1, arg2), [arg1, arg2]);
    }

    public static void Print<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3) {
        Print(() => func(arg1, arg2, arg3), [arg1, arg2, arg3]);
    }

    public static void Print<TArg1, TArg2, TArg3, TArg4, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4) {
        Print(() => func(arg1, arg2, arg3, arg4), [arg1, arg2, arg3, arg4]);
    }

    private static void Print<TResult>(Func<TResult> result, object[] input) {
        Console.WriteLine("TEST {0}", Value(input));

        var stopwatch = Stopwatch.StartNew();

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

        Console.Write("  ");

        using (ConsoleIndicator.Result()) {
            Console.Write("RETURNED");
        }

        Console.WriteLine(" [{0}ms] ANSWER {1}", stopwatch.ElapsedMilliseconds, Value(answer));
    }

    private static bool CheckResult(object answer, object expected) {
        switch (answer) {
            case null: return expected == null;

            case int i_answer when expected is int i_expected: return i_answer == i_expected;
            case uint ui_answer when expected is uint ui_expected: return ui_answer == ui_expected;
            case long l_answer when expected is long l_expected: return l_answer == l_expected;
            case ulong ul_answer when expected is ulong ul_expected: return ul_answer == ul_expected;
            case float f_answer when expected is float f_expected: return Math.Abs(f_answer - f_expected) < Single.Epsilon;
            case double d_answer when expected is double d_expected: return Math.Abs(d_answer - d_expected) < Double.Epsilon;
            case bool b_answer when expected is bool b_expected: return b_answer == b_expected;
            case char c_answer when expected is char c_expected: return c_answer == c_expected;
            case string s_answer when expected is string s_expected: return s_answer == s_expected;

            case int[] ia_answer when expected is int[] ia_expected: return CheckArrayResult(ia_answer, ia_expected, (x, y) => x == y);
            case uint[] uia_answer when expected is uint[] uia_expected: return CheckArrayResult(uia_answer, uia_expected, (x, y) => x == y);
            case long[] la_answer when expected is long[] la_expected: return CheckArrayResult(la_answer, la_expected, (x, y) => x == y);
            case ulong[] ula_answer when expected is ulong[] ula_expected: return CheckArrayResult(ula_answer, ula_expected, (x, y) => x == y);
            case float[] fa_answer when expected is float[] fa_expected: return CheckArrayResult(fa_answer, fa_expected, (x, y) => Math.Abs(x - y) < Single.Epsilon);
            case double[] da_answer when expected is double[] da_expected: return CheckArrayResult(da_answer, da_expected, (x, y) => Math.Abs(x - y) < Double.Epsilon);
            case bool[] ba_answer when expected is bool[] ba_expected: return CheckArrayResult(ba_answer, ba_expected, (x, y) => x == y);
            case char[] ca_answer when expected is char[] ca_expected: return CheckArrayResult(ca_answer, ca_expected, (x, y) => x == y);
            case string[] sa_answer when expected is string[] sa_expected: return CheckArrayResult(sa_answer, sa_expected, (x, y) => x == y);

            case int[][] i2a_answer when expected is int[][] i2a_expected: return Check2ArrayResult(i2a_answer, i2a_expected, (x, y) => x == y);
            case uint[][] ui2a_answer when expected is uint[][] ui2a_expected: return Check2ArrayResult(ui2a_answer, ui2a_expected, (x, y) => x == y);
            case long[][] l2a_answer when expected is long[][] l2a_expected: return Check2ArrayResult(l2a_answer, l2a_expected, (x, y) => x == y);
            case ulong[][] ul2a_answer when expected is ulong[][] ul2a_expected: return Check2ArrayResult(ul2a_answer, ul2a_expected, (x, y) => x == y);
            case float[][] f2a_answer when expected is float[][] f2a_expected: return Check2ArrayResult(f2a_answer, f2a_expected, (x, y) => Math.Abs(x - y) < Single.Epsilon);
            case double[][] d2a_answer when expected is double[][] d2a_expected: return Check2ArrayResult(d2a_answer, d2a_expected, (x, y) => Math.Abs(x - y) < Double.Epsilon);
            case bool[][] b2a_answer when expected is bool[][] b2a_expected: return Check2ArrayResult(b2a_answer, b2a_expected, (x, y) => x == y);
            case char[][] c2a_answer when expected is char[][] c2a_expected: return Check2ArrayResult(c2a_answer, c2a_expected, (x, y) => x == y);
            case string[][] s2a_answer when expected is string[][] s2a_expected: return Check2ArrayResult(s2a_answer, s2a_expected, (x, y) => x == y);

            case IList<int> il_answer when expected is IList<int> il_expected: return CheckListResult(il_answer, il_expected, (x, y) => x == y);
            case IList<uint> uil_answer when expected is IList<uint> uil_expected: return CheckListResult(uil_answer, uil_expected, (x, y) => x == y);
            case IList<long> ll_answer when expected is IList<long> ll_expected: return CheckListResult(ll_answer, ll_expected, (x, y) => x == y);
            case IList<ulong> ull_answer when expected is IList<ulong> ull_expected: return CheckListResult(ull_answer, ull_expected, (x, y) => x == y);
            case IList<float> fl_answer when expected is IList<float> fl_expected: return CheckListResult(fl_answer, fl_expected, (x, y) =>  Math.Abs(x - y) < Single.Epsilon);
            case IList<double> dl_answer when expected is IList<double> dl_expected: return CheckListResult(dl_answer, dl_expected, (x, y) => Math.Abs(x - y) < Double.Epsilon);
            case IList<bool> bl_answer when expected is IList<bool> bl_expected: return CheckListResult(bl_answer, bl_expected, (x, y) => x == y);
            case IList<char> cl_answer when expected is IList<char> cl_expected: return CheckListResult(cl_answer, cl_expected, (x, y) => x == y);
            case IList<string> sl_answer when expected is IList<string> sl_expected: return CheckListResult(sl_answer, sl_expected, (x, y) => x == y);

            case HashSet<int> ih_answer when expected is HashSet<int> ih_expected: return CheckHashSet(ih_answer, ih_expected);
            case HashSet<uint> uih_answer when expected is HashSet<uint> uih_expected: return CheckHashSet(uih_answer, uih_expected);
            case HashSet<long> lh_answer when expected is HashSet<long> lh_expected: return CheckHashSet(lh_answer, lh_expected);
            case HashSet<ulong> ulh_answer when expected is HashSet<ulong> ulh_expected: return CheckHashSet(ulh_answer, ulh_expected);
            case HashSet<char> ch_answer when expected is HashSet<char> ch_expected: return CheckHashSet(ch_answer, ch_expected);
            case HashSet<string> sh_answer when expected is HashSet<string> sh_expected: return CheckHashSet(sh_answer, sh_expected);

            default: return answer.Equals(expected);
        }
    }

    private static bool CheckArrayResult<T>(T[] answer, T[] expected, Func<T, T, bool> comparison) {
        if (answer.Length != expected.Length) {
            return false;
        }

        for (var i = 0; i < answer.Length; i++) {
            if (!comparison(answer[i], expected[i])) {
                return false;
            }

        }

        return true;
    }

    private static bool Check2ArrayResult<T>(T[][] answer, T[][] expected, Func<T, T, bool> comparison) {
        if (answer.Length != expected.Length) {
            return false;
        }

        for (var i = 0; i < answer.Length; i++) {
            if (!CheckArrayResult(answer[i], expected[i], comparison)) {
                return false;
            }
        }

        return true;
    }

    private static bool CheckListResult<T>(IList<T> answer, IList<T> expected, Func<T, T, bool> comparison) {
        if (answer.Count != expected.Count) {
            return false;
        }

        for (var i = 0; i < answer.Count; i++) {
            if (!comparison(answer[i], expected[i])) {
                return false;
            }

        }

        return true;
    }

    private static bool CheckHashSet<T>(HashSet<T> answer, HashSet<T> expected) {
        if (answer.Count != expected.Count) {
            return false;
        }

        HashSet<T> hs1 = [];

        hs1.UnionWith(answer);
        hs1.ExceptWith(expected);

        HashSet<T> hs2 = [];

        hs2.UnionWith(expected);
        hs2.ExceptWith(answer);

        return hs1.Count == 0 && hs2.Count == 0;
    }

    private static readonly JsonSerializerOptions OPTIONS = new JsonSerializerOptions {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    private static string Value(object value) {
        if (value == null) {
            return "(null)";
        } else if (value is int[] ia) {
            return Format("{0} (Length={1})", JsonSerializer.Serialize(ia, OPTIONS), ia.Length);
        } else if (value is uint[] uia) {
            return Format("{0} (Length={1})", JsonSerializer.Serialize(uia, OPTIONS), uia.Length);
        } else if (value is long[] la) {
            return Format("{0} (Length={1})", JsonSerializer.Serialize(la, OPTIONS), la.Length);
        } else if (value is ulong[] ula) {
            return Format("{0} (Length={1})", JsonSerializer.Serialize(ula, OPTIONS), ula.Length);
        } else if (value is bool[] ba) {
            return Format("{0} (Length={1})", JsonSerializer.Serialize(ba, OPTIONS), ba.Length);
        } else if (value is char[] ca) {
            return Format("{0} (Length={1})", JsonSerializer.Serialize(ca, OPTIONS), ca.Length);
        } else if (value is string[] sa) {
            return Format("{0} (Length={1})", JsonSerializer.Serialize(sa, OPTIONS), sa.Length);
        } else if (value is int[][] i2a) {
            return Format2Array(i2a);
        } else if (value is char[][] c2a) {
            return Format2Array(c2a);
        } else if (value is object[] objs) {
            var sb = new StringBuilder();

            sb.Append("[");

            for (var i = 0; i < objs.Length; i++) {
                if (i > 0) {
                    sb.Append(",");
                }

                sb.Append(Value(objs[i]));
            }

            sb.AppendFormat("] (Length={0})", objs.Length);

            return sb.ToString();
        } else if (value is IList<int> il) {
            return Format("{0} (Count={1})", JsonSerializer.Serialize(il, OPTIONS), il.Count);
        } else if (value is IList<uint> uil) {
            return Format("{0} (Count={1})", JsonSerializer.Serialize(uil, OPTIONS), uil.Count);
        } else if (value is IList<long> ll) {
            return Format("{0} (Count={1})", JsonSerializer.Serialize(ll, OPTIONS), ll.Count);
        } else if (value is IList<ulong> ull) {
            return Format("{0} (Count={1})", JsonSerializer.Serialize(ull, OPTIONS), ull.Count);
        } else if (value is IList<bool> bl) {
            return Format("{0} (Count={1})", JsonSerializer.Serialize(bl, OPTIONS), bl.Count);
        } else if (value is IList<char> cl) {
            return Format("{0} (Count={1})", JsonSerializer.Serialize(cl, OPTIONS), cl.Count);
        } else if (value is IList<string> sl) {
            return Format("{0} (Count={1})", JsonSerializer.Serialize(sl, OPTIONS), sl.Count);
        } else if (value is IList<IList<int>> ill) {
            return Format("{0} (Count={1})", JsonSerializer.Serialize(ill, OPTIONS), ill.Count);
        } else if (value is IList<IList<uint>> uill) {
            return Format("{0} (Count={1})", JsonSerializer.Serialize(uill, OPTIONS), uill.Count);
        } else if (value is IList<IList<long>> lll) {
            return Format("{0} (Count={1})", JsonSerializer.Serialize(lll, OPTIONS), lll.Count);
        } else if (value is IList<IList<ulong>> ulll) {
            return Format("{0} (Count={1})", JsonSerializer.Serialize(ulll, OPTIONS), ulll.Count);
        } else if (value is IList<IList<bool>> bll) {
            return Format("{0} (Count={1})", JsonSerializer.Serialize(bll, OPTIONS), bll.Count);
        } else if (value is IList<IList<char>> cll) {
            return Format("{0} (Count={1})", JsonSerializer.Serialize(cll, OPTIONS), cll.Count);
        } else if (value is IList<IList<string>> sll) {
            return Format("{0} (Count={1})", JsonSerializer.Serialize(sll, OPTIONS), sll.Count);
        } else if (value is HashSet<int> ih) {
            var i_l = ih.ToList();
            i_l.Sort();
            return Format("{0} (Count={1})", JsonSerializer.Serialize(i_l, OPTIONS), ih.Count);
        } else if (value is HashSet<uint> uih) {
            var ui_l = uih.ToList();
            ui_l.Sort();
            return Format("{0} (Count={1})", JsonSerializer.Serialize(ui_l, OPTIONS), uih.Count);
        } else if (value is HashSet<long> lh) {
            var l_l = lh.ToList();
            l_l.Sort();
            return Format("{0} (Count={1})", JsonSerializer.Serialize(l_l, OPTIONS), lh.Count);
        } else if (value is HashSet<ulong> ulh) {
            var ul_l = ulh.ToList();
            ul_l.Sort();
            return Format("{0} (Count={1})", JsonSerializer.Serialize(ul_l, OPTIONS), ulh.Count);
        } else if (value is HashSet<char> ch) {
            var c_l = ch.ToList();
            c_l.Sort();
            return Format("{0} (Count={1})", JsonSerializer.Serialize(c_l, OPTIONS), ch.Count);
        } else if (value is HashSet<string> sh) {
            var s_l = sh.ToList();
            s_l.Sort();
            return Format("{0} (Count={1})", JsonSerializer.Serialize(s_l, OPTIONS), sh.Count);
        } else if (value is string s) {
            return Format("\"{0}\"", s);
        } else if (value is IBinaryTreeNode itn) {
            var sb = new StringBuilder();
            sb.Append("\r\n");
            FormatBinaryTreeNode(itn, sb, "ROOT", 0);
            return sb.ToString();
        } else if (value is IFormattable f) {
            return Format(CultureInfo.InvariantCulture, "{0}", f);
        } else {
            return value.ToString();
        }
    }

    private static string Format2Array<T>(T[][] array) {
        int m = array.Length;
        if (m <= 0) {
            return "[0x?]";
        }
        int n = array[0].Length;
        if (n <= 0) {
            return Format("[{0}x0]", n);
        }

        var sb = new StringBuilder();

        sb.AppendFormat("[{0}x{1}] = ", m, n);

        for (var i = 0; i < m; i++) {
            sb.Append("\r\n[");
            for (var j = 0; j < n; j++) {
                if (j > 0) {
                    sb.Append(" ");
                }

                sb.Append(array[i][j]);
            }
            sb.Append("]");
        }

        return sb.ToString();
    }

    private static void FormatBinaryTreeNode(IBinaryTreeNode node, StringBuilder sb, string prefix, int level) {
        sb.Append("  ");

        for (var i = 0; i < level; i++) {
            sb.Append("  ");
        }

        if (!IsNullOrEmpty(prefix)) {
            sb.AppendFormat("{0}: ", prefix);
        }

        if (node == null) {
            sb.Append("(null)\r\n");
        } else {
            sb.AppendFormat("{0}\r\n", Value(node.Value));

            if (node.Left != null || node.Right != null) {
                FormatBinaryTreeNode(node.Right, sb, "RIGHT", level + 1);
                FormatBinaryTreeNode(node.Left, sb, "LEFT", level + 1);
            }
        }
    }

}
