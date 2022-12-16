using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
namespace SumOfTriangle
{
    public class FlattenTheTriangleInto
    {
               

        public  static int[,] FlattenTheTriangleIntoTable(string[] arrayOfRowsByNewlines)
        {
            int[,] tableHolder = new int[arrayOfRowsByNewlines.Length, arrayOfRowsByNewlines.Length + 1];

            for (int row = 0; row < arrayOfRowsByNewlines.Length; row++)
            {
                var eachCharactersInRow = arrayOfRowsByNewlines[row].Trim().Split(' ');

                for (int column = 0; column < eachCharactersInRow.Length; column++)
                {
                    int number;
                    int.TryParse(eachCharactersInRow[column], out number);
                    tableHolder[row, column] = number;
                }
            }
            return tableHolder;
        }
    }
}
