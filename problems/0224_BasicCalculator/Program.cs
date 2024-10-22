namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.Calculate, "0", 0);
            Test.Check(solution.Calculate, "0 +1", 1);
            Test.Check(solution.Calculate, "0 + -1", -1);
            Test.Check(solution.Calculate, "1 + -1", 0);
            Test.Check(solution.Calculate, "2 + - 10", -8);
            Test.Check(solution.Calculate, "2 * - 10", -20);
            Test.Check(solution.Calculate, "20 / -10", -2);
            Test.Check(solution.Calculate, "20 - -10", 30);
            Test.Check(solution.Calculate, "1", 1);
            Test.Check(solution.Calculate, "10/2", 5);
            Test.Check(solution.Calculate, "10*2", 20);
            Test.Check(solution.Calculate, "10+2", 12);
            Test.Check(solution.Calculate, "100-2", 98);
            Test.Check(solution.Calculate, "1+1-1", 1);
            Test.Check(solution.Calculate, "1+1-1+5", 6);
            Test.Check(solution.Calculate, "1+1-1+5+2", 8);
            Test.Check(solution.Calculate, "10+2*2", 14);
            Test.Check(solution.Calculate, "2*3+2*4", 14);
            Test.Check(solution.Calculate, "2*3+2*4*20", 166);
            Test.Check(solution.Calculate, "2*3+2*4*20+4", 170);
            Test.Check(solution.Calculate, "2*3+2*4*20+4/2", 168);
            Test.Check(solution.Calculate, "2*3/4+2*4*20+4/2", 163);
            Test.Check(solution.Calculate, "    1 + 2020 - 1 ", 2020);
            Test.Check(solution.Calculate, "1+ 100", 101);
            Test.Check(solution.Calculate, "2*2001+1", 4003);
            Test.Check(solution.Calculate, "2*2 +4* 4", 20);
            Test.Check(solution.Calculate, "1- 2*2 +4*4", 13);
            Test.Check(solution.Calculate, "1-2*2+4*4-4/2", 11);
            Test.Check(solution.Calculate, "1-2*2+4*4- 7/5*5", 8);
            Test.Check(solution.Calculate, "1-2*20+4*4- 70/6*6", -89);
            Test.Check(solution.Calculate, " 3 + 2 * 2 ", 7);
            Test.Check(solution.Calculate, "3/2", 1);
            Test.Check(solution.Calculate, " 3+5 / 2 ", 5);
            Test.Check(solution.Calculate, "6-4 / 2", 4);

            Test.Check(solution.Calculate, "(1)", 1);
            Test.Check(solution.Calculate, "((2))", 2);
            Test.Check(solution.Calculate, "(1+1)", 2);
            Test.Check(solution.Calculate, "(1+1)-1", 1);
            Test.Check(solution.Calculate, "10+(1+1)", 12);
            Test.Check(solution.Calculate, "12-(1+1)", 10);
            Test.Check(solution.Calculate, "2*(1+1)", 4);
            Test.Check(solution.Calculate, "4/(1+1)", 2);

            Test.Check(solution.Calculate, "(4-2)/(1+1)", 1);
            Test.Check(solution.Calculate, "(10+4*2)/(1+1)", 9);
            Test.Check(solution.Calculate, "(1+4*2)/(1+10/5)", 3);

            Test.Check(solution.Calculate, "(10-4/(2+2))/(5-(5+5)/5)", 3);

            Test.Check(solution.Calculate, "2*(5+5*2)/3+(6/2+8)", 21);
            Test.Check(solution.Calculate, "(2+6* 3+5- (3*14/7+2)*5)+3", -12);

            Test.Check(solution.Calculate, "0-2147483648", -2147483648);

            Test.Check(solution.Calculate, "-2+ 1", -1);
            Test.Check(solution.Calculate, "-(2+1)*5", -15);
        }

    }
}
