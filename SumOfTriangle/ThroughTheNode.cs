using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTriangle
{
    public static class ThroughTheNode
    {
        public static int[,] Walk(string[] arrayOfRowsByNewlines, int[,] tableHolder)
        {
            // walking through the non-prime node
            for (int i = arrayOfRowsByNewlines.Length - 2; i >= 0; i--)
            {
                for (int j = 0; j < arrayOfRowsByNewlines.Length; j++)
                {
                    //only sum through the non-prime node
                    if ((!IsPrime.IsPrimes(tableHolder[i, j])))
                    {
                        tableHolder[i, j] = Math.Max(tableHolder[i, j] + tableHolder[i + 1, j],
                            tableHolder[i, j] + tableHolder[i + 1, j + 1]);
                    }
                }
            }
            return tableHolder;
        }
    }
}
