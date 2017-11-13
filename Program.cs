using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp22
{
	class Program
	{
		static void Main(string[] args)
		{

            //// <summary>
            /// Standart, indstillinger for spillet. </summary>
            int guld = 500;
			int army = 300;
           
			lande england = new lande();
			lande frankrig = new lande();
			lande spainien = new lande();
			lande norge = new lande();
			lande sverige = new lande();
			lande ireland = new lande();


            ArrayList al = new ArrayList();
            al.Add("England");
            al.Add("Frankrig");
      

            /// <summary>
            /// Antal mænd de forskellige lande har.
            /// 
            /// </summary>

            String war = "England, Frankrig";
			england.men = 200;
			frankrig.men = 800;
			spainien.men = 1200;


            // <summary>
            // En lille fortælling
            // </summary>

			Console.WriteLine("Vi er taget 1100.år, Tilbage i tiden");
			Thread.Sleep(500);
			Console.WriteLine("Nemlig til vikinge tiden");
			Thread.Sleep(500);
			Console.WriteLine("Du er nu blevet den ny hersker af Kategat, hvad vil du gøre?");
			Console.WriteLine();
			Thread.Sleep(800);
            Console.WriteLine("Kommands");
            Console.WriteLine("stats - for at se dine ressourcer");
            Console.WriteLine("shop - for at købe ting");
			Console.WriteLine("krig - for at plyndre andre lande");
            Console.WriteLine("");
            
      

            /* Så længe, man har mere end 1 mand forsætter spillet */
            while (army > 1)

            {

                string menu = Console.ReadLine();


			    if (menu == "stats")

			    {
				    Console.WriteLine("Guld: " + guld);
                    Console.WriteLine("Hær: " + army);
                    
			    }

                if (menu == "getsmall")
                {
                    if (guld < 100)
                    {
                        Console.WriteLine("Du har ikke nok guld");
                    }

                    if (guld > 99)
                    {
                    guld = guld - 100;
                    army = army + 50;
                    Console.WriteLine("Du har købt 50 mænd for 100 guld");
                    }
                }

                if (menu == "krig")
                {
                    Console.WriteLine("Her er en liste, over lande du kan angribe");
                    Console.WriteLine(war);
                    Console.WriteLine("Du skriver navnet på et land for angribe");

                }

               // <summary>
               // Shop, hvor esktra mænd kan købes
               // </summary>
                if (menu == "shop")
                {
                    Console.WriteLine("Du kan købe:");
                    Console.WriteLine("getsmall - køb 50 mænd for 100 Guld");
                    Console.WriteLine("getbig - køb 200 mænd for 350 Guld");
                    Console.WriteLine("getall - køb 500 mænd for 800 Guld");                    
                }

                if (menu == "England")
                {

                    /* Tjekker om england har flere mænd */
                    if (england.men < 1)
                    {

                        Console.WriteLine("Du har allerede besejret england");
                    }

                    if (england.men > 1)
                    {
                        Console.WriteLine("Angriber england");

                        if (army > england.men)
                        {
                            Console.WriteLine("Du har vundet krigen mod england");
                            army = army - england.men;
                            england.men = 0;
                            Console.WriteLine("Din trup er nu på: " + army + " mænd");
                            guld = guld + 800;
                            Console.WriteLine("Din vender tilbage med 800 esktra guld");
                        }
                    }
                }

                /* Frankrig */

                if (menu == "Frankrig")
                {

                    /* Tjekker om england har flere mænd */
                    if (frankrig.men < 1)
                    {

                        Console.WriteLine("Du har allerede besejret Frankrig");
                    }

                    if (frankrig.men > 1)
                    {
                        Console.WriteLine("Angriber Frankrig");

                        if (army > frankrig.men)
                        {
                            Console.WriteLine("Du har vundet krigen mod Frankrig");
                            army = army - frankrig.men;
                            frankrig.men = 0;
                            Console.WriteLine("Din trup er nu på: " + army + " mænd");
                            guld = guld + 1200;
                            Console.WriteLine("Din vender tilbage med 1200 esktra guld");
                        }

                        // <summary>
                        //</summary>

                        else if (army < frankrig.men )
                        {
                            frankrig.men = frankrig.men - army;
                            army = army - frankrig.men;
                            Console.WriteLine("Din hær er død, frankrig har: " + frankrig.men + "mænd tilbage");
                        }
                        
                    }
                }


                if (army < 1)
                {
                    Console.WriteLine("Du har tabt");
                }

            }   

	        Console.ReadLine();
        }
    }
	class lande
	{
		public int men;

	}
}
