using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lotto_app
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


        static List<Nyertesszamok> Nyertesszamlista = new List<Nyertesszamok>();

        static int[] bekertSzamok = new int[5];

        static void Bekeres()
        {
            Console.WriteLine("Adj meg egy számot 1 és 90 között. ");
            bekertSzamok[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adj meg egy 2. számot 1 és 90 között. Nem lehet ugyanaz, mint az előző.  ");
            bekertSzamok[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adj meg egy 3. számot 1 és 90 között. Nem lehet ugyanaz, mint az előzők.  ");
            bekertSzamok[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adj meg egy 4. számot 1 és 90 között. Nem lehet ugyanaz, mint az előzők.  ");
            bekertSzamok[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adj meg egy 5. számot 1 és 90 között. Nem lehet ugyanaz, mint az előzők.  ");
            bekertSzamok[4] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A kapott számok: " + bekertSzamok[0] + " " + bekertSzamok[1] + " " + 
                bekertSzamok[2] + " " + bekertSzamok[3] + " " + bekertSzamok[4]);

            if (bekertSzamok[0] == bekertSzamok[1] || bekertSzamok[0] == bekertSzamok[2] || 
                bekertSzamok[0] == bekertSzamok[3] || bekertSzamok[0] == bekertSzamok[4] ||
                bekertSzamok[1] == bekertSzamok[2] || bekertSzamok[1] == bekertSzamok[3] || 
                bekertSzamok[1] == bekertSzamok[4] || bekertSzamok[1] == bekertSzamok[4] ||
                bekertSzamok[2] == bekertSzamok[3] || bekertSzamok[2] == bekertSzamok[4] ||
                bekertSzamok[3] == bekertSzamok[4])

            {
                Console.WriteLine("legalább 2 szám azonos az 5 közül");
            }

            else
            {
                Console.WriteLine("Helyes, mind az 5 szám különböző!\n\n " +
                    "Nézd meg, nyertél-e volna, ha minden héten megjéátszottad volna ezeket a számokat...   ");
            }


            Array.Sort(bekertSzamok);
        }


        static void Beolvas() //  beolvassa a húzásokat tartalmazó fájlt
        {
            StreamReader sr = new StreamReader("otos.csv");
      

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] temp = sor.Split(';');               
                Nyertesszamok ny = new Nyertesszamok(
                    Convert.ToInt32(temp[11]),
                    Convert.ToInt32(temp[12]),
                    Convert.ToInt32(temp[13]),
                    Convert.ToInt32(temp[14]),
                    Convert.ToInt32(temp[15]));

                Nyertesszamlista.Add(ny);

            }

            sr.Close();
        }


        static void hanyszor()
        {
            Console.WriteLine(Nyertesszamlista[111]);

            Console.WriteLine(Nyertesszamlista[3315].Kiirias());

            int tatalatKettes = 0;

            for (int i = 0; i < Nyertesszamlista.Count; i++)
            {
                // 1. és x. bekért szám egyezik a nyertes számok sorainak 1-5. tagjával 
                if ((bekertSzamok[0] == Nyertesszamlista[i].Sz1 && bekertSzamok[1] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz2 && bekertSzamok[1] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz3 && bekertSzamok[1] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz4 && bekertSzamok[1] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz5 && bekertSzamok[1] == Nyertesszamlista[i].Sz5) ||

                   (bekertSzamok[0] == Nyertesszamlista[i].Sz1 && bekertSzamok[2] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz2 && bekertSzamok[2] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz3 && bekertSzamok[2] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz4 && bekertSzamok[2] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz5 && bekertSzamok[2] == Nyertesszamlista[i].Sz5) ||

                    (bekertSzamok[0] == Nyertesszamlista[i].Sz1 && bekertSzamok[3] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz2 && bekertSzamok[3] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz3 && bekertSzamok[3] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz4 && bekertSzamok[3] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz5 && bekertSzamok[3] == Nyertesszamlista[i].Sz5) ||

                    (bekertSzamok[0] == Nyertesszamlista[i].Sz1 && bekertSzamok[4] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz2 && bekertSzamok[4] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz3 && bekertSzamok[4] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz4 && bekertSzamok[4] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz5 && bekertSzamok[4] == Nyertesszamlista[i].Sz5) ||

                    // 2. és x. bekért szám egyezik a nyertes számok sorainak 1.-5. tagjával 

                    (bekertSzamok[1] == Nyertesszamlista[i].Sz1 && bekertSzamok[2] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz2 && bekertSzamok[2] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz3 && bekertSzamok[2] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz4 && bekertSzamok[2] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz5 && bekertSzamok[2] == Nyertesszamlista[i].Sz5) ||

                    (bekertSzamok[1] == Nyertesszamlista[i].Sz1 && bekertSzamok[3] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz2 && bekertSzamok[3] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz3 && bekertSzamok[3] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz4 && bekertSzamok[3] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz5 && bekertSzamok[3] == Nyertesszamlista[i].Sz5) ||

                    (bekertSzamok[1] == Nyertesszamlista[i].Sz1 && bekertSzamok[4] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz2 && bekertSzamok[4] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz3 && bekertSzamok[4] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz4 && bekertSzamok[4] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz5 && bekertSzamok[4] == Nyertesszamlista[i].Sz5) ||


                    // 3. és x. bekért szám egyezik a nyertes számok sorainak 1-5 tagjával 

                    (bekertSzamok[2] == Nyertesszamlista[i].Sz1 && bekertSzamok[3] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[2] == Nyertesszamlista[i].Sz2 && bekertSzamok[3] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[2] == Nyertesszamlista[i].Sz3 && bekertSzamok[3] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[2] == Nyertesszamlista[i].Sz4 && bekertSzamok[3] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[2] == Nyertesszamlista[i].Sz5 && bekertSzamok[3] == Nyertesszamlista[i].Sz5) ||

                    (bekertSzamok[2] == Nyertesszamlista[i].Sz1 && bekertSzamok[4] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[2] == Nyertesszamlista[i].Sz2 && bekertSzamok[4] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[2] == Nyertesszamlista[i].Sz3 && bekertSzamok[4] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[2] == Nyertesszamlista[i].Sz4 && bekertSzamok[4] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[2] == Nyertesszamlista[i].Sz5 && bekertSzamok[4] == Nyertesszamlista[i].Sz5) ||

                    // 4. és 5. bekért szám egyezik a nyertes számok sorainak 1-5 tagjával 

                    (bekertSzamok[3] == Nyertesszamlista[i].Sz1 && bekertSzamok[4] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[3] == Nyertesszamlista[i].Sz2 && bekertSzamok[4] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[3] == Nyertesszamlista[i].Sz3 && bekertSzamok[4] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[3] == Nyertesszamlista[i].Sz4 && bekertSzamok[4] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[3] == Nyertesszamlista[i].Sz5 && bekertSzamok[4] == Nyertesszamlista[i].Sz5) )
                    
                    
                    
                {
                    
                    tatalatKettes++;
                }

            }

            Console.WriteLine("Kettes: " + tatalatKettes);


            int tatalatHarmas = 0;

            for (int i = 0; i < Nyertesszamlista.Count; i++)
            {
                // 1.-x. bekért szám egyezik a nyertes számok sorainak 1-5. tagjával 
                if ((bekertSzamok[0] == Nyertesszamlista[i].Sz1 && bekertSzamok[1] == Nyertesszamlista[i].Sz1 && bekertSzamok[2] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz2 && bekertSzamok[1] == Nyertesszamlista[i].Sz2 && bekertSzamok[2] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz3 && bekertSzamok[1] == Nyertesszamlista[i].Sz3 && bekertSzamok[2] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz4 && bekertSzamok[1] == Nyertesszamlista[i].Sz4 && bekertSzamok[2] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz5 && bekertSzamok[1] == Nyertesszamlista[i].Sz5 && bekertSzamok[2] == Nyertesszamlista[i].Sz5) ||

                    (bekertSzamok[0] == Nyertesszamlista[i].Sz1 && bekertSzamok[2] == Nyertesszamlista[i].Sz1 && bekertSzamok[3] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz2 && bekertSzamok[2] == Nyertesszamlista[i].Sz2 && bekertSzamok[3] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz3 && bekertSzamok[2] == Nyertesszamlista[i].Sz3 && bekertSzamok[3] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz4 && bekertSzamok[2] == Nyertesszamlista[i].Sz4 && bekertSzamok[3] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz5 && bekertSzamok[2] == Nyertesszamlista[i].Sz5 && bekertSzamok[3] == Nyertesszamlista[i].Sz5) ||

                    (bekertSzamok[0] == Nyertesszamlista[i].Sz1 && bekertSzamok[3] == Nyertesszamlista[i].Sz1 && bekertSzamok[4] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz2 && bekertSzamok[3] == Nyertesszamlista[i].Sz2 && bekertSzamok[4] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz3 && bekertSzamok[3] == Nyertesszamlista[i].Sz3 && bekertSzamok[4] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz4 && bekertSzamok[3] == Nyertesszamlista[i].Sz4 && bekertSzamok[4] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz5 && bekertSzamok[3] == Nyertesszamlista[i].Sz5 && bekertSzamok[4] == Nyertesszamlista[i].Sz5) ||

                   
                    // 2. és x. bekért szám egyezik a nyertes számok sorainak 1.-5. tagjával 

                    (bekertSzamok[1] == Nyertesszamlista[i].Sz1 && bekertSzamok[2] == Nyertesszamlista[i].Sz1 && bekertSzamok[3] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz2 && bekertSzamok[2] == Nyertesszamlista[i].Sz2 && bekertSzamok[3] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz3 && bekertSzamok[2] == Nyertesszamlista[i].Sz3 && bekertSzamok[3] == Nyertesszamlista[i].Sz3)  ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz4 && bekertSzamok[2] == Nyertesszamlista[i].Sz4 && bekertSzamok[3] == Nyertesszamlista[i].Sz4)  ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz5 && bekertSzamok[2] == Nyertesszamlista[i].Sz5 && bekertSzamok[3] == Nyertesszamlista[i].Sz5) ||

                    (bekertSzamok[1] == Nyertesszamlista[i].Sz1 && bekertSzamok[2] == Nyertesszamlista[i].Sz1 && bekertSzamok[4] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz2 && bekertSzamok[2] == Nyertesszamlista[i].Sz2 && bekertSzamok[4] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz3 && bekertSzamok[2] == Nyertesszamlista[i].Sz3 && bekertSzamok[4] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz4 && bekertSzamok[2] == Nyertesszamlista[i].Sz4 && bekertSzamok[4] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz5 && bekertSzamok[2] == Nyertesszamlista[i].Sz5 && bekertSzamok[4] == Nyertesszamlista[i].Sz5) ||

                    (bekertSzamok[1] == Nyertesszamlista[i].Sz1 && bekertSzamok[3] == Nyertesszamlista[i].Sz1 && bekertSzamok[4] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz2 && bekertSzamok[3] == Nyertesszamlista[i].Sz2 && bekertSzamok[4] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz3 && bekertSzamok[3] == Nyertesszamlista[i].Sz3 && bekertSzamok[4] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz4 && bekertSzamok[3] == Nyertesszamlista[i].Sz4 && bekertSzamok[4] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz5 && bekertSzamok[3] == Nyertesszamlista[i].Sz5 && bekertSzamok[4] == Nyertesszamlista[i].Sz5) ||

                    (bekertSzamok[2] == Nyertesszamlista[i].Sz1 && bekertSzamok[3] == Nyertesszamlista[i].Sz1 && bekertSzamok[4] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[2] == Nyertesszamlista[i].Sz2 && bekertSzamok[3] == Nyertesszamlista[i].Sz2 && bekertSzamok[4] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[2] == Nyertesszamlista[i].Sz3 && bekertSzamok[3] == Nyertesszamlista[i].Sz3 && bekertSzamok[4] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[2] == Nyertesszamlista[i].Sz4 && bekertSzamok[3] == Nyertesszamlista[i].Sz4 && bekertSzamok[4] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[2] == Nyertesszamlista[i].Sz5 && bekertSzamok[3] == Nyertesszamlista[i].Sz5 && bekertSzamok[4] == Nyertesszamlista[i].Sz5) ||
                                                            
                    )

                {
                     tatalatHarmas++;
                }

            }

            Console.WriteLine("Hármas: " + tatalatHarmas);

            int tatalatNegyes = 0;

            for (int i = 0; i < Nyertesszamlista.Count; i++)
            {
                // 1.-x. bekért szám egyezik a nyertes számok sorainak 1-5. tagjával 
                if (
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz1 && bekertSzamok[1] == Nyertesszamlista[i].Sz1 && bekertSzamok[2] == Nyertesszamlista[i].Sz1 && bekertSzamok[3] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz2 && bekertSzamok[1] == Nyertesszamlista[i].Sz2 && bekertSzamok[2] == Nyertesszamlista[i].Sz2 && bekertSzamok[3] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz3 && bekertSzamok[1] == Nyertesszamlista[i].Sz3 && bekertSzamok[2] == Nyertesszamlista[i].Sz3 && bekertSzamok[3] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz4 && bekertSzamok[1] == Nyertesszamlista[i].Sz4 && bekertSzamok[2] == Nyertesszamlista[i].Sz4 && bekertSzamok[3] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz5 && bekertSzamok[1] == Nyertesszamlista[i].Sz5 && bekertSzamok[2] == Nyertesszamlista[i].Sz5 && bekertSzamok[3] == Nyertesszamlista[i].Sz5) ||

                    (bekertSzamok[0] == Nyertesszamlista[i].Sz1 && bekertSzamok[2] == Nyertesszamlista[i].Sz1 && bekertSzamok[3] == Nyertesszamlista[i].Sz1 && bekertSzamok[4] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz2 && bekertSzamok[2] == Nyertesszamlista[i].Sz2 && bekertSzamok[3] == Nyertesszamlista[i].Sz2 && bekertSzamok[4] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz3 && bekertSzamok[2] == Nyertesszamlista[i].Sz3 && bekertSzamok[3] == Nyertesszamlista[i].Sz3 && bekertSzamok[4] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz4 && bekertSzamok[2] == Nyertesszamlista[i].Sz4 && bekertSzamok[3] == Nyertesszamlista[i].Sz4 && bekertSzamok[4] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[0] == Nyertesszamlista[i].Sz5 && bekertSzamok[2] == Nyertesszamlista[i].Sz5 && bekertSzamok[3] == Nyertesszamlista[i].Sz5 && bekertSzamok[4] == Nyertesszamlista[i].Sz5) ||


                     (bekertSzamok[1] == Nyertesszamlista[i].Sz1 && bekertSzamok[2] == Nyertesszamlista[i].Sz1 && bekertSzamok[3] == Nyertesszamlista[i].Sz1 && bekertSzamok[4] == Nyertesszamlista[i].Sz1) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz2 && bekertSzamok[2] == Nyertesszamlista[i].Sz2 && bekertSzamok[3] == Nyertesszamlista[i].Sz2 && bekertSzamok[4] == Nyertesszamlista[i].Sz2) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz3 && bekertSzamok[2] == Nyertesszamlista[i].Sz3 && bekertSzamok[3] == Nyertesszamlista[i].Sz3 && bekertSzamok[4] == Nyertesszamlista[i].Sz3) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz4 && bekertSzamok[2] == Nyertesszamlista[i].Sz4 && bekertSzamok[3] == Nyertesszamlista[i].Sz4 && bekertSzamok[4] == Nyertesszamlista[i].Sz4) ||
                    (bekertSzamok[1] == Nyertesszamlista[i].Sz5 && bekertSzamok[2] == Nyertesszamlista[i].Sz5 && bekertSzamok[3] == Nyertesszamlista[i].Sz5 && bekertSzamok[4] == Nyertesszamlista[i].Sz5) 
                   )

                {
                    tatalatNegyes++;
                }

            }

            Console.WriteLine("Négyes: " + tatalatNegyes);


            //int db = 0; 

            //for (int i = 0; i < Nyertesszamlista.Count; i++)
            //{
            //    for (int j = 0; j < bekertSzamok.Length; j++)
            //    {
            //        if (Nyertesszamlista[i].Sz1 == bekertSzamok[j])
            //        {
            //            db++;
            //        }
            //    } 
            //}

            //Console.WriteLine("aaa" + db);

            //var aaa = Nyertesszamlista.FindIndex(x => x.Sz1 == bekertSzamok[0] && x.Sz2 == bekertSzamok[1]);

            //Console.WriteLine("szorszám " + aaa);


            //for (int i = 0; i < Nyertesszamlista.Count; i++)
            //{
            //    //Nyertesszamlista[i].Sz1 Contains(bekertSzamok[0]);
            //    Nyertesszamlista[i].Contains(bekertSzamok[0]);
            //}


            int tatalatOtos = 0;

            for (int i = 0; i < Nyertesszamlista.Count; i++)
            {
                if (bekertSzamok[0] == Nyertesszamlista[i].Sz1 && bekertSzamok[1] == Nyertesszamlista[i].Sz2
                    && bekertSzamok[2] == Nyertesszamlista[i].Sz3 && bekertSzamok[3] == Nyertesszamlista[i].Sz4
                    && bekertSzamok[4] == Nyertesszamlista[i].Sz5)
                {

                    tatalatOtos++;
                }
            }

            Console.WriteLine("Ötös: " + tatalatOtos);


        }



        static void Main(string[] args)
        {

            Bekeres();
            Beolvas();            
            hanyszor();

            Console.ReadLine();

        }
    }
}
