using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegisterLibrary
{
    public class Calculator
    {
        /// <summary>
        /// Plus to hel tal sammen
        /// </summary>
       public int CalcPlus(int num1, int num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// Plus to decimal tal sammen (float)
        /// </summary>
        public float CalcPlus(float num1, float num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// Plus to decimal tal sammen (double]
        /// </summary>
        public double CalcPlus(double num1, double num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// Minus to hel tal sammen
        /// </summary>
        public int CalcMinus(int num1, int num2)
        {
            return num1 - num2;
        }

        /// <summary>
        /// Minus to decimal tal sammen (float)
        /// </summary>
        public float CalcMinus(float num1, float num2)
        {
            return num1 - num2;
        }

        /// <summary>
        /// Minus to decimal tal sammen (double)
        /// </summary>
        public double CalcMinus(double num1, double num2)
        {
            return num2 - num2;
        }

        /// <summary>
        /// Gange to hel tal sammen
        /// </summary>
        public int CalcGange(int num1, int num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// Gange to decimal tal sammen (float)
        /// </summary>
        public float CalcGange(float num1, float num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// Gange to decimal tal sammen (double)
        /// </summary>
        public double CalcGange( double num1, double num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// Divider to hel tal sammen
        /// </summary>
        public int CalcDivider(int num1, int num2)
        {
            return num1 / num2;
        }

        /// <summary>
        /// Divider to decimal tal sammen (float)
        /// </summary>
        public float CalcDivider(float num1, float num2)
        {
            return num1 / num2;
        }

        /// <summary>
        /// Divider to decimal tal sammen (double)
        /// </summary>
        public double CalcDivider(double num1, double num2)
        {
            return num1 / num2;
        }

        /// <summary>
        /// Tag x antal procent af et beløb
        /// </summary>
        public double CalcProcent(double procent, double number)
        {
            return (number / 100) * procent;  
        }


    }
}
