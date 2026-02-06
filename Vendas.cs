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
    public partial class Vendas : Form
    {
        SqlConnection conn = new SqlConnection(
            @"Server=.\BDSENAC;Database=AgendaDB;User Id=senaclivre;Password=senaclivre;"
);
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

        private void PreTex_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vendas_Load(object sender, EventArgs e)
        {

        }

        private void venda_Click(object sender, EventArgs e)
        {

        }

        private void RegBut_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sql = @"INSERT INTO Vendas
            (IdCliente, IdProduto, DataCompra, Quantidade, PrecoUnitario, Desconto, TotalSemDesconto, TotalComDesconto)
            VALUES
            (@IdCliente, @IdProduto, @DataCompra, @Quantidade, @PrecoUnitario, @Desconto, @TotalSemDesconto, @TotalcomDesconto)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("IdCliente", IdcTex.Text);
            cmd.Parameters.AddWithValue("IdProduto", IdpTex.Text);
            cmd.Parameters.AddWithValue("@DataCompra", DataPic.Value.Date);
            cmd.Parameters.AddWithValue("@Quantidade", QuaTex.Text);
            cmd.Parameters.AddWithValue("@PrecoUnitario", 0);
            cmd.Parameters.AddWithValue("@Desconto", 0);
            cmd.Parameters.AddWithValue("@TotalSem", TotsTex.Text);
            cmd.Parameters.AddWithValue("@TotalCom", TotcTex.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Venda registrada com sucesso!");
        }
    }
}
