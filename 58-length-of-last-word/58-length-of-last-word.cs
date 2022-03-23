public class Solution {
    public int LengthOfLastWord(string s) {
        int c = 0;
        for (int i = s.Length - 1; i >= 0; i--){
            if (s[i] != ' '){
                c++;
            }
            
            else{
                if(c > 0){
                    return c;
                }
            }
        }
        
        return c;
    }
}

//char[] chars = s.trim().toCharArray(); 