namespace IsomorphicStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Result: {IsIsomorphic("rgfs", "hkll")}");
        }
        public static bool IsIsomorphic(string s, string t)
        {
            if (s == null || t == null || s.Length != t.Length)
            {
                return false;
            }
            int[] a1 = new int[256];
            int[] a2 = new int[256];
            for (int i = 0; i < s.Length; i++)
            {
                char c1 = s[i];
                char c2 = t[i];
                if (a1[c1] != a2[c2])
                    return false;
                Console.WriteLine(a2[c1]);
                a1[c1] = i + 1;
                a2[c2] = i + 1;
            }
            return true;
        }
    }
}