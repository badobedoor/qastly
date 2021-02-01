using System;
using System.Collections.Generic;
using System.Text;

namespace qastly.Helpers
{
    public abstract  class abstractTist
    {
        //fields
        //string id;
        //protected double price;
        ////properties
        //public abstract string ID{get;set;}

        //public abstract double Price { get; set; }
        //public int amount { get; set; }
        //public abstract double CalculatePrice();
        //public  int CalculatePric() 
        //{
        //    return 5;
        //}

        //********************
        //fields
        string id;
        protected double price;
        //properties
        string ID { get; set; }

        public double Price { get; set; }
        public int amount { get; set; }
       // abstract double CalculatePrice();
        int CalculatePric()
        {
            return 5;
        }

    }
}
