namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Print(solution.CombinationSum, IntArray("[]"), 1);
            Test.Print(solution.CombinationSum, IntArray("[2]"), 1);
            Test.Print(solution.CombinationSum, IntArray("[1]"), 1);
            Test.Print(solution.CombinationSum, IntArray("[1]"), 2);
            Test.Print(solution.CombinationSum, IntArray("[1,2]"), 1);
            Test.Print(solution.CombinationSum, IntArray("[1,2]"), 2);
            Test.Print(solution.CombinationSum, IntArray("[1,2,3]"), 3);
            Test.Print(solution.CombinationSum, IntArray("[2,3,5]"), 8);
            Test.Print(solution.CombinationSum, IntArray("[2,3,6,7]"), 7);
            Test.Print(solution.CombinationSum, IntArray("[3,5,7,11,13]"), 20);
            Test.Print(solution.CombinationSum, IntArray("[3,5,7,11,13,17,19]"), 83);
            Test.Print(solution.CombinationSum, IntArray("[3,5,7,11,13,17,19,23,29]"), 97);
            Test.Print(solution.CombinationSum, IntArray("[3,5,7,11,13,17,19,23,29,31,37]"), 97);
            Test.Print(solution.CombinationSum, IntArray("[5,7,11,13,17,19,23,29,31,37,41,43]"), 113);
            Test.Print(solution.CombinationSum, IntArray("[23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97,101,103,107,109,113,127,131,137,139,149,151,157,163,167]"), 500);
        }

    }
}
