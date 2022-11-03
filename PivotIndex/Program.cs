namespace PivotIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] example = { 1, 2, 3 };
            int result = Result(example);
            Console.WriteLine(result);
        }
        public static int Result(int[] nums)
        {
            int totalSum = 0;
            int leftSum = 0;
            foreach (int num in nums)
            {
                totalSum += num;
            }
            for(int i = 0; i < nums.Length; i++)
            {
                if(totalSum - leftSum - nums[i] == leftSum)
                {
                    return i;
                }
                leftSum += nums[i];
            }
            return -1;
        }
    }
}