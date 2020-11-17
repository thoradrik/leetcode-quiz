using System;

namespace Quiz {
    public static class Program {
        
        private static void Main(string[] args) {
            MyCalendarTwo my_calendar_two = new MyCalendarTwo();

            // Check(my_calendar_two, 10, 20, true);
            // Check(my_calendar_two, 50, 60, true);
            // Check(my_calendar_two, 10, 40, true);
            // Check(my_calendar_two, 5, 15, false);
            // Check(my_calendar_two, 5, 10, true);
            // Check(my_calendar_two, 25, 55, true);
            //
            Check(my_calendar_two, 26,35, true);
            Check(my_calendar_two, 26,32, true);
            Check(my_calendar_two, 25,32, false);
            Check(my_calendar_two, 18,26, true);
            Check(my_calendar_two, 40,45, true);
            Check(my_calendar_two, 19,26, true);
            Check(my_calendar_two, 48,50, true);
            Check(my_calendar_two, 1,6, true);
            Check(my_calendar_two, 46,50, true);
            Check(my_calendar_two, 11,18, true);
            
            // Check(my_calendar_two, 12,26,true);
            // Check(my_calendar_two, 70,85,true);
            // Check(my_calendar_two, 55,67,true);
            // Check(my_calendar_two, 2,13,true);
            // Check(my_calendar_two, 3,18,false);
            // Check(my_calendar_two, 91,100,true);
            // Check(my_calendar_two, 13,26,true);
            // Check(my_calendar_two, 17,27,false);
            // Check(my_calendar_two, 41,55,true);
            // Check(my_calendar_two, 15,26,false);
            // Check(my_calendar_two, 50,68,true);
            // Check(my_calendar_two, 34,52,false);
            // Check(my_calendar_two, 95,100,true);
            // Check(my_calendar_two, 23,33,false);
            // Check(my_calendar_two, 89,100,false);
            // Check(my_calendar_two, 27,43,true);
            // Check(my_calendar_two, 80,95,true);
            // Check(my_calendar_two, 97,100,false);
            // Check(my_calendar_two, 28,47,false);
            // Check(my_calendar_two, 45,58,false);
            // Check(my_calendar_two, 76,93,false);
            // Check(my_calendar_two, 56,75,false);
            // Check(my_calendar_two, 91,100,false);
            // Check(my_calendar_two, 61,77,false);
            // Check(my_calendar_two, 36,49,false);
            // Check(my_calendar_two, 18,32,false);
            // Check(my_calendar_two, 96,100,false);
            // Check(my_calendar_two, 96,100,false);
            // Check(my_calendar_two, 67,86,false);
            // Check(my_calendar_two, 46,64,false);
            // Check(my_calendar_two, 95,100,false);
            // Check(my_calendar_two, 17,35,false);
            // Check(my_calendar_two, 8,27,false);
            // Check(my_calendar_two, 4,14,false);
            // Check(my_calendar_two, 30,43,false);
            // Check(my_calendar_two, 74,89,false);
            // Check(my_calendar_two, 77,95,false);
            // Check(my_calendar_two, 98,100,false);
            // Check(my_calendar_two, 31, 41, true);
            // Check(my_calendar_two, 35, 53, false);
                
            // Check(my_calendar_two, 24,40, true);
            // Check(my_calendar_two, 43,50, true);
            // Check(my_calendar_two, 27,43, true);
            // Check(my_calendar_two, 5,21, true);
            // Check(my_calendar_two, 30,40, false);
            // Check(my_calendar_two, 14,29, false);
            // Check(my_calendar_two, 3,19, true);
            // Check(my_calendar_two, 3,14, false);
            // Check(my_calendar_two, 25,39, false);
            // Check(my_calendar_two, 6,19, false);
        }

        private static void Check(MyCalendarTwo my_calendar_two, int a, int b, bool expected) {
            Console.WriteLine("ADD [{0},{1})", a, b);
            
            bool answer = my_calendar_two.Book(a, b);
            
            if (expected != answer) {
                Console.WriteLine("  !!! FAILED {0} {1}", answer, expected);
            } else {
                Console.WriteLine("  PASSED {0}  {1}", answer, expected);
            }
        }

    }
}