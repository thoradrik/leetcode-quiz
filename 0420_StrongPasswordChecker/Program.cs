using System;

namespace Quiz {
    public static class Program {
        
        private static void Main(string[] args) {
            Solution solution = new Solution();

//            Check(solution, "", 6);
//            Check(solution, "1", 5);
//            Check(solution, "1234lUa", 0);
//            Check(solution, "1234lUa0", 0);
//            Check(solution, "1234lua", 1);
//            Check(solution, "1234LUA", 1);
//            Check(solution, "UVXYLUA", 2);
//            Check(solution, "1234567890abcdeFGHIJ", 0);
//            Check(solution, "1234567890abcdeFGHIJZ", 1);
//            Check(solution, "1234567890abcdeFGHIJZZ", 2);
//            Check(solution, "12345678901234567890zZz", 3);
//            Check(solution, "1zZ2345678901234567890z", 3);
//            Check(solution, "aa", 4);
//            Check(solution, "aaa", 3);
//            Check(solution, "aaaa", 2);
//            Check(solution, "aaaaa", 2);
//            Check(solution, "aaaaaa", 2);
//            Check(solution, "00000111112222233333", 4);
//            Check(solution, "AAAAAAAAAAAAAAAAAAAAAAAAA", 11);
//            Check(solution, "aa123", 1);
//            Check(solution, "aaa123", 1);
//            Check(solution, "aaAA11", 0);
//            Check(solution, "1010101010aaaB10101010", 2);
//            Check(solution, "aaaabbaaabbaaa123456A", 3);
            Check(solution, "1Abababcaaaabababababa", 2);
            
        }

        private static void Check(Solution solution, string pwd, int check) {
            int answer = solution.StrongPasswordChecker(pwd);
            if (check != answer) {
                Console.WriteLine("'{0}' returned {1} expected {2}", pwd, answer, check);

                for (int index = 0; index < solution.Result.Count; index++) {
                    string s = solution.Result[index];
                    Console.WriteLine("   {0:00} = {1}", index, s);
                }
            } else {
                Console.WriteLine("'{0}' PASSED", pwd);
            }
        }

    }
}