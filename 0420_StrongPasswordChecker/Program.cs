namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.StrongPasswordChecker, "", 6);
            Test.Check(solution.StrongPasswordChecker, "1", 5);
            Test.Check(solution.StrongPasswordChecker, "1234lUa", 0);
            Test.Check(solution.StrongPasswordChecker, "1234lUa0", 0);
            Test.Check(solution.StrongPasswordChecker, "1234lua", 1);
            Test.Check(solution.StrongPasswordChecker, "1234LUA", 1);
            Test.Check(solution.StrongPasswordChecker, "UVXYLUA", 2);
            Test.Check(solution.StrongPasswordChecker, "1234567890abcdeFGHIJ", 0);
            Test.Check(solution.StrongPasswordChecker, "1234567890abcdeFGHIJZ", 1);
            Test.Check(solution.StrongPasswordChecker, "1234567890abcdeFGHIJZZ", 2);
            Test.Check(solution.StrongPasswordChecker, "12345678901234567890zZz", 3);
            Test.Check(solution.StrongPasswordChecker, "1zZ2345678901234567890z", 3);
            Test.Check(solution.StrongPasswordChecker, "aa", 4);
            Test.Check(solution.StrongPasswordChecker, "aaa", 3);
            Test.Check(solution.StrongPasswordChecker, "aaaa", 2);
            Test.Check(solution.StrongPasswordChecker, "aaaaa", 2);
            Test.Check(solution.StrongPasswordChecker, "aaaaaa", 2);
            Test.Check(solution.StrongPasswordChecker, "00000111112222233333", 4);
            Test.Check(solution.StrongPasswordChecker, "AAAAAAAAAAAAAAAAAAAAAAAAA", 11);
            Test.Check(solution.StrongPasswordChecker, "aa123", 1);
            Test.Check(solution.StrongPasswordChecker, "aaa123", 1);
            Test.Check(solution.StrongPasswordChecker, "aaAA11", 0);
            Test.Check(solution.StrongPasswordChecker, "1010101010aaaB10101010", 2);
            Test.Check(solution.StrongPasswordChecker, "aaaabbaaabbaaa123456A", 3);
            Test.Check(solution.StrongPasswordChecker, "1Abababcaaaabababababa", 2);
        }

    }
}