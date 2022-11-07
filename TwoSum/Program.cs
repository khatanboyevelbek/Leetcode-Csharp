using System.Collections.Generic;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] result = Calculating(new int[] { 2, 7, 9, 4, 8 }, 9);
            foreach(int itemOfResult in result)
            {
                Console.WriteLine(itemOfResult);
            }
        }
        public static int[] Calculating(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new();
            for(int i = 0; i < nums.Length; i++)
            {
                if(dictionary.ContainsValue(target - nums[i]))
                {
                    return new int[] { dictionary.FirstOrDefault(a => a.Value == (target - nums[i])).Key,  i };
                }
                else
                {
                   dictionary.Add(i, nums[i]);
                }
            }
            return new int[2];
        }
    }
}