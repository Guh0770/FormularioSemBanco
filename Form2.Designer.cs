namespace primeiroprojetoti48
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Formulario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NomTxt = new System.Windows.Forms.TextBox();
            this.Funcao = new System.Windows.Forms.Label();
            this.FunTxt = new System.Windows.Forms.TextBox();
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
            this.Formulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formulario.Location = new System.Drawing.Point(220, 20);
            this.Formulario.Name = "Formulario";
            this.Formulario.Size = new System.Drawing.Size(348, 73);
            this.Formulario.TabIndex = 0;
            this.Formulario.Text = "Formulário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // NomTxt
            // 
            this.NomTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomTxt.Location = new System.Drawing.Point(64, 157);
            this.NomTxt.Name = "NomTxt";
            this.NomTxt.Size = new System.Drawing.Size(541, 31);
            this.NomTxt.TabIndex = 2;
            this.NomTxt.TextChanged += new System.EventHandler(this.NomTxt_TextChanged);
            // 
            // Funcao
            // 
            this.Funcao.AutoSize = true;
            this.Funcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Funcao.Location = new System.Drawing.Point(60, 216);
            this.Funcao.Name = "Funcao";
            this.Funcao.Size = new System.Drawing.Size(63, 20);
            this.Funcao.TabIndex = 3;
            this.Funcao.Text = "Função";
            // 
            // FunTxt
            // 
            this.FunTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunTxt.Location = new System.Drawing.Point(64, 239);
            this.FunTxt.Name = "FunTxt";
            this.FunTxt.Size = new System.Drawing.Size(541, 31);
            this.FunTxt.TabIndex = 2;
            // 
            // NumTxt
            // 
            this.NumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumTxt.Location = new System.Drawing.Point(64, 324);
            this.NumTxt.Name = "NumTxt";
            this.NumTxt.Size = new System.Drawing.Size(541, 31);
            this.NumTxt.TabIndex = 2;
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.Location = new System.Drawing.Point(60, 301);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(65, 20);
            this.Numero.TabIndex = 3;
            this.Numero.Text = "Número";
            // 
            // EmaTxt
            // 
            this.EmaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmaTxt.Location = new System.Drawing.Point(64, 411);
            this.EmaTxt.Name = "EmaTxt";
            this.EmaTxt.Size = new System.Drawing.Size(541, 31);
            this.EmaTxt.TabIndex = 2;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(60, 388);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 20);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            // 
            // Dat
            // 
            this.Dat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dat.Location = new System.Drawing.Point(215, 542);
            this.Dat.Name = "Dat";
            this.Dat.Size = new System.Drawing.Size(286, 22);
            this.Dat.TabIndex = 4;
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(60, 542);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(144, 20);
            this.Data.TabIndex = 3;
            this.Data.Text = "Data do formulário:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 593);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 136);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AdicionarBut
            // 
            this.AdicionarBut.BackColor = System.Drawing.Color.GreenYellow;
            this.AdicionarBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdicionarBut.Location = new System.Drawing.Point(64, 762);
            this.AdicionarBut.Name = "AdicionarBut";
            this.AdicionarBut.Size = new System.Drawing.Size(92, 42);
            this.AdicionarBut.TabIndex = 6;
            this.AdicionarBut.Text = "Adicionar";
            this.AdicionarBut.UseVisualStyleBackColor = false;
            this.AdicionarBut.Click += new System.EventHandler(this.AdicionarBut_Click);
            // 
            // AlterarBut
            // 
            this.AlterarBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlterarBut.Location = new System.Drawing.Point(215, 762);
            this.AlterarBut.Name = "AlterarBut";
            this.AlterarBut.Size = new System.Drawing.Size(92, 42);
            this.AlterarBut.TabIndex = 7;
            this.AlterarBut.Text = "Alterar";
            this.AlterarBut.UseVisualStyleBackColor = true;
            this.AlterarBut.Click += new System.EventHandler(this.AlterarBut_Click);
            // 
            // ExcluirBut
            // 
            this.ExcluirBut.BackColor = System.Drawing.Color.DarkRed;
            this.ExcluirBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcluirBut.Location = new System.Drawing.Point(368, 762);
            this.ExcluirBut.Name = "ExcluirBut";
            this.ExcluirBut.Size = new System.Drawing.Size(92, 42);
            this.ExcluirBut.TabIndex = 8;
            this.ExcluirBut.Text = "Excluir";
            this.ExcluirBut.UseVisualStyleBackColor = false;
            this.ExcluirBut.Click += new System.EventHandler(this.ExcluirBut_Click);
            // 
            // ConsultarBut
            // 
            this.ConsultarBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarBut.Location = new System.Drawing.Point(513, 762);
            this.ConsultarBut.Name = "ConsultarBut";
            this.ConsultarBut.Size = new System.Drawing.Size(107, 42);
            this.ConsultarBut.TabIndex = 9;
            this.ConsultarBut.Text = "Consultar";
            this.ConsultarBut.UseVisualStyleBackColor = true;
            this.ConsultarBut.Click += new System.EventHandler(this.ConsultarBut_Click);
            // 
            // MDadosBut
            // 
            this.MDadosBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MDadosBut.Location = new System.Drawing.Point(64, 833);
            this.MDadosBut.Name = "MDadosBut";
            this.MDadosBut.Size = new System.Drawing.Size(106, 52);
            this.MDadosBut.TabIndex = 10;
            this.MDadosBut.Text = "Mostar Dados";
            this.MDadosBut.UseVisualStyleBackColor = true;
            this.MDadosBut.Click += new System.EventHandler(this.MDadosBut_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(60, 458);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 11;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.label2_Click);
            // 
            // IdTxt
            // 
            this.IdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTxt.Location = new System.Drawing.Point(64, 481);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(541, 31);
            this.IdTxt.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 900);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.MDadosBut);
            this.Controls.Add(this.ConsultarBut);
            this.Controls.Add(this.ExcluirBut);
            this.Controls.Add(this.AlterarBut);
            this.Controls.Add(this.AdicionarBut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Dat);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.EmaTxt);
            this.Controls.Add(this.NumTxt);
            this.Controls.Add(this.Funcao);
            this.Controls.Add(this.FunTxt);
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
        private System.Windows.Forms.Label Funcao;
        private System.Windows.Forms.TextBox FunTxt;
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