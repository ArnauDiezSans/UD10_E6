using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_E6
{
    class Program
    {
        static void Main()
        {
            Libro L1 = new Libro ( "9780544003415", "El Señor de los Anillos", "J.R.R. Tolkien", 1200 );
            Libro L2 = new Libro("8478884459", "Harry Potter y la piedra filosofal", "J.K. Rowling",309);
            L1.ToString();
            L2.ToString();
            if (L1._Num_pags > L2._Num_pags)
            {
                Console.WriteLine(L1._Titulo + " tiene más páginas.");
            }
            else
            {
                Console.WriteLine(L2._Titulo + " tiene más páginas.");
            }
        }
    }
}
