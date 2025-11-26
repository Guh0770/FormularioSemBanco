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
            public int ID { get; set; }
            public string Nome { get; set; }
            public string Funcao { get; set; }
            public string Numero { get; set; }
            public string Email { get; set; }
            public DateTime DataForm { get; set; }
        }

        List<Contato> lista = new List<Contato>();
        int proximoId = 1;

        private void AtualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }

        private bool EmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
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
            c.ID = proximoId++;
            c.Nome = NomTxt.Text;
            c.Funcao = FunTxt.Text;
            c.Numero = NumTxt.Text;
            c.Email = EmaTxt.Text;
            c.DataForm = Dat.Value;

            // Adicionar na Lista
            lista.Add(c);

            // Atualizar grid
            AtualizarGrid();

            // Limpar campo
            IdTxt.Clear();
            NomTxt.Clear();
            FunTxt.Clear();
            NumTxt.Clear();
            EmaTxt.Clear();
            
            NomTxt.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               var contato  = lista[e.RowIndex];
                IdTxt.Text = contato.ID.ToString();
                NomTxt.Text = contato.Nome;
                FunTxt.Text = contato.Funcao;
                NumTxt.Text = contato.Numero;
                EmaTxt.Text = contato.Email;
                Dat.Value = contato.DataForm;
            }
        }
        private void AlterarBut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IdTxt.Text))
            {
                MessageBox.Show("Selecione um registro para alterar!");
                return;
            }

            int id = int.Parse(IdTxt.Text);

            Contato contato = lista.FirstOrDefault(c => c.ID == id);
            if (contato == null)
            {
                MessageBox.Show("Registro não encontrado!");
                return;
            }

            contato.Nome = NomTxt.Text;
            contato.Funcao = FunTxt.Text;
            contato.Numero = NumTxt.Text;
            contato.Email = EmaTxt.Text;
            contato.DataForm = Dat.Value;

            AtualizarGrid();
            MessageBox.Show("Registro alterado com sucesso!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExcluirBut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IdTxt.Text))
            {
                MessageBox.Show("Selecione um registro para excluir!");
                return;
            }
            if (MessageBox.Show("Deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = int.Parse(IdTxt.Text);

            Contato contato = lista.FirstOrDefault(c => c.ID == id);

            if (contato != null)
            {
              lista.Remove(contato);
                AtualizarGrid();
                MessageBox.Show("Registro excluído com sucesso!");
            }
        }

        private void MDadosBut_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
    }
}
