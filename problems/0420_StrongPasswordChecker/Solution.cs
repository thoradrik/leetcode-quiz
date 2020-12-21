using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz {
    public class Solution {
        /*
         *
         * A password is considered strong if below conditions are all met:

    It has at least 6 characters and at most 20 characters.
    It must contain at least one lowercase letter, at least one uppercase letter, and at least one digit.
    It must NOT contain three repeating characters in a row ("...aaa..." is weak, but "...aa...a..." is strong, assuming other conditions are met).

Write a function strongPasswordChecker(s), that takes a string s as input, and return the MINIMUM change required to make s a strong password. If s is already strong, return 0.

Insertion, deletion or replace of any one character are all considered as one change.

         */

        public List<string> Result { get; private set; } = new List<string>();
        
        public int StrongPasswordChecker(string s) {
            Result.Clear();
            
            Str str = new Str(s);

            if (str.Length < 6) {
                for (int d = 2; d < str.Length; d++) {
                    if (str[d - 2] == str[d] && str[d - 1] == str[d]) {
                        if (str.LowerIndex < 0) {
                            Result.Add(str.Value);
                            str.Insert(d, GetUniqueFromSet(str, Str.LOWERS));
                        } else if (str.UpperIndex < 0) {
                            Result.Add(str.Value);
                            str.Insert(d, GetUniqueFromSet(str, Str.UPPERS));
                        } else if (str.NumberIndex < 0) {
                            Result.Add(str.Value);
                            str.Insert(d, GetUniqueFromSet(str, Str.NUMBERS));
                        } else {
                            Result.Add(str.Value);
                            str.Insert(d, GetUniqueFromSet(str, Str.ALPHABET));
                        }
                    }

                    if (str.Length >= 6) {
                        break;
                    }
                }
            } else if (str.Length > 20) {
                for (int d = 3; d < Math.Min(str.Length, 20); d++) {
                    if (str[d - 3] == str[d] && str[d - 2] == str[d] && str[d - 1] == str[d]) {
                        if (str.LowerIndex < 0) {
                            Result.Add(str.Value);
                            str.Replace(d - 1, GetUniqueFromSet(str, Str.LOWERS));
                        } else if (str.UpperIndex < 0) {
                            Result.Add(str.Value);
                            str.Replace(d - 1, GetUniqueFromSet(str, Str.UPPERS));
                        } else if (str.NumberIndex < 0) {
                            Result.Add(str.Value);
                            str.Replace(d - 1, GetUniqueFromSet(str, Str.NUMBERS));
                        } else {
                            Result.Add(str.Value);
                            str.Replace(d - 1, GetUniqueFromSet(str, Str.ALPHABET));
                        }
                    }

                    if (str.Length <= 20) {
                        goto ok;
                    }
                }
                for (int d = 2; d < Math.Min(str.Length, 20); d++) {
                    if (str[d - 2] == str[d] && str[d - 1] == str[d]) {
                        Result.Add(str.Value);
                        str.Delete(d);
                    }

                    if (str.Length <= 20) {
                        goto ok;
                    }
                }
            ok: 
                ;
            }
            
            while (str.Length < 6) {
                if (str.LowerIndex < 0) {
                    Result.Add(str.Value);
                    str.Insert(0, GetUniqueFromSet(str, Str.LOWERS));
                } else if (str.UpperIndex < 0) {
                    Result.Add(str.Value);
                    str.Insert(0, GetUniqueFromSet(str, Str.UPPERS));
                } else if (str.NumberIndex < 0) {
                    Result.Add(str.Value);
                    str.Insert(0, GetUniqueFromSet(str, Str.NUMBERS));
                } else {
                    Result.Add(str.Value);
                    str.Insert(0, GetUniqueFromSet(str, Str.ALPHABET));
                }
            }

            for (int d = 2; d < Math.Min(str.Length, 20); d++) {
                if (str[d - 2] == str[d] && str[d - 1] == str[d]) {
                    if (str.LowerIndex < 0) {
                        Result.Add(str.Value);
                        str.Replace(d, GetUniqueFromSet(str, Str.LOWERS));
                    } else if (str.UpperIndex < 0) {
                        Result.Add(str.Value);
                        str.Replace(d, GetUniqueFromSet(str, Str.UPPERS));
                    } else if (str.NumberIndex < 0) {
                        Result.Add(str.Value);
                        str.Replace(d, GetUniqueFromSet(str, Str.NUMBERS));
                    } else {
                        Result.Add(str.Value);
                        str.Replace(d, GetUniqueFromSet(str, Str.ALPHABET));
                    }
                }
            }
            

            if (str.Length > 20) {
                int i = str.Length - 1;
                while (str.Length > 20) {
                    if ((i != str.UpperIndex) && (i != str.LowerIndex) && (i != str.NumberIndex)) {
                        Result.Add(str.Value);
                        str.Delete(i);
                    }
                    i--;
                }
            }

            if (str.LowerIndex < 0) {
                for (int i = 0; i < str.Length; i++) {
                    if ((i != str.UpperIndex) && (i != str.NumberIndex)) {
                        Result.Add(str.Value);
                        str.Replace(i, 'a');
                        break;
                    }
                }
            }

            if (str.UpperIndex < 0) {
                for (int i = 0; i < str.Length; i++) {
                    if ((i != str.LowerIndex) && (i != str.NumberIndex)) {
                        Result.Add(str.Value);
                        str.Replace(i, 'A');
                        break;
                    }
                }
            }

            if (str.NumberIndex < 0) {
                for (int i = 0; i < str.Length; i++) {
                    if ((i != str.UpperIndex) && (i != str.LowerIndex)) {
                        Result.Add(str.Value);
                        str.Replace(i, '0');
                        break;
                    }
                }
            }
            
            Result.Add(str.Value);
            
            return str.Mods;
        }

        private char GetUniqueFromSet(Str str, string alphabet) {
            for (int i = 0; i < alphabet.Length; i++) {
                char c = alphabet[i];
                if (!str.Contains(c)) {
                    return c;
                }
            }

            return alphabet[0];
        }

        private class Str {

            public Str(string value) {
                m_Value = new StringBuilder(value);
                EvaluateLowerIndex();
                EvaluateUpperIndex();
                EvaluateNumberIndex();
            }

            private readonly StringBuilder m_Value;

            public char this[int index] => m_Value[index];
            
            public int Length => m_Value.Length;

            public string Value => m_Value.ToString();
            
            public int Mods { get; private set; }

            public bool Contains(char c) {
                for (int i = 0; i < m_Value.Length; i++) {
                    if (m_Value[i] == c) {
                        return true;
                    }
                }
                return false;
            }

            public void Insert(int index, char c) {
                m_Value.Insert(index, c);
                Mods++;
                
                if (UpperIndex < 0) {
                    if (UPPERS_HS.Contains(c)) {
                        UpperIndex = index;
                    }
                } else if (UpperIndex >= index) {
                    if (UPPERS_HS.Contains(c)) {
                        UpperIndex = index;
                    } else {
                        UpperIndex++;
                    }
                }
                
                if (LowerIndex < 0) {
                    if (LOWERS_HS.Contains(c)) {
                        LowerIndex = index;
                    }
                } else if (LowerIndex >= index) {
                    if (LOWERS_HS.Contains(c)) {
                        LowerIndex = index;
                    } else {
                        LowerIndex++;
                    }
                }
                
                if (NumberIndex < 0) {
                    if (NUMBERS_HS.Contains(c)) {
                        NumberIndex = index;
                    }
                } else if (NumberIndex >= index) {
                    if (NUMBERS_HS.Contains(c)) {
                        NumberIndex = index;
                    } else {
                        NumberIndex++;
                    }
                }
            }

            public void Delete(int index) {
                m_Value.Remove(index, 1);
                Mods++;

                if (UpperIndex == index) {
                    EvaluateUpperIndex();
                } else if (UpperIndex > index) {
                    UpperIndex--;
                }

                if (LowerIndex == index) {
                    EvaluateLowerIndex();
                } else if (LowerIndex > index) {
                    LowerIndex--;
                }

                if (NumberIndex == index) {
                    EvaluateNumberIndex();
                } else if (NumberIndex > index) {
                    NumberIndex--;
                }
            }

            public void Replace(int index, char c) {
                m_Value[index] = c;
                Mods++;

                if (UpperIndex < 0) {
                    if (UPPERS_HS.Contains(c)) {
                        UpperIndex = index;
                    }
                } else if (UpperIndex == index) {
                    if (!UPPERS_HS.Contains(c)) {
                        EvaluateUpperIndex();
                    }
                }

                if (LowerIndex < 0) {
                    if (LOWERS_HS.Contains(c)) {
                        LowerIndex = index;
                    }
                } else if (LowerIndex == index) {
                    if (!LOWERS_HS.Contains(c)) {
                        EvaluateLowerIndex();
                    }
                }

                if (NumberIndex < 0) {
                    if (NUMBERS_HS.Contains(c)) {
                        NumberIndex = index;
                    }
                } else if (NumberIndex == index) {
                    if (!NUMBERS_HS.Contains(c)) {
                        EvaluateLowerIndex();
                    }
                }
            }

            public const string UPPERS = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
            
            private static readonly HashSet<char> UPPERS_HS = new HashSet<char>(UPPERS);
            
            public int UpperIndex { get; private set; }

            private void EvaluateUpperIndex() {
                for (int i = 0; i < m_Value.Length; i++) {
                    if (UPPERS_HS.Contains(m_Value[i])) {
                        UpperIndex = i;
                        return;
                    }
                }

                UpperIndex = -1;
            }
            
            public const string LOWERS = "abcdefghijklmnopqrstuvxyz";
            
            private static readonly HashSet<char> LOWERS_HS = new HashSet<char>(LOWERS);
            
            public int LowerIndex { get; private set; }

            private void EvaluateLowerIndex() {
                for (int i = 0; i < m_Value.Length; i++) {
                    if (LOWERS_HS.Contains(m_Value[i])) {
                        LowerIndex = i;
                        return;
                    }
                }

                LowerIndex = -1;
            }
            
            public const string NUMBERS = "0123456789";
            
            private static readonly HashSet<char> NUMBERS_HS = new HashSet<char>(NUMBERS);

            public int NumberIndex { get; private set; }

            private void EvaluateNumberIndex() {
                for (int i = 0; i < m_Value.Length; i++) {
                    if (NUMBERS_HS.Contains(m_Value[i])) {
                        NumberIndex = i;
                        return;
                    }
                }

                NumberIndex = -1;
            }

            public const string ALPHABET = "01abAB23456789cdefghijklmnopqrstuvxyzCDEFGHIJKLMNOPQRSTUVXYZ";
            

        }
        
    }
}