using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace akasztofa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<string> l = new List<string>(); 
            StreamReader sr = new StreamReader("akasztofa.txt");
            while (!sr.EndOfStream)
                l.Add(sr.ReadLine());
            string szo = l[r.Next(1, l.Count)];
            List<char> betuk=new List<char>();
            for (int i = 0; i < szo.Length; i++)
                Console.Write("_ ");
            Console.WriteLine("\n\nMi a tipped?");
            char b=' ';
            string a = "  ";
            int hossz = 0;
            char[] asd = new char[szo.Length];
            for (int i = 0; i < asd.Length; i++) 
                asd[i] = '_';
            int elet = 11;
            while (hossz!=szo.Length && elet!=0)
            {
                while (a.Length != 1)
                {
                    a = Console.ReadLine();
                    if (a.Length != 1)
                        Console.WriteLine("Csak egy betut adj meg!");
                    else
                        b = Convert.ToChar(a);
                }
                a = "  ";
                Console.Clear();
                if (szo.Contains(b) && !betuk.Contains(b))
                    for (int i = 0; i < szo.Length; i++)
                        if (szo[i]==b )
                        {
                            hossz++;
                            asd[i] = b;
                        }
                if (!szo.Contains(b) && !betuk.Contains(b))
                    elet--;
                bool betutart = false;
                if (!betuk.Contains(b))
                    betuk.Add(b);
                else
                    betutart = true;
                for (int i = 0; i < asd.Length; i++)
                    Console.Write(asd[i]+" ");
                Console.WriteLine("\n\nÉleteid száma: " + elet+ "\n\nFelhasznált betűk: ");
                for (int i = 0; i < betuk.Count; i++)
                    Console.Write(betuk[i]+" ");
                Console.WriteLine("\n\nMi a tipped?");
                if (betutart)
                    Console.WriteLine("Ezt a betűt már használtad!");
            }
            Console.Clear();
            if (hossz==szo.Length)
                Console.WriteLine("WoW kitaltad!");
            else
                Console.WriteLine("Ezt elrontottad!");
            Console.WriteLine("\nA szó \""+szo+"\" volt");
            Console.ReadKey();
        }
    }
}
