﻿namespace apCaminhosMarte
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbMarte = new System.Windows.Forms.TabControl();
            this.tpRotas = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDijkstra = new System.Windows.Forms.RadioButton();
            this.rbRecursao = new System.Windows.Forms.RadioButton();
            this.rbPilha = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCusto = new System.Windows.Forms.RadioButton();
            this.rbTempo = new System.Windows.Forms.RadioButton();
            this.rbDistancia = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvMelhorCaminho = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCaminhos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbDestino = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbOrigem = new System.Windows.Forms.ListBox();
            this.pbMapa = new System.Windows.Forms.PictureBox();
            this.tpArvore = new System.Windows.Forms.TabPage();
            this.pbArvore = new System.Windows.Forms.PictureBox();
            this.tbMarte.SuspendLayout();
            this.tpRotas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMelhorCaminho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).BeginInit();
            this.tpArvore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArvore)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMarte
            // 
            this.tbMarte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMarte.Controls.Add(this.tpRotas);
            this.tbMarte.Controls.Add(this.tpArvore);
            this.tbMarte.Location = new System.Drawing.Point(2, 6);
            this.tbMarte.Name = "tbMarte";
            this.tbMarte.SelectedIndex = 0;
            this.tbMarte.Size = new System.Drawing.Size(1347, 736);
            this.tbMarte.TabIndex = 0;
            // 
            // tpRotas
            // 
            this.tpRotas.Controls.Add(this.groupBox2);
            this.tpRotas.Controls.Add(this.groupBox1);
            this.tpRotas.Controls.Add(this.btnBuscar);
            this.tpRotas.Controls.Add(this.dgvMelhorCaminho);
            this.tpRotas.Controls.Add(this.dgvCaminhos);
            this.tpRotas.Controls.Add(this.label4);
            this.tpRotas.Controls.Add(this.label3);
            this.tpRotas.Controls.Add(this.label2);
            this.tpRotas.Controls.Add(this.lsbDestino);
            this.tpRotas.Controls.Add(this.label1);
            this.tpRotas.Controls.Add(this.lsbOrigem);
            this.tpRotas.Controls.Add(this.pbMapa);
            this.tpRotas.Location = new System.Drawing.Point(4, 22);
            this.tpRotas.Name = "tpRotas";
            this.tpRotas.Padding = new System.Windows.Forms.Padding(3);
            this.tpRotas.Size = new System.Drawing.Size(1339, 710);
            this.tpRotas.TabIndex = 0;
            this.tpRotas.Text = "Rotas entre cidades";
            this.tpRotas.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDijkstra);
            this.groupBox2.Controls.Add(this.rbRecursao);
            this.groupBox2.Controls.Add(this.rbPilha);
            this.groupBox2.Location = new System.Drawing.Point(1144, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 108);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // rbDijkstra
            // 
            this.rbDijkstra.AutoSize = true;
            this.rbDijkstra.Location = new System.Drawing.Point(9, 73);
            this.rbDijkstra.Name = "rbDijkstra";
            this.rbDijkstra.Size = new System.Drawing.Size(60, 17);
            this.rbDijkstra.TabIndex = 14;
            this.rbDijkstra.TabStop = true;
            this.rbDijkstra.Text = "Dijkstra";
            this.rbDijkstra.UseVisualStyleBackColor = true;
            // 
            // rbRecursao
            // 
            this.rbRecursao.AutoSize = true;
            this.rbRecursao.Location = new System.Drawing.Point(10, 46);
            this.rbRecursao.Name = "rbRecursao";
            this.rbRecursao.Size = new System.Drawing.Size(71, 17);
            this.rbRecursao.TabIndex = 13;
            this.rbRecursao.TabStop = true;
            this.rbRecursao.Text = "Recursão";
            this.rbRecursao.UseVisualStyleBackColor = true;
            // 
            // rbPilha
            // 
            this.rbPilha.AutoSize = true;
            this.rbPilha.Location = new System.Drawing.Point(9, 19);
            this.rbPilha.Name = "rbPilha";
            this.rbPilha.Size = new System.Drawing.Size(53, 17);
            this.rbPilha.TabIndex = 12;
            this.rbPilha.TabStop = true;
            this.rbPilha.Text = "Pilhas";
            this.rbPilha.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCusto);
            this.groupBox1.Controls.Add(this.rbTempo);
            this.groupBox1.Controls.Add(this.rbDistancia);
            this.groupBox1.Location = new System.Drawing.Point(1051, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 108);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbCusto
            // 
            this.rbCusto.AutoSize = true;
            this.rbCusto.Location = new System.Drawing.Point(9, 73);
            this.rbCusto.Name = "rbCusto";
            this.rbCusto.Size = new System.Drawing.Size(52, 17);
            this.rbCusto.TabIndex = 14;
            this.rbCusto.TabStop = true;
            this.rbCusto.Text = "Custo";
            this.rbCusto.UseVisualStyleBackColor = true;
            // 
            // rbTempo
            // 
            this.rbTempo.AutoSize = true;
            this.rbTempo.Location = new System.Drawing.Point(10, 46);
            this.rbTempo.Name = "rbTempo";
            this.rbTempo.Size = new System.Drawing.Size(58, 17);
            this.rbTempo.TabIndex = 13;
            this.rbTempo.TabStop = true;
            this.rbTempo.Text = "Tempo";
            this.rbTempo.UseVisualStyleBackColor = true;
            // 
            // rbDistancia
            // 
            this.rbDistancia.AutoSize = true;
            this.rbDistancia.Location = new System.Drawing.Point(9, 19);
            this.rbDistancia.Name = "rbDistancia";
            this.rbDistancia.Size = new System.Drawing.Size(69, 17);
            this.rbDistancia.TabIndex = 12;
            this.rbDistancia.TabStop = true;
            this.rbDistancia.Text = "Distância";
            this.rbDistancia.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.Location = new System.Drawing.Point(1050, 293);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dgvMelhorCaminho
            // 
            this.dgvMelhorCaminho.AllowUserToAddRows = false;
            this.dgvMelhorCaminho.AllowUserToDeleteRows = false;
            this.dgvMelhorCaminho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMelhorCaminho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMelhorCaminho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvMelhorCaminho.Location = new System.Drawing.Point(1050, 497);
            this.dgvMelhorCaminho.Name = "dgvMelhorCaminho";
            this.dgvMelhorCaminho.ReadOnly = true;
            this.dgvMelhorCaminho.RowHeadersVisible = false;
            this.dgvMelhorCaminho.Size = new System.Drawing.Size(277, 71);
            this.dgvMelhorCaminho.TabIndex = 10;
            this.dgvMelhorCaminho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMelhorCaminho_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 75;
            // 
            // dgvCaminhos
            // 
            this.dgvCaminhos.AllowUserToAddRows = false;
            this.dgvCaminhos.AllowUserToDeleteRows = false;
            this.dgvCaminhos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCaminhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaminhos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvCaminhos.Location = new System.Drawing.Point(1053, 335);
            this.dgvCaminhos.Name = "dgvCaminhos";
            this.dgvCaminhos.ReadOnly = true;
            this.dgvCaminhos.RowHeadersVisible = false;
            this.dgvCaminhos.Size = new System.Drawing.Size(271, 143);
            this.dgvCaminhos.TabIndex = 9;
            this.dgvCaminhos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaminhos_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cidade";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 39;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cidade";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 39;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cidade";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 39;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cidade";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 39;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cidade";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 39;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cidade";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 39;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1048, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Melhor caminho";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1050, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caminhos encontrados:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1054, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destino";
            // 
            // lsbDestino
            // 
            this.lsbDestino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lsbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbDestino.FormattingEnabled = true;
            this.lsbDestino.ItemHeight = 16;
            this.lsbDestino.Items.AddRange(new object[] {
            "  0  - Acheron          ",
            "  1  - Arena           ",
            "  2  - Arrakeen       ",
            "  3  - Bakhuysen       ",
            "  4  - Bradbury ",
            "  5  - Burroughs       ",
            "  6  - Cairo",
            "  7  - Dumont",
            "  8  - Echus Overlook",
            "  9  - Esperança",
            " 10 - Gondor          ",
            " 11 - Lakefront         ",
            " 12 - Lowell          ",
            " 13 - Moria         ",
            " 14 - Nicosia          ",
            " 15 - Odessa         ",
            " 16 - Perseverança    ",
            " 17 - Rowan           ",
            " 18 - Senzeni Na       ",
            " 19 - Sheffield        ",
            " 20 - Temperança      ",
            " 21 - Tharsis          ",
            " 22 - Underhill      "});
            this.lsbDestino.Location = new System.Drawing.Point(1056, 105);
            this.lsbDestino.Name = "lsbDestino";
            this.lsbDestino.Size = new System.Drawing.Size(176, 68);
            this.lsbDestino.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1053, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origem";
            // 
            // lsbOrigem
            // 
            this.lsbOrigem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lsbOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbOrigem.FormattingEnabled = true;
            this.lsbOrigem.ItemHeight = 16;
            this.lsbOrigem.Items.AddRange(new object[] {
            "  0  - Acheron          ",
            "  1  - Arena           ",
            "  2  - Arrakeen       ",
            "  3  - Bakhuysen       ",
            "  4  - Bradbury ",
            "  5  - Burroughs       ",
            "  6  - Cairo",
            "  7  - Dumont",
            "  8  - Echus Overlook",
            "  9  - Esperança",
            " 10 - Gondor          ",
            " 11 - Lakefront         ",
            " 12 - Lowell          ",
            " 13 - Moria         ",
            " 14 - Nicosia          ",
            " 15 - Odessa         ",
            " 16 - Perseverança    ",
            " 17 - Rowan           ",
            " 18 - Senzeni Na       ",
            " 19 - Sheffield        ",
            " 20 - Temperança      ",
            " 21 - Tharsis          ",
            " 22 - Underhill      "});
            this.lsbOrigem.Location = new System.Drawing.Point(1053, 18);
            this.lsbOrigem.Name = "lsbOrigem";
            this.lsbOrigem.Size = new System.Drawing.Size(167, 68);
            this.lsbOrigem.TabIndex = 1;
            // 
            // pbMapa
            // 
            this.pbMapa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbMapa.Image = ((System.Drawing.Image)(resources.GetObject("pbMapa.Image")));
            this.pbMapa.Location = new System.Drawing.Point(11, 29);
            this.pbMapa.Name = "pbMapa";
            this.pbMapa.Size = new System.Drawing.Size(1024, 512);
            this.pbMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMapa.TabIndex = 0;
            this.pbMapa.TabStop = false;
            // 
            // tpArvore
            // 
            this.tpArvore.Controls.Add(this.pbArvore);
            this.tpArvore.Location = new System.Drawing.Point(4, 22);
            this.tpArvore.Name = "tpArvore";
            this.tpArvore.Padding = new System.Windows.Forms.Padding(3);
            this.tpArvore.Size = new System.Drawing.Size(1185, 559);
            this.tpArvore.TabIndex = 1;
            this.tpArvore.Text = "Árvore de Cidades";
            this.tpArvore.UseVisualStyleBackColor = true;
            // 
            // pbArvore
            // 
            this.pbArvore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbArvore.Location = new System.Drawing.Point(6, 6);
            this.pbArvore.Name = "pbArvore";
            this.pbArvore.Size = new System.Drawing.Size(1035, 510);
            this.pbArvore.TabIndex = 0;
            this.pbArvore.TabStop = false;
            this.pbArvore.Paint += new System.Windows.Forms.PaintEventHandler(this.pbArvore_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 598);
            this.Controls.Add(this.tbMarte);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Projeto 3 - busca de caminhos entre cidades";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tbMarte.ResumeLayout(false);
            this.tpRotas.ResumeLayout(false);
            this.tpRotas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMelhorCaminho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).EndInit();
            this.tpArvore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbArvore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbMarte;
        private System.Windows.Forms.TabPage tpRotas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDijkstra;
        private System.Windows.Forms.RadioButton rbRecursao;
        private System.Windows.Forms.RadioButton rbPilha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCusto;
        private System.Windows.Forms.RadioButton rbTempo;
        private System.Windows.Forms.RadioButton rbDistancia;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvMelhorCaminho;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView dgvCaminhos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbOrigem;
        private System.Windows.Forms.PictureBox pbMapa;
        private System.Windows.Forms.TabPage tpArvore;
        private System.Windows.Forms.PictureBox pbArvore;
    }
}

