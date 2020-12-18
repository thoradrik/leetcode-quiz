using System.Text.Json;

namespace Quiz {
    public static class Program {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.LargestTimeFromDigits, Array("[1,2,3,4]"), "23:41");
            Test.Check(solution.LargestTimeFromDigits, Array("[5,5,5,5]"), "");
            Test.Check(solution.LargestTimeFromDigits, Array("[0,0,0,0]"), "00:00");
            Test.Check(solution.LargestTimeFromDigits, Array("[0,0,1,0]"), "10:00");
            Test.Check(solution.LargestTimeFromDigits, Array("[5,2,3,9]"), "23:59");
        }

        private static int[] Array(string s) => JsonSerializer.Deserialize<int[]>(s);

    }
}