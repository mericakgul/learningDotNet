using System;
using Xunit;
using System.Collections.Generic;
using Algorithms;

namespace UnitTests
{
    public class UnitTest1
    {
        Algorithm myObj = new Algorithm();
        List <int> listOfPrimeNumbers = new List<int>();
        List <int> listOfFibonacciSequence = new List<int>();

        [Fact]
        public void PrimeTest1()
        {
            listOfPrimeNumbers = myObj.CreateListOfPrimeNumbers(-1);
            int size = listOfPrimeNumbers.Count;
            Assert.StrictEqual(0, size);
        }
        [Fact]
        public void PrimeTest2()
        {
            listOfPrimeNumbers = myObj.CreateListOfPrimeNumbers(0);
            int size = listOfPrimeNumbers.Count;
            Assert.StrictEqual(0, size);
        }
        [Fact]
        public void PrimeTest3()
        {
            listOfPrimeNumbers = myObj.CreateListOfPrimeNumbers(1);
            int size = listOfPrimeNumbers.Count;
            Assert.StrictEqual(0, size);
        }
        [Fact]
        public void PrimeTest4()
        {
            listOfPrimeNumbers = myObj.CreateListOfPrimeNumbers(2);
            int size = listOfPrimeNumbers.Count;
            Assert.StrictEqual(1, size);
            Assert.StrictEqual(2, listOfPrimeNumbers[0]);
        }
        [Fact]
        public void PrimeTest5()
        {
            listOfPrimeNumbers = myObj.CreateListOfPrimeNumbers(10);
            int size = listOfPrimeNumbers.Count;
            Assert.StrictEqual(4, size);
            Assert.StrictEqual(2, listOfPrimeNumbers[0]);
            Assert.StrictEqual(3, listOfPrimeNumbers[1]);
            Assert.StrictEqual(5, listOfPrimeNumbers[2]);
            Assert.StrictEqual(7, listOfPrimeNumbers[3]);
        }
        [Fact]
        public void FibonacciTest1()
        {
            listOfFibonacciSequence = myObj.CreateListOfFibonacci(-1);
            int size = listOfFibonacciSequence.Count;
            Assert.StrictEqual(0, size);
        }
        [Fact]
        public void FibonacciTest2()
        {
            listOfFibonacciSequence = myObj.CreateListOfFibonacci(0);
            int size = listOfFibonacciSequence.Count;
            Assert.StrictEqual(1, size);
            Assert.StrictEqual(0, listOfFibonacciSequence[0]);
        }
        [Fact]
        public void FibonacciTest3()
        {
            listOfFibonacciSequence = myObj.CreateListOfFibonacci(1);
            int size = listOfFibonacciSequence.Count;
            Assert.StrictEqual(3, size);
            Assert.StrictEqual(0, listOfFibonacciSequence[0]);
            Assert.StrictEqual(1, listOfFibonacciSequence[1]);
            Assert.StrictEqual(1, listOfFibonacciSequence[2]);
        }
        [Fact]
        public void FibonacciTest4()
        {
            listOfFibonacciSequence = myObj.CreateListOfFibonacci(2);
            int size = listOfFibonacciSequence.Count;
            Assert.StrictEqual(4, size);
            Assert.StrictEqual(0, listOfFibonacciSequence[0]);
            Assert.StrictEqual(1, listOfFibonacciSequence[1]);
            Assert.StrictEqual(1, listOfFibonacciSequence[2]);
            Assert.StrictEqual(2, listOfFibonacciSequence[3]);
        }
        [Fact]
        public void FibonacciTest5()
        {
            listOfFibonacciSequence = myObj.CreateListOfFibonacci(3);
            int size = listOfFibonacciSequence.Count;
            Assert.StrictEqual(5, size);
            Assert.StrictEqual(0, listOfFibonacciSequence[0]);
            Assert.StrictEqual(1, listOfFibonacciSequence[1]);
            Assert.StrictEqual(1, listOfFibonacciSequence[2]);
            Assert.StrictEqual(2, listOfFibonacciSequence[3]);
            Assert.StrictEqual(3, listOfFibonacciSequence[4]);
        }
        [Fact]
        public void FibonacciTest6()
        {
            listOfFibonacciSequence = myObj.CreateListOfFibonacci(4);
            int size = listOfFibonacciSequence.Count;
            Assert.StrictEqual(5, size);
            Assert.StrictEqual(0, listOfFibonacciSequence[0]);
            Assert.StrictEqual(1, listOfFibonacciSequence[1]);
            Assert.StrictEqual(1, listOfFibonacciSequence[2]);
            Assert.StrictEqual(2, listOfFibonacciSequence[3]);
            Assert.StrictEqual(3, listOfFibonacciSequence[4]);
        }
        [Fact]
        public void FibonacciTest7()
        {
            listOfFibonacciSequence = myObj.CreateListOfFibonacci(1000);
            int size = listOfFibonacciSequence.Count;
            Assert.StrictEqual(17, size);
            Assert.StrictEqual(144, listOfFibonacciSequence[12]);
            Assert.StrictEqual(233, listOfFibonacciSequence[13]);
            Assert.StrictEqual(377, listOfFibonacciSequence[14]);
            Assert.StrictEqual(610, listOfFibonacciSequence[15]);
            Assert.StrictEqual(987, listOfFibonacciSequence[16]);
        }

        [Fact]
        public void FibonacciTest8()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => myObj.CreateListOfFibonacci(10_001));
        }
    }
}
