namespace TestProject.HeapOrPriorityQueue;

/// <summary>
/// https://leetcode.com/problems/kth-largest-element-in-a-stream/
/// </summary>
public class KthLargest
{
    private PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
    private int k;
    
    public KthLargest(int k, int[] nums)
    {
        this.k = k;
        foreach (var num in nums)
        {
            this.Add(num);
        }
    }
    
    public int Add(int val) {
        this.priorityQueue.Enqueue(val, val);
        
        if (this.priorityQueue.Count > k)
        {
            this.priorityQueue.Dequeue();
        }

        return this.priorityQueue.Peek();
    }
}