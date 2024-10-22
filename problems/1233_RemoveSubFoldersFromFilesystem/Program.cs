namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.RemoveSubfolders, StringArray("[\"/a\"]"), StringArray("[\"/a\"]"));
            Test.Check(solution.RemoveSubfolders, StringArray("[\"/a\",\"/b\"]"), StringArray("[\"/a\",\"/b\"]"));
            Test.Check(solution.RemoveSubfolders, StringArray("[\"/a\",\"/a/b\"]"), StringArray("[\"/a\"]"));
            Test.Check(solution.RemoveSubfolders, StringArray("[\"/a/b\",\"/a/c\"]"), StringArray("[\"/a/b\",\"/a/c\"]"));
            Test.Check(solution.RemoveSubfolders, StringArray("[\"/a/b\",\"/a/c\"]"), StringArray("[\"/a/b\",\"/a/c\"]"));

            Test.Check(solution.RemoveSubfolders, StringArray("[\"/a\",\"/a/b\",\"/c/d\",\"/c/d/e\",\"/c/f\"]"), StringArray("[\"/a\",\"/c/d\",\"/c/f\"]"));
            Test.Check(solution.RemoveSubfolders, StringArray("[\"/a\",\"/a/b/c\",\"/a/b/d\"]"), StringArray("[\"/a\"]"));
            Test.Check(solution.RemoveSubfolders, StringArray("[\"/a/b/c\",\"/a/b/ca\",\"/a/b/d\"]"), StringArray("[\"/a/b/c\",\"/a/b/ca\",\"/a/b/d\"]"));
        }

    }
}