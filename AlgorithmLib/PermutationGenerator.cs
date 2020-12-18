using System;
using System.Collections.Generic;

namespace AlgorithmLib {
    public static class PermutationGenerator {

        public static IEnumerable<T[]> Enumerate<T>(T[] array) {
            int[] stack = new int[array.Length];
            int ptr = 0;

            yield return array;

            while (ptr < array.Length) {
                if (stack[ptr] < ptr) {
                    if (ptr % 2 == 0) {
                        Swap(ref array[0], ref array[ptr]);
                    } else {
                        Swap(ref array[stack[ptr]], ref array[ptr]);
                    }

                    yield return array;

                    stack[ptr]++;
                    ptr = 0;
                } else {
                    stack[ptr] = 0;
                    ptr++;
                }
            }
        }

        public static void Generate<T>(T[] array, Action<T[]> output) {
            int[] stack = new int[array.Length];
            int ptr = 0;

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
            T tmp = a;
            a = b;
            b = tmp;
        }
        
    }
}