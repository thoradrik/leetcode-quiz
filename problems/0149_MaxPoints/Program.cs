namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.MaxPoints, new int[][] { }, 0);
            Test.Check(solution.MaxPoints, new[] { new[] { 0, 0 } }, 1);
            Test.Check(solution.MaxPoints, new[] { new[] { 0, 0 }, new[] { 0, 0 } }, 2);
            Test.Check(solution.MaxPoints, new[] { new[] { 0, 0 }, new[] { 0, 0 }, new[] { 1, 1 }, new[] { 1, 1 } }, 4);
            Test.Check(solution.MaxPoints, new[] { new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 } }, 3);
            Test.Check(solution.MaxPoints, new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 } }, 3);
            Test.Check(solution.MaxPoints, new[] { new[] { 1, 1 }, new[] { 3, 2 }, new[] { 5,3 }, new[] { 4,1 }, new[] { 2,3 }, new[] { 1,4 } }, 4);
            Test.Check(solution.MaxPoints, new[] { new[] { 84,250 }, new[] { 0,0 }, new[] { 1,0 }, new[] { 0,-70 }, new[] { 0,-70 }, new[] { 1,-1 }, new[] { 21,10}, new[] { 42,90 } , new[] { -42,-230 } }, 6);
        }

    }
}