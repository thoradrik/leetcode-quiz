namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Employee[] test = {
                new Employee(1, 5, new[] { 2, 3 }),
                new Employee(2, 3),
                new Employee(3, 3)
            };
            Test.Check(solution.GetImportance, test, 1, 11);
        }

    }
}