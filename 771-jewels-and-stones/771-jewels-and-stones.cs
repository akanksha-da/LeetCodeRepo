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

/*public int numJewelsInStones(String jewels, String stones) {
        int result = 0;
        for(int i = 0; i < stones.length(); i++){
            if(jewels.indexOf(stones.charAt(i)) != -1){
                result++;
            }
        }
        return result;
    }*/