using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroprojetoti48
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public class Contato
        {
            public string Nome { get; set; }
            public string Funcao { get; set; }
            public string Numero { get; set; }
            public string Email { get; set; }
        }

        List<Contato> lista = new List< Contato>();

        private void AtualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }

        private bool EmailValido(string email)
        {

        }

        private void NomTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdicionarBut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomTxt.Text))
            {
                MessageBox.Show("Por favor, preencha o Nome!");
                return;
            }
            
            if (string.IsNullOrWhiteSpace(FunTxt.Text))
            {
                MessageBox.Show("Por favor, preencha a função!");
                return;
            }

            if (string.IsNullOrWhiteSpace(NumTxt.Text))
            {
                MessageBox.Show("Por favor, preencha o número!");
                return;
            }

            if (!EmailValido(EmaTxt.Text))
            {
                MessageBox.Show("Email Inválido!");
                return;
            }

            // Criar objeto Contato
            Contato c = new Contato();
            c.Nome = NomTxt.Text;
            c.Funcao = FunTxt.Text;
            c.Numero = NumTxt.Text;

            // Adicionar na Lista
            lista.Add(c);

            // Atualizar grid
            AtualizarGrid();

            // Limpar campo
            NomTxt.Clear();
            FunTxt.Clear();
            NumTxt.Clear();

            NumTxt.Focus();
        }
        
    }
}
