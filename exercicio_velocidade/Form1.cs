using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_velocidade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo)== DialogResult.Yes)
                Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Km, vm, tempo;
          
            Km = double.Parse(txtKm.Text);
            tempo = double.Parse(txtMinutos.Text);

            double horas = tempo / 60.0;

            vm = Km / horas;

            MessageBox.Show("A velocidade média da viagem é: " + vm + " Km/h");

        }
    }
}
