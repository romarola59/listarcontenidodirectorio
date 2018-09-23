using System;
using System.IO;

namespace Listarcontenidodedirectorio
{
    public class Program
    {
        public static void Main()
        {
            string miDirectorio = @"c:\";
            string[] listaFicheros;
            listaFicheros = Directory.GetFiles(miDirectorio);
            foreach(String fichero in listaFicheros)
            Console.WriteLine(fichero);
            Console.ReadKey();
        }
    }
}
