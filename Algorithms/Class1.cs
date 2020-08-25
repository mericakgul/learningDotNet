using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Algorithm
    {
        public List <int> createListOfPrimeNumbers(int N){

            List <int> primeNumbers = new List<int> ();

            if (N <= 1){
                return primeNumbers;
            }

            else if(N==2){
                primeNumbers.Add(2);
                return primeNumbers;
            }

            else{
                primeNumbers.Add(2);
                for(int num = 3 ; num <= N ; num++){
                    Boolean control = true;
                    int i = 2;

                    do{ 
                        if (num%i == 0){
                            control = false;
                            break;
                        }
                        i++;
                    }while(i <= num/2);

                    if(control == true){
                        primeNumbers.Add(num);
                    }
                }
            return primeNumbers;
            }
        }
    
        public List <int> createListOfFibonacci(int N){

             List <int> fibonacciSequence = new List<int> ();
             int n1 = 0;
             int n2 = 1;
             int n3;
            
            if(N < 0){
                return fibonacciSequence;
            }

            else if(N == 0){
                fibonacciSequence.Add(n1);
                return fibonacciSequence;
            }

            else{
                fibonacciSequence.Add(n1);
                fibonacciSequence.Add(n2);
                while(n1+n2 <= N){
                    n3 = n1 + n2;
                    fibonacciSequence.Add(n3);
                    n1 = n2;
                    n2 = n3;
                }
                return fibonacciSequence;
            }
        }
    }
}
