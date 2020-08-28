using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Algorithm
    {
        public List<int> CreateListOfPrimeNumbers(int maxNumber)
        {
            List<int> primeNumbers = new List<int>();

            for (int currentNumber = 2; currentNumber <= maxNumber; currentNumber++)
            {
                if (IsPrime(currentNumber))
                {
                    primeNumbers.Add(currentNumber);
                }
            }

            return primeNumbers;
        }

        private bool IsPrime(int currentNumber)
        {
            if (currentNumber <= 1)
                return false;

            if (currentNumber == 2)
                return true;

            int divider = 2;

            do
            {
                if (currentNumber % divider == 0)
                {
                    return false;
                }
                divider++;
            } while (divider <= currentNumber / 2);

            return true;
        }

        public List<int> CreateListOfFibonacci(int maxNumber)
        {
            if (maxNumber > 10_000)
            {
                throw new ArgumentOutOfRangeException();
            }

            List<int> fibonacciSequence = new List<int>();
            
            if (maxNumber < 0)
            {
                return fibonacciSequence;
            }
            else if (maxNumber == 0)
            {
                fibonacciSequence.Add(0);
                return fibonacciSequence;
            }
            else
            {
                int previousNumber = 0;
                int currentNumber = 1;
                int nextNumber = previousNumber + currentNumber;

                fibonacciSequence.Add(previousNumber);
                fibonacciSequence.Add(currentNumber);

                while (nextNumber <= maxNumber)
                {
                    fibonacciSequence.Add(nextNumber);
                    previousNumber = currentNumber;
                    currentNumber = nextNumber;
                    nextNumber = previousNumber + currentNumber;
                }

                return fibonacciSequence;
            }
        }
    }
}
