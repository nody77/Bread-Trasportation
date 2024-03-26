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
            /*Int64 work_done = 0;
            Int64 number_of_bread = 0;
            for (int i = 0; i < N; i++)
            {
                if (DemandPerHouse[i] < 0)
                {
                    if (number_of_bread < 0)
                    {
                        work_done += (-1 * number_of_bread);
                    }
                    else
                    {
                        work_done += number_of_bread;
                    }
                    number_of_bread += DemandPerHouse[i];
                }
                else if (DemandPerHouse[i] > 0)
                {
                    if (number_of_bread < 0)
                    {
                        work_done += (-1 * number_of_bread);
                    }
                    else
                    {
                        work_done += number_of_bread;
                    }
                    number_of_bread += DemandPerHouse[i];
                }
            }
            return work_done;*/
            Int64 work_done = 0;
            Int64 number_of_bread = 0;
            for (int i = 0; i < N; i++)
            {
                if (number_of_bread < 0)
                {
                    work_done += (-1 * number_of_bread);
                }
                else
                {
                    work_done += number_of_bread;
                }
                number_of_bread += DemandPerHouse[i];
            }
            return work_done;
        }
        #endregion
    }
}
