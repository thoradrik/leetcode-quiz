using System.Text.Json;

namespace Quiz {
    public static class Program {
        
        public static void Main() {
            Solution solution = new Solution();

            int[] Func(int[] a1, int a2, int[] a3, int a4) {
                solution.Merge(a1, a2, a3, a4);
                return a1;
            }

            Test.Check(Func, Array("[]"), 0, Array("[]"), 0, Array("[]"));
            Test.Check(Func, Array("[1]"), 1, Array("[]"), 0, Array("[1]"));
            Test.Check(Func, Array("[0]"), 0, Array("[1]"), 1, Array("[1]"));
            Test.Check(Func, Array("[1,2,3,0,0,0]"), 3, Array("[2,5,6]"), 3, Array("[1,2,2,3,5,6]"));
        }

        private static int[] Array(string s) => JsonSerializer.Deserialize<int[]>(s);

    }
}