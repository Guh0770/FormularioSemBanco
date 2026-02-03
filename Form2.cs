using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace primeiroprojetoti48
{
    public partial class Form2 : Form
    {

        Connection con = new Connection();


        public Form2()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            IdTxt.Clear();
            NomTxt.Clear();
            FunTxt.Clear();
            NumTxt.Clear();
            EmaTxt.Clear();
            NomTxt.Focus();
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

        public class Contato
        {
            public int ID { get; set; }
            public string Nome { get; set; }
            public string Funcao { get; set; }
            public string Numero { get; set; }
            public string Email { get; set; }
            public DateTime DataForm { get; set; }
        }

        private void AtualizarGrid()
        {
            using (SqlConnection conn = con.Connect())
            {
                string sql = "SELECT * FROM Contatos";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
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

            try
            {
                //abre a conexão com o banco
                using (SqlConnection conn = con.Connect())
                {
                    string sql = @"INSERT INTO Contatos (Nome, Funcao, Numero, Email, DataForm)
                       VALUES (@Nome, @Funcao, @Numero, @Email, @DataForm)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", NomTxt.Text);
                        cmd.Parameters.AddWithValue("@Funcao", FunTxt.Text);
                        cmd.Parameters.AddWithValue("@Numero", NumTxt.Text);
                        cmd.Parameters.AddWithValue("@Email", EmaTxt.Text);
                        cmd.Parameters.AddWithValue("@DataForm", Dat.Value.Date);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registro inserido com sucesso!");

                // Atualizar grid
                AtualizarGrid();

                // Limpar campo
                LimparCampos();

                NomTxt.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir registro: " + ex.Message);
            }
        }

        private void ConsultarPorNome()
        {
            try
            {
                using (SqlConnection conn = con.Connect())
                {
                    string sql = "SELECT * FROM Contatos WHERE Nome LIKE @Nome";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Busca pelo nome parcialmente (LIKE '%nome%')
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                IdTxt.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                NomTxt.Text = dataGridView1.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                FunTxt.Text = dataGridView1.Rows[e.RowIndex].Cells["Funcao"].Value.ToString();
                NumTxt.Text = dataGridView1.Rows[e.RowIndex].Cells["Numero"].Value.ToString();
                EmaTxt.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                Dat.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["DataForm"].Value);
            }
        }
        private void AlterarBut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IdTxt.Text))
            {
                MessageBox.Show("Selecione um registro para alterar!");
                return;
            }

            using (SqlConnection conn = con.Connect())
            {
                string sql = @"UPDATE Contatos
                                 SET Nome=@Nome, Funcao=@Funcao, Numero=@Numero, Email=@Email, DataForm=@DataForm
                                 WHERE ID=@Id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id", IdTxt.Text);
                    cmd.Parameters.AddWithValue("Nome", NomTxt.Text);
                    cmd.Parameters.AddWithValue("Funcao", FunTxt.Text);
                    cmd.Parameters.AddWithValue("Numero", NumTxt.Text);
                    cmd.Parameters.AddWithValue("Email", EmaTxt.Text);
                    cmd.Parameters.AddWithValue("DataForm", Dat.Value.Date);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Registro alterado com sucesso!");
            AtualizarGrid();

            LimparCampos();
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

            using (SqlConnection conn = con.Connect())
            {
                string sql = "DELETE FROM Contatos WHERE ID=@ID";

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


        private void MDadosBut_Click(object sender, EventArgs e)
        {
            AtualizarGrid(); //carrega todos os registros do banco
        }

        private void ConsultarBut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomTxt.Text))
            {
                MessageBox.Show("Digite o nome para consultar!");
                NomTxt.Focus();
                return;
            }

            ConsultarPorNome();
        }

        private void FunTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
