using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    #region
    class One_Dimension
    {
        private char[] set;
        private readonly int sizex;
        private int numOfconsonants;
        private readonly int maximum;
        private readonly int minimum;
        public One_Dimension(int set_x)
        {
            this.sizex = set_x;
        }
        public One_Dimension(int sizeOFArr, int minim, int maxim)
        {
            this.sizex = sizeOFArr;
            this.maximum = maxim;
            this.minimum = minim;
        }
        public void read()
        {
            char newVar;
            set = new char[sizex];
            Random rnd = new Random();

            for (int i = 0; i < sizex; i++)
            {
                set[i] = (char)rnd.Next(65, 90);
                Console.Write(set[i] + " ");
            }

            newVar = set[minimum + 1];//1 is needed
            set[1] = set[maximum - 2];//swap the second and penultimate elements and a 24 is needed
            set[24] = newVar;
            Console.WriteLine();
        }
        public char[] Character()
        {
            char[] Chassss = new char[set.Length];
            for (int i = 0; i < set.Length; i++)
            {
                Chassss[i] = set[i];
                Console.Write(Chassss[i] + " ");
            }
            return Chassss;
        }

        public int setConsonantVolu
        {
            get
            {
                numOfconsonants = 0;
                for (int i = 0; i < sizex; i++)
                {
                    if (set[i] == 'A' || set[i] == 'E' || set[i] == 'I' || set[i] == 'O' || set[i] == 'U')
                    {
                        continue;
                    }
                    else
                    {
                        numOfconsonants++;
                    }
                }
                return numOfconsonants;
            }
        }
        public void Indexof_Y()
        {
            int valu = 0;
            for (int i = 0; i < sizex; i++)
            {
                if (set[i] == 'Y')//determining value of Y
                {
                    valu++;
                    Console.WriteLine("The set does  contain Y at index " + i);
                }
            }
            if (valu == 0)
            {
                Console.WriteLine("The set doesnt contain the character Y.");
            }
        }
    }
    #endregion
}
