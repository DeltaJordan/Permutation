using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    internal static class Program
    {
        private static List<string> perms = new List<string>();

        static void Main(string[] args)
        {
            string input1 = "pneumonoultramicroscopicsilicovolcanoconiosis";
            string input2 = "pneumonoultramicroscopicsilicovolcanoconiossi";

            Console.Out.WriteLine("Resulting permutations:");
            GetPer(input1.ToCharArray());
            Console.Out.WriteLine("End Results.");
            Console.Out.WriteLine();
            Console.Out.WriteLine(perms.Contains(input2) ? "Its a permutation!" : "Its not a permutation...");

            Console.ReadKey(true);
        }

        private static void Swap(ref char a, ref char b)
        {
            if (a == b)
            {
                return;
            }

            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static void GetPer(char[] list)
        {
            GetPer(list, 0, list.Length - 1);
        }

        private static void GetPer(char[] list, int recursionDepth, int maxDepth)
        {
            if (recursionDepth == maxDepth)
            {
                if (!perms.Contains(new string(list)))
                {
                    perms.Add(new string(list));
                    Console.WriteLine(list);
                }
            }
            else
            {
                for (int i = recursionDepth; i <= maxDepth; i++)
                {
                    Swap(ref list[recursionDepth], ref list[i]);
                    GetPer(list, recursionDepth + 1, maxDepth);
                    Swap(ref list[recursionDepth], ref list[i]);
                }
            }
        }
    }
}
