using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHelloWorld
{
    internal class CalculateBMI
    {
        static void Main(string[] args)
        {
            string? flag = "";
            while (flag != "Q")
            {
                string? name = "";
                string? weight = "";
                string? height = "";

                Console.Clear();
                //Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("----------------++++----------------");
                Console.WriteLine("BMI Calculator");
                Console.WriteLine();
                while (name == "" || name == null || name == " " || name.Any(char.IsDigit) || name.Length < 2)
                {
                    Console.Write("Please, enter your name (eng): ");
                    name = Console.ReadLine();

                    if (name == "" || name == null || name == " " || name.Any(char.IsDigit) || name.Length < 2)
                    {
                        Console.WriteLine("Name cannot be empty. Please try again.");
                    }
                }
                line("-", 30);
                Console.WriteLine("Welcome to BMI Calculator, " + name + "!");
                line("-", 30);
                while (weight == "" || weight == null || weight == " " || weight.Length < 2)
                {
                    Console.Write("Please, enter your weight (kg): ");
                    weight = Console.ReadLine();
                    if (weight == "" || weight == null || weight == " " || weight.Length < 2)
                    {
                        Console.WriteLine("Weight must be a number. Please try again.");
                    }
                }

                while (height == "" || height == null || height == " " || !height.All(char.IsDigit) || height.Length < 2)
                {
                    Console.Write("Please, enter your height (cm): ");
                    height = Console.ReadLine();
                    if (height == "" || height == null || height == " " || !height.All(char.IsDigit) || height.Length < 2)
                    {
                        Console.WriteLine("Height must be a number. Please try again.");
                    }
                }
                line("-", 30);
                double weightDouble = Convert.ToDouble(weight);
                double heightDouble = Convert.ToDouble(height);
                double bmi = CalculateBMI(weightDouble, heightDouble);
                Console.WriteLine("Your BMI is " + bmi.ToString("#,##0.00"));
                if (bmi < 18.5)
                {
                    Console.WriteLine("You are underweight.");
                }else if (bmi > 18.5 && bmi < 25)
                {
                    Console.WriteLine("You are in the normal weight range.");
                }else if (bmi > 25 && bmi < 30)
                {
                    Console.WriteLine("You are overweight.");
                }
                else
                {
                    Console.WriteLine("You are obese.");

                }
                line("-", 30);
                Console.Write("Press Q to quit or any other key to continue: ");
                flag = Console.ReadLine()?.ToUpper();
            }
            static void line(string ch, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
            static double CalculateBMI(double weight, double height)
            {
                double heightInMeters = height / 100;
                double bmi = weight / Math.Pow(heightInMeters, 2);
                return bmi;
            }
        }
        
    }
}
