using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_s2016_Lesson3
{
    /**
    * this class defines the generic Person
    *
    * @class person
    * @field _name {string}
    */
    public class Person
    {
        // Private Instance Variables ++++++++++++++++++++++++++++++++++++++++++++++++
        private string _name;

        // Public properties +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        
        /**
        * This is a property for our _name field
        *
        * @property {string} name
        */
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }

        }

        /**
        * This is the default empty constructor for the Person Class
        *
        * @constructor Person
        */
        public Person()
        {
            this._name = "Unknown name!";
        }
        /**
        * This is a constructor that takes name as a parameter and passes it 
        * to the _name private instance variable
        *
        * @constructor Person
        * @param {string} name
        */
        public Person(string name)
        {
            this._name = name;
        }
    }
}
