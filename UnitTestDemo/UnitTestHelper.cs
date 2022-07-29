using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    public class UnitTestHelper
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="numberA"></param>
        /// <param name="numberB"></param>
        /// <returns></returns>
        public static double Add(double numberA,double numberB)
        {
            return numberA + numberB;
        }

        /// <summary>
        /// Substract
        /// </summary>
        /// <param name="numberA"></param>
        /// <param name="numberB"></param>
        /// <returns></returns>
        public static double Substract(double numberA, double numberB)
        {
            return numberA - numberB;
        }

        /// <summary>
        /// Multiply
        /// </summary>
        /// <param name="numberA"></param>
        /// <param name="numberB"></param>
        /// <returns></returns>
        public static double Multiply(double numberA, double numberB)
        {
            return numberA * numberB;
        }

        /// <summary>
        /// Multiply
        /// </summary>
        /// <param name="numberA"></param>
        /// <param name="numberB"></param>
        /// <returns></returns>
        public static double Divide(double numberA, double numberB)
        {
            if (numberB==0)
            {
                throw new Exception($"Parameter \"numberB\" cannot be zero , please input another \"numberB\"");
            }
            return numberA / numberB;
        }
    }
}
