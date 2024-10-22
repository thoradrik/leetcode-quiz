namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.NextGreaterElement, 241, 412);
            Test.Check(solution.NextGreaterElement, 23241, 23412);
            Test.Check(solution.NextGreaterElement, 230241, 230412);
            Test.Check(solution.NextGreaterElement, 132, 213);
            Test.Check(solution.NextGreaterElement, 1132, 1213);
            Test.Check(solution.NextGreaterElement, 15421, 21145);
            Test.Check(solution.NextGreaterElement, 511, -1);
            Test.Check(solution.NextGreaterElement, 516, 561);
            Test.Check(solution.NextGreaterElement, 5116, 5161);
            Test.Check(solution.NextGreaterElement, 51166, 51616);

            Test.Check(solution.NextGreaterElement, 1, -1);
            Test.Check(solution.NextGreaterElement, 11, -1);
            Test.Check(solution.NextGreaterElement, 102, 120);
            Test.Check(solution.NextGreaterElement, 101, 110);
            Test.Check(solution.NextGreaterElement, 12, 21);
            Test.Check(solution.NextGreaterElement, 21, -1);
            Test.Check(solution.NextGreaterElement, 123, 132);
            Test.Check(solution.NextGreaterElement, 1234, 1243);
            Test.Check(solution.NextGreaterElement, 1243, 1324);
            Test.Check(solution.NextGreaterElement, 2147483647, -1);
            Test.Check(solution.NextGreaterElement, 2147473648, 2147473684);
        }

    }
}
