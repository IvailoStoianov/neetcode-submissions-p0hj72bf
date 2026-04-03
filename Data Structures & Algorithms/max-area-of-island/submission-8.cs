public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int r = grid.Length;
        int c = grid[0].Length;
        int maxArea = 0;
        var visited = new HashSet<(int,int)>();

        for(int i = 0; i < r; i++)
        {
            for(int j = 0; j < c; j++)
            {
                if(!visited.Contains((i,j)))
                {
                    int area = Dfs(grid, i,j,visited,0);
                    if(area > maxArea)
                    {
                        maxArea = area;
                    }
                }
                visited.Add((r,c));
            }
        }
        return maxArea;
    }
    private int Dfs(int[][] grid, int r, int c, HashSet<(int,int)> visited, int count)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        if (r < 0 ||
         c < 0 ||
          r >= rows ||
           c >= cols ||
            grid[r][c] == 0 ||
             visited.Contains((r, c))) 
        {
            return 0;
        }
        visited.Add((r,c));

        count = 1;
        
        count+= Dfs(grid, r+1,c,visited,count);
        count+= Dfs(grid, r-1,c,visited,count);
        count+= Dfs(grid, r,c+1,visited,count);
        count+= Dfs(grid, r,c-1,visited,count);

        return count;
    }
}
