using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPracticeProblem
{
    /*
     * Murali is attending a quiz. In the quiz, the question contains an integer N,
        Murali has to tell the closest number to N where all the digits of that
        number are even.
        In case of a tie between two numbers, choose the smallest one. Write a
        program to find the number.
        Explanation:
        In the example, the number is 17. The closest number that has all even
        digits in it is 20. So the output should be 20.
        In example two, the number is -33. The closest number that has all even
        digits in it is -28. So the output should be -28.
     */
    public class ClosestEvenNumber
    {
        public static void CloesestEvenNoMainMethod()
        {
            Console.WriteLine("Enter the number:");
            int N = int.Parse(Console.ReadLine());

            int closestEvenNumber = FindClosestEvenNumber(N);

            Console.WriteLine("Closest number with all even digits: " + closestEvenNumber);
        }

        public static int FindClosestEvenNumber(int N)
        {
            int closestNumber = N;
            int increment = 1;
            int decrement = -1;

            if (N < 0)
            {
                increment = -1;
                decrement = 1;
            }

            while (true)
            {
                closestNumber += increment;

                if (ContainsOnlyEvenDigits(closestNumber))
                    return closestNumber;

                closestNumber = N;

                while (true)
                {
                    closestNumber += decrement;

                    if (ContainsOnlyEvenDigits(closestNumber))
                        return closestNumber;
                }
            }
        }

        public static bool ContainsOnlyEvenDigits(int number)
        {
            string digits = Math.Abs(number).ToString();

            foreach (char digit in digits)
            {
                if ((digit - '0') % 2 != 0)
                    return false;
            }

            return true;
        }
    }
}
