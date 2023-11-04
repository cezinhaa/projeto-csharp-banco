using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Aplicativo01
{
    public partial class Banco : Form
    {
        Cliente cliente;
        public Banco()
        {
            InitializeComponent();
            this.cliente = new Cliente();
        }

        private void Banco_Load(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBoxDeposito.Text);
            try
            {
                cliente.Creditar(valor);
                labelSaldoValor.Text = cliente.saldo.ToString("0.00");
                MessageBox.Show("Depósito realizado com sucesso!");
                textBoxDeposito.Clear();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
        private void buttonSacar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBoxSaque.Text);

            try
            {
                cliente.Debitar(valor);
                labelSaldoValor.Text = cliente.saldo.ToString("0.00");
                MessageBox.Show("Saque realizado com sucesso!");
                textBoxSaque.Clear();
            }
            catch (Exception exception) 
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
