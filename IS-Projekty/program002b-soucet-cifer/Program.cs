using System;

class Program {
    static void Main() {
        
        string again = "a";
        
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("***********************************");
            Console.WriteLine("***** Ciferný součet a součin *****");
            Console.WriteLine("***********************************");
            Console.WriteLine("******* Matyáš Vyhnalík ***********");
            Console.WriteLine("***********************************");
            Console.WriteLine();


            Console.Write("Zadejte celé číslo: ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
            }

            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Cislo: {0}", number);

            string numberString = Math.Abs(number).ToString();
            int sum = 0;

            foreach (char digitChar in numberString) {
                int digitValue = digitChar - '0';
                sum += difitValue;
                Console.WriteLine("Momentální zbytek = {0}", digitChar);
            
            }

            Console.WriteLine("");

            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'A'");
            again = Console.ReadLine();

        }

    }
}    