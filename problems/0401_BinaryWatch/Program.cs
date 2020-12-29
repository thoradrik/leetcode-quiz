namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            // Test.Check(solution.ReadBinaryWatch, 0, StringArray("[\"0:00\"]"));
            // Test.Check(solution.ReadBinaryWatch, 1, StringArray("[\"0:01\", \"0:02\", \"0:04\", \"0:08\", \"0:16\", \"0:32\", \"1:00\", \"2:00\", \"4:00\", \"8:00\"]"));
            // Test.Print(solution.ReadBinaryWatch, 2);
            // Test.Print(solution.ReadBinaryWatch, 3);
            // Test.Print(solution.ReadBinaryWatch, 4);
            // Test.Print(solution.ReadBinaryWatch, 5);
            Test.Print(solution.ReadBinaryWatch, 6);
            Test.Print(solution.ReadBinaryWatch, 7);
            Test.Print(solution.ReadBinaryWatch, 8);
            Test.Print(solution.ReadBinaryWatch, 9);
            Test.Print(solution.ReadBinaryWatch, 10);
        }

    }
}