namespace AlgorithmLib;

public static class PermutationGenerator {

    public static void Generate<T>(T[] array, Action<T[]> output) {
        var stack = new int[array.Length];
        var ptr = 0;

        output(array);

        while (ptr < array.Length) {
            if (stack[ptr] < ptr) {
                if (ptr % 2 == 0) {
                    Swap(ref array[0], ref array[ptr]);
                } else {
                    Swap(ref array[stack[ptr]], ref array[ptr]);
                }

                output(array);

                stack[ptr]++;
                ptr = 0;
            } else {
                stack[ptr] = 0;
                ptr++;
            }
        }
    }

    private static void Swap<T>(ref T a, ref T b) {
        var tmp = a;
        a = b;
        b = tmp;
    }

}
