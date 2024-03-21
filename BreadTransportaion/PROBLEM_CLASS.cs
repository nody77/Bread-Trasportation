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

            int work = 0;
            List<int> suppliers = new List<int>();
            List<int> demanders = new List<int>();

            Parallel.For(0, N, i =>
            {
                if (DemandPerHouse[i] > 0)
                {
                    suppliers.Add(i);
                }
                else if (DemandPerHouse[i] < 0)
                {
                    demanders.Add(i);
                }
            });

            /*for (int i = 0; i < N; i++)
            {
                if (DemandPerHouse[i] > 0)
                {
                    suppliers.Add(i);
                }
                else if (DemandPerHouse[i] < 0)
                {
                    demanders.Add(i);
                }
            }*/

            int s = 0, d = 0;
            while (s < suppliers.Count && d < demanders.Count)
            {
                int distance, trade = 0;
                if(suppliers[s] - demanders[d] < 0)
                {
                    distance = -1 * (suppliers[s] - demanders[d]);
                }
                else
                {
                    distance = suppliers[s] - demanders[d];
                }
                if (DemandPerHouse[suppliers[s]] <= -1 * DemandPerHouse[demanders[d]])
                {
                    trade = DemandPerHouse[suppliers[s]];
                }
                else if (DemandPerHouse[suppliers[s]] > -1 * DemandPerHouse[demanders[d]])
                {
                    trade = DemandPerHouse[demanders[d]];
                }
                work += trade * distance;

                DemandPerHouse[suppliers[s]] -= trade;
                DemandPerHouse[demanders[d]] += trade;

                if (DemandPerHouse[suppliers[s]] == 0) s++;
                if (DemandPerHouse[demanders[d]] == 0) d++;
            }

            return work;
        }
        #endregion
    }
}
