
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_P7_ConstData
{
    class MyMathClass
    {
        //public const double PI = 3.14;


        // Read-only fields can be assigned in ctors,
        // but nowhere else.



        public readonly double PI;

        //public static readonly double PI = 3.14; // static reado-only field
        static MyMathClass() // Static ctor
        {
            //PI = 3.14;
        }
        public MyMathClass()
        {
            // Not possible- must assign at time of declaration.
            PI = 3.14;
        }



        // Error!
        public void ChangePI()
        {
           // PI = 3.14444;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Const *****\n");

            //Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);

            //MyMathClass mathClass = new MyMathClass();

            //mathClass.

            // Error! Can't change a constant!
            //MyMathClass.PI = 3.1444;


            //LocalConstStringVariable();

            #region Static Read-Only Fields

            //Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);

            #endregion

            Console.ReadLine();
        }

        private static void LocalConstStringVariable()
        {
            // A local constant data point can be directly accessed.
            const string fixedStr = "Fixed string Data";
            Console.WriteLine(fixedStr);


           // Error!
           // fixedStr = "This will not work!";
        }
    }
}
