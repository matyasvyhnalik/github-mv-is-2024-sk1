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
            int number
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
            }

            int suma = 0;
            int multi = 1;
            int numberBackup = number;
            int digit;

            if(number<0) {
                number = - number;
            }

            while(number >= 10) {
                digit = number % 10;
                number = (number-digit)/10;
                Console.WriteLine("Digit = {0}", digit);
                suma = suma + digit;
                multi = multi * number;
            }
            Console.WriteLine("Digit = {0}", number);

            //musime pricist jeste posledni cifru
            suma = suma + number;

            multi = multi * number;

            Console.WriteLine();
            Console.WriteLine("Součet cifer čísla {0} je {1}", numberBackup, suma);
            Console.WriteLine("Součin cifer čísla {0} je {1}", numberBackup, suma);


            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        }

    }
}    