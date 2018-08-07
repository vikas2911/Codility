using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3, 8, 9, 7, 6 };
           // int[] A  = { 3 };
            int[] result = solution(A, 23); 
        }
        /// <summary>
        /// Cyclic Rotation 
        /// Test cases - empty array, single element array, K should be a positive number, K is greater than or equal to array length
        /// Test passed - 100%
        /// </summary>
        /// <param name="A"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int[] solution(int[] A, int K) 
        {
            if (K <= 0  || A.Length <= 1)  
                return A;
            if (K >= A.Length)
                K = K % A.Length; 
            int j = 0;
            int[] result = new int[A.Length];
            for (int i= 0; i<A.Length;i++)
            {
                j = i + K;
                if (j >= A.Length)
                    j = j - A.Length; 
                result[j] = A[i]; 
            }
            return result; 
        }
        /// <summary>
        /// This function was not used. Instead K was reduced in the beginning. 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        private static int NextIndex(int index, int length)
        {
            if (index < length)
                return index;
            else
                index = index - length; 
                return NextIndex(index,length); 
        }
    }
    // issues with the code -
    // fails with single element
    // fails when K>=N
}
