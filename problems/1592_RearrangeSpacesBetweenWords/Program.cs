namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.ReorderSpaces, "one", "one");
            Test.Check(solution.ReorderSpaces, " one", "one ");
            Test.Check(solution.ReorderSpaces, " one ", "one  ");
            Test.Check(solution.ReorderSpaces, " one  ", "one   ");
            Test.Check(solution.ReorderSpaces, "  one  ", "one    ");
            Test.Check(solution.ReorderSpaces, "hi there", "hi there");
            Test.Check(solution.ReorderSpaces, " hi there", "hi  there");
            Test.Check(solution.ReorderSpaces, " hi there ", "hi   there");
            Test.Check(solution.ReorderSpaces, " hi  there ", "hi    there");
            Test.Check(solution.ReorderSpaces, " hi  there  ", "hi     there");
            Test.Check(solution.ReorderSpaces, "hi there  some code", "hi there some code ");
            Test.Check(solution.ReorderSpaces, "hi  there  some code", "hi there some code  ");
            Test.Check(solution.ReorderSpaces, "hi  there   some  code", "hi  there  some  code ");
            Test.Check(solution.ReorderSpaces, "hi   there   some  code", "hi  there  some  code  ");
            Test.Check(solution.ReorderSpaces, "hi   there   some    code", "hi   there   some   code ");
            Test.Check(solution.ReorderSpaces, "hi    there   some    code", "hi   there   some   code  ");
            Test.Check(solution.ReorderSpaces, "hi    there    some    code", "hi    there    some    code");
            Test.Check(solution.ReorderSpaces, " hi     there    some    code", "hi    there    some    code  ");
            Test.Check(solution.ReorderSpaces, " hi     there    some    code ", "hi     there     some     code");
        }

    }
}