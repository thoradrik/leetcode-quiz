namespace Quiz;

public class Program : ProgramBase {

    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.ThreeSum, IntArray("[0,0,0]"), CheckResult, Int2List("[[0,0,0]]"));
        Test.Check(solution.ThreeSum, IntArray("[0,0,1]"), CheckResult, Int2List("[]"));
        Test.Check(solution.ThreeSum, IntArray("[1,0,1]"), CheckResult, Int2List("[]"));
        Test.Check(solution.ThreeSum, IntArray("[1,0,-1]"), CheckResult, Int2List("[[-1,0,1]]"));
        Test.Check(solution.ThreeSum, IntArray("[-1,0,1,2,-1,-4]"), CheckResult, Int2List("[[-1,-1,2],[-1,0,1]]"));
        // Test.Check(solution.FindIndex, IntArray("[-4,-1,-1,0,1,2]"), -4, 0, 0);
        // Test.Check(solution.FindIndex, IntArray("[-4,-1,-1,0,1,2]"), -1, 0, 2);
        // Test.Check(solution.FindIndex, IntArray("[-4,-1,-1,0,1,2]"), 0, 0, 3);
        // Test.Check(solution.FindIndex, IntArray("[-4,-1,-1,0,1,2]"), 1, 0, 4);
        // Test.Check(solution.FindIndex, IntArray("[-4,-1,-1,0,1,2]"), 2, 0, 5);
    }

    public static bool CheckResult(IList<IList<int>> answer, IList<IList<int>> expected) {
        if (answer.Count != expected.Count) {
            return false;
        }

        var answer_hs = new HashSet<string>();

        foreach (var turple in answer) {
            var list = new List<int>(turple);
            list.Sort();
            var item = String.Join(',', list);
            answer_hs.Add(item);
        }

        var expected_hs = new HashSet<string>();

        foreach (var turple in expected) {
            var list = new List<int>(turple);
            list.Sort();
            var item = String.Join(',', list);
            expected_hs.Add(item);
        }

        HashSet<string> hs1 = [];

        hs1.UnionWith(answer_hs);
        hs1.ExceptWith(expected_hs);

        HashSet<string> hs2 = [];

        hs2.UnionWith(expected_hs);
        hs2.ExceptWith(answer_hs);

        return hs1.Count == 0 && hs2.Count == 0;
    }
}
