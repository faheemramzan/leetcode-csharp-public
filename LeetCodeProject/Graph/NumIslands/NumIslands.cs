/// <summary>
/// https://leetcode.com/problems/number-of-islands/
/// </summary>
public class Solution {
    public int NumIslands(char[][] grid)
    {
        var numIslands = 0;
        var rowCount = grid.Length;
        var columnCount = grid[0].Length;

        var visited = new HashSet<Tuple<int, int>>();

        void recursiveNumIslands(int r, int c)
        {
            Console.WriteLine($"r: {r}, c: {c}");
            var tuple = new Tuple<int, int>(r, c);
            if ((r < 0 || c < 0) || 
                (r >= rowCount || c >= columnCount) || 
                grid[r][c] != '1' || 
                visited.Contains(tuple))
            {
                return;
            }
            
            Console.WriteLine($"grid[r][c]: {grid[r][c]}");

            visited.Add(tuple);

            var directions = new[]
            {
                new Tuple<int, int>(1, 0),
                new Tuple<int, int>(-1, 0),
                new Tuple<int, int>(0, 1),
                new Tuple<int, int>(0, -1)
            };
            
            foreach (var d in directions)
            {
                recursiveNumIslands(r + d.Item1, c + d.Item2);
            }
        }

        for (var r = 0; r < rowCount; r++)
        {
            for (var c = 0; c < columnCount; c++)
            {   
                Console.WriteLine("------------------------");
                Console.WriteLine("----------INIT----------");
                Console.WriteLine("-----------------------");
                
                var tuple = new Tuple<int, int>(r, c);
                if (!visited.Contains(tuple) && grid[r][c] == '1')
                {
                    numIslands++;
                    recursiveNumIslands(r, c);
                }
            }
        }

        return numIslands;
    }
}