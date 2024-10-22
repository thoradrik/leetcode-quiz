namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.AsteroidCollision, IntArray("[]"), IntArray("[]"));
            Test.Check(solution.AsteroidCollision, IntArray("[1]"), IntArray("[1]"));
            Test.Check(solution.AsteroidCollision, IntArray("[-1]"), IntArray("[-1]"));
            Test.Check(solution.AsteroidCollision, IntArray("[-1,1]"), IntArray("[-1,1]"));
            Test.Check(solution.AsteroidCollision, IntArray("[-1,10]"), IntArray("[-1,10]"));
            Test.Check(solution.AsteroidCollision, IntArray("[10,-1]"), IntArray("[10]"));
            Test.Check(solution.AsteroidCollision, IntArray("[10,-1,-2]"), IntArray("[10]"));
            Test.Check(solution.AsteroidCollision, IntArray("[10,-1,-2,-3]"), IntArray("[10]"));
            Test.Check(solution.AsteroidCollision, IntArray("[10,-1,-2,-3,-11]"), IntArray("[-11]"));
            Test.Check(solution.AsteroidCollision, IntArray("[10,-1,-2,-3,-11,-10]"), IntArray("[-11,-10]"));
            Test.Check(solution.AsteroidCollision, IntArray("[10,-1,-2,-3,-11,-10,2]"), IntArray("[-11,-10,2]"));
            Test.Check(solution.AsteroidCollision, IntArray("[5,10,-5]"), IntArray("[5,10]"));
            Test.Check(solution.AsteroidCollision, IntArray("[8,-8]"), IntArray("[]"));
            Test.Check(solution.AsteroidCollision, IntArray("[10,2,-5]"), IntArray("[10]"));
            Test.Check(solution.AsteroidCollision, IntArray("[-2,-1,1,2]"), IntArray("[-2,-1,1,2]"));
            Test.Check(solution.AsteroidCollision, IntArray("[5,-2,-1,1,2,-4]"), IntArray("[5]"));
            Test.Check(solution.AsteroidCollision, IntArray("[5,-2,-1,1,2,-4,-6]"), IntArray("[-6]"));
            Test.Check(solution.AsteroidCollision, IntArray("[5,-2,-1,1,2,-4,-6,10]"), IntArray("[-6,10]"));
        }

    }
}
