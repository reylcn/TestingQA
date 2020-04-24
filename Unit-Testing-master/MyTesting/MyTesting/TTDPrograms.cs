using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTesting
{
    public class TTDPrograms
    {
        public int Power(int b,int exp)
        {
            int result = 1;
            for(int i=0; i<exp; i++)
            {
                result = result * b;
            }

            return result;
        }

        public int Smallest(int[] arr)
        {
            int result=arr[0];
            for(int i=1; i<arr.Length; i++)
            {
                if (result > arr[i])
                {
                    result = arr[i];
                }
            }

            return result;
        }
    }
}
