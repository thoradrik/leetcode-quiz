using System.Text.Json;

namespace Quiz;

public class ProgramBase {

    protected static bool[] BoolArray(string s) => JsonSerializer.Deserialize<bool[]>(s);

    protected static char[] CharArray(string s) => JsonSerializer.Deserialize<char[]>(s);

    protected static char[][] Char2Array(string s) => JsonSerializer.Deserialize<char[][]>(s);

    protected static int[] IntArray(string s) => JsonSerializer.Deserialize<int[]>(s);

    protected static int[][] Int2Array(string s) => JsonSerializer.Deserialize<int[][]>(s);

    protected static IList<IList<int>> Int2List(string s) {
        var arr2 = JsonSerializer.Deserialize<int[][]>(s);

        var list = new List<IList<int>>();

        foreach (var arr in arr2) {
            list.Add(arr);
        }

        return list;
    }

    protected static string[] StringArray(string s) => JsonSerializer.Deserialize<string[]>(s);

}
