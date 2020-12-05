using System;

namespace CoverageTestLib
{
    public class CoverageTest
    {
        public CoverageTest(string someValue)
        {
            Value = someValue;
        }

        public string Value { get; }

        public void DoSomething()
        {
            Console.WriteLine($"The value is {Value}.");
        }
    }
}
