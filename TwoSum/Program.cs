using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution s1 = new solution();
            int [] result = s1.TwoSum( new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine($"{result[0]}, {result[1]}");
        }
    }
    public class solution
    {
        public int[] TwoSum(int[] nums, int k)
        {
            int[] arr = new int[2];
            for (int i=0; i<nums.Length; i++)
            {
                for(int j=i+1 ; j< nums.Length; j++)
                {
                    if (nums[i] + nums[j] == k) { 
                        arr[0] = i;
                        arr[1] = j;
                      
                        }
                }
            }
        return arr;
          
        }
    }
}
