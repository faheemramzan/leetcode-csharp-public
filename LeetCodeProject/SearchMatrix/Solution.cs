namespace TestProject.SearchMatrix;
/// <summary>
/// https://leetcode.com/problems/search-a-2d-matrix/
/// </summary>
public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        if (matrix.Length == 0)
            return false;
            
        var rowsCount = matrix.Length;
        var columnsCount = matrix[0].Length;
        
        var top = 0;
        var bottom = rowsCount - 1;
        var row = 0;

        while (top <= bottom)
        {
            row = (top + bottom) / 2;
            
            if (target < matrix[row][0])
            {
                bottom = row - 1;
            }
            else if (target > matrix[row][columnsCount - 1])
            {
                top = row + 1;
            }
            else
            {
                break;
            }
        }

        if (top > bottom)
            return false;

        var left = 0;
        var right = columnsCount - 1;
        while (left <= right)
        {
            var middle = (left + right) / 2;
            if (target < matrix[row][middle])
            {
                right = middle - 1;
            }
            else if (target > matrix[row][middle])
            {
                left = middle + 1;
            }
            else
            {
                return true;
            }
        }
        
        return false;
    }
}