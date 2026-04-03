public class Solution {
    public int NumIslands(char[][] grid) {
        if (grid == null || grid.Length == 0) return 0;

        int rows = grid.Length;
        int cols = grid[0].Length;
        var visited = new HashSet<(int, int)>();
        int count = 0;

        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (grid[r][c] == '1' && !visited.Contains((r, c))) {
                    DFS(grid, r, c, visited);
                    count++;  // New island found
                }
            }
        }

        return count;
    }

    private void DFS(char[][] grid, int r, int c, HashSet<(int, int)> visited) {
        int rows = grid.Length;
        int cols = grid[0].Length;

        // Boundary and base case checks
        if (r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] == '0' || visited.Contains((r, c))) {
            return;
        }

        visited.Add((r, c));

        // Explore all 4 directions
        DFS(grid, r - 1, c, visited); // up
        DFS(grid, r + 1, c, visited); // down
        DFS(grid, r, c - 1, visited); // left
        DFS(grid, r, c + 1, visited); // right
    }
}
