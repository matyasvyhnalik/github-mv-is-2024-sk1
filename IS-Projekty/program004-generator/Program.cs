
﻿using System;

class Program {
    static void Main() {
        
        string again = "a";
        
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("***** Generátor preudonáhodných čísel *****");
            Console.WriteLine("****************************");
            Console.WriteLine("******* Matyáš Vyhnalík ********");
            Console.WriteLine("****************************");
            Console.WriteLine();

            Console.WriteLine("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
            }

            Console.WriteLine("Zadejte dolní mez: ");
            int dn;
            while(!int.TryParse(Console.ReadLine(), out dn)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
            }

            Console.WriteLine("Zadejte horní mez: ");
            int hn;
            while(!int.TryParse(Console.ReadLine(), out hn)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("*******************************");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dn, hn);
            Console.WriteLine("*******************************");
            Console.WriteLine();

            //deklarace pole
            int[] myArray = new int[n];

            Random randomNumber = new Random();

            Console.WriteLine("\n\nNáhodná čísla: ");
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dn,hn);
                Console.Write("{0}; ", myArray[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        }

    }
}    
