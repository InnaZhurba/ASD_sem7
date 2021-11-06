using ASD_lab1_ucu_2021.Sorting;

namespace ASD_sem7.task_9
{
    public class ProjectManagement
    {
        public int solve9(int K, int C, int[] A, int[] B)
        {
            MergeSortPrMng merge = new MergeSortPrMng();
            
            //nlogn
            merge.devideANDconquare(A,0,A.Length-1,B);

            int i = B.Length - 1;
            //k*n
            while (K > 0)
            {
                if (C >= B[i])
                {
                    K--;
                    C += A[i];
                    B[i] = 0;
                    A[i] = 0;
                }
                i--;
                if (i == -1)
                    i = B.Length - 1;
            }
            
            return C;
        }
    }
}