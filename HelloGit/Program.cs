using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Display();
        }

        public static void Display()
        {
            ArrayList al = new ArrayList();
            BuildOutArray(al);

            foreach (string s in al)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

        public static ArrayList BuildOutArray(ArrayList al)
        {
            al.Add("Todd");
            al.Add("Tiff");
            al.Add("Kelley");

            return al;
        }
    }
}
