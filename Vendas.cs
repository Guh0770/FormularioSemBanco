using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace primeiroprojetoti48
{
    public partial class Vendas : Form
    {
        public SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(
                @"Server=.\BDSENAC;Database=AgendaDB;User Id=senaclivre;Password=senaclivre;"
            );
            conn.Open();
            return conn;
        }

        public Vendas()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 agenda = new Form2();
            agenda.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizarGrid()
        {
            using (SqlConnection conn = Connect())
            {
                string sql = "SELECT * FROM Vendas";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void CarregarClientes()
        {
            using (SqlConnection conn = Connect())
            {
                string sql = "SELECT ID, Nome FROM Contatos";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                CliCom.DataSource = dt;
                CliCom.DisplayMember = "Nome";
                CliCom.ValueMember = "ID";
                CliCom.SelectedIndex = -1;
            }
        }

        private void CarregarProdutos()
        {
            using (SqlConnection conn = Connect())
            {
                string sql = "SELECT ID, Nome FROM Produtos";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                CliCom.DataSource = dt;
                CliCom.DisplayMember = "Nome";
                CliCom.ValueMember = "ID";
                CliCom.SelectedIndex = -1;
            }
        }

        private void CalcularTotais()
        {
            if (QuaTex.Text == "" || PreTex.Text == "")
                return;

            int quantidade = int.Parse(QuaTex.Text);
            decimal precoUnitario = decimal.Parse(PreTex.Text);

            decimal desconto = 0;
            if (DesTex.Text != "")
                desconto = decimal.Parse(DesTex.Text);

            decimal totalSemDesconto = quantidade * precoUnitario;
            decimal valorDesconto = totalSemDesconto * (desconto / 100);
            decimal totalComDesconto = totalSemDesconto - valorDesconto;

            TotsTex.Text = totalSemDesconto.ToString("F2");
            TotcTex.Text = totalComDesconto.ToString("F2");
        }

        private void PreTex_TextChanged(object sender, EventArgs e)
        {
            CalcularTotais();
        }

        private void QuaTex_TextChanged(object sender, EventArgs e)
        {
            CalcularTotais();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            CarregarClientes();
            CarregarProdutos();
        }

        private void venda_Click(object sender, EventArgs e)
        {
        }

        private void RegBut_Click(object sender, EventArgs e)
        {
            if (
                IdcTex.Text == "" ||
                IdpTex.Text == "" ||
                QuaTex.Text == "" ||
                PreTex.Text == ""
            )
            {
                MessageBox.Show("Preencha os campos obrigatórios!");
                return;
            }

            using (SqlConnection conn = Connect())
            {
                if (CliCom.SelectedIndex == -1 || ProCom.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um cliente e um produto!");
                    return;
                }

                string sql = @"INSERT INTO Vendas
                (IdCliente, IdProduto, DataCompra, Quantidade, PrecoUnitario, Desconto, TotalSemDesconto, TotalComDesconto)
                VALUES
                (@IdCliente, @IdProduto, @DataCompra, @Quantidade, @PrecoUnitario, @Desconto, @TotalSemDesconto, @TotalComDesconto)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@IdCliente",
                        Convert.ToInt32(CliCom.SelectedValue)
                    );

                    cmd.Parameters.AddWithValue(
                        "@IdProduto",
                        Convert.ToInt32(ProCom.SelectedValue)
                    );

                    cmd.Parameters.AddWithValue("@DataCompra", DataPic.Value.Date);
                    cmd.Parameters.AddWithValue("@Quantidade", int.Parse(QuaTex.Text));
                    cmd.Parameters.AddWithValue("@PrecoUnitario", decimal.Parse(PreTex.Text));
                    cmd.Parameters.AddWithValue("@Desconto", DesTex.Text == "" ? 0 : decimal.Parse(DesTex.Text));
                    cmd.Parameters.AddWithValue("@TotalSemDesconto", decimal.Parse(TotsTex.Text));
                    cmd.Parameters.AddWithValue("@TotalComDesconto", decimal.Parse(TotcTex.Text));

                    cmd.ExecuteNonQuery();
                }


                AtualizarGrid();
                MessageBox.Show("Venda registrada com sucesso!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                IdTex.Text = row.Cells["IdVenda"].Value.ToString();
                IdcTex.Text = row.Cells["IdCliente"].Value.ToString();
                IdpTex.Text = row.Cells["IdProduto"].Value.ToString();
                QuaTex.Text = row.Cells["Quantidade"].Value.ToString();
                PreTex.Text = row.Cells["PrecoUnitario"].Value.ToString();
                DesTex.Text = row.Cells["Desconto"].Value.ToString();
                TotsTex.Text = row.Cells["TotalSemDesconto"].Value.ToString();
                TotcTex.Text = row.Cells["TotalComDesconto"].Value.ToString();
                DataPic.Value = Convert.ToDateTime(row.Cells["DataCompra"].Value);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void AltBut_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connect())
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Vendas SET " +
                    "IdCliente=@IdCliente, " +
                    "IdProduto=@IdProduto, " +
                    "Quantidade=@Quantidade, " +
                    "PrecoUnitario=@PrecoUnitario, " +
                    "Desconto=@Desconto, " +
                    "TotalSemDesconto=@TotalSemDesconto, " +
                    "TotalComDesconto=@TotalComDesconto, " +
                    "DataCompra=@DataCompra " +
                    "WHERE IdVenda=@IdVenda", conn);

                cmd.Parameters.AddWithValue("@IdVenda", int.Parse(IdTex.Text));
                cmd.Parameters.AddWithValue("@IdCliente", int.Parse(IdcTex.Text));
                cmd.Parameters.AddWithValue("@IdProduto", int.Parse(IdpTex.Text));
                cmd.Parameters.AddWithValue("@Quantidade", int.Parse(QuaTex.Text));
                cmd.Parameters.AddWithValue("@PrecoUnitario", decimal.Parse(PreTex.Text));
                cmd.Parameters.AddWithValue("@Desconto", DesTex.Text == "" ? 0 : decimal.Parse(DesTex.Text));
                cmd.Parameters.AddWithValue("@TotalSemDesconto", decimal.Parse(TotsTex.Text));
                cmd.Parameters.AddWithValue("@TotalComDesconto", decimal.Parse(TotcTex.Text));
                cmd.Parameters.AddWithValue("@DataCompra", DataPic.Value.Date);

                cmd.ExecuteNonQuery();
            }

            AtualizarGrid();
            MessageBox.Show("Venda alterada com sucesso!");
        }

        private void ExcBut_Click(object sender, EventArgs e)
        {
            if (IdcTex.Text == "")
            {
                MessageBox.Show("Selecione uma venda para exluir!");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir esta venda?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            using (SqlConnection conn = Connect())
            {
                SqlCommand cmd = new SqlCommand(
                "DELETE FROM Vendas WHERE IdVenda = @IdVenda", conn);

                cmd.Parameters.AddWithValue("@IdVenda", int.Parse(IdcTex.Text));

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Venda excluída com sucesso!");
            AtualizarGrid();
        }

        private void CliCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CliCom.SelectedIndex != -1)
            {
                IdcTex.Text = CliCom.SelectedValue.ToString();
            }
        }

        private void ProCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProCom.SelectedIndex != -1)
                return;
            using (SqlConnection conn = Connect())
            {
                string sql = "SELECT Preco FROM Produtos WHERE ID = @IdProduto";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@IdProduto",
                        Convert.ToInt32(ProCom.SelectedValue)
                        );

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        PreTex.Text = Convert.ToDecimal(resultado).ToString("F2");
                    }
                }
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 clientes = new Form2();
            clientes.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            vendas.ShowDialog();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

