using System;

namespace Quiz {
    public class Solution {

        private const int STATE_WHITESPACE = 0;
        private const int STATE_PLUSMINUS = 1;
        private const int STATE_NUMBER = 2;
        
        public int MyAtoi(string str) {
            char[] cs = str.ToCharArray();

            int status = STATE_WHITESPACE;
            bool sign = true;
            long result = 0;

            for (int i = 0; i < cs.Length; i++) {
                char c = cs[i];

                if (c == ' ') {
                    if (status == STATE_WHITESPACE) {
                        status = STATE_WHITESPACE;
                    } else if (status == STATE_NUMBER) {
                        break;
                    } else {
                        return 0;
                    }
                } else if (c == '-') {
                    if (status == STATE_WHITESPACE) {
                        sign = false;
                        status = STATE_PLUSMINUS;
                    } else if (status == STATE_NUMBER) {
                        break;
                    } else {
                        return 0;
                    }
                } else if (c == '+') {
                    if (status == STATE_WHITESPACE) {
                        sign = true;
                        status = STATE_PLUSMINUS;
                    } else if (status == STATE_NUMBER) {
                        break;
                    } else {
                        return 0;
                    }
                } else if (c >= '0' && c <= '9') {
                    if (status == STATE_WHITESPACE || status == STATE_PLUSMINUS || status == STATE_NUMBER) {
                        int n = c - '0';
                        result = result * 10 + n;
                       
                        if (result > Int32.MaxValue) {
                            if (sign) {
                                return Int32.MaxValue;
                            } else {
                                return Int32.MinValue;
                            }
                        }
                        
                        status = STATE_NUMBER;
                    } else {
                        return 0;
                    }
                } else {
                    break;
                }
            }
            
            return (int)(sign ? result : -result);
        }
        
    }
}