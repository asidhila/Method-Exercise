using System;

namespace MethodsExercise
{
    class Program
    { 
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;

        }
        public static int Multi (int num1, int num2)
        {
            var answer = num1 * num2;
            return answer;
        }
        public static int Add (params int[]list)
        {
            int Sum = 0;
            for (int x = 0;x < list.Length;x++)
            {
                Sum = Sum + list[x];
            }
            return Sum;
        }
        
        
        
    

    
        static void Main(string[] args)
        { 
         var amountOfcars = Sum(2, 6);
            var numberOfBuyers = Multi(4, 6);
            var basketball = Add(3, 5, 7, 9);
            Console.WriteLine(numberOfBuyers);
            Console.WriteLine(basketball);

            Console.WriteLine(amountOfcars);
           //-------- Exercise 1-------
            //Name: Simmons
            //Favorite Color: Black
            //Favorite Animal: Dog
            //Favorite Band : The Beatles
        
            Console.WriteLine("Hello - What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi,{userName},What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color!What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great !Now,what is your band? ");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks,{userName}! Here is your profile");
            Console.WriteLine($"{userName}");
            Console.WriteLine($"Favorite color{color}");
            Console.WriteLine($"Favorite animal{animal}");
            Console.WriteLine($"Favorite band{band}");

            //-----------------------Exercise 2--------------------------------

        }
    }
}
