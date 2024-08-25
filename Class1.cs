using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;




public class Program
{
	string void Main(string[] args)
	{
        List<int> nums = new List<int> { 1, 2, 3 };
        foreach (var num in nums) 
            nums.Remove(num); 
        Console.WriteLine(nums.Count);

    }
}
