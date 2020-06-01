using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfrowanie
{
    class Program
    {
        static void Szyfrowanie()
        {
            string c1 = "qwe4rty1uiop5as9d2fghjkl6zx3cv8bn7m";
            string c2 = "l9kj5hg8fds1a7mnb2vcx4zpoiuyt6re3wq";
            int a = 0;

            Console.WriteLine("Szyfruj zdanie:");
            string tekst = Console.ReadLine();
            //tekst = tekst.ToLower();   
            
            string[] tabela = new string[0];

            for (int i = 0; i < tekst.Length; i++)
            {
                a++;
                Array.Resize<string>(ref tabela, a);
                if (c1.IndexOf(tekst[i]) == -1)
                {
                    tabela[i] = Convert.ToString(tekst[i]);
                }
                else
                {
                    tabela[i] = Convert.ToString(c2[c1.IndexOf(tekst[i])]);
                }
            }

            Console.WriteLine("Twój szyfr to:\n");
            string tesktOut = null;
            foreach (string b in tabela)
            {
                tesktOut += b;
            }
            Console.Write(tesktOut);
        }

        static void Deszyfrowanie()
        {
            string c1 = "qwe4rty1uiop5as9d2fghjkl6zx3cv8bn7m";
            string c2 = "l9kj5hg8fds1a7mnb2vcx4zpoiuyt6re3wq";
            int a = 0;


            Console.WriteLine("Odszyfruj zdanie:");
            string tekst = Console.ReadLine();
            //tekst = tekst.ToLower();   

            string[] tabela = new string[0];
            
            for (int i = 0; i < tekst.Length; i++)
            {
                a++;
                Array.Resize<string>(ref tabela, a);
                if (c1.IndexOf(tekst[i]) == -1)
                {
                    tabela[i] = Convert.ToString(tekst[i]);
                }
                else
                {
                    tabela[i] = Convert.ToString(c1[c2.IndexOf(tekst[i])]);
                }
            }

            Console.WriteLine("Twóje zdanie to:\n");
            string tesktOut = null;
            foreach (string b in tabela)
            {
                tesktOut += b;
            }
            Console.Write(tesktOut);
        }
        static void Zakoncz()
        {
            Environment.Exit(0);
        }

        static void Main(string[] args)
        {

            string a = "a";
            while (a != "0")
            {
                
                Console.Write("Naciśnij klawisz:\n\n1. Szyfruj \n2. Deszyfruj \n0. Wyjście\n");
                a = Console.ReadLine();
                if (a =="1")
                {
                    Console.Clear();
                    Szyfrowanie();
                    Console.WriteLine("\n");
                    continue;
                }
                if (a == "2")
                {
                    Console.Clear();
                    Deszyfrowanie();
                    Console.WriteLine("\n");
                    continue;
                }
                if (a == "0")
                {
                    Console.Clear();
                    Zakoncz();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ten klawisz nie ma przypisanej funkcji\n");
                }
            }
            
        }
    }
}