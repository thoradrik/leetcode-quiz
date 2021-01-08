namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.ExclusiveTime, 1, StringArray("[\"0:start:0\",\"0:end:0\"]"), IntArray("[1]"));
            Test.Check(solution.ExclusiveTime, 1, StringArray("[\"0:start:0\",\"0:end:1\"]"), IntArray("[2]"));
            Test.Check(solution.ExclusiveTime, 2, StringArray("[\"0:start:0\",\"1:start:2\",\"1:end:5\",\"0:end:6\"]"), IntArray("[3,4]"));
            Test.Check(solution.ExclusiveTime, 1, StringArray("[\"0:start:0\",\"0:start:2\",\"0:end:5\",\"0:start:6\",\"0:end:6\",\"0:end:7\"]"), IntArray("[8]"));
            Test.Check(solution.ExclusiveTime, 2, StringArray("[\"0:start:0\",\"0:start:2\",\"0:end:5\",\"1:start:6\",\"1:end:6\",\"0:end:7\"]"), IntArray("[7,1]"));
            Test.Check(solution.ExclusiveTime, 2, StringArray("[\"0:start:0\",\"0:start:2\",\"0:end:5\",\"1:start:7\",\"1:end:7\",\"0:end:8\"]"), IntArray("[8,1]"));
            Test.Check(solution.ExclusiveTime, 1, StringArray("[\"0:start:0\",\"0:start:1\",\"0:start:2\",\"0:end:3\",\"0:end:4\",\"0:end:5\"]"), IntArray("[6]"));
        }

    }
}