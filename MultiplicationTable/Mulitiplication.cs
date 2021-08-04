using System;
using System.Collections.Generic;
using System.Text;

namespace MultiplicationTable
{
    public class Mulitiplication
    {
        //this function could be only void but returning list type for unit testing since that testing a void method is not properly tests behaviour and is for all intents and purposes unbreakable.

        public List<int> MultiplicationTable(int number)
        {
            List<int> output = new List<int>();
            for (int i = 0; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
                    output.Add(number * i);
                }
            }

            return output;
        }

        /// <summary>
        /// check if number is prime
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool IsPrime(int num)
        {
            if (num < 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
                if (num % i == 0)
                    return false;

            return true;
        }
    }
}
