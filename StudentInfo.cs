using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    class StudentInfo
    {
        public string Name;
        public string HomeTown;
        public string FavoriteFood;

        //default constructor
        public StudentInfo () {}

        public StudentInfo (string name2)
        {
            Name = name2;
        }

        public StudentInfo(string name2, string homeTown)
        {
            Name = name2;
            HomeTown = homeTown;
        }

        public StudentInfo(string name2, string homeTown, string favoriteFood)
        {
            Name = name2;
            HomeTown = homeTown;
            FavoriteFood = favoriteFood;
        }
    }
}
