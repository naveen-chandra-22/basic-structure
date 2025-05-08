using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string variable = "string varaible print H";
            foreach (var newItem in variable.ToArray())
            {

                Console.WriteLine($"i am writing in interpolation: {(SqlInt64)((variable.Length * sizeof(Char))) / 10}");
            }
            SqlInt32 sqlvalues = new SqlInt32(16);
            //if (sqlvalues.IsNull)
            //{
            //    Console.WriteLine(sqlvalues.Value);

            //}


            // pointer type
            //unsafe
            //{
            //    int i = 0;
            //    int* j = &i;

            //    Console.WriteLine($"write value: {i}");
            //    Console.WriteLine($"write address: {(int)j}");
            //}

        }
    }
}
