using System;
using System.Collections.Generic;
using System.Text;

namespace numberOne
{
    class Customer
    {
        private int id;
        private string name;

        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string customerName(int id)
        {
            return this.name;
        }

        public int customerId(string name)
        {
            return this.id;
        }


    }
}
