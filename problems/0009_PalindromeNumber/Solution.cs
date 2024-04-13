namespace Quiz;

public class Solution {
        
    public bool IsPalindrome(int x) {
        if (x < 0) return false;
            
        if (x < 10) return true;

        int xx = x;
        int yy = 0;
        
        while (xx > 0) {
            int rem = xx % 10;

            yy = yy * 10 + rem;
            
            xx = xx / 10;
        }

        return yy == x;
    }
        
}