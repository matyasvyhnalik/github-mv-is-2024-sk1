using System;
class Program
{
    static void Main()
    {
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("*******************************");
            Console.WriteLine("**** Součet cifer *************");
            Console.WriteLine("******** Matyáš Vyhnalík ******");
            Console.WriteLine("*******************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Zadejte celé číslo: ");
            string input = Console.ReadLine();
            int number;
            while (!int.TryParse(input, out number)){
                Console.Write("Nezadali jste celé číslo. Zadejte první číslo znovu: ");
                input = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("číslo: {0}", number);
            string numberString = Math.Abs(number).ToString();
            int sum = 0; 
            foreach (char digitChar in numberString){
                
                int digitValue = digitChar - '0';
                sum += digitValue;
                Console.WriteLine("Aktuální zbytek = {0}", digitChar);
            }
            Console.WriteLine("\n\nSoučet cifer čísla {0} je {1}", number, sum);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'A'");
            again = Console.ReadLine();
        }
    }
}