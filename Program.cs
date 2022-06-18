using System;

namespace AlphaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("================ Question 1 ==================");

            Console.WriteLine("Enter the firstword");
            string firstword = Console.ReadLine();
            Console.WriteLine("Enter the secondword");
            string secondword = Console.ReadLine();
            int sum = (firstword.Length + secondword.Length);
            Console.WriteLine("The length of the firstword is " + firstword.Length + " and the length of the second word is " + secondword.Length);
            Console.WriteLine("The sum of the lengths is " + sum);
            int message;
            message = (firstword.Length + secondword.Length > 20) ? (firstword.Length + secondword.Length * 3) : (firstword.Length + secondword.Length + 20);
            Console.WriteLine(message);*/


            /*Console.WriteLine("===================== Question 2 =========================");
            decimal costprice;
            costprice = 200.876m;
            decimal sellingprice;
            sellingprice = 255.425m;
            decimal profit = (sellingprice - costprice);
            Console.WriteLine($"The profit made is ${sellingprice - costprice}");
            Console.WriteLine($"The profit made is ${Math.Round(profit,2)}");*/



            /*Console.WriteLine("======================= Question 3 ======================");
            Console.WriteLine("Enter any word");
            String name = Console.ReadLine();
            int index = (int)name[3];
            int wordLength = name.Length;
            int sum = name.IndexOf(name[3]) + name.Length;
            char result = (char)sum;

            Console.WriteLine($"The Index of third character is {name.IndexOf(name[3])}");
            Console.WriteLine($"The length of the string is {name.Length}");
            Console.WriteLine($"The sum of the index and the length is {sum}");
            Console.WriteLine($"The character of the answer is {(char)sum}");*/



            /*Console.WriteLine("======================== Question 4 =======================");
            Console.WriteLine("Enter your first number");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your first number is {firstnumber} and your second number is {secondnumber}");
            Console.WriteLine($"The larger number is {Math.Max(firstnumber,secondnumber)}");*/
            
            /*Console.WriteLine("======================== Question 5 =======================");

            int sum = 0;
            int i = 0;
            while (i <= 4)
            {
                Console.Write("Please enter number:");

                string input = Console.ReadLine();
                int x;
                bool isInteger = int.TryParse(input, out x);
                if (!isInteger);
                {
                    i--;
                    Console.Write("Invalid input!");

                }
                sum += x;
                i++;
            }
            Console.WriteLine($"The sum of the number is :{sum}");


            Console.WriteLine("Enter the first integer number");
            int firstno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer number");
            int secondno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third integer number");
            int thirdno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the forth integer number");
            int forthno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fifth integer number");
            int fifthno = Convert.ToInt32(Console.ReadLine());
            int sum = (firstno + secondno + thirdno + forthno + fifthno);
            Console.WriteLine("The sum of the five integer numbers is " + sum);
            while (true);
                {
                    Console.WriteLine("Enter a valid integer number");
                }*/
           
           
           
            Console.WriteLine("======================== Question 6 =======================");
            const int value = 5;
            Console.WriteLine ("Enter number 1");
            double number1 = int.Parse(Console.ReadLine());
            Console.WriteLine ("Enter number 2");
            double number2 = int.Parse(Console.ReadLine());
            double sum = number1 + number2 - value;
            Console.WriteLine("Enter the correct answer");
            double correct = int.Parse(Console.ReadLine);
            
                string result = (sum == correct) ? "Correct Answer!" : $"Wrong Answer! The correct answer is {sum}";
                Console.WriteLine(result);
            

            Console.WriteLine("======================== Question 7 =======================");
            Console.WriteLine("Enter any number from 0-9");
            String number = Console.ReadLine();
            switch(number)
            {
                case "0":Console.WriteLine("Zero");break;
                case "1":Console.WriteLine("One");break;
                case "2":Console.WriteLine("Two");break;
                case "3":Console.WriteLine("Three");break;
                case "4":Console.WriteLine("Four");break;
                case "5":Console.WriteLine("Five");break;
                case "6":Console.WriteLine("Six");break;
                case "7":Console.WriteLine("Seven");break;
                case "8":Console.WriteLine("Eight");break;
                case "9":Console.WriteLine("Nine");break;
            
                default: Console.WriteLine("Invalid digit, input a valid one"); break;
            }
            
            
            

            
            



        }
    }
}
