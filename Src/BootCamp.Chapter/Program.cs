using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //This code accepts the name of the individual
            Console.Write("Name:");
            var name = Console.ReadLine();
            //Accept the age
            Console.Write("Age:");
            var age = Console.ReadLine();
            //Accept the weight- since this will be used in a calculation, you'll need to use either "int.Parse" or "double.Parse" to convert it to its respective type
            Console.Write("Weight:");
            var weight = float.Parse(Console.ReadLine());
            //Accept the height
            Console.Write("Height (cm):");
            var height = float.Parse(Console.ReadLine()) / 100;

            var BMI = weight / (height * height);
            Console.WriteLine("Your BMI is " + BMI);


            //This code accepts the second individual's info from here on out
            Console.Write("Second Name:");
            var nameSecond = Console.ReadLine();
            //Accept the age
            Console.Write("Second Age:");
            var ageSecond = Console.ReadLine();
            //Accept the weight- since this will be used in a calculation, you'll need to use either "int.Parse" or "double.Parse" to convert it to its respective type
            Console.Write("Second Weight:");
            var weightSecond = float.Parse(Console.ReadLine());
            //Accept the height
            Console.Write("Second Height (cm):");
            var heightSecond = float.Parse(Console.ReadLine()) / 100;

            var BMISecond = weightSecond / (heightSecond * heightSecond);
            Console.WriteLine("The second person's BMI is " + BMISecond);
        }
    }
}
