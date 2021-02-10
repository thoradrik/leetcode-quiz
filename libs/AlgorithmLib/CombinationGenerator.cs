using System;
using System.Collections.Generic;

namespace AlgorithmLib {
    public static class CombinationGenerator {

        public static void Generate<T>(int length, T[] array, Action<T[]> output) {
            int[] stack = new int[length];
            int ptr = 0;
            
            T[] result = new T[length];

            do {
                if (ptr < length) {
                    int index = stack[ptr];
                    if (index < array.Length) {
                        result[ptr] = array[index];
                        ptr++;
                    } else {
                        stack[ptr] = 0;
                        ptr--;
                        if (ptr < 0) {
                            break;
                        } else {
                            stack[ptr]++;
                        }
                    }
                } else {
                    output(result);
                    ptr--;
                    stack[ptr]++;
                }
            } while (true);
        }

        public static void Generate<T>(int length, T[][] array, Action<T[]> output) {
            int[] stack = new int[length];
            int ptr = 0;
            
            T[] result = new T[length];

            do {
                if (ptr < length) {
                    int index = stack[ptr];
                    if (index < array[ptr].Length) {
                        result[ptr] = array[ptr][index];
                        ptr++;
                    } else {
                        stack[ptr] = 0;
                        ptr--;
                        if (ptr < 0) {
                            break;
                        } else {
                            stack[ptr]++;
                        }
                    }
                } else {
                    output(result);
                    ptr--;
                    stack[ptr]++;
                }
            } while (true);
        }

        public static void Generate<T>(int length, IList<IList<T>> array, Action<T[]> output) {
            int[] stack = new int[length];
            int ptr = 0;
            
            T[] result = new T[length];

            do {
                if (ptr < length) {
                    int index = stack[ptr];
                    if (index < array[ptr].Count) {
                        result[ptr] = array[ptr][index];
                        ptr++;
                    } else {
                        stack[ptr] = 0;
                        ptr--;
                        if (ptr < 0) {
                            break;
                        } else {
                            stack[ptr]++;
                        }
                    }
                } else {
                    output(result);
                    ptr--;
                    stack[ptr]++;
                }
            } while (true);
        }

        public static void Generate<T>(int length, Func<int, int> count_of_variants_at_index, Func<int, int, T> variant_at_index, Action<T[]> output) {
            int[] stack = new int[length];
            int ptr = 0;
            
            T[] result = new T[length];

            do {
                if (ptr < length) {
                    int index = stack[ptr];
                    if (index < count_of_variants_at_index(ptr)) {
                        result[ptr] = variant_at_index(ptr, index);
                        ptr++;
                    } else {
                        stack[ptr] = 0;
                        ptr--;
                        if (ptr < 0) {
                            break;
                        } else {
                            stack[ptr]++;
                        }
                    }
                } else {
                    output(result);
                    ptr--;
                    stack[ptr]++;
                }
            } while (true);
        }
        
    }
}