using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Problem
{
    // *****************************************
    // DON'T CHANGE CLASS OR FUNCTION NAME
    // YOU CAN ADD FUNCTIONS IF YOU NEED TO
    // *****************************************
    public static class PROBLEM_CLASS
    {
        #region YOUR CODE IS HERE 

        //Your Code is Here:
        //==================
        /// <summary>
        /// Write a function to calculate the minimum work units for bread transportation among houses
        /// </summary>
        /// <param name="N">Number of houses in city </param>
        /// <param name="DemandPerHouse">Array containing bread demand per house </param>
        /// <returns>Minimum work units needed to destribute bread among neighbourhood</returns>
        static public  Int64 RequiredFunction(int N,int[] DemandPerHouse)
        {
            //REMOVE THIS LINE BEFORE START CODING
            //throw new NotImplementedException();
            Int64 work_done = 0;
            Stack<Int64> demanders = new Stack<Int64>();
            for (int i = N - 1; i >= 0; i--)
            {
                if (DemandPerHouse[i] < 0)
                {
                    demanders.Push((Int64)i);
                }
            }
            int s = 0;
            while (s < N)
            {
                if (demanders.Count == 0)
                {
                    break;
                }
                if (DemandPerHouse[s] == 0 || DemandPerHouse[s] < 0)
                {
                    s++;
                    continue;
                }
                Int64 distance = 0, trade = 0, index_of_demander = demanders.Peek();
                distance = (Int64)Math.Abs(s - index_of_demander);
                trade = (Int64)Math.Min(DemandPerHouse[s], -DemandPerHouse[(int)index_of_demander]);
                work_done += trade * distance;
                DemandPerHouse[s] -= (int)trade;
                DemandPerHouse[(int)index_of_demander] += (int)trade;
                if (DemandPerHouse[s] == 0)
                {
                    s++;
                }
                if (DemandPerHouse[(int)index_of_demander] == 0)
                {
                    demanders.Pop();
                }
            }
            return work_done;
            
        }
        #endregion
    }
}
