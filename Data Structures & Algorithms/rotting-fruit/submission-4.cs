public class Solution {
    public int OrangesRotting(int[][] grid) {
        var visited = new HashSet<(int,int)>();
        var notRotten = new HashSet<(int,int)>();
        var q = new Queue<(int,int)>();
        int rows = grid.Length;
        int columns = grid[0].Length;
        int length = 0;        

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                if(grid[i][j] == 2)
                {
                    q.Enqueue((i,j));
                    visited.Add((i,j));
                }
                if(grid[i][j] == 1)
                {
                    notRotten.Add((i,j));
                }
            }
        }

        (int dr, int dc)[] directions = new (int, int)[] {
            (0, 1), (1, 0), (0, -1), (-1, 0)
        };

        while(q.Count > 0)
        {
            int size = q.Count;
            bool anyNewRotten = false;

            for(int i = 0; i < size; i++)
            {
                (int r, int c) = q.Dequeue();

                foreach (var (dr, dc) in directions) 
                {
                    int nr = r + dr;
                    int nc = c + dc;

                    if(nr == rows || nc == columns || nr < 0 || nc < 0 || visited.Contains((nr,nc)))
                    {
                        continue;
                    }
                    if(grid[nr][nc] == 1)
                    {
                        q.Enqueue((nr,nc));
                        visited.Add((nr,nc));
                        notRotten.Remove((nr,nc));
                        anyNewRotten = true;
                    }
                }
            }
            if(anyNewRotten)
            {
                length++;
            }
            
        }
        if(notRotten.Count > 0)
        {
            return -1;
        }
        return length;
    }
}
