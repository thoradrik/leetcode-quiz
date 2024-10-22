namespace Quiz;

public class Solution {
    
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int mine = tickets[k];

        int sum = mine;
        
        for (var i = 0; i < k; i++) {
            sum += Math.Min(tickets[i], mine);
        }
        
        for (int i = k + 1; i < tickets.Length; i++) {
            sum += Math.Min(tickets[i], mine - 1);
        }

        return sum;
    }
    
}
