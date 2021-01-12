using System;

namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.LastSubstring, "", "");
            Test.Check(solution.LastSubstring, "a", "a");
            Test.Check(solution.LastSubstring, "ab", "b");
            Test.Check(solution.LastSubstring, "abc", "c");
            Test.Check(solution.LastSubstring, "abcb", "cb");
            Test.Check(solution.LastSubstring, "abcba", "cba");
            Test.Check(solution.LastSubstring, "aaa", "aaa");
            Test.Check(solution.LastSubstring, "zyx", "zyx");
            Test.Check(solution.LastSubstring, "zyxzzyx", "zzyx");
            Test.Check(solution.LastSubstring, "abab", "bab");
            Test.Check(solution.LastSubstring, "leetcode", "tcode");
            Test.Check(solution.LastSubstring, "cacacb", "cb");
            Test.Check(solution.LastSubstring, "cacacbcbd", "d");
            Test.Check(solution.LastSubstring, "cacacbcbdadae", "e");
            Test.Check(solution.LastSubstring, "ecacacbcbdadae", "ecacacbcbdadae");
            Test.Check(solution.LastSubstring, "decacacbcbdadae", "ecacacbcbdadae");
            Test.Check(solution.LastSubstring, new String('A', 40000), new String('A', 40000));
            Test.Check(solution.LastSubstring, new String('A', 40000)+"B", "B");
        }

    }
}