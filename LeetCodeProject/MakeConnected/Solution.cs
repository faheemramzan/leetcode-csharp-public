namespace TestProject.MakeConnected;

/// <summary>
/// https://leetcode.com/problems/number-of-operations-to-make-network-connected/
/// </summary>
public class Solution
{
    public int MakeConnected(int n, int[][] connections) {

        if(connections.Length < n - 1) {
            return -1;
        }

        Graph graph = new Graph(n);
        foreach(var connection in connections) {
            graph.AddEdge(connection);
        }

        bool[] visited = new bool[n];
        int clustersCounter = -1;
        for(int index=0; index<n; index++) {
            if (!visited[index]) {
                graph.RecursiveDFS(index, ref visited);
                clustersCounter++;
            }                   
        }
        return clustersCounter;
    }

    class Graph {
        private List<int>[] adjacentList;
    
        public Graph(int n)
        {
            this.adjacentList = new List<int>[n];
            for (int index = 0; index < n; index++) {
                this.adjacentList[index] = new List<int>();
            }                
        }
    
        public void AddEdge(int[] connection)
        {
            this.adjacentList[connection[0]].Add(connection[1]);
            this.adjacentList[connection[1]].Add(connection[0]);
        }
    
        public void RecursiveDFS(int vertex, ref bool[] visited)
        {
            visited[vertex] = true;            
            foreach(int n in this.adjacentList[vertex])
            {
                if (!visited[n]) {
                    this.RecursiveDFS(n, ref visited);
                }                    
            }
        }
    }
}