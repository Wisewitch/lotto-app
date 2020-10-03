using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lotto_app2
{
    class Program
    {
        // Babusáné Gazdik Ágnes 2/14 SL  2020 10 02
        // Feladat: 

        // Készíts programot, amely bekér öt számot 1 és 90 tartományból.
        // A számok nem ismétlődhetnek. 
        //A program írja ki, hogy az eddigi számhúzások alapján (ha minden héten megjátszotta volna)
        // hány darab kettes, hármas, négyes, vagy ötös találata lett volna.

        // Beadandó a megoldás github linkje! - feltölteni



        static void Bekeres()
        {

            Console.WriteLine("Adj meg egy számot 1 és 90 között. ");
            int szam1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Adj meg egy 2. számot 1 és 90 között. Nem lehet ugyanaz, mint az előző.  ");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adj meg egy 3. számot 1 és 90 között. Nem lehet ugyanaz, mint az előzők.  ");
            int szam3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adj meg egy 4. számot 1 és 90 között. Nem lehet ugyanaz, mint az előzők.  ");
            int szam4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adj meg egy 5. számot 1 és 90 között. Nem lehet ugyanaz, mint az előzők.  ");
            int szam5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A kapott számok: " + szam1 + " " + szam2 + " " + szam3 + " " + szam4 + " " + szam5);

            if (szam1 == szam2 || szam1 == szam3 || szam1 == szam4 || szam1 == szam5 || szam2 == szam3 || szam2 == szam4 || szam2 == szam5 ||
            szam3 == szam4 || szam3 == szam5 || szam4 == szam5)

            {
                Console.WriteLine("legalább 2 szám azonos az 5 közül");
            }

            else
            {
                Console.WriteLine("Helyes, mind az 5 szám különböző!\n\n " +
                    "Nézd meg, nyertél-e volna, ha minden héten megjéátszottad volna ezeket a számokat...   ");

            }
        }

        static List<Nyertesszamok> Nyertesszamlista = new List<Nyertesszamok>();
        static void Beolvas() //  beolvassa a húzásokat
        {
            StreamReader sr = new StreamReader("otos.csv");
            int i = 0;
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] temp = sor.Split(';');
                Nyertesszamok ny = new Nyertesszamok();
                ny.sz1 = Convert.ToInt32(temp[11]);
                ny.sz2 = Convert.ToInt32(temp[12]);
                ny.sz3 = Convert.ToInt32(temp[13]);
                ny.sz4 = Convert.ToInt32(temp[14]);
                ny.sz5 = Convert.ToInt32(temp[15]);
                Nyertesszamlista.Add(ny);

            }
            sr.Close();
        }


        static void hanyszor(List<Nyertesszamok> Nyertesszamlista)
        {
            Console.WriteLine(ny.sz1 == szam1 && ny.sz2 == szam2).Count());


        }

        /*  static void Kiertekel()
          {
              Console.WriteLine("a keresett számok: " + szam1 + szam2 + szam3 + szam4 + szam5);

            while (i < t.Length && t[i] != szam)
              {
                  i++;
              }

              int talalat = 0;


              switch (talalat) 
              {
                  case 5:

                      break;
                  case 4:
                      break;
                  case 3:
                      break;
                  case 2:
                      break;
                  case 1:
                      break;
                  case 0:
                      break; 
                  default:
                      break; 

              }



          }*/

        static void Main(string[] args)
        {

            Bekeres();
            Beolvas();
            //  Kiertekel();
            hanyszor(szam1, szam2);

            Console.ReadLine();

        }
    }
}
