using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morseovka
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] M = new string[91];
            M[65] = " . – ";
            M[66] = " – . . . ";
            M[67] = " – . – . ";
            M[68] = " – . . ";
            M[69] = " . ";
            M[70] = " . . – . ";
            M[71] = " – – . ";
            M[72] = " . . . . ";
            M[73] = " . . ";
            M[74] = " . – – – ";
            M[75] = " – . – ";
            M[76] = " . – . . ";
            M[77] = " – – ";
            M[78] = " – . ";
            M[79] = " – – – ";
            M[80] = " . – – . ";
            M[81] = " – – . – ";
            M[82] = " . – . ";
            M[83] = " . . . ";
            M[84] = " – ";
            M[85] = " . . – ";
            M[86] = " . . . – ";
            M[87] = " . – – ";
            M[88] = " – . . – ";
            M[89] = " – . – – ";
            M[90] = " – – . . ";


            string vstup = "filip je nejlepsi mania cz hrac xd"; //Text kterej si prelozime
            string vystup = ""; //Vystpni promenna musi byt prazdna
            int kodznaku;
            vstup = vstup.ToUpper(); //Upravi na velka pismena
            for(int i=0; i <= vstup.Length-1; i++) //Spocitani znaku
            {
                kodznaku = (int)vstup[i]; //Do promene "kodznaku" si zapiseme pocet znaku vstupu, ktery nam spocitala funkce for
                if (kodznaku >= 65 && kodznaku <= 90) //Pokud bude znak mimo stanoveny rozsah, nezapise se nic
                {
                    vystup += M[kodznaku] + "/";
                }
            }
            Console.Write(vystup);
            Console.ReadKey();
        }
    }
}
