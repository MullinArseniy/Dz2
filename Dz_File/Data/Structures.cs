using Dz_File.Enums;
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

    public struct Student 
    {
        public string Name;
        public string Surname;
        public Guid Id;
        public DateTime Birthdate;
        public AlcoholicType AlcogolicCategory;
        public double DrinkVolume;
        public Drink TypeDrink;
    }

    public struct Drink
    {
        public string Name;
        public double PercentageOfAlcohole;
    }

}


    
