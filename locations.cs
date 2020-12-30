using System.ComponentModel;
using System.Collections.Generic;
using System;

namespace StoreAppConsole
{
    public class Locations
    {
       //[key]
       public Guid locationID { get; set; } = Guid.NewGuid();

        public Customers CustATM { get; set; } 

    }
}