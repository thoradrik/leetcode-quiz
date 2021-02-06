using System;

namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();
/*
            Test.Check(solution.StrStr, "", "", 0);
            Test.Check(solution.StrStr, "a", "b", -1);
            Test.Check(solution.StrStr, "a", "a", 0);
            Test.Check(solution.StrStr, "aa", "a", 0);
            Test.Check(solution.StrStr, "ba", "a", 1);
            Test.Check(solution.StrStr, "baca", "a", 1);
            Test.Check(solution.StrStr, "baca", "ac", 1);
            Test.Check(solution.StrStr, "baca", "aca", 1);
            Test.Check(solution.StrStr, "bacac", "acb", -1);
            Test.Check(solution.StrStr, "bacad", "ac", 1);
            Test.Check(solution.StrStr, "bacad", "ad", 3);
            Test.Check(solution.StrStr, "babaabaa", "aa", 3);
            Test.Check(solution.StrStr, "baaabaabaacbaad", "baac", 7);
            Test.Check(solution.StrStr, "hello", "hello1", -1);
            Test.Check(solution.StrStr, "hello", "ll", 2);
*/

            string s = "abcdefghzzzzzzzzzzzlrjflkwerfljwerlkfjweklrfjlwkejrfkl";
            int len = 10;

            int index = 6;
            int hash = Solution.Hash(s, index, len);
            Console.WriteLine("{0} = {1} *", s.Substring(index, len), hash);

            for (int i = 0; i < s.Length - len; i++) {
                if (i == 0) {
                    hash = Solution.Hash(s, 0, len);
                } else {
                    hash = Solution.Hash(hash, s[i - 1], s[i + len - 1]);
                }
                
                Console.WriteLine("{0} = {1}", s.Substring(i, len), hash);
            }
        }

    }
}