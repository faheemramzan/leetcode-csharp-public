namespace TestProject.LongestCycle;

/// <summary>
/// https://leetcode.com/problems/longest-cycle-in-a-graph/
/// </summary>
public class Solution
{
    public int LongestCycle(int[] edges)
    {
        var answer = -1;
        var cycles = new List<Cycle>(Enumerable.Repeat(new Cycle(), edges.Length));
        
        for (var index = 0; index < edges.Length; ++index)
        {
            var edge = index;
            var distanceFromIndex = 0;

            while (true)
            {
                if (edge == -1)
                    break;
                    
                var cycle = cycles[edge];
                if (cycle.Visited)
                {
                    if (cycle.Index == index)
                    {
                        answer = Math.Max(answer, distanceFromIndex - cycle.Distance);
                    }
                    break;
                }
                
                cycles[edge] = new Cycle
                {
                    Index = index,
                    Edge = edge,
                    Distance = distanceFromIndex,
                    Visited = true
                };
                
                distanceFromIndex++;
                edge = edges[edge];
            }
        }
        
        return answer;
    }

    private class Cycle
    {
        public Cycle()
        {
            Index = -1;
            Distance = -1;
        }
        public int Index;
        public int Edge;
        public int Distance;
        public bool Visited;
    }

}