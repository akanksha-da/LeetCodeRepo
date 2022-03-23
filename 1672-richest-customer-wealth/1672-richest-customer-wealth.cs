public class Solution {
    public int MaximumWealth(int[][] accounts) {
        
        int maxSum = 0;
        int sum = 0;
        
        for (int i = 0; i < accounts.Length; i++){
            sum = 0;
            for (int j = 0; j < accounts[0].Length; j++){
                                
                sum = sum + accounts[i][j];
                
                }
            maxSum = maxSum > sum ? maxSum: sum;
            }
        return maxSum;
        }
        
    }
