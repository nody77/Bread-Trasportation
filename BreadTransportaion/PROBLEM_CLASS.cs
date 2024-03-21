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

            /*int work_units = 0;
           
            List<int> suppliers = new List<int>();
            List<int> demanders = new List<int>();

            for (int i = 0; i < N; i++)
            {
                if (DemandPerHouse[i] > 0)
                {
                    suppliers.Add(i);
                }
                else if (DemandPerHouse[i] < 0)
                {
                    demanders.Add(i);
                }
            }

            int s = 0, d = 0;
            while (s < suppliers.Count && d < demanders.Count)
            {
                int distance_between_the_houses, trade = 0;

                if(suppliers[s] - demanders[d] < 0)
                {
                    distance_between_the_houses = -1 * (suppliers[s] - demanders[d]);
                }
                else
                {
                    distance_between_the_houses = suppliers[s] - demanders[d];
                }

                if (DemandPerHouse[suppliers[s]] <= -1 * DemandPerHouse[demanders[d]])
                {
                    trade = DemandPerHouse[suppliers[s]];
                }
                else if (DemandPerHouse[suppliers[s]] > -1 * DemandPerHouse[demanders[d]])
                {
                    trade = DemandPerHouse[demanders[d]];
                }

                work_units += trade * distance_between_the_houses;

                DemandPerHouse[suppliers[s]] -= trade;
                DemandPerHouse[demanders[d]] += trade;

                if (DemandPerHouse[suppliers[s]] == 0) 
                { 
                    s++; 
                }
                if (DemandPerHouse[demanders[d]] == 0) 
                { 
                    d++; 
                }
            }
            return work_units;*/

            int i = 0, j = 0, steps = 0, temp = 0, work_units = 0;
            while (temp < N - 1)
            {
                while (j < N && DemandPerHouse[j] >= 0)
                {
                    j++;
                }
                while (i < N && DemandPerHouse[i] <= 0)
                {
                    i++;
                }
                if (i == N || j == N)
                {
                    break;
                }
                steps = Math.Abs(j - i);
                if (Math.Abs(DemandPerHouse[j]) <= DemandPerHouse[i])
                {
                    work_units += steps * Math.Abs(DemandPerHouse[j]);
                    DemandPerHouse[i] += DemandPerHouse[j];
                    DemandPerHouse[j] = 0;
                }
                else
                {
                    work_units += steps * DemandPerHouse[i];
                    DemandPerHouse[j] += DemandPerHouse[i];
                    DemandPerHouse[i] = 0;
                }
                temp++;
            }
            return work_units;
        }
        #endregion
    }
}
