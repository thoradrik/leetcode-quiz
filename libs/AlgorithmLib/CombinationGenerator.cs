using System;
using System.Collections.Generic;

namespace AlgorithmLib {
    public static class CombinationGenerator {

        public static void Generate<T>(T[] array, int length, Action<T[]> output) {
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
        
    }
}