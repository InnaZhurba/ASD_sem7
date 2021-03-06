using System;
using System.Threading.Tasks;
using ASD_sem7.task_7;
using ASD_sem7.task_8;
using ASD_sem7.task_9;

namespace ASD_sem7
{
    class Program
    {
        public static void Call_task7()
        {
            scheduling schedule = new scheduling();
            int[][] a = new int[][] {
                new int[] {1, 10}, 
                new int[] {12, 15},
                new int[]{5,25}, 
                new int[]{18,20}
                
            };
            /*int[][] a = new int[][] {
                new int[] {-5, 5}, 
                new int[] {-5, 5}, 
                new int[] {-5, 5}
            };*/
            /*int[][] a = new int[][] {
                new int[] {1, 10}, 
                new int[] {12, 15},
                new int[]{5,25}, 
                new int[]{15,20}
                
            };*/
            Console.WriteLine(schedule.solve7(a));
        }

        public static void Call_task8()
        {
            MaxProfit maxProfit = new MaxProfit();
            int []arr = { 10,1,2,1,4,3}; //4
            //int []arr = { 5,10,15,20}; //15
            
            Console.WriteLine(maxProfit.solve(arr));
        }

        public static void Call_task9()
        {
            ProjectManagement projectManagement = new ProjectManagement();
            int K = 3,
                C = 0;
            int[] A = { 5,6,7},
                B = { 0,3,4};
                
            /*int[] A = { 100,50,80},
                B = { 0,0,0};
                */
            
            Console.WriteLine(projectManagement.solve9(K,C,A,B));
        }
        static void Main(string[] args)
        {
            //Call_task7();
            //Call_task8();
            Call_task9();
        }
    }
}