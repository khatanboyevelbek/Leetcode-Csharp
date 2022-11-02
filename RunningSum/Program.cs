namespace RunningSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] example = { 4, 2, 6, 5 };
            foreach(int i in Result(example))
            {
                Console.WriteLine(i);
            }
        }
        public static int[] Result(int[] nums)
        {
            for(int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i] + nums[i - 1];
            }
            return nums;
        }
    }
}