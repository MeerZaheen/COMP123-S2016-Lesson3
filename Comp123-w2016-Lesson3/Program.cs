using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_s2016_Lesson3
{
    /**
    * this class is the driver class for our Program
    *
    * @class Program
    */
    public class Program
    {
        /**
        * the main method for our driver class Program
        *
        * @method main
        * @param {string[]} args
        */
        public static void Main(string[] args)
        {
            // can change lowercase 'person' to anything else like your name or 'tom'
            Person person;

            // create a new instance of the Person class
            // or Person person = new Person();
            person = new Person("Tom");

            Console.WriteLine(person.Name);

            // set a value in the Name property of the Person Class
            person.Name = "Tom";

            // get the name value and print to console.
            Console.WriteLine(person.Name);
        }
    }
}
