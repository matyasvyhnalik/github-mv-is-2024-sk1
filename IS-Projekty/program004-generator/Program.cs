
﻿using System;
using System.Threading.Tasks.Dataflow;

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

            int down = 0;
            int nula = 0;
            int up = 0;
            int suda = 0;
            int licha = 0;

            Console.WriteLine("\n\nNáhodná čísla: ");
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dn,hn);
                Console.Write("{0}; ", myArray[i]);

                //if(myArray[i]>0)
                  //  up++;
                //if(myArray[i]<0)
                  //  down++;
                //if(myArray[i]==0)
                //nula++;

                if(myArray[i]>0)
                    up++;
                else if(myArray[i]<0)
                    down++;
                else
                    nuly++;

                if(myArray[i] % 2 == 0)
                    suda++;
                else
                    licha++;


            }

            Console.WriteLine();
            Console.WriteLine("\n\nPočet kladných čísel: {0}", up);
            
            Console.WriteLine("Počet záporných čísel: {0} ", down);
            Console.WriteLine("Počet nul: {0}", nula);          
            Console.WriteLine("Počet sudých čísel: {0}", suda);
            Console.WriteLine("Počet lichých čísel: {0}", licha);  

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        }

    }
}    
