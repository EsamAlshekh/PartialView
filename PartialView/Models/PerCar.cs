using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialView.Models
{
    public class PerCar
    {
        public static List<Person> People { get; set; }

        public static List<Car> Cars { get; set; }

        //public PerCar()
        //{
        //    People = new List<Person>();
        //    Cars = new List<Car>();
        //}


        static PerCar()
        {
            People = new List<Person>();
            Cars = new List<Car>();

            People.Add(new Person(/*35, "Ulf"*/) { Name = "Ulf", Age = 35 });
            People.Add(new Person(/*30,"Ali"*/) { Name = "Ali", Age = 30 });
            People.Add(new Person(/*38,"Fredric"*/) { Name = "Freerik", Age = 38 });

            Cars.Add(new Car(/*"9-5", "SAAB"*/) { Name = "9-5", Brand = "SAAB" });
            Cars.Add(new Car(/*"V60", "VOLVO"*/) { Name = "V60", Brand = "VOLVO" });
            Cars.Add(new Car(/*"i850", "BMW"*/) { Name = "i850", Brand = "BMW"});
        }
    }
}