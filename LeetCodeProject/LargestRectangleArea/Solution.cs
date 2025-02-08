namespace TestProject.LargestRectangleArea;

/// <summary>
/// https://leetcode.com/problems/largest-rectangle-in-histogram/
/// </summary>
public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
      var stackPair = new Stack<HeightIndexPair>();
      var maxArea = 0;

      for(var index=0; index<heights.Length; index++)
      {
        var startIndex = index;
        while (stackPair.Count > 0 && stackPair.Peek().Height > heights[index])
        {
            var top = stackPair.Pop();
            maxArea = Math.Max(maxArea, (index - top.StartIndex) * top.Height);       
            startIndex = top.StartIndex;
        }
        stackPair.Push(new HeightIndexPair() { StartIndex = startIndex, Height = heights[index]});
      }

      foreach (var item in stackPair)
      {
          maxArea = Math.Max(maxArea, (heights.Length - item.StartIndex) * item.Height);
    }
      
      return maxArea;
    }

    private class HeightIndexPair
    {
        public int StartIndex;
        public int Height;
    }
}