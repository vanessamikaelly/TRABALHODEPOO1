namespace Trabalho_Cadastro_de_Livro
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_livro = new System.Windows.Forms.DataGridView();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_sinopse = new System.Windows.Forms.TextBox();
            this.txt_valoraquisicao = new System.Windows.Forms.TextBox();
            this.cb_genero = new System.Windows.Forms.ComboBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.txt_editora = new System.Windows.Forms.TextBox();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_lucro = new System.Windows.Forms.TextBox();
            this.txt_valorvenda = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_livro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Livros";
            // 
            // dataGrid_livro
            // 
            this.dataGrid_livro.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGrid_livro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_livro.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGrid_livro.Location = new System.Drawing.Point(-2, 563);
            this.dataGrid_livro.Name = "dataGrid_livro";
            this.dataGrid_livro.RowHeadersWidth = 51;
            this.dataGrid_livro.RowTemplate.Height = 24;
            this.dataGrid_livro.Size = new System.Drawing.Size(1027, 215);
            this.dataGrid_livro.TabIndex = 1;
          
            // 
            // bt_limpar
            // 
            this.bt_limpar.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpar.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_limpar.Location = new System.Drawing.Point(292, 494);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(110, 47);
            this.bt_limpar.TabIndex = 2;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click_1);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_cadastrar.Location = new System.Drawing.Point(475, 494);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(117, 47);
            this.bt_cadastrar.TabIndex = 3;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(370, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(87, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(190, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Editora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(79, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sinopse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(262, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(585, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ano";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(85, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 28);
            this.label8.TabIndex = 11;
            this.label8.Text = "Gênero";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(421, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 28);
            this.label9.TabIndex = 12;
            this.label9.Text = "Autor(a)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(641, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 28);
            this.label10.TabIndex = 13;
            this.label10.Text = "Preço";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(447, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 28);
            this.label11.TabIndex = 14;
            this.label11.Text = "Lucro %";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_codigo.Location = new System.Drawing.Point(162, 131);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(158, 35);
            this.txt_codigo.TabIndex = 15;
            // 
            // txt_sinopse
            // 
            this.txt_sinopse.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sinopse.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_sinopse.Location = new System.Drawing.Point(163, 189);
            this.txt_sinopse.Name = "txt_sinopse";
            this.txt_sinopse.Size = new System.Drawing.Size(675, 35);
            this.txt_sinopse.TabIndex = 16;
            // 
            // txt_valoraquisicao
            // 
            this.txt_valoraquisicao.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valoraquisicao.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_valoraquisicao.Location = new System.Drawing.Point(227, 425);
            this.txt_valoraquisicao.Name = "txt_valoraquisicao";
            this.txt_valoraquisicao.Size = new System.Drawing.Size(128, 35);
            this.txt_valoraquisicao.TabIndex = 17;
            // 
            // cb_genero
            // 
            this.cb_genero.AutoCompleteCustomSource.AddRange(new string[] {
            "Literatura",
            "Conto",
            "Fabula",
            "Romance",
            "Drama",
            "Suspence",
            "Aventura",
            "Infatil "});
            this.cb_genero.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cb_genero.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_genero.ForeColor = System.Drawing.Color.DarkGreen;
            this.cb_genero.FormattingEnabled = true;
            this.cb_genero.Items.AddRange(new object[] {
            "Suspense",
            "Conto",
            "Romance",
            "Terror",
            "Ficção Cientifica",
            "Biografia e Autobiografia",
            "Religioso",
            "Autoajuda",
            "Aventura"});
            this.cb_genero.Location = new System.Drawing.Point(163, 248);
            this.cb_genero.Name = "cb_genero";
            this.cb_genero.Size = new System.Drawing.Size(239, 36);
            this.cb_genero.TabIndex = 18;
            // 
            // txt_ano
            // 
            this.txt_ano.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ano.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_ano.Location = new System.Drawing.Point(629, 315);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(121, 35);
            this.txt_ano.TabIndex = 19;
            // 
            // txt_editora
            // 
            this.txt_editora.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_editora.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_editora.Location = new System.Drawing.Point(263, 316);
            this.txt_editora.Name = "txt_editora";
            this.txt_editora.Size = new System.Drawing.Size(260, 35);
            this.txt_editora.TabIndex = 20;
            // 
            // txt_autor
            // 
            this.txt_autor.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_autor.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_autor.Location = new System.Drawing.Point(496, 248);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(254, 35);
            this.txt_autor.TabIndex = 21;
            // 
            // txt_titulo
            // 
            this.txt_titulo.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_titulo.Location = new System.Drawing.Point(433, 130);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(405, 35);
            this.txt_titulo.TabIndex = 22;
            // 
            // txt_lucro
            // 
            this.txt_lucro.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lucro.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_lucro.Location = new System.Drawing.Point(418, 424);
            this.txt_lucro.Name = "txt_lucro";
            this.txt_lucro.Size = new System.Drawing.Size(128, 35);
            this.txt_lucro.TabIndex = 23;
            // 
            // txt_valorvenda
            // 
            this.txt_valorvenda.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorvenda.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_valorvenda.Location = new System.Drawing.Point(611, 425);
            this.txt_valorvenda.Name = "txt_valorvenda";
            this.txt_valorvenda.Size = new System.Drawing.Size(128, 35);
            this.txt_valorvenda.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cadastro_de_livros.trabalho__.Properties.Resources._1decbb43_4491_4488_b76e_d2eb219e92c3;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1027, 577);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // bt_excluir
            // 
            this.bt_excluir.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluir.ForeColor = System.Drawing.Color.DarkGreen;
            this.bt_excluir.Location = new System.Drawing.Point(655, 494);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(117, 47);
            this.bt_excluir.TabIndex = 26;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::cadastro_de_livros.trabalho__.Properties.Resources._1decbb43_4491_4488_b76e_d2eb219e92c31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1020, 773);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.txt_valorvenda);
            this.Controls.Add(this.txt_lucro);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.txt_editora);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.cb_genero);
            this.Controls.Add(this.txt_valoraquisicao);
            this.Controls.Add(this.txt_sinopse);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.dataGrid_livro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_livro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid_livro;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_sinopse;
        private System.Windows.Forms.TextBox txt_valoraquisicao;
        private System.Windows.Forms.ComboBox cb_genero;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.TextBox txt_editora;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_lucro;
        private System.Windows.Forms.TextBox txt_valorvenda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_excluir;
    }
}

