public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        for (int i = 0; i <= matrix.Length-1; i++)
        {
            if(matrix[i][matrix[i].Length-1] == target)
            {
                return true;
            }
            if (matrix[i][matrix[i].Length - 1] > target)
            {
                if(matrix[i][0] > target)
                {
                    return false;
                }
                int left = 0;
                int right = matrix[i].Length - 1;
                
                while (left <= right)
                {
                    int mid = (left + right) / 2;
                    if (matrix[i][mid] < target)
                    {
                        left = mid + 1;
                    }
                    else if (matrix[i][mid] > target)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        return true; 
                    }
                }
            }
        }
        return false;
    }
}
