using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace ClosestSumfromArray
{
    public class FindClosestSum
    {
        // Returns element closest to target in arr[] 
        public static int findClosest(int []arr, int target) 
        { 
            int closestSum = int.MaxValue;
 
            // Run three nested loops each loop for each element of triplet
            for(int i = 0; i < arr.Length; i++) 
            {
                 for(int j = i + 1; j < arr.Length; j++)
                 {
                     for(int k = j + 1; k < arr.Length; k++)
                     {
                        if (Math.Abs(target - closestSum) >  Math.Abs(target - ((int)arr[i] + (int)arr[j] + (int)arr[k])))
                        {
                        closestSum = ((int)arr[i] + (int)arr[j] +  (int)arr[k]); 
                        }
                     } 
                 }
            }
     
            // Return the closest sum found
            return closestSum;
        }
    }
}