using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PETSHOP2
{
    
    public partial class Form1 : Form
    {
        Pessoa s = new Pessoa();
        Animal r = new Animal();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCadastra_Click(object sender, EventArgs e)
        {
            s.Nomepessoa = textNomepessoa.Text;
            s.Telefone = int.Parse(textTelefone.Text);
            s.Endereço = textEndereço.Text;

            r.Nomeanimal = textNomeAnimal.Text;
            r.Sexo = textBoxSexo.Text;
            r.Idade = int.Parse(textBoxIdade.Text);
            r.Tipo = textBoxTipo.Text;
        }

    }
}
