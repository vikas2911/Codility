using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrencesInArray
{
    /// <summary>
    /// main function
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 9, 3, 9, 3, 9, 7, 9 }; 
            Console.WriteLine(solution(A));
            Console.ReadLine(); 
        }


        /// <summary>
        /// Time out errors coming as of now (66%)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int solution(int[] A)
        {
            if (A.Length == 1)
                return A[0];

            int result = 0;
            Dictionary<int, int> pairedElements = new Dictionary<int, int>();
            Dictionary<int, int> unPairtedElements = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                unPairtedElements.Add(i, i);
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (pairedElements.ContainsKey(i))
                {
                    continue;
                }

                for (int j = i + 1; j < A.Length; j++)
                {
                    if (pairedElements.ContainsKey(j))
                    {
                        continue;
                    }
                    if (A[i] == A[j])
                    {
                            pairedElements.Add(i, i);
                            pairedElements.Add(j, j);
                            unPairtedElements.Remove(i);
                            unPairtedElements.Remove(j);
                            break;                      // come out of the inner loop and find the next i; 
                    }
                }
            }
            result = unPairtedElements.First().Value; 
            return A[result]; 
        }
    }
}
