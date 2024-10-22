using System.Text;

namespace Quiz;

public class Solution {

    private static readonly string[] TEENS = [
        null,
        "One",
        "Two",
        "Three",
        "Four",
        "Five",
        "Six",
        "Seven",
        "Eight",
        "Nine",
        "Ten",
        "Eleven",
        "Twelve",
        "Thirteen",
        "Fourteen",
        "Fifteen",
        "Sixteen",
        "Seventeen",
        "Eighteen",
        "Nineteen"
    ];

    private static readonly string[] DECADES = [
        "Zero",
        "Ten",
        "Twenty",
        "Thirty",
        "Forty",
        "Fifty",
        "Sixty",
        "Seventy",
        "Eighty",
        "Ninety"
    ];

    public string NumberToWords(int num) {
        if (num <= 0) {
            return "Zero";
        }

        var sb = new StringBuilder();
        Build(sb, num);
        return sb.ToString();
    }

    private void Build(StringBuilder sb, int num) {
        if (num < 20) {
            AddWord(sb, TEENS[num]);
        } else if (num < 100) {
            AddWord(sb, DECADES[num / 10]);
            AddWord(sb, TEENS[num % 10]);
        } else if (num < 1000) {
            var hundreds = num / 100;
            Build(sb, hundreds);
            AddWord(sb, "Hundred");
            int decades = num % 100;
            Build(sb, decades);
        } else if (num < 1000000) {
            var thousands = num / 1000;
            Build(sb, thousands);
            AddWord(sb, "Thousand");
            int hudreeds = num % 1000;
            Build(sb, hudreeds);
        } else if (num < 1000000000) {
            var millions = num / 1000000;
            Build(sb, millions);
            AddWord(sb, "Million");
            int thousands = num % 1000000;
            Build(sb, thousands);
        } else {
            var billions = num / 1000000000;
            Build(sb, billions);
            AddWord(sb, "Billion");
            int millions = num % 1000000000;
            Build(sb, millions);
        }
    }

    private void AddWord(StringBuilder sb, string word) {
        if (word == null) {
            return;
        }

        if (sb.Length > 0) {
            sb.Append(" ");
        }

        sb.Append(word);
    }
}
