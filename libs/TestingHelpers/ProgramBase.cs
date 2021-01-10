using System.Text.Json;

namespace Quiz {
    public class ProgramBase {

        protected static char[][] Char2Array(string s) => JsonSerializer.Deserialize<char[][]>(s);

        protected static int[] IntArray(string s) => JsonSerializer.Deserialize<int[]>(s);

        protected static int[][] Int2Array(string s) => JsonSerializer.Deserialize<int[][]>(s);
        
        protected static string[] StringArray(string s) => JsonSerializer.Deserialize<string[]>(s);

    }
}