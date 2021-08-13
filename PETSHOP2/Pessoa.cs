using System;
using System.Collections.Generic;
using System.Text;

namespace PETSHOP2
{
    class Pessoa
    {
        public String Nomepessoa { get; set; }
        public int Telefone { get; set; }
        public string Endereço { get; set; }
        public Animal[] animais { get; } = new Animal[3];
        private int quantsanimais = 0;
        public void Registraanimais(Animal d)
        {
            if (quantsanimais < 10)
                animais[quantsanimais++] = d;
        }

        public int Obeterquatanimais()
        {
            return quantsanimais;
        }
        public Animal Dpindice(int indice)
        {
            return animais[indice];
        }
        
    }
}
