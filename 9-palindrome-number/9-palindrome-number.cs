public class Solution {
    public bool IsPalindrome(int x) {
        int y = x, r = 0;
        while (y>0){
            r = r * 10;
            r = r + y % 10;
            y = y / 10;
        }
        
        bool res = (r == x) ? true : false;
        
        return res;
        }
    }
