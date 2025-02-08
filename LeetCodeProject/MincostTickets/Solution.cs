namespace TestProject.MincostTickets;
/// <summary>
/// URL: https://leetcode.com/problems/minimum-cost-for-tickets/
/// </summary>
public class Solution
{
    private IDictionary<int, int> passWithCost;
    private IDictionary<int, int> travelDayWithCost;
    
    public int MincostTickets(int[] days, int[] costs)
    {
        if (days.Length == 0)
            return 0;
            
        passWithCost = new Dictionary<int, int>
        {
            { 1, costs[0] },
            { 7, costs[1] },
            { 30, costs[2] }
        };
        travelDayWithCost = new Dictionary<int, int>();
        var orderedTravelDays = days.OrderBy(day => day).ToArray();
        foreach (var travelDay in orderedTravelDays) 
        {
            travelDayWithCost[travelDay] = passWithCost.Keys.Min(pass => CalcTravelDayCostPerPass(travelDay, pass));
        }
        
        return travelDayWithCost[orderedTravelDays.Last()];
    }

    private int CalcTravelDayCostPerPass(int travelDay, int pass)
    {
        var anyDay = travelDay - pass;
        var lastDay = travelDayWithCost.Keys.LastOrDefault(tDay => tDay <= anyDay);
        if (lastDay > 0)
        {
            return travelDayWithCost[lastDay] + passWithCost[pass];
        }

        return passWithCost[pass];
    }
}