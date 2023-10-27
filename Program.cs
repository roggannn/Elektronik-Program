using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int FB1 = 0;
            int FB2 = 0;
            int FB3 = 0;
            int FB4 = 0;
            double FB4d = 0;


            while(true)
            {
                Console.Clear();
                Console.WriteLine("Vad är det du vill räkna ut?");

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. Resistans");
                Console.WriteLine("2. Ström");
                Console.WriteLine("3. Spänning");
                Console.WriteLine("4. Effekt");
                Console.WriteLine("5. Tau");
                Console.WriteLine("6. Kapacitans");
                Console.WriteLine("7. Laddningsmängd");
                Console.WriteLine("8. Kapacitiv reaktans");
                Console.WriteLine("9. Förkorta t.ex. nF till bara F (farad)");
                Console.WriteLine("10. Räkna ut kapacitansen av en kondensator genom färgbanden");
                Console.WriteLine("11. Räkna ut resistansen av en resistor genom färgbanden");
                Console.ForegroundColor= ConsoleColor.White;
                string menySvar = Console.ReadLine();

                switch (menySvar)
                {
                    case "1":
                        {
                            Console.WriteLine("Går till 'Resistans' menyn...");
                            Task.Delay(650).Wait();
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("");
                            Console.WriteLine("1. Räkna ut resistans hos en resistor genom färgband");
                            Console.WriteLine("2. Räkna ut resistansen inom en krets");
                            Console.WriteLine("");
                            string menuSvar = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;

                            switch (menuSvar)
                            {
                                case "1":
                                    {
                                        Console.WriteLine("Hur många färgband har resistorn?");
                                        string färgband = Console.ReadLine();

                                        switch (färgband)
                                        {
                                            case "4":
                                                {
                                                    Console.WriteLine("Skriv in färgen på första bandet");
                                                    string färg1 = Console.ReadLine().ToLower();
                                                    Console.WriteLine("Skriv in färgen på andra bandet");
                                                    string färg2 = Console.ReadLine().ToLower();
                                                    Console.WriteLine("Skriv in färgen på tredje bandet");
                                                    string färg3 = Console.ReadLine().ToLower();
                                                    Console.WriteLine("Skriv in färgen på fjärde bandet");
                                                    string färg4 = Console.ReadLine().ToLower();

                                                    switch (färg1)
                                                    {
                                                        case "röd":
                                                            {
                                                                FB1 = 2;
                                                                break;
                                                            }
                                                        case "gul":
                                                            {
                                                                FB1 = 4;
                                                                break;
                                                            }
                                                        case "blå":
                                                            {
                                                                FB1 = 6;
                                                                break;
                                                            }
                                                        case "brun":
                                                            {
                                                                FB1 = 1;
                                                                break;
                                                            }
                                                        case "orange":
                                                            {
                                                                FB1 = 3;
                                                                break;
                                                            }
                                                        case "grön":
                                                            {
                                                                FB1 = 5;
                                                                break;
                                                            }
                                                        case "lila":
                                                            {
                                                                FB1 = 7;
                                                                break;
                                                            }
                                                        case "grå":
                                                            {
                                                                FB1 = 8;
                                                                break;
                                                            }
                                                        case "vit":
                                                            {
                                                                FB1 = 9;
                                                                break;
                                                            }
                                                        case "svart":
                                                            {
                                                                FB1 = 0;
                                                                break;
                                                            }
                                                    }
                                                    switch (färg2)
                                                    {
                                                        case "röd":
                                                            {
                                                                FB2 = 2;
                                                                break;
                                                            }
                                                        case "gul":
                                                            {
                                                                FB2 = 4;
                                                                break;
                                                            }
                                                        case "blå":
                                                            {
                                                                FB2 = 6;
                                                                break;
                                                            }
                                                        case "brun":
                                                            {
                                                                FB2 = 1;
                                                                break;
                                                            }
                                                        case "orange":
                                                            {
                                                                FB2 = 3;
                                                                break;
                                                            }
                                                        case "grön":
                                                            {
                                                                FB2 = 5;
                                                                break;
                                                            }
                                                        case "lila":
                                                            {
                                                                FB2 = 7;
                                                                break;
                                                            }
                                                        case "grå":
                                                            {
                                                                FB2 = 8;
                                                                break;
                                                            }
                                                        case "vit":
                                                            {
                                                                FB2 = 9;
                                                                break;
                                                            }
                                                        case "svart":
                                                            {
                                                                FB2 = 0;
                                                                break;
                                                            }
                                                    }
                                                    switch (färg3)
                                                    {
                                                        case "röd":
                                                            {
                                                                FB3 = 100;
                                                                break;
                                                            }
                                                        case "gul":
                                                            {
                                                                FB3 = 10000;
                                                                break;
                                                            }
                                                        case "blå":
                                                            {
                                                                FB3 = 1000000;
                                                                break;
                                                            }
                                                        case "brun":
                                                            {
                                                                FB3 = 10;
                                                                break;
                                                            }
                                                        case "orange":
                                                            {
                                                                FB3 = 1000;
                                                                break;
                                                            }
                                                        case "grön":
                                                            {
                                                                FB3 = 100000;
                                                                break;
                                                            }
                                                        case "lila":
                                                            {
                                                                FB3 = 10000000;
                                                                break;
                                                            }
                                                        case "grå":
                                                            {
                                                                FB3 = 100000000;
                                                                break;
                                                            }
                                                        case "vit":
                                                            {
                                                                FB3 = 1000000000;
                                                                break;
                                                            }
                                                        case "svart":
                                                            {
                                                                FB3 = 1;
                                                                break;
                                                            }
                                                    }
                                                    switch (färg4)
                                                    {
                                                        case "röd":
                                                            {
                                                                FB4 = 2; 
                                                                break;
                                                            }
                                                        case "blå":
                                                            {
                                                                FB4d = 0.25;
                                                                break;
                                                            }
                                                        case "brun":
                                                            {
                                                                FB4 = 1;
                                                                break;
                                                            }
                                                        case "grön":
                                                            {
                                                                FB4d = 0.5;
                                                                break;
                                                            }
                                                        case "lila":
                                                            {
                                                                FB4d = 0.1;
                                                                break;
                                                            }
                                                        case "grå":
                                                            {
                                                                FB4d = 0.05;
                                                                break;
                                                            }
                                                        case "guld":
                                                            {
                                                                FB4 = 5;
                                                                break;
                                                            }
                                                        case "silver":
                                                            {
                                                                FB4 = 10;
                                                                break;
                                                            }
                                                    }


                                                   
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Resistansen i resistorn är " + );


                                                    break;
                                                }
                                        }
                                        
                                        break;
                                    }
                                case "2":
                                    {
                                        break;
                                    }
                            }


                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine();
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine();
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine();
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine();
                            break;
                        }
                    case "8":
                        {
                            Console.WriteLine();
                            break;
                        }
                    case "9":
                        {
                            Console.WriteLine();
                            break;
                        }
                    case "10":
                        {
                            Console.WriteLine();
                            break;
                        }
                    case "11":
                        {
                            Console.WriteLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Välj ett av alternativen från listan.");
                            break;
                        }
                        
                }
            }
            
        }
    }
}