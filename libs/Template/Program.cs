﻿namespace Quiz;

public class Program : ProgramBase {
    
    public static void Main() {
        Solution solution = new Solution();

        Test.Check(solution.Method, 1, 1);
    }

}
