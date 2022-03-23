public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        
        int count = 0;
        
        foreach (char j in jewels){
            foreach (char i in stones){
                if(i == j)                    
                count++;
                
            }
        }
        return count;
    }
}