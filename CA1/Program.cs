using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Program
    {
        static void Main(string[] args)
        {
            int IComparable.CompareTo(object obj)
{
                sort s = (sort)obj;
                return String.Compare(this.make, s.make);

            }
            Shuffle myShuffle = new Shuffle();

            foreach (Shuffle s in myShuffle.Cards)
            {
                Console.WriteLine(s);
            }
           
        }
    }
}
