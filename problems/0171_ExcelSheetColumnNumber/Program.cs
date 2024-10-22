namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.TitleToNumber, "A", 1);
            Test.Check(solution.TitleToNumber, "B", 2);
            Test.Check(solution.TitleToNumber, "C", 3);
            Test.Check(solution.TitleToNumber, "X", 24);
            Test.Check(solution.TitleToNumber, "Y", 25);
            Test.Check(solution.TitleToNumber, "Z", 26);
            Test.Check(solution.TitleToNumber, "AA", 27);
            Test.Check(solution.TitleToNumber, "AB", 28);
            Test.Check(solution.TitleToNumber, "AC", 29);
            Test.Check(solution.TitleToNumber, "AD", 30);
            Test.Check(solution.TitleToNumber, "AZ", 52);
            Test.Check(solution.TitleToNumber, "BA", 53);
            Test.Check(solution.TitleToNumber, "CA", 79);
            Test.Check(solution.TitleToNumber, "DA", 105);
            Test.Check(solution.TitleToNumber, "YX", 674);
            Test.Check(solution.TitleToNumber, "YY", 675);
            Test.Check(solution.TitleToNumber, "YZ", 676);
            Test.Check(solution.TitleToNumber, "ZA", 677);
            Test.Check(solution.TitleToNumber, "ZY", 701);
            Test.Check(solution.TitleToNumber, "ZZ", 702);
            Test.Check(solution.TitleToNumber, "FXSHRXW", 2147483647);
        }

    }
}
