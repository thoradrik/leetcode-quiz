using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using AlgorithmLib;

namespace Quiz {
    public class Solution {

        public IList<string> LetterCasePermutation(string S) {
            var list = new List<string>();

            CombinationGenerator.Generate(
                S.Length,
                ptr => IsLetter(S[ptr]) ? 2 : 1,
                (ptr, index) => index,
                flags => {
                    var sb = new StringBuilder(S.Length);

                    for (var i = 0; i < flags.Length; i++) {
                        char c = S[i];

                        if (IsLower(c)) {
                            sb.Append(flags[i] == 0 ? c : ToUpper(c));
                        } else if (IsUpper(c)) {
                            sb.Append(flags[i] == 0 ? ToLower(c) : c);
                        } else {
                            sb.Append(c);
                        }
                    }

                    list.Add(sb.ToString());
                }
            );

            return list;
        }

        [ MethodImpl(MethodImplOptions.AggressiveInlining) ]
        private bool IsLetter(char c) => IsUpper(c) || IsLower(c);

        [ MethodImpl(MethodImplOptions.AggressiveInlining) ]
        private bool IsUpper(char c) => c >= 'A' && c <= 'Z';

        [ MethodImpl(MethodImplOptions.AggressiveInlining) ]
        private bool IsLower(char c) => c >= 'a' && c <= 'z';

        [ MethodImpl(MethodImplOptions.AggressiveInlining) ]
        private char ToLower(char c) => (char)((c - 'A') + 'a');

        [ MethodImpl(MethodImplOptions.AggressiveInlining) ]
        private char ToUpper(char c) => (char)((c - 'a') + 'A');

    }
}
