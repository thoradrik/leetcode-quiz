namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.CanPlaceFlowers, IntArray("[0]"), 0, true);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0]"), 1, true);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,0]"), 1, true);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,0]"), 2, false);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,1]"), 1, false);
            Test.Check(solution.CanPlaceFlowers, IntArray("[1,0,1]"), 1, false);
            Test.Check(solution.CanPlaceFlowers, IntArray("[1,0,0]"), 1, true);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,1,0]"), 1, false);
            Test.Check(solution.CanPlaceFlowers, IntArray("[1,0,0,0]"), 1, true);
            Test.Check(solution.CanPlaceFlowers, IntArray("[1,0,0,0]"), 2, false);
            Test.Check(solution.CanPlaceFlowers, IntArray("[1,0,0,0,1]"), 1, true);
            Test.Check(solution.CanPlaceFlowers, IntArray("[1,0,0,0,1]"), 2, false);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,1,0,1,0]"), 1, false);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,1,0,1,0]"), 1, false);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,1,0,0,0]"), 1, true);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,1,0,0,0]"), 2, false);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,0,1,0,0]"), 1, true);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,0,1,0,0]"), 2, true);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,0,1,0,1]"), 2, false);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,0,0,0,0,0]"), 1, true);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,0,0,0,0,0]"), 2, true);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,0,0,0,0,0]"), 3, true);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,0,0,0,0,0]"), 4, false);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,1,0,0,0,0]"), 1, true);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,1,0,0,0,0]"), 2, true);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,1,0,0,0,0]"), 3, false);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,1,0,0,0,0]"), 4, false);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,0,1,0,0,0]"), 1, true);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,0,1,0,0,0]"), 2, true);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,0,1,0,0,0]"), 3, false);
            Test.Check(solution.CanPlaceFlowers, IntArray("[0,0,1,0,0,0]"), 4, false);
        }

    }
}
