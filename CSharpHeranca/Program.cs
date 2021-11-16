using System;

namespace CSharpHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Tv tv = new Tv("LG", "Smart LG 5000");

            ControleRemoto controleRemoto = new ControleRemoto(tv);

            Console.WriteLine(controleRemoto.Tv.Modelo);

            controleRemoto.aumentarVolume();
            controleRemoto.aumentarVolume();
            controleRemoto.diminuirVolume();
        }
    }
}
