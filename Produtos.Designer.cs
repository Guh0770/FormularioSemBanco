namespace primeiroprojetoti48
{
    partial class Produtos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NomTxt = new System.Windows.Forms.TextBox();
            this.Descricao = new System.Windows.Forms.Label();
            this.DesTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PreTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EstTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.MdadosBut = new System.Windows.Forms.Button();
            this.CatCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Produtos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // IdTxt
            // 
            this.IdTxt.Location = new System.Drawing.Point(67, 121);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(184, 31);
            this.IdTxt.TabIndex = 3;
            this.IdTxt.TextChanged += new System.EventHandler(this.IdTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome";
            // 
            // NomTxt
            // 
            this.NomTxt.Location = new System.Drawing.Point(67, 230);
            this.NomTxt.Name = "NomTxt";
            this.NomTxt.Size = new System.Drawing.Size(255, 31);
            this.NomTxt.TabIndex = 5;
            // 
            // Descricao
            // 
            this.Descricao.AutoSize = true;
            this.Descricao.Location = new System.Drawing.Point(62, 297);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(108, 25);
            this.Descricao.TabIndex = 4;
            this.Descricao.Text = "Descrição";
            // 
            // DesTxt
            // 
            this.DesTxt.Location = new System.Drawing.Point(67, 341);
            this.DesTxt.Name = "DesTxt";
            this.DesTxt.Size = new System.Drawing.Size(255, 31);
            this.DesTxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Preço";
            // 
            // PreTxt
            // 
            this.PreTxt.Location = new System.Drawing.Point(67, 457);
            this.PreTxt.Name = "PreTxt";
            this.PreTxt.Size = new System.Drawing.Size(255, 31);
            this.PreTxt.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Estoque";
            // 
            // EstTxt
            // 
            this.EstTxt.Location = new System.Drawing.Point(71, 579);
            this.EstTxt.Name = "EstTxt";
            this.EstTxt.Size = new System.Drawing.Size(251, 31);
            this.EstTxt.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 664);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Categoria";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 392);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Adicionar
            // 
            this.Adicionar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Adicionar.Location = new System.Drawing.Point(375, 550);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(119, 39);
            this.Adicionar.TabIndex = 14;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = false;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // Alterar
            // 
            this.Alterar.Location = new System.Drawing.Point(529, 550);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(119, 39);
            this.Alterar.TabIndex = 14;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.Color.DarkRed;
            this.Excluir.Location = new System.Drawing.Point(672, 550);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(119, 39);
            this.Excluir.TabIndex = 14;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(442, 629);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(119, 39);
            this.Consultar.TabIndex = 15;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // MdadosBut
            // 
            this.MdadosBut.Location = new System.Drawing.Point(614, 618);
            this.MdadosBut.Name = "MdadosBut";
            this.MdadosBut.Size = new System.Drawing.Size(134, 60);
            this.MdadosBut.TabIndex = 15;
            this.MdadosBut.Text = "Mostrar Dados";
            this.MdadosBut.UseVisualStyleBackColor = true;
            this.MdadosBut.Click += new System.EventHandler(this.MdadosBut_Click);
            // 
            // CatCb
            // 
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "Alimentos",
            "Bebidas",
            "Eletrônicos",
            "Informática",
            "Limpeza",
            "Higiene",
            "Vestuário",
            "Acessórios",
            "Papelaria",
            "Ferramentas"});
            this.CatCb.Location = new System.Drawing.Point(67, 715);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(255, 33);
            this.CatCb.TabIndex = 16;
            this.CatCb.SelectedIndexChanged += new System.EventHandler(this.CatCb_SelectedIndexChanged);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(824, 831);
            this.Controls.Add(this.CatCb);
            this.Controls.Add(this.MdadosBut);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EstTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PreTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DesTxt);
            this.Controls.Add(this.NomTxt);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Produtos";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NomTxt;
        private System.Windows.Forms.Label Descricao;
        private System.Windows.Forms.TextBox DesTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PreTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EstTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button MdadosBut;
        private System.Windows.Forms.ComboBox CatCb;
    }
}