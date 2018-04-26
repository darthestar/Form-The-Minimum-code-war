using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_The_Minimum_code_war
{

    class Program
    {
        //sort
        //remove dups
        //push number into []
        //combine

        public static long MinValue(int[] array)
        {
            var removeDups = array.Distinct();
            foreach (var number in removeDups)
            {

            };
            var sort = from s in removeDups orderby s select s;
            var result = String.Join("", sort);
            Console.WriteLine(result);
            var endresult = Int32.Parse(result);
            return endresult;
        }

        static void Main(string[] args)
        {
            int[] a = { 6, 7, 8, 7, 6, 6 };

            MinValue(a);
            Console.ReadLine();

        }
    }
}




