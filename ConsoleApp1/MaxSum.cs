using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// Complexity O(n)
    /// </summary>
	public class MaxSum
	{
        public int FindSum(int[] arr)
        {
            int include = arr[0];
            int exclude = 0;
            int newExclude;

            for (var i = 1; i < arr.Length; i++)
            {
                newExclude = Math.Max(include, exclude);

                include = exclude + arr[i];
                exclude = newExclude;
            }

            return Math.Max(include, exclude);
        }
    }
}
