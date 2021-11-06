using System.Collections.Generic;

namespace ASD_sem7.task_8
{
    public class MaxProfit
    {
        public int solve8(int[] arr)
        {
            int profit = 0;
            
            //n
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1]) 
                    profit += arr[i] - arr[i - 1];
            }
            return profit;
        }
    }
}