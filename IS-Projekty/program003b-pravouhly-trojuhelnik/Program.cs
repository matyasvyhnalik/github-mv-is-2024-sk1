﻿string again = "a";
while(again == "a") {

            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("** Pravoúhlý trojúhelník ***");
            Console.WriteLine("******* Matyáš Vyhnalík ****");
            Console.WriteLine("****************************");
            Console.WriteLine();

            Console.Write("Zadejte celé číslo: ");
            uint a;
            while(!uint.TryParse(Console.ReadLine(), out a)) {
                Console.Write("Nezadali jste celé číslo. Zadejte první číslo znovu: ");
            }


            Console.WriteLine();
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Šířka: {0}", a);

            for(int y = 1; y <= a ;y++){
                for(int x = 1; x <= y ;x++){
                   Console.Write("* "); 
                   System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine(); 

}