namespace Quiz {
    public static class Program {
        
        public static void Main() {
            MyCalendarTwo solution = new MyCalendarTwo();

            // Test.Check(solution.Book, 10, 20, true);
            // Test.Check(solution.Book, 50, 60, true);
            // Test.Check(solution.Book, 10, 40, true);
            // Test.Check(solution.Book, 5, 15, false);
            // Test.Check(solution.Book, 5, 10, true);
            // Test.Check(solution.Book, 25, 55, true);

            Test.Check(solution.Book, 26,35, true);
            Test.Check(solution.Book, 26,32, true);
            Test.Check(solution.Book, 25,32, false);
            Test.Check(solution.Book, 18,26, true);
            Test.Check(solution.Book, 40,45, true);
            Test.Check(solution.Book, 19,26, true);
            Test.Check(solution.Book, 48,50, true);
            Test.Check(solution.Book, 1,6, true);
            Test.Check(solution.Book, 46,50, true);
            Test.Check(solution.Book, 11,18, true);
            
            // Test.Check(solution.Book, 12,26,true);
            // Test.Check(solution.Book, 70,85,true);
            // Test.Check(solution.Book, 55,67,true);
            // Test.Check(solution.Book, 2,13,true);
            // Test.Check(solution.Book, 3,18,false);
            // Test.Check(solution.Book, 91,100,true);
            // Test.Check(solution.Book, 13,26,true);
            // Test.Check(solution.Book, 17,27,false);
            // Test.Check(solution.Book, 41,55,true);
            // Test.Check(solution.Book, 15,26,false);
            // Test.Check(solution.Book, 50,68,true);
            // Test.Check(solution.Book, 34,52,false);
            // Test.Check(solution.Book, 95,100,true);
            // Test.Check(solution.Book, 23,33,false);
            // Test.Check(solution.Book, 89,100,false);
            // Test.Check(solution.Book, 27,43,true);
            // Test.Check(solution.Book, 80,95,true);
            // Test.Check(solution.Book, 97,100,false);
            // Test.Check(solution.Book, 28,47,false);
            // Test.Check(solution.Book, 45,58,false);
            // Test.Check(solution.Book, 76,93,false);
            // Test.Check(solution.Book, 56,75,false);
            // Test.Check(solution.Book, 91,100,false);
            // Test.Check(solution.Book, 61,77,false);
            // Test.Check(solution.Book, 36,49,false);
            // Test.Check(solution.Book, 18,32,false);
            // Test.Check(solution.Book, 96,100,false);
            // Test.Check(solution.Book, 96,100,false);
            // Test.Check(solution.Book, 67,86,false);
            // Test.Check(solution.Book, 46,64,false);
            // Test.Check(solution.Book, 95,100,false);
            // Test.Check(solution.Book, 17,35,false);
            // Test.Check(solution.Book, 8,27,false);
            // Test.Check(solution.Book, 4,14,false);
            // Test.Check(solution.Book, 30,43,false);
            // Test.Check(solution.Book, 74,89,false);
            // Test.Check(solution.Book, 77,95,false);
            // Test.Check(solution.Book, 98,100,false);
            // Test.Check(solution.Book, 31, 41, true);
            // Test.Check(solution.Book, 35, 53, false);
                
            // Test.Check(solution.Book, 24,40, true);
            // Test.Check(solution.Book, 43,50, true);
            // Test.Check(solution.Book, 27,43, true);
            // Test.Check(solution.Book, 5,21, true);
            // Test.Check(solution.Book, 30,40, false);
            // Test.Check(solution.Book, 14,29, false);
            // Test.Check(solution.Book, 3,19, true);
            // Test.Check(solution.Book, 3,14, false);
            // Test.Check(solution.Book, 25,39, false);
            // Test.Check(solution.Book, 6,19, false);
        }

    }
}