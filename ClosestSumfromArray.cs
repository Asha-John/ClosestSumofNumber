using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace ClosestSumfromArray
{
    public class closestSumofTarget
    {
        public static void Main(String[] args)
        {
            Console.Write("Please Enter your numbers for array : ");
            string mainstring = Console.ReadLine();
            string[] _array1=mainstring.Split(',');
            List<int> _numbers=new List<int>();
            foreach(string str in _array1)
            {
                int _num=int.Parse(str);
                _numbers.Add(_num);
            }
            int[] _numberArray=_numbers.ToArray();
             Console.Write("Please Enter your Target Number : ");
             string _target= Console.ReadLine();
           int  _targetNum=int.Parse(_target);
             Array.Sort(_numberArray);

             var _closestSum=FindClosestSum.findClosest(_numberArray, _targetNum); 

          Console.Write("Closest Sum is : " + _closestSum);


        }
    }
}