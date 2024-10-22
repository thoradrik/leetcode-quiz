namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Print(solution.Permute, IntArray("[]"));
            Test.Print(solution.Permute, IntArray("[1]"));
            Test.Print(solution.Permute, IntArray("[1,2]"));
            Test.Print(solution.Permute, IntArray("[1,2,3]"));
            Test.Print(solution.Permute, IntArray("[1,2,3,4]"));
            Test.Print(solution.Permute, IntArray("[1,2,3,4,5]"));
            Test.Print(solution.Permute, IntArray("[1,2,3,4,5,6]"));
            Test.Print(solution.Permute, IntArray("[1,2,3,4,5,6,7]"));
        }

    }
}
