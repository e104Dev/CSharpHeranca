using System;
namespace CSharpHeranca
{
    public class EletroEletronico
    {
        private string marca;
        public string Marca { get; set; }      

        private string modelo;
        public string Modelo { get; set; }

        private int voltagem = 220;
        public int Voltagem { get; set; }

        private bool ligado = false;
        public bool Ligado { get; set; }


        public EletroEletronico()
        {

        }

        public EletroEletronico(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public override string ToString()
        {
            return String.Format("{0}{{marca={1}, modelo={2}, voltagem={3}}}",
                this.GetType().Name, Marca, Modelo, Voltagem);
        }
    }
}
