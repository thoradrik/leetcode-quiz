namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.LongestPalindromeSubseq, "a", 1);
            Test.Check(solution.LongestPalindromeSubseq, "aa", 2);
            Test.Check(solution.LongestPalindromeSubseq, "aba", 3);
            Test.Check(solution.LongestPalindromeSubseq, "abca", 3);
            Test.Check(solution.LongestPalindromeSubseq, "abcda", 3);
            Test.Check(solution.LongestPalindromeSubseq, "abcdea", 3);
            Test.Check(solution.LongestPalindromeSubseq, "adbac", 3);
            Test.Check(solution.LongestPalindromeSubseq, "dabkac", 3);
            Test.Check(solution.LongestPalindromeSubseq, "cdabkac", 5);
            Test.Check(solution.LongestPalindromeSubseq, "zcdabkacl", 5);
            Test.Check(solution.LongestPalindromeSubseq, "zcdabkaclz", 7);
            Test.Check(solution.LongestPalindromeSubseq, "aaaabbbbbbbbbbccccccccccddddddddddeeeeeeeeeeffffffffffgggggggggghhhhhhhhhhiiiiiiiiiijjjjjjjjjjkkkkkkkkkkllllllllllmmmmmmmmmmnnnnnnnnnnooooooooooppppppppppqqqqqqqqqqrrrrrrrrrrssssssssssttttttttttuuuuuuuuuuvvvvvvvvvvwwwwwwwwwwxxxxxxxxxxyyyyyyyyyyzzzzzzzzzzyyyyyyyyyyxxxxxxxxxxwwwwwwwwwwvvvvvvvvvvuuuuuuuuuuttttttttttssssssssssrrrrrrrrrrqqqqqqqqqqppppppppppoooooooooonnnnnnnnnnmmmmmmmmmmllllllllllkkkkkkkkkkjjjjjjjjjjiiiiiiiiiihhhhhhhhhhggggggggggffffffffffeeeeeeeeeeddddddddddccccccccccbbbbbbbbbbaaaaaaaabbbbbbbbbbccccccccccddddddddddeeeeeeeeeeffffffffffgggggggggghhhhhhhhhhiiiiiiiiiijjjjjjjjjjkkkkkkkkkkllllllllllmmmmmmmmmmnnnnnnnnnnooooooooooppppppppppqqqqqqqqqqrrrrrrrrrrssssssssssttttttttttuuuuuuuuuuvvvvvvvvvvwwwwwwwwwwxxxxxxxxxxyyyyyyyyyyzzzzzzzzzzyyyyyyyyyyxxxxxxxxxxwwwwwwwwwwvvvvvvvvvvuuuuuuuuuuttttttttttssssssssssrrrrrrrrrrqqqqqqqqqqppppppppppoooooooooonnnnnnnnnnmmmmmmmmmmllllllllllkkkkkkkkkkjjjjjjjjjjiiiiiiiiiihhhhhhhhhhggggggggggffffffffffeeeeeeeeeeddddddddddccccccccccbbbbbbbbbbaaaa", 996);
        }

    }
}
