using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dz_File.Structures
{
    public struct accountData
    {
        public string name;
        public string city;
        public int age;
        public string pin;
    }

    public struct student 
    {
        public string name;
        public string surname;
        public string id;
        public DateTime birthdate;
        public char AlcogolicCategory;
        public double DrinkVolume;
        public Drink TypeDrink;
    }

    public struct Drink
    {
        public string name;
        public double PercentageOfAlcohole;
    }

}


    
