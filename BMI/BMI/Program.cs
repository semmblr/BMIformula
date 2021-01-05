using System;

namespace BMI
{
    class Program
    {
        private static int bmi;
        private static double height;
        private static double weight;

        static void Main(string[] args)
        {
            
                Console.WriteLine("Lütfen boyunuzu giriniz : ");
                height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Lütfen kilonuzu giriniz : ");
                weight = Convert.ToDouble(Console.ReadLine());
            
            

            static decimal Calculate(double weight, double height)
            {
                decimal bmi = 0;
                bmi = (decimal)Math.Pow((weight / (height * height)), 2);
                
                return Math.Round(bmi, 2);
}

            if (bmi <= 18.4)
            {
                Console.WriteLine("Under  weight");
            }
             else if (bmi >18.5 & bmi <24.9)
            {
               
                    Console.WriteLine("Normal Weight"); 
               
            }
            else if (bmi > 25 & bmi < 29.9)
            {

                Console.WriteLine("Over Weight");

            }
            else if (bmi > 30 & bmi < 34.9)
            {

                Console.WriteLine("Obesity (Class 1)");

            }
            else if (bmi > 35 & bmi < 39.9)
            {

                Console.WriteLine("Obesity (Class 2)");

            }

            else if (bmi >=40 )
            {

                Console.WriteLine("Obesity (Class 3)");

            }


            Console.ReadLine();
        }
        
       
    }
}
