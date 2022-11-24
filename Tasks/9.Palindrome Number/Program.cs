using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(IsPolyndrom(1211));
        }
        static bool IsPolyndrom(int value)
        {
            string str = value.ToString();
            int j = str.Length - 1;

            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] == str[j])
                {
                    j--;
                    continue;
                }
                else
                    return false;
                j--;
            }
            return true;
        }
    }
}