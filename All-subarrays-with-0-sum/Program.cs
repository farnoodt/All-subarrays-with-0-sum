using System;
using System.Collections.Generic;

namespace All_subarrays_with_0_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };

            printAllSubarrays(nums);
        }

        public static void printAllSubarrays(int[] nums)
        {
            int sum = 0;
            Dictionary<int, List<int>> Dic = new Dictionary<int, List<int>>();
            Dic.Add(sum, new List<int>() { 0});
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (Dic.ContainsKey(sum))
                {
                    
                    foreach (var item in Dic[sum])
                    {
                        Console.WriteLine(item + ","+ i); 
                    }
                    Dic[sum].Add(i + 1);
                }
                else
                {
                    Dic.Add(sum, new List<int>() { i +1});
                }
                
            }

            //foreach (var item in Dic)
            //{
            //    for(int j=0; j<item.Value.Count-1; j++)
            //    {
            //        for (int k = j+1; k < item.Value.Count; k++)
            //        {
            //            Console.WriteLine((item.Value[j]) + " , " + (item.Value[k]));
            //        }
            //    }
            //}
        }
    }
}
