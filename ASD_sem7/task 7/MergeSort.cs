using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ASD_lab1_ucu_2021.Sorting
{
    public class MergeSort
    {
        public void devideANDconquare(int[] arr, int l, int r, int[][] A){
            int counter = 0;
            if (l < r && arr != null){
                int middle = (l + r) / 2;

                devideANDconquare(arr, l, middle, A);
                devideANDconquare(arr, middle + 1, r, A);

                merge(arr, l, r, middle, A);
            }
        }

        public void merge(int[] arr, int l, int r, int m, int[][] A){
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] left = new int[n1];
            int[] right = new int[n2];
            int[][] leftA = new int[n1][];
            int[][] rightA = new int[n2][];

            for (int i = 0; i < n1; i++){
                left[i] = arr[l + i];
                leftA[i] = A[l+i];
            }
            for (int j = 0; j < n2; j++){
                right[j] = arr[m + j + 1];
                rightA[j] = A[m + j + 1];
            }

            int n = 0, k = 0, ind = l;

            while (ind < (r + 1)){
                if (n >= n1){
                    arr[ind] = right[k];
                    A[ind]=rightA[k];
                    k++;
                }
                else{
                    if (k >= n2){
                        arr[ind] = left[n];
                        A[ind]=leftA[n];
                        n++;
                    }
                    else{
                        if (left[n] <= right[k]){
                            arr[ind] = left[n];
                            A[ind]=leftA[n];
                            n++;
                        }
                        else{
                            if (left[n] >= right[k]){
                                arr[ind] = right[k];
                                A[ind]=rightA[k];
                                k++;
                            }
                        }
                    }
                }
                ind++;
            }
        }
    }
}