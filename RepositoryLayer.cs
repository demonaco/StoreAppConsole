using System;
using System.Linq;
using System.Collections.Generic;

namespace StoreAppConsole
{
    public class RepositoryLayer
    {
        List<Customers> customers = new List<Customers>();
        List<Locations> locations = new List<Locations>();




        public Customers AddCustomer(string FirstN = "null", string LastN = "null")
        {
           Customers cust = new Customers();
           cust = customers.Where(z => z.Firstn == FirstN && z.Lastn == LastN).FirstOrDefault();

           if(cust == null)
           {
               cust = new Customers()
               {
                   Firstn = FirstN,
                   Lastn = LastN
               };
               customers.Add(cust);
           }
           return cust;

        }

         public Locations AddLocation(Customers c1)
        {
            Locations locations = new Locations();
            locations.CustATM = c1;
            return locations;
        }

        // public bool SaveLocation(Locations locations)
        // {
        //     if(!locations.Any(z => z.locationID ==  locations.locationID)
        //     {
        //         locations.Add(locations);
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }

        // public bool LocationStored(Locations locations)
        // {
        //     if(!locations.Exists(locations.Exists(z => z.locateID)))
        //     {
        //         locations.Add(locations);
        //         return true;
        //     } else return false;
        // }


        //Saving our shoppers
        public List<Customers> RetreiveCustomers()
        {
            return customers;
        }

        public List<Locations> RetreiveLocation()
        {
            return locations;
        }

        public int String2Int(string input)
        {
            int resp;
            bool UserDecides = int.TryParse(input, out resp);
            if(UserDecides == false)
            {
                return -1;
            } 
            else
            {
                return resp;
            }

        }
    }
}