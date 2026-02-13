namespace primeiroprojetoti48
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Formulario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NomTxt = new System.Windows.Forms.TextBox();
            this.Endereco = new System.Windows.Forms.Label();
            this.EndTxt = new System.Windows.Forms.TextBox();
            this.NumTxt = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.Label();
            this.EmaTxt = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Dat = new System.Windows.Forms.DateTimePicker();
            this.Data = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdicionarBut = new System.Windows.Forms.Button();
            this.AlterarBut = new System.Windows.Forms.Button();
            this.ExcluirBut = new System.Windows.Forms.Button();
            this.ConsultarBut = new System.Windows.Forms.Button();
            this.MDadosBut = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.IdTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Formulario
            // 
            this.Formulario.AutoSize = true;
            this.Formulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.Formulario.Location = new System.Drawing.Point(220, 20);
            this.Formulario.Name = "Formulario";
            this.Formulario.Size = new System.Drawing.Size(272, 73);
            this.Formulario.TabIndex = 0;
            this.Formulario.Text = "Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(60, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // NomTxt
            // 
            this.NomTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.NomTxt.Location = new System.Drawing.Point(64, 157);
            this.NomTxt.Name = "NomTxt";
            this.NomTxt.Size = new System.Drawing.Size(541, 31);
            this.NomTxt.TabIndex = 2;
            this.NomTxt.TextChanged += new System.EventHandler(this.NomTxt_TextChanged_1);
            // 
            // Endereco
            // 
            this.Endereco.AutoSize = true;
            this.Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Endereco.Location = new System.Drawing.Point(60, 216);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(78, 20);
            this.Endereco.TabIndex = 3;
            this.Endereco.Text = "Endereço";
            // 
            // EndTxt
            // 
            this.EndTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.EndTxt.Location = new System.Drawing.Point(64, 239);
            this.EndTxt.Name = "EndTxt";
            this.EndTxt.Size = new System.Drawing.Size(541, 31);
            this.EndTxt.TabIndex = 4;
            // 
            // NumTxt
            // 
            this.NumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.NumTxt.Location = new System.Drawing.Point(64, 324);
            this.NumTxt.Name = "NumTxt";
            this.NumTxt.Size = new System.Drawing.Size(541, 31);
            this.NumTxt.TabIndex = 5;
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Numero.Location = new System.Drawing.Point(60, 301);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(65, 20);
            this.Numero.TabIndex = 6;
            this.Numero.Text = "Número";
            // 
            // EmaTxt
            // 
            this.EmaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.EmaTxt.Location = new System.Drawing.Point(64, 411);
            this.EmaTxt.Name = "EmaTxt";
            this.EmaTxt.Size = new System.Drawing.Size(541, 31);
            this.EmaTxt.TabIndex = 7;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Email.Location = new System.Drawing.Point(60, 388);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 20);
            this.Email.TabIndex = 8;
            this.Email.Text = "Email";
            // 
            // Dat
            // 
            this.Dat.Location = new System.Drawing.Point(215, 542);
            this.Dat.Name = "Dat";
            this.Dat.Size = new System.Drawing.Size(286, 20);
            this.Dat.TabIndex = 9;
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Data.Location = new System.Drawing.Point(60, 542);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(144, 20);
            this.Data.TabIndex = 10;
            this.Data.Text = "Data do formulário:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 593);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 136);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AdicionarBut
            // 
            this.AdicionarBut.Location = new System.Drawing.Point(64, 762);
            this.AdicionarBut.Name = "AdicionarBut";
            this.AdicionarBut.Size = new System.Drawing.Size(92, 42);
            this.AdicionarBut.TabIndex = 12;
            this.AdicionarBut.Text = "Adicionar";
            this.AdicionarBut.UseVisualStyleBackColor = true;
            this.AdicionarBut.Click += new System.EventHandler(this.AdicionarBut_Click);
            // 
            // AlterarBut
            // 
            this.AlterarBut.Location = new System.Drawing.Point(215, 762);
            this.AlterarBut.Name = "AlterarBut";
            this.AlterarBut.Size = new System.Drawing.Size(92, 42);
            this.AlterarBut.TabIndex = 13;
            this.AlterarBut.Text = "Alterar";
            this.AlterarBut.UseVisualStyleBackColor = true;
            this.AlterarBut.Click += new System.EventHandler(this.AlterarBut_Click);
            // 
            // ExcluirBut
            // 
            this.ExcluirBut.Location = new System.Drawing.Point(368, 762);
            this.ExcluirBut.Name = "ExcluirBut";
            this.ExcluirBut.Size = new System.Drawing.Size(92, 42);
            this.ExcluirBut.TabIndex = 14;
            this.ExcluirBut.Text = "Excluir";
            this.ExcluirBut.UseVisualStyleBackColor = true;
            this.ExcluirBut.Click += new System.EventHandler(this.ExcluirBut_Click);
            // 
            // ConsultarBut
            // 
            this.ConsultarBut.Location = new System.Drawing.Point(513, 762);
            this.ConsultarBut.Name = "ConsultarBut";
            this.ConsultarBut.Size = new System.Drawing.Size(107, 42);
            this.ConsultarBut.TabIndex = 15;
            this.ConsultarBut.Text = "Consultar";
            this.ConsultarBut.UseVisualStyleBackColor = true;
            this.ConsultarBut.Click += new System.EventHandler(this.ConsultarBut_Click);
            // 
            // MDadosBut
            // 
            this.MDadosBut.Location = new System.Drawing.Point(64, 833);
            this.MDadosBut.Name = "MDadosBut";
            this.MDadosBut.Size = new System.Drawing.Size(106, 52);
            this.MDadosBut.TabIndex = 16;
            this.MDadosBut.Text = "Mostrar Dados";
            this.MDadosBut.UseVisualStyleBackColor = true;
            this.MDadosBut.Click += new System.EventHandler(this.MDadosBut_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ID.Location = new System.Drawing.Point(60, 458);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 17;
            this.ID.Text = "ID";
            // 
            // IdTxt
            // 
            this.IdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.IdTxt.Location = new System.Drawing.Point(64, 481);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(541, 31);
            this.IdTxt.TabIndex = 18;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(712, 900);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.MDadosBut);
            this.Controls.Add(this.ConsultarBut);
            this.Controls.Add(this.ExcluirBut);
            this.Controls.Add(this.AlterarBut);
            this.Controls.Add(this.AdicionarBut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Dat);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.EmaTxt);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.NumTxt);
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.EndTxt);
            this.Controls.Add(this.NomTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Formulario);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Formulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomTxt;
        private System.Windows.Forms.Label Endereco;
        private System.Windows.Forms.TextBox EndTxt;
        private System.Windows.Forms.TextBox NumTxt;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.TextBox EmaTxt;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.DateTimePicker Dat;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AdicionarBut;
        private System.Windows.Forms.Button AlterarBut;
        private System.Windows.Forms.Button ExcluirBut;
        private System.Windows.Forms.Button ConsultarBut;
        private System.Windows.Forms.Button MDadosBut;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox IdTxt;
    }
}
