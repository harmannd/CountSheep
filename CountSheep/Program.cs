using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.CountSheep
{
    //
    //Contains the list of number that were counted.
    //
    public class list
    {

    }

    class CountSheep
    {
        static void Main(string[] args)
        {
            int interval = 0;
            Console.WriteLine( "Input" + "Output".PadLeft(10) + "\r\n" + "\r\n" );
            while ( true )
            {
                try
                {
                    interval = Console.Read();
                    if (interval > 0 && interval < 101)
                        break;
                }
                catch ( Exception )
                {
                    Console.WriteLine("Invalid entry");
                }
            }
        }

        public void Count( int interval )
        {

        }
    }
}
