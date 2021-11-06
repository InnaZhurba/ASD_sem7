using System.Collections.Generic;
using ASD_lab1_ucu_2021.Sorting;

namespace ASD_sem7.task_7
{
    public class scheduling
    {
        //a[n][m] => n*m matrix
        public int solve7(int[][] a)
        {
            int nDeleteEl = 0;
            int[] arr = new int[a.GetLength(0)];
            MergeSort mergeSort = new MergeSort();

            //n
            for (int i = 0; i < a.GetLength(0); i++)
            {
                arr[i] = a[i][1];
            }
            
            //nlogn
            mergeSort.devideANDconquare(arr,0,a.GetLength(0)-1,a);
            
            //n
            for (int i = 1; i < a.GetLength(0); i++)
            {
                if (a[i][0] < a[i - 1][1])
                {
                    nDeleteEl++;
                }
            }

            return nDeleteEl;
        }
    }
}