using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialView.Models
{
    public class Person
    {
        public int Id { get; set; }
        public static int idCount { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public Person(/*int age,string name*/)
        {
            Id = idCount++;
            //Name = name;
            //Age = age;
        }

    }
}