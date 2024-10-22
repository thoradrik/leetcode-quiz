namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.CheckRecord, "A", true);
            Test.Check(solution.CheckRecord, "AA", false);
            Test.Check(solution.CheckRecord, "L", true);
            Test.Check(solution.CheckRecord, "LL", true);
            Test.Check(solution.CheckRecord, "LLL", false);
            Test.Check(solution.CheckRecord, "P", true);
            Test.Check(solution.CheckRecord, "PP", true);
            Test.Check(solution.CheckRecord, "PPP", true);
            Test.Check(solution.CheckRecord, "PPPP", true);
            Test.Check(solution.CheckRecord, "PPPPL", true);
            Test.Check(solution.CheckRecord, "LPPPPL", true);
            Test.Check(solution.CheckRecord, "LPLPPPL", true);
            Test.Check(solution.CheckRecord, "LPLLPPPL", true);
            Test.Check(solution.CheckRecord, "LPLLPPLPL", true);
            Test.Check(solution.CheckRecord, "LPLLPPLLPL", true);
            Test.Check(solution.CheckRecord, "LPLALPPLLPL", true);
            Test.Check(solution.CheckRecord, "LPLLPPLLLPL", false);
            Test.Check(solution.CheckRecord, "LPLLPPLALPL", true);
            Test.Check(solution.CheckRecord, "LPLLPPLALLPL", true);
            Test.Check(solution.CheckRecord, "LPLLLPPLALLPL", false);
            Test.Check(solution.CheckRecord, "LPLALPPLALLPL", false);
        }

    }
}
