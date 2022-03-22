public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int maxSize = 0;
        int size = 0;
        
        for (int row = 0; row < grid.Length; row++){
            for (int column = 0; column < grid[0].Length; column++){
                if(grid[row][column] == 1){                
                
                size = getAreaOfIsland(grid, row, column);
                maxSize = maxSize > size ? maxSize : size;
                    
                }
                
            }
        }
        
        return maxSize;
    }
    
    
    private int getAreaOfIsland(int[][] matrix, int r, int c){
        
        if(r < 0 || c < 0 || r >= matrix.Length || c >= matrix[0].Length)
            return 0;
        
        if(matrix[r][c] == 0)
            return 0;
        
        matrix[r][c] = 0;
        
        int size = 1;
        
        size = size + getAreaOfIsland(matrix, r+1, c);
        size = size + getAreaOfIsland(matrix, r-1, c);
    
        size = size + getAreaOfIsland(matrix, r, c+1); 
        size = size + getAreaOfIsland(matrix, r, c-1); 
    
        return size;
    
        
    }
}