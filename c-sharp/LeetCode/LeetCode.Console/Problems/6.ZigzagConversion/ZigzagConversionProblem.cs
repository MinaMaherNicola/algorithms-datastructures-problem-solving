using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Console.Problems._6.ZigzagConversion
{
    public class ZigzagConversionProblem
    {
        public string Convert(string s, int numRows)
        {
            if (s.Length == numRows || numRows == 1)
            {
                return s;
            }
            int sCounter = 0, rowsCounter = 0;
            List<string[]> listOfArrays = new();
            string[] arr = new string[numRows];
            while(sCounter < s.Length)
            {
                arr[rowsCounter] = s[sCounter].ToString();
                if (rowsCounter < numRows - 1)
                {
                    rowsCounter++;
                    sCounter++;
                    continue;
                }
                listOfArrays.Add(arr.ToArray());
                Array.Clear(arr);
                sCounter++;
                rowsCounter--;
                while (rowsCounter > 0 && sCounter < s.Length)
                {
                    arr[rowsCounter] = s[sCounter].ToString();
                    listOfArrays.Add(arr.ToArray());
                    Array.Clear(arr);
                    sCounter++;
                    rowsCounter--;
                }
            }
            listOfArrays.Add(arr);

            string output = "";

            for (int i = 0; i < numRows; i++)
            {
                listOfArrays.ForEach(array =>
                {
                    if (array[i] != null)
                    {
                        output += array[i].ToString();
                    }
                });
            }
            return output;
        }
    }
}
