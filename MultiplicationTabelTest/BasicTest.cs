using System;
using Xunit;
using MultiplicationTable;
using System.Collections.Generic;

namespace MultiplicationTabelTest
{
    public class BasicTest
    {
        [Fact]

        //Test if user input is prime number
        public void IsPrimeTest()
        {
            Mulitiplication numbers = new Mulitiplication();
            Assert.True(numbers.IsPrime(3));
            Assert.False(numbers.IsPrime(4));
        }

        //test output
        [Fact]
        public void GetMultiplicationTest()
        {
            List<int> outputNumbers = new List<int>();
            int num = 100;
            Mulitiplication mlt = new Mulitiplication();
            try
            {
               outputNumbers = mlt.MultiplicationTable(num);
                Assert.NotNull(outputNumbers);

            }
            catch
            {
                Assert.False(true);
            }
            finally
            {
                Assert.True(true);
            }
        }
    }
}
