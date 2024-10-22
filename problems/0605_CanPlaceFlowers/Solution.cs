namespace Quiz {
    public class Solution {

        public bool CanPlaceFlowers(int[] flowerbed, int n) {
            if (n <= 0) {
                return true;
            }

            for (var i = 0; i < flowerbed.Length; i++) {
                if (flowerbed[i] > 0) {
                    if (i > 0) {
                        flowerbed[i - 1] = -1;
                    }
                    if (i < flowerbed.Length - 1) {
                        flowerbed[i + 1] = -1;
                    }
                }
            }

            for (var i = 0; i < flowerbed.Length; i++) {
                if (flowerbed[i] == 0) {
                    n--;

                    if (n <= 0) {
                        return true;
                    }

                    i++;
                }
            }

            return false;
        }

    }
}
