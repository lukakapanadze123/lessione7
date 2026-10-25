namespace lessione7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pirveli davaleba - studentis qulebi

            //lokaluri funqcia - amowmebs qula 0-dan 100-mde aris tu ara
            bool IsValidScore(int score)
            {
                return score >= 0 && score <= 100;
            }

            Console.WriteLine("Enter first score");
            bool isFirstValid = int.TryParse(Console.ReadLine(), out int first);

            Console.WriteLine("Enter second score");
            bool isSecondValid = int.TryParse(Console.ReadLine(), out int second);

            Console.WriteLine("Enter third score");
            bool isThirdValid = int.TryParse(Console.ReadLine(), out int third);

            if (!isFirstValid || !isSecondValid || !isThirdValid)
            {
                Console.WriteLine("Invalid input");
            }
            else if (!IsValidScore(first) || !IsValidScore(second) || !IsValidScore(third))
            {
                Console.WriteLine("Score must be from 0 to 100");
            }
            else
            {
                double average = CalculateAverage(first, second, third);

                Console.WriteLine($"Average: {average}");
                Console.WriteLine($"Grade: {GetGrade(average)}");

                if (IsPassed(average))
                {
                    Console.WriteLine("Status: Passed");
                }
                else
                {
                    Console.WriteLine("Status: Failed");
                }
            }



            //meore davaleba - ricxvis analizi

            //lokaluri funqcia - amowmebs ricxvi dadebitia tu ara
            bool IsPositive(int value)
            {
                return value > 0;
            }

            Console.WriteLine("Enter a whole number");
            bool isNumberValid = int.TryParse(Console.ReadLine(), out int number);

            if (!isNumberValid)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                if (IsEven(number))
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }

                if (IsPrime(number))
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }

                Console.WriteLine($"Digits: {CountDigits(number)}");
                Console.WriteLine($"Reversed: {ReverseNumber(number)}");

                if (IsPositive(number))
                {
                    Console.WriteLine("Positive");
                }
                else
                {
                    Console.WriteLine("Not positive");
                }
            }
        }



        //pirveli davalebis metodebi

        static double CalculateAverage(int first, int second, int third)
        {
            return (first + second + third) / 3.0;
        }

        static string GetGrade(double average)
        {
            if (average >= 90)
            {
                return "A";
            }
            else if (average >= 80)
            {
                return "B";
            }
            else if (average >= 70)
            {
                return "C";
            }
            else if (average >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        static bool IsPassed(double average)
        {
            return average >= 60;
        }



        //meore davalebis metodebi

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static int CountDigits(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            int count = 0;

            while (number != 0)
            {
                number /= 10;
                count++;
            }

            return count;
        }

        //string-s vabrunebT, rom nulebi ar dakargos (1200 -> 0021)
        static string ReverseNumber(int number)
        {
            string text = number.ToString();
            string result = "";
            int stop = 0;

            if (number < 0)
            {
                result = "-";
                stop = 1;
            }

            for (int i = text.Length - 1; i >= stop; i--)
            {
                result += text[i];
            }

            return result;
        }
    }
}