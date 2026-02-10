namespace primeiroprojetoti48
{
    partial class Vendas
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
            this.venda = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IDCliente = new System.Windows.Forms.Label();
            this.IDProduto = new System.Windows.Forms.Label();
            this.DataCompra = new System.Windows.Forms.Label();
            this.Quant = new System.Windows.Forms.Label();
            this.Pre = new System.Windows.Forms.Label();
            this.Des = new System.Windows.Forms.Label();
            this.SemD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RegBut = new System.Windows.Forms.Button();
            this.AltBut = new System.Windows.Forms.Button();
            this.ExcBut = new System.Windows.Forms.Button();
            this.IdTex = new System.Windows.Forms.TextBox();
            this.IdcTex = new System.Windows.Forms.TextBox();
            this.IdpTex = new System.Windows.Forms.TextBox();
            this.DataPic = new System.Windows.Forms.DateTimePicker();
            this.QuaTex = new System.Windows.Forms.TextBox();
            this.PreTex = new System.Windows.Forms.TextBox();
            this.DesTex = new System.Windows.Forms.TextBox();
            this.TotcTex = new System.Windows.Forms.TextBox();
            this.TotsTex = new System.Windows.Forms.TextBox();
            this.ProCom = new System.Windows.Forms.ComboBox();
            this.CliCom = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // venda
            // 
            this.venda.AutoSize = true;
            this.venda.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venda.Location = new System.Drawing.Point(23, 37);
            this.venda.Name = "venda";
            this.venda.Size = new System.Drawing.Size(171, 60);
            this.venda.TabIndex = 0;
            this.venda.Text = "Vendas";
            this.venda.Click += new System.EventHandler(this.venda_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(30, 125);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(22, 18);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "ID";
            // 
            // IDCliente
            // 
            this.IDCliente.AutoSize = true;
            this.IDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDCliente.Location = new System.Drawing.Point(194, 125);
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.Size = new System.Drawing.Size(67, 18);
            this.IDCliente.TabIndex = 2;
            this.IDCliente.Text = "IDCliente";
            // 
            // IDProduto
            // 
            this.IDProduto.AutoSize = true;
            this.IDProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDProduto.Location = new System.Drawing.Point(366, 125);
            this.IDProduto.Name = "IDProduto";
            this.IDProduto.Size = new System.Drawing.Size(75, 18);
            this.IDProduto.TabIndex = 2;
            this.IDProduto.Text = "IDProduto";
            // 
            // DataCompra
            // 
            this.DataCompra.AutoSize = true;
            this.DataCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataCompra.Location = new System.Drawing.Point(30, 204);
            this.DataCompra.Name = "DataCompra";
            this.DataCompra.Size = new System.Drawing.Size(117, 18);
            this.DataCompra.TabIndex = 2;
            this.DataCompra.Text = "Data da Compra";
            // 
            // Quant
            // 
            this.Quant.AutoSize = true;
            this.Quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quant.Location = new System.Drawing.Point(194, 204);
            this.Quant.Name = "Quant";
            this.Quant.Size = new System.Drawing.Size(83, 18);
            this.Quant.TabIndex = 2;
            this.Quant.Text = "Quantidade";
            // 
            // Pre
            // 
            this.Pre.AutoSize = true;
            this.Pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pre.Location = new System.Drawing.Point(331, 204);
            this.Pre.Name = "Pre";
            this.Pre.Size = new System.Drawing.Size(48, 18);
            this.Pre.TabIndex = 2;
            this.Pre.Text = "Preço";
            // 
            // Des
            // 
            this.Des.AutoSize = true;
            this.Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Des.Location = new System.Drawing.Point(428, 204);
            this.Des.Name = "Des";
            this.Des.Size = new System.Drawing.Size(73, 18);
            this.Des.TabIndex = 2;
            this.Des.Text = "Desconto";
            // 
            // SemD
            // 
            this.SemD.AutoSize = true;
            this.SemD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemD.Location = new System.Drawing.Point(30, 310);
            this.SemD.Name = "SemD";
            this.SemD.Size = new System.Drawing.Size(143, 18);
            this.SemD.TabIndex = 2;
            this.SemD.Text = "Total sem Desconto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total com Desconto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::primeiroprojetoti48.Properties.Resources.compras;
            this.pictureBox1.Location = new System.Drawing.Point(433, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(646, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 280);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RegBut
            // 
            this.RegBut.BackColor = System.Drawing.Color.LimeGreen;
            this.RegBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegBut.Location = new System.Drawing.Point(646, 334);
            this.RegBut.Name = "RegBut";
            this.RegBut.Size = new System.Drawing.Size(107, 47);
            this.RegBut.TabIndex = 5;
            this.RegBut.Text = "Registrar venda";
            this.RegBut.UseVisualStyleBackColor = false;
            this.RegBut.Click += new System.EventHandler(this.RegBut_Click);
            // 
            // AltBut
            // 
            this.AltBut.BackColor = System.Drawing.Color.Yellow;
            this.AltBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltBut.Location = new System.Drawing.Point(773, 341);
            this.AltBut.Name = "AltBut";
            this.AltBut.Size = new System.Drawing.Size(94, 32);
            this.AltBut.TabIndex = 5;
            this.AltBut.Text = "Alterar";
            this.AltBut.UseVisualStyleBackColor = false;
            this.AltBut.Click += new System.EventHandler(this.AltBut_Click);
            // 
            // ExcBut
            // 
            this.ExcBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExcBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcBut.Location = new System.Drawing.Point(890, 341);
            this.ExcBut.Name = "ExcBut";
            this.ExcBut.Size = new System.Drawing.Size(91, 32);
            this.ExcBut.TabIndex = 5;
            this.ExcBut.Text = "Excluir";
            this.ExcBut.UseVisualStyleBackColor = false;
            this.ExcBut.Click += new System.EventHandler(this.ExcBut_Click);
            // 
            // IdTex
            // 
            this.IdTex.Location = new System.Drawing.Point(33, 160);
            this.IdTex.Name = "IdTex";
            this.IdTex.ReadOnly = true;
            this.IdTex.Size = new System.Drawing.Size(114, 20);
            this.IdTex.TabIndex = 6;
            // 
            // IdcTex
            // 
            this.IdcTex.Location = new System.Drawing.Point(197, 160);
            this.IdcTex.Name = "IdcTex";
            this.IdcTex.Size = new System.Drawing.Size(114, 20);
            this.IdcTex.TabIndex = 6;
            this.IdcTex.Visible = false;
            // 
            // IdpTex
            // 
            this.IdpTex.Location = new System.Drawing.Point(367, 160);
            this.IdpTex.Name = "IdpTex";
            this.IdpTex.Size = new System.Drawing.Size(114, 20);
            this.IdpTex.TabIndex = 6;
            this.IdpTex.Visible = false;
            // 
            // DataPic
            // 
            this.DataPic.Location = new System.Drawing.Point(33, 250);
            this.DataPic.Name = "DataPic";
            this.DataPic.Size = new System.Drawing.Size(140, 20);
            this.DataPic.TabIndex = 7;
            // 
            // QuaTex
            // 
            this.QuaTex.Location = new System.Drawing.Point(197, 250);
            this.QuaTex.Name = "QuaTex";
            this.QuaTex.Size = new System.Drawing.Size(101, 20);
            this.QuaTex.TabIndex = 6;
            this.QuaTex.TextChanged += new System.EventHandler(this.QuaTex_TextChanged);
            // 
            // PreTex
            // 
            this.PreTex.Location = new System.Drawing.Point(324, 250);
            this.PreTex.Name = "PreTex";
            this.PreTex.Size = new System.Drawing.Size(86, 20);
            this.PreTex.TabIndex = 6;
            this.PreTex.TextChanged += new System.EventHandler(this.PreTex_TextChanged);
            // 
            // DesTex
            // 
            this.DesTex.Location = new System.Drawing.Point(431, 250);
            this.DesTex.Name = "DesTex";
            this.DesTex.Size = new System.Drawing.Size(86, 20);
            this.DesTex.TabIndex = 6;
            this.DesTex.TextChanged += new System.EventHandler(this.PreTex_TextChanged);
            // 
            // TotcTex
            // 
            this.TotcTex.Location = new System.Drawing.Point(217, 354);
            this.TotcTex.Name = "TotcTex";
            this.TotcTex.ReadOnly = true;
            this.TotcTex.Size = new System.Drawing.Size(140, 20);
            this.TotcTex.TabIndex = 8;
            // 
            // TotsTex
            // 
            this.TotsTex.Location = new System.Drawing.Point(33, 354);
            this.TotsTex.Name = "TotsTex";
            this.TotsTex.ReadOnly = true;
            this.TotsTex.Size = new System.Drawing.Size(140, 20);
            this.TotsTex.TabIndex = 8;
            // 
            // ProCom
            // 
            this.ProCom.FormattingEnabled = true;
            this.ProCom.Location = new System.Drawing.Point(367, 160);
            this.ProCom.Name = "ProCom";
            this.ProCom.Size = new System.Drawing.Size(121, 21);
            this.ProCom.TabIndex = 9;
            this.ProCom.SelectedIndexChanged += new System.EventHandler(this.ProCom_SelectedIndexChanged);
            // 
            // CliCom
            // 
            this.CliCom.FormattingEnabled = true;
            this.CliCom.Location = new System.Drawing.Point(197, 160);
            this.CliCom.Name = "CliCom";
            this.CliCom.Size = new System.Drawing.Size(114, 21);
            this.CliCom.TabIndex = 9;
            this.CliCom.SelectedIndexChanged += new System.EventHandler(this.CliCom_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1036, 408);
            this.Controls.Add(this.CliCom);
            this.Controls.Add(this.ProCom);
            this.Controls.Add(this.TotsTex);
            this.Controls.Add(this.TotcTex);
            this.Controls.Add(this.DataPic);
            this.Controls.Add(this.DesTex);
            this.Controls.Add(this.PreTex);
            this.Controls.Add(this.QuaTex);
            this.Controls.Add(this.IdpTex);
            this.Controls.Add(this.IdcTex);
            this.Controls.Add(this.IdTex);
            this.Controls.Add(this.ExcBut);
            this.Controls.Add(this.AltBut);
            this.Controls.Add(this.RegBut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SemD);
            this.Controls.Add(this.Des);
            this.Controls.Add(this.Pre);
            this.Controls.Add(this.Quant);
            this.Controls.Add(this.DataCompra);
            this.Controls.Add(this.IDProduto);
            this.Controls.Add(this.IDCliente);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.venda);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label venda;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label IDCliente;
        private System.Windows.Forms.Label IDProduto;
        private System.Windows.Forms.Label DataCompra;
        private System.Windows.Forms.Label Quant;
        private System.Windows.Forms.Label Pre;
        private System.Windows.Forms.Label Des;
        private System.Windows.Forms.Label SemD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RegBut;
        private System.Windows.Forms.Button AltBut;
        private System.Windows.Forms.Button ExcBut;
        private System.Windows.Forms.TextBox IdTex;
        private System.Windows.Forms.TextBox IdcTex;
        private System.Windows.Forms.TextBox IdpTex;
        private System.Windows.Forms.DateTimePicker DataPic;
        private System.Windows.Forms.TextBox QuaTex;
        private System.Windows.Forms.TextBox PreTex;
        private System.Windows.Forms.TextBox DesTex;
        private System.Windows.Forms.TextBox TotcTex;
        private System.Windows.Forms.TextBox TotsTex;
        private System.Windows.Forms.ComboBox ProCom;
        private System.Windows.Forms.ComboBox CliCom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}