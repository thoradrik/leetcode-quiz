﻿namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.NthUglyNumber, 10, 12);
        }

    }
}
