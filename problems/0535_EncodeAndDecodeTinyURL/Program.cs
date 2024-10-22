namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var codec = new Codec();

            string[] urls = {
                "https://leetcode.com/problems/encode-and-decode/",
                "https://leetcode.com/problems/encode-and-decode-tinyurl/"
            };

            foreach (var url in urls) {
                Test.Check(codec.decode, codec.encode(url), url);
            }
        }

    }
}
