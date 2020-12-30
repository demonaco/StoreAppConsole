using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreAppConsole
{
    class Program
    {
        static Customers customer = new Customers();
        static RepositoryLayer rl = new RepositoryLayer();
        static Locations locations = new Locations(); 
        static int locationChoices = Enum.GetNames(typeof(lEnum)).Length;
        // static int LocateChoice = Enum.GetNames(typeof(Locations)).Length;

        // int locationOptions = enum.GetLocations(typeof(Locations)).Length;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, and welcome to Shoe City! We hope you enjoy your shopping experience!");

            
            int userIsLoggedIn;

            do{
            userIsLoggedIn = HomeScreen();


           if(userIsLoggedIn == 2)
           {
               Console.WriteLine("Goodbye!");
               break;
           }


            //change this list select * from customers column once DB implemented
            String[] listOfLoggedInCust = CustomerList();

            // }
            RepositoryLayer rl = new RepositoryLayer();
            // List<locationsObj> locate = new List<locationsObj>();

            Customers customerToBeAdded;
            if(listOfLoggedInCust.Length == 1)
            {
                customerToBeAdded = rl.AddCustomer(FirstN: listOfLoggedInCust[0]); 
            } else if (listOfLoggedInCust.Length > 1)
            {
                customerToBeAdded = rl.AddCustomer(listOfLoggedInCust[0], listOfLoggedInCust[1]);
            } else
            {
                throw new ArgumentNullException("Input was not valid");
            }


            List<Customers> customers = rl.RetreiveCustomers();
            List<Locations> locations = rl.RetreiveLocation();
            // List<locationsObj> locate = locate.CU();

           CustomerData(customers);
           
            
          
            String[] LocationsOpts = {"Los Angeles", "San Francisco", "Seattle", "Dallas", "Miami", "NYC", "Minneapolis", "Denver"};
 
            for(var i = 0; i < LocationsOpts[i].Length; i++){

               Console.WriteLine("Please select a location to shop at with the corresponding numerical value: \t\n0.Los Angeles, \t\n1.San Francisco, \t\n2.Seattle, \t\n3.Dallas, \t\n4.Miami, \t\n5.NYC, \t\n6.Minneapolis, \t\n7.Denver\t\n.");
            
            Int32 decisionL = 0;
            do 
            {
                String selectionL = Console.ReadLine(); 

                Int32.TryParse(selectionL, out decisionL);
               
                
           } while(decisionL < 1 || decisionL > (LocationsOpts.Length + 1));

           Console.WriteLine("You have chosen {0} as your shopping location.", LocationsOpts[i]);

                
        //    do
        //    {
        //        Locations location = rl.AddLocation(c1);
        //        do
        //        {
        //        lEnum locationPick = LocationMenu(locations);

        //        Console.WriteLine($"You have chosen {}.");
        //        } while(locations = true);
        //    } while();

            // string[] LocationChoice = { "\t\n1.Los Angeles", "\t\n2.San Francisco", "\t\n3.Seattle", "\t\n4.Dallas", "\t\n5.Miami", "\t\n6.NYC", "\t\n7.Minneapolis", "\t\n8.Denver\t\n" };
 
            //     Console.WriteLine("Please choose one of these locations to shop at by entering in it's corresponding numerical value.");

            //      for (var i = 0; i < LocationChoice.Length; i++)
            //         {
            //             Console.Write(LocationChoice[i]);
            //         }
            //         Int32 decision = 0;
            //         do
            //         {
            //             String readresp = Console.ReadLine();
            //             Int32.TryParse(readresp, out decision);

            //         } while(decision > 0 || decision < (LocationChoice.Length + 1));
            //        Console.WriteLine($"Excellent Choice - you've chosen to shop at {0} {1}", decision, LocationChoice[decision - 1]);



        //    LocationData(customers);

        //     LocationSelection(locations);

     

        


            }  
        } while(userIsLoggedIn != 2);

    }
    
    
            


            // int listOfLocations = Locations();

    //Methods for store shopping onboarding flow
        public static int HomeScreen()
        {
            int userIsLoggedIn;

            do
            {
                Console.WriteLine("Please enter '1' to log into your account. Enter '2' to leave the store.");
                userIsLoggedIn = rl.String2Int(Console.ReadLine());
               if (userIsLoggedIn == -1)
                {
                    Console.WriteLine("Oops, we didn't catch that response. Please enter '1' to log into your account. Enter '2' to exit this program");

                }
            } while (userIsLoggedIn != 1 && userIsLoggedIn != 2);
            return userIsLoggedIn;
        }


        public static String[] CustomerList()
        {
            String[] listOfLoggedInCust;
            do
            {
                Console.WriteLine("\nWhat is your first and last name?");
                listOfLoggedInCust = Console.ReadLine().Trim().Split(' ');
            } while (listOfLoggedInCust[0] == "");
            return listOfLoggedInCust;
        }




        //methods for displaying information onto the console


        public static void CustomerData(List<Customers> c)
            {
            foreach(Customers customers in c)
            {
                
                Console.WriteLine($"It's great to see you {customers.Firstn} {customers.Lastn}! \nYour Shoe City member ID is {customers.CustomerId}.");
            }
            }

        // public static void LocationData(List<Locations> l)
        // {
        //     foreach(Locations locations in l)
        //     {
        //         Console.WriteLine("Great choice! You have selected {} with the ID of {}");
        //     }
        // }



        // public static void LocationData(List<Customers> c) 
        // {
        
        //     foreach(Customers customers in c)
        //     {
        //         Console.WriteLine($"Hey {customers.Firstn} {customers.Lastn}, please select your shopping location by entering in the corresponding numerical value.");
        //     }

        //     LocationSelection();//call method here to function below which will take in location information
        // }

        // public static String[] LocationSelection()
        // {
        //     int[] locationArray;
        //     int LocationPick;

        //     do
        //     {
        //         Console.WriteLine("\n\t1. Los Angeles \n\t2. San Francisco \n\t3. Seattle \n\t4. Dallas \n\t5. Miami \n\t6. NYC \n\t7. Minneapolis \n\t8. Denver");
        //         LocationPick = rl.String2Int.ReadLine();

        //         if(LocationPick < 0 || LocationPick > 8)
        //         {
        //              Console.WriteLine("Please select a valid store number location.");
        //         }
        //         } while(locationArray[0] == "");
        //     }
        // }

        //  public static lEnum LocationMenu(Locations locations)
        //     {
        //      int LocationChoice;
                
        //         do{
        //           Console.WriteLine($"Hey there {locations.c1.Firstn} please choose a City to shop from: \n\t1. Los Angeles \n\t2. San Francisco \n\t3. Seattle \n\t4. Dallas \n\t5. Miami \n\t6. NYC \n\t7. Minneapolis \n\t8. Denver");
        //           LocationChoice = rl.String2Int(Console.ReadLine());

        //          if(LocationChoice > 7 || LocationChoice < 0)
        //          {
        //               Console.WriteLine("Please select a valid store location.");
        //          }
        //          } while(LocationChoice > locationChoices || LocationChoice < 0);
        //          return (locationChoices)LocationChoice;
        //      }
            
     
    }    
} 
        

            // public static void LocationDecision(List<Locations> locations)
            // {
            //     foreach(Locations l in locations)
            //     {
            //         Console.WriteLine($"Awesome! you've chosen to shop at our store in {l}.");
            //     }
            // }
    
    
      