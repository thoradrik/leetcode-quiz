using System;

namespace Quiz {
    public static class Program {
        
        private static void Main(string[] args) {
            MyCalendarThree my_calendar_three = new MyCalendarThree();

            // Check(my_calendar_three, 10, 20, 1);
            // Check(my_calendar_three, 50, 60, 1);
            // Check(my_calendar_three, 10, 40, 2);
            // Check(my_calendar_three, 5, 15, 3);
            // Check(my_calendar_three, 5, 10, 3);
            // Check(my_calendar_three, 25, 55, 3);

            Check(my_calendar_three, 47, 50, 1);
            Check(my_calendar_three, 1,10, 1);
            Check(my_calendar_three, 27,36, 1);
            Check(my_calendar_three, 40,47, 1);
            Check(my_calendar_three, 20,27, 1);
            Check(my_calendar_three, 15,23, 2);
            Check(my_calendar_three, 10,18, 2);
            Check(my_calendar_three, 27, 36, 2);
            Check(my_calendar_three, 17,25, 3);
            Check(my_calendar_three, 8,17, 3);
            Check(my_calendar_three, 24, 33, 3);
            Check(my_calendar_three, 23, 28, 4);
            Check(my_calendar_three, 21,27, 5);
            Check(my_calendar_three, 47,50, 5);
            Check(my_calendar_three, 14,21, 5);
            Check(my_calendar_three, 26,32, 5);
            Check(my_calendar_three, 16,21, 5);
            Check(my_calendar_three, 2, 7, 5);
            Check(my_calendar_three, 24,33, 6);
            Check(my_calendar_three, 6,13, 6);
            Check(my_calendar_three, 44,50, 6);
            Check(my_calendar_three, 33,39, 6);
            Check(my_calendar_three, 30,36, 6);
            Check(my_calendar_three, 6, 15, 6);
            Check(my_calendar_three, 21,27, 7);
            Check(my_calendar_three, 49,50, 7);
            Check(my_calendar_three, 38,45, 7);
            Check(my_calendar_three, 4,12, 7);
            Check(my_calendar_three, 46,50, 7);
            Check(my_calendar_three, 13, 21, 7);
        }

        private static void Check(MyCalendarThree my_calendar_three, int a, int b, int expected) {
            Console.WriteLine("ADD [{0},{1})", a, b);
            
            int answer = my_calendar_three.Book(a, b);
            
            if (expected != answer) {
                Console.WriteLine("  !!! FAILED {0} {1}", answer, expected);
            } else {
                Console.WriteLine("  PASSED {0}  {1}", answer, expected);
            }
        }

    }
}