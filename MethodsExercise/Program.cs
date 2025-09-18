using System.ComponentModel.DataAnnotations;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How was your day at the zoo?\nPlease, tell me your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Please, tell me your favorite zoo animal?");
            string favoriteZooAnimal = Console.ReadLine();
            Console.WriteLine("Please, tell me what you fed the zoo animals?");
            string animalFood = Console.ReadLine();
            Console.WriteLine("Please, tell me whom you fed?");
            string fedAnimal = Console.ReadLine();
            Console.WriteLine("Please, tell me what souvenir you chose from the gift shop?");
            string zooSouvenir = Console.ReadLine();
            DayAtTheZoo(userName, favoriteZooAnimal, animalFood, fedAnimal, zooSouvenir);

            Console.WriteLine("That story was fun! It's time for some arithmetic!\nThe sum of integers three, five, & seven?");
            Console.WriteLine($"The sum is {SumOfIntegers(3, 5, 7)}");
            Console.WriteLine($"The difference of integers thirteen, nine, & seven is {DifferenceOfIntegers(13, 9, 7)}");
            Console.WriteLine($"The product of integers three, nine, & eleven is {ProductOfIntegers(3, 9, 11)}");
            Console.WriteLine($"The quotient of integers twenty-one & six is {QuotientOfIntegers(21, 6)}");
        }
        
        //Console.WriteLine("Please, enter numbers to sum then type 'done' to finish!");
           //while (true)
          //  {
            //    string input = Console.ReadLine();
             //   if (input.ToLower() == "done")
             //   {
             //       break;
             //   }

             //   if (int.TryParse(input, out int number))
             //   {
                //    SumOfIntegers(number);
             //   }
             //   else
              //  {
              //      Console.WriteLine("Invalid input. Please enter a number or 'done'");
           //     }
          //  }

           // Console.WriteLine("The difference of integers!");
            //Console.WriteLine("Please, enter the numbers to subtract then type 'done' to finish!");
           // while (true)
           // {
            //    string input = Console.ReadLine();
            //    if (input.ToLower() == "done")
             //   {
              //      break;
              //  }
              //  if (int.TryParse(input, out int number))
               // {
                 //   DifferenceOfIntegers(number);
               // }
               // else
               // {
                //    Console.WriteLine("Invalid input. Please enter a number or 'done'");
               // }
           // }

           // Console.WriteLine("The product of integers!");
           // Console.WriteLine("Please, enter the numbers to multiply then type 'done' to finish!");
            //while (true)
            //{
             //   string input = Console.ReadLine();
             //   if (input.ToLower() == "done")
             //   {
              //      break;
              //  }
              //  if (int.TryParse(input, out int number))
             //   {
              //      ProductOfIntegers(number);
               // }
               // else
               // {
                //    Console.WriteLine("Invalid input. Please enter a number or 'done'");
                //}
           // }

           // Console.WriteLine("The quotient of integers!");
           // Console.WriteLine("Please, enter the numbers to multiply then type 'done' to finish!");
           // while (true)
           // {
            //    string input = Console.ReadLine();
            //    if (input.ToLower() == "done")
            //    {
            //        break;
             //   }
              //  if (int.TryParse(input, out int number))
              //  {
              //      QuotientOfIntegers(number);
             //   }
             //   else
             //   {
             //       Console.WriteLine("Invalid input. Please enter a number or 'done'");
             //   }
           // }

           public static void DayAtTheZoo(string userName, string favoriteZooAnimal, string animalFood, string fedAnimal,
                string zooSouvenir)
            {
                Console.WriteLine($"Today, {userName} went to the zoo!");
                Console.WriteLine($"The favorite animal of {userName} is the {favoriteZooAnimal}.");
                Console.WriteLine($"{userName} could have watched the {favoriteZooAnimal}s all day!");
                Console.WriteLine($"{userName} fed {animalFood} to the {fedAnimal}.");
                Console.WriteLine($"{userName} purchased a {zooSouvenir} at the zoo gift shop!");
            }

           public static int SumOfIntegers(params int[] numbers)
           {
              int sumInteger = 0;
               foreach (int number in numbers)
              {
                    sumInteger += number;
               }
            //    Console.WriteLine($"The sum is {sumInteger}");
                return sumInteger;
            }

            public static int DifferenceOfIntegers(params int[] numbers)
            {
                if (numbers.Length == 0) return 0;
                int differenceInteger = numbers[0];
                foreach (int number in numbers)
                {
                    differenceInteger -= number;
                }
              //  Console.WriteLine($"The difference is {differenceInteger}.");
                return differenceInteger;
            }

            public static int ProductOfIntegers(params int[] numbers)
            {
                int productInteger = 1;
                foreach (int number in numbers)
                {
                    productInteger *= number;
                }
             //   Console.WriteLine($"The product is {productInteger}");
                return productInteger;
            }

            public static double QuotientOfIntegers(params double[] numbers)
            {
                double quotientInteger = numbers[0];
                foreach (double number in numbers)
                {
                    quotientInteger /= number;
                }
            //    Console.WriteLine($"The quotient is {quotientInteger}");
                return quotientInteger;
            }
    }
}    