namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.ConvertToTitle, 1, "A");
            Test.Check(solution.ConvertToTitle, 2, "B");
            Test.Check(solution.ConvertToTitle, 3, "C");
            Test.Check(solution.ConvertToTitle, 24, "X");
            Test.Check(solution.ConvertToTitle, 25, "Y");
            Test.Check(solution.ConvertToTitle, 26, "Z");
            Test.Check(solution.ConvertToTitle, 27, "AA");
            Test.Check(solution.ConvertToTitle, 28, "AB");
            Test.Check(solution.ConvertToTitle, 29, "AC");
            Test.Check(solution.ConvertToTitle, 30, "AD");
            Test.Check(solution.ConvertToTitle, 52, "AZ");
            Test.Check(solution.ConvertToTitle, 53, "BA");
            Test.Check(solution.ConvertToTitle, 79, "CA");
            Test.Check(solution.ConvertToTitle, 105, "DA");
            Test.Check(solution.ConvertToTitle, 674, "YX");
            Test.Check(solution.ConvertToTitle, 675, "YY");
            Test.Check(solution.ConvertToTitle, 676, "YZ");
            Test.Check(solution.ConvertToTitle, 677, "ZA");
            Test.Check(solution.ConvertToTitle, 701, "ZY");
            Test.Check(solution.ConvertToTitle, 702, "ZZ");
            Test.Check(solution.ConvertToTitle, 2147483647, "FXSHRXW");
        }

    }
}
