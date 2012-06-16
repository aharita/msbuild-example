// A very naive calculator, which whole purpose is to create an MSBuild file and do some unit testing and
// code coverage

using System;

namespace Calculator
{
    public static class Operations
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new Exception("Can't divide by 0");
            }

            return x / y;
        }
    }
}
