using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public class Item {

            public Item(int min, int count) {
                Min = min;
                Count = count;
            }

            public readonly int Min;

            public readonly int Count;

        }

        public int SumSubarrayMins(int[] arr) {
            long sum = 0;

            var stack = new Stack<Item>();

            var dot = 0;
            for (var i = 0; i < arr.Length; i++) {

                var count = 1;

                while (stack.TryPeek(out var item) && item.Min >= arr[i]) {
                    stack.Pop();
                    count += item.Count;
                    dot -= item.Min * item.Count;
                }

                stack.Push(new Item(arr[i], count));

                dot += arr[i] * count;
                sum += dot;
            }

            return (int)(sum % 1000000007);
        }

        public int SumSubarrayMins_Naive(int[] arr) {
            long sum = 0;

            for (var i = 0; i < arr.Length; i++) {
                int min = arr[i];
                for (int j = i; j < arr.Length; j++) {
                    int a = arr[j];
                    if (a < min) {
                        min = a;
                    }
                    sum += min;
                }
            }

            return (int)(sum % 1000000007);
        }


    }
}
