﻿namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.MinimumDeleteSum, "sea", "eat", 's' + 't');
            Test.Check(solution.MinimumDeleteSum, "delete", "leet", 'd' + 'e' + 'e' + 'e');
        }

    }
}
