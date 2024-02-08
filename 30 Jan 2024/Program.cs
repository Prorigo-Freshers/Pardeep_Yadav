using System;

namespace Indexno
{
    class Solution
    {
        public int[] retunIndex(int[] num, int target)
        {
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 1; j < num.Length; j++)
                {
                    if (num[i] + num[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { -1, -1 };
        }

        static void Main(string[] args)
        {
        
        }
    }
}
