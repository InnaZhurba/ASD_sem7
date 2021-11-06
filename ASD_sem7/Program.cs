using System;
using System.Threading.Tasks;
using ASD_sem7.task_7;

namespace ASD_sem7
{
    class Program
    {
        static void Main(string[] args)
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
    }
}