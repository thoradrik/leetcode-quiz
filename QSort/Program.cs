using System;
using System.Collections.Generic;

namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            int[] array = new int[20];

            for (int i = 0; i < array.Length; i++) {
                array[i] = i % 2 + i % 3 + i % 9;
            }
            
            for (int i = 0; i < array.Length; i++) {
                Console.Write("{0:00} ", array[i]);
            }
            
            Console.WriteLine(" ");
            
            Solution solution = new Solution();

            solution.QSort(array, Comparer<int>.Default);
            
            for (int i = 0; i < array.Length; i++) {
                Console.Write("{0:00} ", array[i]);
            }
            
            Console.WriteLine(" ");
        }

    }
}