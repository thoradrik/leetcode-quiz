namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.SimilarRGB, "#000000", "#000000");
            Test.Check(solution.SimilarRGB, "#080808", "#000000");
            Test.Check(solution.SimilarRGB, "#090909", "#111111");
            Test.Check(solution.SimilarRGB, "#0a0a0a", "#111111");
            Test.Check(solution.SimilarRGB, "#111111", "#111111");
            Test.Check(solution.SimilarRGB, "#121212", "#111111");
            Test.Check(solution.SimilarRGB, "#181818", "#111111");
            Test.Check(solution.SimilarRGB, "#1a1a1a", "#222222");
            Test.Check(solution.SimilarRGB, "#09f166", "#11ee66");
            Test.Check(solution.SimilarRGB, "#f0f0f0", "#eeeeee");
            Test.Check(solution.SimilarRGB, "#ffffff", "#ffffff");
        }

    }
}
