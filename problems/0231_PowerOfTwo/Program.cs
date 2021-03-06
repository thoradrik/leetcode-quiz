namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            Test.Check(solution.IsPowerOfTwo, 0, false);
            Test.Check(solution.IsPowerOfTwo, 1, true);
            Test.Check(solution.IsPowerOfTwo, 2, true);
            Test.Check(solution.IsPowerOfTwo, 3, false);
            Test.Check(solution.IsPowerOfTwo, 4, true);
            Test.Check(solution.IsPowerOfTwo, 5, false);
            Test.Check(solution.IsPowerOfTwo, 8, true);
            Test.Check(solution.IsPowerOfTwo, 9, false);
            Test.Check(solution.IsPowerOfTwo, 10, false);
            Test.Check(solution.IsPowerOfTwo, 15, false);
            Test.Check(solution.IsPowerOfTwo, 16, true);
            Test.Check(solution.IsPowerOfTwo, 31, false);
            Test.Check(solution.IsPowerOfTwo, 32, true);
            Test.Check(solution.IsPowerOfTwo, 64, true);
            Test.Check(solution.IsPowerOfTwo, 66, false);
            Test.Check(solution.IsPowerOfTwo, 128, true);
            Test.Check(solution.IsPowerOfTwo, 120, false);
            Test.Check(solution.IsPowerOfTwo, 256, true);
            Test.Check(solution.IsPowerOfTwo, 512, true);
            Test.Check(solution.IsPowerOfTwo, 1024, true);
            Test.Check(solution.IsPowerOfTwo, 1524, false);
            Test.Check(solution.IsPowerOfTwo, 2048, true);
            Test.Check(solution.IsPowerOfTwo, 4096, true);
            Test.Check(solution.IsPowerOfTwo, 8192, true);
            Test.Check(solution.IsPowerOfTwo, 16384, true);
            Test.Check(solution.IsPowerOfTwo, 32768, true);
            Test.Check(solution.IsPowerOfTwo, 65536, true);
            Test.Check(solution.IsPowerOfTwo, 131072, true);
            Test.Check(solution.IsPowerOfTwo, 262144, true);
            Test.Check(solution.IsPowerOfTwo, 524288, true);
            Test.Check(solution.IsPowerOfTwo, 1048576, true);
            Test.Check(solution.IsPowerOfTwo, 2097152, true);
            Test.Check(solution.IsPowerOfTwo, 4194304, true);
            Test.Check(solution.IsPowerOfTwo, 8388608, true);
            Test.Check(solution.IsPowerOfTwo, 16777216, true);
            Test.Check(solution.IsPowerOfTwo, 33554432, true);
            Test.Check(solution.IsPowerOfTwo, 67108864, true);
            Test.Check(solution.IsPowerOfTwo, 134217728, true);
            Test.Check(solution.IsPowerOfTwo, 268435456, true);
            Test.Check(solution.IsPowerOfTwo, 536870912, true);
            Test.Check(solution.IsPowerOfTwo, 1073741824, true);
            Test.Check(solution.IsPowerOfTwo, 2147483647, false);
            Test.Check(solution.IsPowerOfTwo, -2147483648, false);
        }

    }
}