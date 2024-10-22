namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new MyCalendar();

            Test.Check(solution.Book, 10, 20, true);
            Test.Check(solution.Book, 15, 25, false);
            Test.Check(solution.Book, 20, 30, true);
        }

    }
}
