using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite password:");
            string Password = Console.ReadLine();
            string pokusaj = "";
            int prvi = 0;
            int drugi = 0;
            int treci = 0;
            int cetvrti = 0;
            int peti = 0;
            int sesti = 0;
            int sedmi = 0;
            int osmi = 0;
            int crack = 0;

            string[] array = new string[38];
            array[0] = ""; //First is empty
            array[1] = "a";
            array[2] = "b";
            array[3] = "c";
            array[4] = "d";
            array[5] = "f";
            array[6] = "g";
            array[7] = "h";
            array[8] = "i";
            array[9] = "j";
            array[10] = "k";
            array[11] = "l";
            array[12] = "m";
            array[13] = "n";
            array[14] = "o";
            array[15] = "p";
            array[16] = "q";
            array[17] = "r";
            array[18] = "s";
            array[20] = "t";
            array[21] = "u";
            array[22] = "v";
            array[23] = "w";
            array[24] = "x";
            array[25] = "y";
            array[26] = "z";
            array[27] = "0";
            array[28] = "1";
            array[29] = "2";
            array[30] = "3";
            array[31] = "4";
            array[32] = "5";
            array[33] = "6";
            array[34] = "7";
            array[35] = "8";
            array[36] = "9";

            while (!pokusaj.Equals(Password))
            {
                if (prvi == array.Length)
                {
                    drugi++;
                    prvi = 0;                  
                }
                if (drugi == array.Length)
                {
                    treci++;
                    drugi = 0;
                }
                if (treci == array.Length)
                {
                    cetvrti++;
                    treci = 0;
                }
                if (cetvrti == array.Length)
                {
                    peti++;
                    cetvrti = 0;
                }
                if (peti == array.Length)
                {
                    sesti++;
                    peti = 0;
                }
                if (sesti == array.Length)
                {
                    sedmi++;
                    sesti = 0;
                }
                if (sedmi == array.Length)
                {
                    osmi++;
                    sedmi = 0;
                }
                if (osmi == array.Length)
                {
                    break; //Finish
                }

                pokusaj = array[sedmi] + array[sesti] + array[peti] + array[cetvrti] + array[treci] + array[drugi] + array[prvi];

                Console.WriteLine(pokusaj);
                prvi++;
                crack++;               
            }
            Console.WriteLine("Ukupno pokusaja: " + " "+ crack + " sifra je : " + Password );
            Console.ReadLine(); //Just to make it stay after finishing
        }
    }
}
