using LAB2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total_elements = 26;
            int mini_index = 0;
            int max_index = 26;

            One_Dimension legth = new One_Dimension(total_elements);


            Console.WriteLine("Swapped the second and penultimate elements");
            One_Dimension max_mini = new One_Dimension(total_elements, mini_index, max_index);

            max_mini.read();
            max_mini.Character();
            int setget = max_mini.setConsonantVolu;
            Console.WriteLine();
            Console.Write("Number of Consonants: " + setget);
            Console.WriteLine();
            max_mini.Indexof_Y();
        }
    }
    
}
