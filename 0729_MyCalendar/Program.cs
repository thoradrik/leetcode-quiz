using System;

namespace Quiz {
    public static class Program {
        
        private static void Main(string[] args) {
            MyCalendar my_calendar = new MyCalendar();

            Check(my_calendar, 10, 20, true);
            Check(my_calendar, 15, 25, false);
            Check(my_calendar, 20, 30, true);
        }

        private static void Check(MyCalendar my_calendar, int a, int b, bool expected) {
            Console.WriteLine("ADD [{0},{1})", a, b);
            
            bool answer = my_calendar.Book(a, b);
            
            if (expected != answer) {
                Console.WriteLine("  !!! FAILED {0} {1}", answer, expected);
            } else {
                Console.WriteLine("  PASSED {0}  {1}", answer, expected);
            }
        }

    }
}