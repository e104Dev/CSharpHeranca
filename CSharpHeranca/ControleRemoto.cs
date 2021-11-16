using System;
namespace CSharpHeranca
{
    public class ControleRemoto
    {

        private Tv tv;
        public Tv Tv { get; set; }

        public ControleRemoto()
        {
        }

        public ControleRemoto(Tv tv)
        {
            this.Tv = tv;
        }

        public void aumentarVolume()
        {
            this.Tv.Volume++;
            Console.WriteLine("Volume: {0}", this.Tv.Volume);
        }

        public void diminuirVolume()
        {
            this.Tv.Volume--;
            Console.WriteLine("Volume: {0}", this.Tv.Volume);
        }
    }
}
