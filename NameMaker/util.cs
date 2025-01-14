using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameMaker
{
    class util
    {

        public static int tryconvert(string word)
        {
            int i = -1;

            try
            {
                i = Convert.ToInt32(word);
            }
            catch (OverflowException)
            {
                //memo("i Outside the range of the Int32 type: " + word);
            }
            catch (FormatException)
            {
                //if ( !String.IsNullOrEmpty(word))
                //    Console.WriteLine("i Not in a recognizable format: " + word);
            }

            return i;

        }

    }
}
