namespace Quiz {
    public static class Program {
        
        public static void Main() {
            MyCalendar solution = new MyCalendar();

            Test.Check(solution.Book, 10, 20, true);
            Test.Check(solution.Book, 15, 25, false);
            Test.Check(solution.Book, 20, 30, true);
        }

    }
}