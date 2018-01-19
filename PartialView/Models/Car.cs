using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialView.Models
{
    public class Car
    {
        public int Id { get; set; }
         static int idCount { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }


        public Car(/*string name,string brand*/)
        {
            Id = idCount++;
            //Name = name;
            //Brand = brand;
        }
    }

    
}