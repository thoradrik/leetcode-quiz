namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            int[] Func(int[] a1, int a2, int[] a3, int a4) {
                solution.Merge(a1, a2, a3, a4);
                return a1;
            }

            Test.Check(Func, IntArray("[]"), 0, IntArray("[]"), 0, IntArray("[]"));
            Test.Check(Func, IntArray("[1]"), 1, IntArray("[]"), 0, IntArray("[1]"));
            Test.Check(Func, IntArray("[0]"), 0, IntArray("[1]"), 1, IntArray("[1]"));
            Test.Check(Func, IntArray("[1,2,3,0,0,0]"), 3, IntArray("[2,5,6]"), 3, IntArray("[1,2,2,3,5,6]"));
        }

    }
}