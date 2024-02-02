using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Komodo_Repository;


    public class KomodoInsurance_UI
    {
        DeveloperRepo _DevRepo = new DeveloperRepo();
        DevTeamRepo _DTRepo = new DevTeamRepo();

        public void Run()
        {
            RunApplication();
        }

        private void RunApplication()
        {
            bool isRunning = true;
            while(isRunning)
            {     
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(
                    " \t \n"+ 
                    " \t=========== Komodo Insurance Application ================\n" +
                    " \t           <============================>                \n"  
                );

                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine(
                    " \tThis Application will help Product Managers to manage \n" +
                    " \t              a team of Developers                            \n" 
                );

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(
                    " \t Please Select from the following: \n"
                    );

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(
                    " \t    DeveloperTeam  \n" +
                    "\t    --------------- \n"
                    );
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(
                " \t1. Add DeveloperTeam\n" +
                " \t2. Get DeveloperTeam\n" +
                " \t4. Delete DeveloperTeam \n"
                );
                
                string userInput = Console.ReadLine().ToLower();
                switch(userInput)
                {
                    case "x":
                        isRunning = CloseApplication();
                        break;

                    default:
                    Console.WriteLine("invalid Selection");
                    PressAnyKey();
                    break;
                }

                Console.WriteLine(
                    " \t========== \n" +
                    " \tX. Exit\n" +
                    " \t========== \n"
                );
                
            }
        }


        private bool CloseApplication()  
        {    
            Console.WriteLine("\"Have a good day.\"");
            PressAnyKey();
            return false;
        }

        private void PressAnyKey() 
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine("\tPress Any Key to Continue...");
            Console.ResetColor();
            Console.ReadKey();
        }

        }
