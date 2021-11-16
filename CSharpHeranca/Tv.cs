using System;
namespace CSharpHeranca
{
    public class Tv : EletroEletronico
    {
        private int volume = 25;
        public int Volume { get; set; }

        private float canal = 6.1f;
        public float Canal { get; set; }

        public Tv()
        {
        }

        public Tv(string marca, string modelo) : base(marca, modelo)
        {
        }

        public override string ToString()
        {
            return String.Format("{0}{{marca={1}, modelo={2}, voltagem={3}, canal={4}, volume={5}}}",
                this.GetType().Name, Marca, Modelo, Voltagem, Canal, Volume);
        }
    }
}
