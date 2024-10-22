namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.KidsWithCandies, IntArray("[]"), 0, BoolArray("[]"));
            Test.Check(solution.KidsWithCandies, IntArray("[]"), 1, BoolArray("[]"));
            Test.Check(solution.KidsWithCandies, IntArray("[1]"), 1, BoolArray("[true]"));
            Test.Check(solution.KidsWithCandies, IntArray("[1,1]"), 1, BoolArray("[true,true]"));
            Test.Check(solution.KidsWithCandies, IntArray("[1,1,2]"), 1, BoolArray("[true,true,true]"));
            Test.Check(solution.KidsWithCandies, IntArray("[1,1,3]"), 1, BoolArray("[false,false,true]"));
            Test.Check(solution.KidsWithCandies, IntArray("[2,3,5,1,3]"), 3, BoolArray("[true,true,true,false,true]"));
            Test.Check(solution.KidsWithCandies, IntArray("[4,2,1,1,2]"), 1, BoolArray("[true,false,false,false,false] "));
            Test.Check(solution.KidsWithCandies, IntArray("[12,1,12]"), 10, BoolArray("[true,false,true]"));
        }

    }
}