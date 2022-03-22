public class Solution {
    public int NumIslands(char[][] grid) {
        //int maxSize = 0;
        int size = 0;
        
        for (int row = 0; row < grid.Length; row++){
            for (int column = 0; column < grid[0].Length; column++){
                if(grid[row][column] == '1'){
                    size++;
                    getIslandSize(grid, row, column);
                }
            }
        }
        return size;
    }
    
    
    public void getIslandSize(char[][] matrix, int r, int c){
        if(r < 0 || c < 0 || r >= matrix.Length || c >= matrix[0].Length){
            return ;
        }
        
        if (matrix[r][c] == '0'){
            return ;
        }
        
        matrix[r][c] = '0';
        
        getIslandSize(matrix, r+1, c);
        getIslandSize(matrix, r-1, c);
        getIslandSize(matrix, r, c+1);
        getIslandSize(matrix, r, c-1);
        
       
    }
}