namespace Simulador_Patos_POO
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
            this.Anterior = new System.Windows.Forms.Button();
            this.Proximo = new System.Windows.Forms.Button();
            this.display_Pato = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Escolhe_Pato = new System.Windows.Forms.Button();
            this.ImagemPato = new System.Windows.Forms.PictureBox();
            this.hab1 = new System.Windows.Forms.Button();
            this.hab2 = new System.Windows.Forms.Button();
            this.hab3 = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemPato)).BeginInit();
            this.SuspendLayout();
            // 
            // Anterior
            // 
            this.Anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anterior.Location = new System.Drawing.Point(112, 159);
            this.Anterior.Margin = new System.Windows.Forms.Padding(2);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(59, 84);
            this.Anterior.TabIndex = 0;
            this.Anterior.Text = "<";
            this.Anterior.UseVisualStyleBackColor = true;
            this.Anterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // Proximo
            // 
            this.Proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proximo.Location = new System.Drawing.Point(480, 159);
            this.Proximo.Margin = new System.Windows.Forms.Padding(2);
            this.Proximo.Name = "Proximo";
            this.Proximo.Size = new System.Drawing.Size(56, 84);
            this.Proximo.TabIndex = 1;
            this.Proximo.Text = ">";
            this.Proximo.UseVisualStyleBackColor = true;
            this.Proximo.Click += new System.EventHandler(this.Proximo_Click);
            // 
            // display_Pato
            // 
            this.display_Pato.AutoSize = true;
            this.display_Pato.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_Pato.Location = new System.Drawing.Point(273, 60);
            this.display_Pato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.display_Pato.Name = "display_Pato";
            this.display_Pato.Size = new System.Drawing.Size(89, 19);
            this.display_Pato.TabIndex = 5;
            this.display_Pato.Text = "NomePato";
            this.display_Pato.Click += new System.EventHandler(this.display_Pato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escolha seu pato";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Escolhe_Pato
            // 
            this.Escolhe_Pato.Location = new System.Drawing.Point(262, 314);
            this.Escolhe_Pato.Margin = new System.Windows.Forms.Padding(2);
            this.Escolhe_Pato.Name = "Escolhe_Pato";
            this.Escolhe_Pato.Size = new System.Drawing.Size(116, 45);
            this.Escolhe_Pato.TabIndex = 8;
            this.Escolhe_Pato.Text = "Ver Habilidades";
            this.Escolhe_Pato.UseVisualStyleBackColor = true;
            this.Escolhe_Pato.Click += new System.EventHandler(this.Escolhe_Pato_Click);
            // 
            // ImagemPato
            // 
            this.ImagemPato.Location = new System.Drawing.Point(190, 89);
            this.ImagemPato.Margin = new System.Windows.Forms.Padding(2);
            this.ImagemPato.Name = "ImagemPato";
            this.ImagemPato.Size = new System.Drawing.Size(273, 221);
            this.ImagemPato.TabIndex = 9;
            this.ImagemPato.TabStop = false;
            this.ImagemPato.Click += new System.EventHandler(this.ImagemPato_Click);
            // 
            // hab1
            // 
            this.hab1.Location = new System.Drawing.Point(172, 314);
            this.hab1.Margin = new System.Windows.Forms.Padding(2);
            this.hab1.Name = "hab1";
            this.hab1.Size = new System.Drawing.Size(86, 30);
            this.hab1.TabIndex = 10;
            this.hab1.Text = "Skill1";
            this.hab1.UseVisualStyleBackColor = true;
            this.hab1.Visible = false;
            this.hab1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hab2
            // 
            this.hab2.Location = new System.Drawing.Point(278, 314);
            this.hab2.Margin = new System.Windows.Forms.Padding(2);
            this.hab2.Name = "hab2";
            this.hab2.Size = new System.Drawing.Size(88, 30);
            this.hab2.TabIndex = 11;
            this.hab2.Text = "Skill2";
            this.hab2.UseVisualStyleBackColor = true;
            this.hab2.Visible = false;
            this.hab2.Click += new System.EventHandler(this.hab2_Click);
            // 
            // hab3
            // 
            this.hab3.Location = new System.Drawing.Point(387, 314);
            this.hab3.Margin = new System.Windows.Forms.Padding(2);
            this.hab3.Name = "hab3";
            this.hab3.Size = new System.Drawing.Size(88, 30);
            this.hab3.TabIndex = 12;
            this.hab3.Text = "Skill3";
            this.hab3.UseVisualStyleBackColor = true;
            this.hab3.Visible = false;
            this.hab3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(278, 11);
            this.menu.Margin = new System.Windows.Forms.Padding(2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(93, 35);
            this.menu.TabIndex = 13;
            this.menu.Text = "Voltar";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Visible = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 394);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.hab3);
            this.Controls.Add(this.hab2);
            this.Controls.Add(this.hab1);
            this.Controls.Add(this.ImagemPato);
            this.Controls.Add(this.Escolhe_Pato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.display_Pato);
            this.Controls.Add(this.Proximo);
            this.Controls.Add(this.Anterior);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ImagemPato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Anterior;
        private System.Windows.Forms.Button Proximo;
        private System.Windows.Forms.Label display_Pato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Escolhe_Pato;
        private System.Windows.Forms.PictureBox ImagemPato;
        private System.Windows.Forms.Button hab1;
        private System.Windows.Forms.Button hab2;
        private System.Windows.Forms.Button hab3;
        private System.Windows.Forms.Button menu;
    }
}

