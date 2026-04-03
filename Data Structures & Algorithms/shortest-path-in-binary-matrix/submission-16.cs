public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        var visited = new HashSet<(int,int)>();
        var q = new Queue<(int,int)>();
        int length = 1;
        int rows = grid.Length;
        int columns = grid[0].Length;
        if(grid[0][0] == 1 || grid[rows - 1][columns - 1] == 1)
        {
            return -1;
        }
        q.Enqueue((0,0));
        visited.Add((0,0));
        (int dr, int dc)[] directions = new (int, int)[] {
            (0, 1), (1, 0), (0, -1), (-1, 0),
            (1, 1), (-1, -1), (1, -1), (-1, 1)
        };
        while(q.Count != 0)
        {
            int size = q.Count;
            for (int i = 0; i < size; i++) {
                (int r, int c) = q.Dequeue();
                if(r == rows-1 && c == columns-1)
                {
                    return length;
                }

                

                foreach(var (dr, dc) in directions)
                {
                    int nr = r + dr;
                    int nc = c + dc;

                    if (nr < 0 || nc < 0 || nr >= rows || nc >= columns)
                        continue;
                    if (grid[nr][nc] == 1 || visited.Contains((nr, nc)))
                        continue;

                    q.Enqueue((nr, nc));
                    visited.Add((nr, nc));
                }
            }
            length++;
        }
        return -1;
    }
}