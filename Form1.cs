using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agendaWF
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void cadastroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.listaContatoDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'listaContatoDBDataSet.Cadastro' table. You can move, or remove it, as needed.
            this.cadastroTableAdapter.Fill(this.listaContatoDBDataSet.Cadastro);

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void estadoTextBox_TextChanged(object sender, EventArgs e)
        {
            int maxLength = 2; // Substitua pelo limite do banco de dados

            if (estadoTextBox.Text.Length > maxLength)
            {
                MessageBox.Show($"O texto inserido excede o limite de {maxLength} caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                estadoTextBox.Text = estadoTextBox.Text.Substring(0, maxLength); // Trunca o texto
                estadoTextBox.SelectionStart = estadoTextBox.Text.Length; // Move o cursor para o final
            }
        }

        private void sexoTextBox_TextChanged(object sender, EventArgs e)
        {
            int maxLength = 1; // Substitua pelo limite do banco de dados

            if (estadoTextBox.Text.Length > maxLength)
            {
                MessageBox.Show($"O texto inserido excede o limite de {maxLength} caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                estadoTextBox.Text = estadoTextBox.Text.Substring(0, maxLength); // Trunca o texto
                estadoTextBox.SelectionStart = estadoTextBox.Text.Length; // Move o cursor para o final
            }
        }
    }
}
