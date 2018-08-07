using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine(solution(16)); 
        }

        public static int solution(int N)
        {
            int result = 0;
            int i = 0;
            int j = 0; 
            string binaryNumber = Convert.ToString(N, 2);
            while(i < binaryNumber.Length )
            {
                i = binaryNumber.IndexOf("0",i);
                if (i == -1) break;                             // no 0 found so exiting the loop at this point
                j = binaryNumber.IndexOf("1", i + 1);
                if (j == -1)
                    j = binaryNumber.Length -1; 
                if (j - i > result)
                    result = j - i  ;
                i = j + 1; 
            }
            return result; 
        }
    }
}
