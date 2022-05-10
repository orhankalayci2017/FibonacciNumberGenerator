using System;

namespace FibonacciNumberGenerator
{
    internal class FibonacciNumberGeneratorClass
    {
        public FibonacciNumberGeneratorClass()
        {
        }

        private bool checkIfIndexValid(int index)
        {
            return (index >= 0);
        }

        internal int errorCode()
        {
            return -321;
        }

        internal int getFibonnaci(int index)
        {
            if (!checkIfIndexValid(index)) return errorCode();
            return fibonnaciNumberCalculatingBusinessRules(index);

        }


        internal int fibonnaciNumberCalculatingBusinessRules(int index)
        {

            int fibonacciNumber = 0 ;

            if (index == 0) { fibonacciNumber = 0; return fibonacciNumber; }
            if (index == 1) { fibonacciNumber = 1; return fibonacciNumber; }


            int twoBefore = 0;
            int oneBefore = 1;

            while (index-- > 1)
            {
                fibonacciNumber = oneBefore + twoBefore;

                twoBefore = oneBefore;
                oneBefore = fibonacciNumber;

            }

            return fibonacciNumber;

        }


    }
}