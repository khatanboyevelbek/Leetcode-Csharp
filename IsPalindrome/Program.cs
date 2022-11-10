namespace IsPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Result: {IsPalindrome(121)}");
        }
        public static bool IsPalindrome(int x)
        {
            int reverseNumber = 0;
            int num = x;
            //if (x <= 9)
            //{
            //    return x;
            //}
            while (x >= 1)
            {
                reverseNumber = reverseNumber * 10 + x % 10;
                x = x / 10;
            }
            return reverseNumber == num;
        }
    }
}