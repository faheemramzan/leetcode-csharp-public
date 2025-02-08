namespace TestProject.Recursion.Exponentiation;

/// <summary>
/// https://leetcode.com/problems/powx-n/solutions/1693787/Pow(x-n)-using-Recursion/
/// </summary>
public class Solution
{
    public int Pow(int x, int e)
    {
        Console.WriteLine("---------BEFORE--------");
        Console.WriteLine("x: " + x);
        Console.WriteLine("e: " + e);
        
        if (e == 0) return 1;
        var h = Pow(x, e/2);
        Console.WriteLine("---------AFTER---------");
        Console.WriteLine("x: " + x);
        Console.WriteLine("e: " + e);
        Console.WriteLine("h: " + h);
        if (e%2 == 0) return h*h;
        return h*h*x;
    }
}