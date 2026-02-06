using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace primeiroprojetoti48
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            IdTxt.Clear();
            NomTxt.Clear();
            DesTxt.Clear();
            PreTxt.Clear();
            EstTxt.Clear();
            CatCb.SelectedIndex = -1;

            NomTxt.Focus();
        }

        private void AtualizarGrid()
        {
            try
            {
                using (SqlConnection conn = new Connection().Connect())
                {
                    string sql = "SELECT * FROM Produtos";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a lista: " + ex.Message);
            }
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            CatCb.Items.Add("Alimentos");
            CatCb.Items.Add("Bebidas");
            CatCb.Items.Add("Eletrônicos");
            CatCb.Items.Add("Informática");
            CatCb.Items.Add("Limpeza");
            CatCb.Items.Add("Higiene");
            CatCb.Items.Add("Vestuário");
            CatCb.Items.Add("Acessórios");
            CatCb.Items.Add("Papelaria");
            CatCb.Items.Add("Ferramentas");

            AtualizarGrid();
        }

        public class Produto
        {
            public int ID { get; set; }
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public decimal Preco { get; set; }
            public int Estoque { get; set; }
            public string Categoria { get; set; }
        }

        public class Connection
        {
            public SqlConnection Connect()
            {
                SqlConnection conn = new SqlConnection(@"Server=.\BDSENAC;Database=AgendaDB;User Id=senaclivre;Password=senaclivre;");
                conn.Open();
                return conn;
            }
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(NomTxt.Text))
            {
                MessageBox.Show("Por favor, preencha o Nome!");
                return;
            }

            if (string.IsNullOrWhiteSpace(DesTxt.Text))
            {
                MessageBox.Show("Por favor, preencha a descrição!");
                return;
            }

            if (string.IsNullOrWhiteSpace(PreTxt.Text))
            {
                MessageBox.Show("Por favor, preencha o preço!");
                return;
            }

            if (string.IsNullOrWhiteSpace(EstTxt.Text))
            {
                MessageBox.Show("Por favor, preencha o estoque!");
                return;
            }

            if (CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione a categoria!");
                return;
            }

            try
            {
                using (SqlConnection conn = new Connection().Connect())
                {
                    string sql = @"INSERT INTO Produtos
                                 (Nome, Descricao, Preco, Estoque, Categoria)
                                 Values (@Nome, @Descricao, @Preco, @Estoque, @Categoria)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", NomTxt.Text);
                        cmd.Parameters.AddWithValue("@Descricao", DesTxt.Text);
                        cmd.Parameters.Add("@Preco", SqlDbType.Decimal).Value = decimal.Parse(PreTxt.Text);
                        cmd.Parameters.Add("@Estoque", SqlDbType.Int).Value = int.Parse(EstTxt.Text);
                        cmd.Parameters.AddWithValue("@Categoria", CatCb.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Produto inserido com sucesso!");

                AtualizarGrid();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir produto: " + ex.Message);
            }
        }

        private void ConsultarPorNome()
        {
            try
            {
                using (SqlConnection conn = new Connection().Connect())
                {
                    string sql = "SELECT * FROM Produtos WHERE Nome LIKE @Nome";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", "%" + NomTxt.Text + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
            }
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomTxt.Text))
            {
                MessageBox.Show("Digite o nome para consultar!");
                NomTxt.Focus();
                return;
            }

            ConsultarPorNome();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            { 
              DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                IdTxt.Text = row.Cells["ID"].Value.ToString();
                NomTxt.Text = row.Cells["Nome"].Value.ToString();
                DesTxt.Text = row.Cells["Descricao"].Value.ToString();
                PreTxt.Text = row.Cells["Preco"].Value.ToString();
                EstTxt.Text = row.Cells["Estoque"].Value.ToString();
                CatCb.Text = row.Cells["Categoria"].Value.ToString();
            }
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IdTxt.Text))
            {
                MessageBox.Show("Selecione um produto no grid para alterar!");
                return;
            }

            if (string.IsNullOrWhiteSpace(NomTxt.Text) ||
        string.IsNullOrWhiteSpace(DesTxt.Text) ||
        string.IsNullOrWhiteSpace(PreTxt.Text) ||
        string.IsNullOrWhiteSpace(EstTxt.Text) ||
        CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos antes de alterar!");
                return;
            }

            try
            {

                using (SqlConnection conn = new Connection().Connect())
                {
                    string sql = @"UPDATE Produtos
                                 SET Nome = @Nome,
                                 Descricao = @Descricao,
                                 Preco = @Preco,
                                 Estoque = @Estoque,
                                 Categoria = @Categoria
                                 WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", int.Parse(IdTxt.Text));
                        cmd.Parameters.AddWithValue("@Nome", NomTxt.Text);
                        cmd.Parameters.AddWithValue("@Descricao", DesTxt.Text);
                        cmd.Parameters.AddWithValue("@Preco", decimal.Parse(PreTxt.Text));
                        cmd.Parameters.AddWithValue("@Estoque", int.Parse(EstTxt.Text));
                        cmd.Parameters.AddWithValue("@Categoria", CatCb.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Produto alterado com sucesso!");

                AtualizarGrid();
                LimparCampos();
            }
              catch (Exception ex) 
            {
                MessageBox.Show("Erro ao alterar: " + ex.Message);
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IdTxt.Text))
            {
                MessageBox.Show("Selecione um registro para excluir!");
                return;
            }
            if (MessageBox.Show("Deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            using (SqlConnection conn = new Connection().Connect())
            {
                string sql = "DELETE FROM Produtos WHERE ID=@ID";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(@"ID", IdTxt.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Registro excluído com sucesso!");
            AtualizarGrid();
            LimparCampos();
        }

        private void MdadosBut_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
