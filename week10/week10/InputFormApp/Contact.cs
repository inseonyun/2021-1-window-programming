using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputFormApp
{
    public class Contact
    {
        string name;
        int age;
        string gender;
        int year;
        int month;
        int day;
        string favorite;

        public Contact(string name, int age, string gender, int year, int month, int day, string favorite)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.year = year;
            this.month = month;
            this.day = day;
            this.favorite = favorite;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public int Month 
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }
        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }
        public string Favorite
        {
            get
            {
                return favorite;
            }
            set
            {
                favorite = value;
            }
        }

    }
}
