using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public IList<string> GetElements()
        {
            IList<string> elements = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                bool isFizz = i % 3 == 0;
                bool isBuzz = i % 5 == 0;

                if (isFizz && isBuzz)
                {
                    elements.Add("FizzBuzz");
                }
                else if (isFizz)
                {
                    elements.Add("Fizz");
                }
                else if (isBuzz)
                {
                    elements.Add("Buzz");
                }
                else
                {
                    elements.Add(i.ToString());
                }
            }

            return elements;
        }
    }
}