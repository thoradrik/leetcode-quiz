using System.Text;

namespace Quiz;

public class Solution {
    public string IntToRoman(int num) {
        var sb = new StringBuilder();

        Write(ref num, sb, 1000, "M");
        Write(ref num, sb, 900, "CM");
        Write(ref num, sb, 500, "D");
        Write(ref num, sb, 400, "CD");
        Write(ref num, sb, 100, "C");
        Write(ref num, sb, 90, "XC");
        Write(ref num, sb, 50, "L");
        Write(ref num, sb, 40, "XL");
        Write(ref num, sb, 10, "X");
        Write(ref num, sb, 9, "IX");
        Write(ref num, sb, 5, "V");
        Write(ref num, sb, 4, "IV");
        Write(ref num, sb, 1, "I");

        return sb.ToString();
    }

    private void Write(ref int num, StringBuilder sb, int value, string literal) {
        while (num >= value) {
            sb.Append(literal);
            num -= value;
        }
    }
}
