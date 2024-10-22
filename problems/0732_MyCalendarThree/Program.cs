namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new MyCalendarThree();

            Test.Check(solution.Book, 10, 20, 1);
            Test.Check(solution.Book, 50, 60, 1);
            Test.Check(solution.Book, 10, 40, 2);
            Test.Check(solution.Book, 5, 15, 3);
            Test.Check(solution.Book, 5, 10, 3);
            Test.Check(solution.Book, 25, 55, 3);
            Test.Check(solution.Book, 47, 50, 1);
            Test.Check(solution.Book, 1,10, 1);
            Test.Check(solution.Book, 27,36, 1);
            Test.Check(solution.Book, 40,47, 1);
            Test.Check(solution.Book, 20,27, 1);
            Test.Check(solution.Book, 15,23, 2);
            Test.Check(solution.Book, 10,18, 2);
            Test.Check(solution.Book, 27, 36, 2);
            Test.Check(solution.Book, 17,25, 3);
            Test.Check(solution.Book, 8,17, 3);
            Test.Check(solution.Book, 24, 33, 3);
            Test.Check(solution.Book, 23, 28, 4);
            Test.Check(solution.Book, 21,27, 5);
            Test.Check(solution.Book, 47,50, 5);
            Test.Check(solution.Book, 14,21, 5);
            Test.Check(solution.Book, 26,32, 5);
            Test.Check(solution.Book, 16,21, 5);
            Test.Check(solution.Book, 2, 7, 5);
            Test.Check(solution.Book, 24,33, 6);
            Test.Check(solution.Book, 6,13, 6);
            Test.Check(solution.Book, 44,50, 6);
            Test.Check(solution.Book, 33,39, 6);
            Test.Check(solution.Book, 30,36, 6);
            Test.Check(solution.Book, 6, 15, 6);
            Test.Check(solution.Book, 21,27, 7);
            Test.Check(solution.Book, 49,50, 7);
            Test.Check(solution.Book, 38,45, 7);
            Test.Check(solution.Book, 4,12, 7);
            Test.Check(solution.Book, 46,50, 7);
            Test.Check(solution.Book, 13, 21, 7);
        }

    }
}
