using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class DeadPixels
	{
        /// <summary>
        /// Complexity O(NxM)
        /// </summary>
        public int CountGroups(char[][] monitor)
		{
            if (monitor == null || monitor.Length == 0)
                return 0;

            int numIslands = 0;
            for (int i = 0; i < monitor.Length; i++)
            {
                for (int j = 0; j < monitor[0].Length; j++)
                {
                    // we have found an island
                    if (monitor[i][j] == '1')
                    {
                        // check neighbours to find # of 1s that are part of this island
                        numIslands += DepthFirstSearch(monitor, i, j);
                    }
                }
            }

            return numIslands;
        }
        

        private int DepthFirstSearch(char[][] monitor, int i, int j)
        {
            // if i and j are out of bound or grid i,j represent water or grid i,j is already visited
            if (i < 0 || i >= monitor.Length || j < 0 || j >= monitor[0].Length || monitor[i][j] == '0' || monitor[i][j] == 'v')
            {
                return 0;
            }

            // mark this point visited. Using 'v 'to mark visited
            monitor[i][j] = 'v';

            // check neighbours up,down,left and right in matrix. Method will mark neighbours visited if monitor[i][j] are one i.e. they are also part of this island.
            DepthFirstSearch(monitor, i - 1, j);
            DepthFirstSearch(monitor, i + 1, j);
            DepthFirstSearch(monitor, i, j - 1);
            DepthFirstSearch(monitor, i, j + 1);

            return 1;

        }
    }
}
