namespace TestProject.HeapOrPriorityQueue;

/// <summary>
/// https://leetcode.com/problems/find-median-from-data-stream/
/// </summary>
public class MedianFinder {

    private readonly PriorityQueue<int, int> leftMaxQueue;
    private readonly PriorityQueue<int, int> rightMinQueue;
    
    public MedianFinder() {
        this.leftMaxQueue = new PriorityQueue<int, int>(new IntMaxCompare());
        this.rightMinQueue =  new PriorityQueue<int, int>();
    }
    
    public void AddNum(int num) {
        if (leftMaxQueue.Count == 0 || num > leftMaxQueue.Peek())
        {
            rightMinQueue.Enqueue(num, num);
        }
        else
        {
            leftMaxQueue.Enqueue(num, num);
        }

        if (leftMaxQueue.Count == rightMinQueue.Count)
            return;

        var (smallQueue, bigQueue) = leftMaxQueue.Count < rightMinQueue.Count
            ? (leftMaxQueue, rightMinQueue)
            : (rightMinQueue, leftMaxQueue);

        var value = bigQueue.Dequeue();
        smallQueue.Enqueue(value, value);
    }
    
    public double FindMedian()
    {
        if (leftMaxQueue.Count < rightMinQueue.Count)
        {
            return rightMinQueue.Peek();
        }

        if (leftMaxQueue.Count > rightMinQueue.Count)
        {
            return leftMaxQueue.Peek();
        }

        return (leftMaxQueue.Peek() + rightMinQueue.Peek()) / 2.0;
    }
}

public class IntMaxCompare : IComparer<int>
{
    public int Compare(int x, int y) => y.CompareTo(x);
}
