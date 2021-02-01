using System;
using System.Collections.Generic;
using System.Text;

namespace qastly.Helpers
{
    public interface Itest
    {
        //fields
        string id;
        protected double price;
        //properties
         string ID { get; set; }

        public  double Price { get; set; }
        public int amount { get; set; }
        double CalculatePrice();
          int CalculatePric()
        {
            return 5;
        }
    }
}
