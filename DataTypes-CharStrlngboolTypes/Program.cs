using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_CharStrlngboolTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = char.MinValue;
            int charMax = char.MaxValue;

            char myVar = 'G';
            int myVarValue = 'G';

            char myVarValue2 = Convert.ToChar(75);

            Console.WriteLine("Min Char = {0} Max Char = {1} My character = {2} My variable number = {3} My conversion value = {4}",
                 charMin, charMax, myVar, myVarValue, myVarValue2);


            string mystring = "This is my variable";
            Console.WriteLine("\nMy string is {0}", mystring);

            bool myBool =false;
            Console.WriteLine("My Boolean Value is {0}", myBool);
            Console.ReadKey();

        }
    }
}
