using System;

namespace StoreAppConsole
{
    public class Customers
    {
        public Customers(string firstn = "null", string lastn = "null")
        {
            this.Firstn = firstn;
            this.Lastn = lastn;
        }

        private Guid customerId = Guid.NewGuid();
        public Guid CustomerId
        {
            get { return customerId; }
        }

        private string FirstN;
        public string Firstn
        {
                get { return FirstN; }
                set 
                {
                    if(value is string && value.Length < 15 && value.Length > 0)
                    {
                        FirstN = value;
                    } else 
                    {
                        throw new Exception("Please enter a first name!");
                    }
                }
        }

        private string LastN;
        public string Lastn
        {
            get { return LastN; }
            set {
                if (value is string && value.Length < 15 && value.Length > 0)
                {
                    LastN = value;
                } else 
                {
                    throw new Exception("Please enter in a valid last name.");
                }
            }
        }


    }
}