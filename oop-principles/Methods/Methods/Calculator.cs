using System;
namespace Methods
{
    public class Calculator
    {
        public int Add(params int[] numbers) // the keyword "params" lets us not to initialize an arrary (new int[] {1,2,3,4})
        {
            var sum = 0;

            foreach (var number in numbers)
            {
                sum += number; 
            }

            return sum;
        }
    }
}
