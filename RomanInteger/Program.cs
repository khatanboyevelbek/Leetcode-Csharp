namespace RomanInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MCMLXXXVIII"));
        }
        public static int RomanToInt(string s)
        {
            int sum = 0;
            Dictionary<char, int> DictOfRoman = new()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    sum += DictOfRoman[s[i]];
                }
                else
                {
                    if (DictOfRoman[s[i]] > DictOfRoman[s[i - 1]])
                    {
                        sum += DictOfRoman[s[i]] - 2 * DictOfRoman[s[i - 1]];
                    }
                    else
                    {
                        sum += DictOfRoman[s[i]];
                    }
                }
            }
            return sum;
        }
    }
}