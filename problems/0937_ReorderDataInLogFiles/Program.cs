namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Solution();

            Test.Check(solution.ReorderLogFiles, StringArray("[\"dig1 8 1 5 1\",\"let1 art can\",\"dig2 3 6\",\"let2 own kit dig\",\"let3 art zero\"]"), StringArray("[\"let1 art can\",\"let3 art zero\",\"let2 own kit dig\",\"dig1 8 1 5 1\",\"dig2 3 6\"]"));
            Test.Check(solution.ReorderLogFiles, StringArray("[\"a1 9 2 3 1\",\"g1 act car\",\"zo4 4 7\",\"ab1 off key dog\",\"a8 act zoo\"]"), StringArray("[\"g1 act car\",\"a8 act zoo\",\"ab1 off key dog\",\"a1 9 2 3 1\",\"zo4 4 7\"]"));

            Test.Check(solution.ReorderLogFiles,
                StringArray("[\"l5sh 6 3869 08 1295\", \"16o 94884717383724 9\", \"43 490972281212 3 51\", \"9 ehyjki ngcoobi mi\", \"2epy 85881033085988\", \"7z fqkbxxqfks f y dg\", \"9h4p 5 791738 954209\", \"p i hz uubk id s m l\", \"wd lfqgmu pvklkdp u\", \"m4jl 225084707500464\", \"6np2 bqrrqt q vtap h\", \"e mpgfn bfkylg zewmg\", \"ttzoz 035658365825 9\", \"k5pkn 88312912782538\", \"ry9 8231674347096 00\", \"w 831 74626 07 353 9\", \"bxao armngjllmvqwn q\", \"0uoj 9 8896814034171\", \"0 81650258784962331\", \"t3df gjjn nxbrryos b\"]"),
                StringArray("[\"bxao armngjllmvqwn q\",\"6np2 bqrrqt q vtap h\",\"9 ehyjki ngcoobi mi\",\"7z fqkbxxqfks f y dg\",\"t3df gjjn nxbrryos b\",\"p i hz uubk id s m l\",\"wd lfqgmu pvklkdp u\",\"e mpgfn bfkylg zewmg\",\"l5sh 6 3869 08 1295\",\"16o 94884717383724 9\",\"43 490972281212 3 51\",\"2epy 85881033085988\",\"9h4p 5 791738 954209\",\"m4jl 225084707500464\",\"ttzoz 035658365825 9\",\"k5pkn 88312912782538\",\"ry9 8231674347096 00\",\"w 831 74626 07 353 9\",\"0uoj 9 8896814034171\",\"0 81650258784962331\"]")
            );
        }

    }
}
