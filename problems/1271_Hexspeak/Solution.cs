using System.Text;

namespace Quiz {
    public class Solution {
        
        public string ToHexspeak(string num) {
            StringBuilder hex = new StringBuilder();

            long acc = 0;

            for (int i = 0; i < num.Length; i++) {
                acc *= 10;
                acc += num[i] - '0';
            }

            while (acc > 0 || hex.Length == 0) {
                switch (acc % 0x10) {
                    case 0x0: hex.Insert(0, "O"); break;
                    case 0x1: hex.Insert(0, "I"); break;
                    case 0xA: hex.Insert(0, "A"); break;
                    case 0xB: hex.Insert(0, "B"); break;
                    case 0xC: hex.Insert(0, "C"); break;
                    case 0xD: hex.Insert(0, "D"); break;
                    case 0xE: hex.Insert(0, "E"); break;
                    case 0xF: hex.Insert(0, "F"); break;
                    default: return "ERROR";
                }
                acc >>= 4;
            }
            
            return hex.ToString();
        }
        
    }
}