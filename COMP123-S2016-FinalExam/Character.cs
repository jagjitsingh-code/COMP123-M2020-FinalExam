/////////////////////////////////////////////////////////////////////
//FileName: Character.cs
//Author's name: Jagjit singh
//StudentID : 301106044
//Changes Made : Add the following properties to the character class: FirstName and LastName. Ensure each property includes both get accessor and set accessor methods
//////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_M2020_FinalExam
{

    /// <summary>
    /// Character class create a model for a person
    /// </summary>
    public class Character
    {
        public string Strength { get; set; }

        public string Dexterity { get; set; }

        public string Constitution { get; set; }

        public string Intelligence { get; set; }

        public string Wisdom { get; set; }

        public string Charisma { get; set; }

        public string Race { get; set; }

        // Creted new Properties First Name  and Last Name with getter and setter

        public string FirstName { get; set; }

        public string LastName { get; set; }


    
    }
}