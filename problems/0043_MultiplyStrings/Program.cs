namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.AddStrings, new[] { "492", "2460", "12300" }, "15252");

            Test.Check(solution.Multiply, "123", "124", "15252");

            Test.Check(solution.Multiply, "0", "0", "0");
            Test.Check(solution.Multiply, "0", "1", "0");
            Test.Check(solution.Multiply, "1", "0", "0");
            Test.Check(solution.Multiply, "9133", "0", "0");
            Test.Check(solution.Multiply, "0", "9133", "0");
            Test.Check(solution.Multiply, "1", "1", "1");
            Test.Check(solution.Multiply, "10", "1", "10");
            Test.Check(solution.Multiply, "1", "11", "11");
            Test.Check(solution.Multiply, "11", "2", "22");
            Test.Check(solution.Multiply, "11", "11", "121");
            Test.Check(solution.Multiply, "121", "112", "13552");
            Test.Check(solution.Multiply, "1234568", "897561646", "1108100886178928");
            Test.Check(solution.Multiply, "987413248761378423", "135687461634894351", "133979597309095926818210910735988473");
            Test.Check(solution.Multiply, "9999999999999999999999999999999999999999999999999999999999999999999", "8888888888888888888888888888888888888888888888888888888888", "88888888888888888888888888888888888888888888888888888888879999999991111111111111111111111111111111111111111111111111111111112");
        }

    }
}
