namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.NextClosestTime, "00:00", "00:00");
            Test.Check(solution.NextClosestTime, "00:01", "00:10");
            Test.Check(solution.NextClosestTime, "01:30", "01:31");
            Test.Check(solution.NextClosestTime, "01:34", "01:40");
            Test.Check(solution.NextClosestTime, "12:09", "12:10");
            Test.Check(solution.NextClosestTime, "19:34", "19:39");
            Test.Check(solution.NextClosestTime, "23:59", "22:22");
        }

    }
}
