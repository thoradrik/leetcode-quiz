using System;

namespace Quiz {
    public class Solution {

        public int CountGoodTriplets(int[] arr, int a, int b, int c) {
            int count = 0;
            
            for (int i = 0; i < arr.Length - 2; i++) {
                int ai = arr[i];
                
                for (int j = i + 1; j < arr.Length - 1; j++) {
                    int aj = arr[j];
                    if (Math.Abs(ai - aj) > a) {
                        continue;
                    }
                    
                    for (int k = j + 1; k < arr.Length; k++) {
                        int ak = arr[k];
                        if (Math.Abs(aj - ak) > b) {
                            continue;
                        }
                        
                        if (Math.Abs(ak - ai) > c) {
                            continue;
                        }

                        count++;
                    }
                }   
            }

            return count;
        }

    }
}