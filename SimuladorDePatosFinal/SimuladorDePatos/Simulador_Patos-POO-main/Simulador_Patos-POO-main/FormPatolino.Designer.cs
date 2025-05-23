using System.Windows.Forms;

namespace Simulador_Patos_POO
{
    partial class FormPatolino
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
            this.display_Pato = new System.Windows.Forms.Label();
            this.btnFecharTudo = new System.Windows.Forms.Button();
            this.btnShopping = new System.Windows.Forms.Button();
            this.RoupaPatolino = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.PatolinoCalca = new System.Windows.Forms.PictureBox();
            this.NovoPato = new System.Windows.Forms.Button();
            this.Patolino1 = new System.Windows.Forms.PictureBox();
            this.PatolinoSh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PatolinoCalca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Patolino1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatolinoSh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Oi!! Eu sou o patolino";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // display_Pato
            // 
            this.display_Pato.AutoSize = true;
            this.display_Pato.Location = new System.Drawing.Point(85, 190);
            this.display_Pato.Name = "display_Pato";
            this.display_Pato.Size = new System.Drawing.Size(67, 16);
            this.display_Pato.TabIndex = 13;
            this.display_Pato.Text = "Eu posso:";
            // 
            // btnFecharTudo
            // 
            this.btnFecharTudo.Location = new System.Drawing.Point(278, 336);
            this.btnFecharTudo.Name = "btnFecharTudo";
            this.btnFecharTudo.Size = new System.Drawing.Size(163, 23);
            this.btnFecharTudo.TabIndex = 17;
            this.btnFecharTudo.Text = "Sair";
            this.btnFecharTudo.UseVisualStyleBackColor = true;
            this.btnFecharTudo.Click += new System.EventHandler(this.btnFecharTudo_Click);
            // 
            // btnShopping
            // 
            this.btnShopping.Location = new System.Drawing.Point(278, 254);
            this.btnShopping.Name = "btnShopping";
            this.btnShopping.Size = new System.Drawing.Size(163, 23);
            this.btnShopping.TabIndex = 18;
            this.btnShopping.Text = "Ir no Shopping";
            this.btnShopping.UseVisualStyleBackColor = true;
            this.btnShopping.Click += new System.EventHandler(this.btnShopping_Click);
            // 
            // RoupaPatolino
            // 
            this.RoupaPatolino.Location = new System.Drawing.Point(88, 254);
            this.RoupaPatolino.Name = "RoupaPatolino";
            this.RoupaPatolino.Size = new System.Drawing.Size(148, 23);
            this.RoupaPatolino.TabIndex = 19;
            this.RoupaPatolino.Text = "Usar roupa";
            this.RoupaPatolino.UseVisualStyleBackColor = true;
            this.RoupaPatolino.Click += new System.EventHandler(this.RoupaPatolino_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(243, 133);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(7, 16);
            this.lblResultado.TabIndex = 20;
            this.lblResultado.Text = "\r\n";
            // 
            // PatolinoCalca
            // 
            this.PatolinoCalca.Location = new System.Drawing.Point(223, 21);
            this.PatolinoCalca.Name = "PatolinoCalca";
            this.PatolinoCalca.Size = new System.Drawing.Size(299, 218);
            this.PatolinoCalca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PatolinoCalca.TabIndex = 21;
            this.PatolinoCalca.TabStop = false;
            this.PatolinoCalca.Visible = false;
            // 
            // NovoPato
            // 
            this.NovoPato.Location = new System.Drawing.Point(88, 336);
            this.NovoPato.Name = "NovoPato";
            this.NovoPato.Size = new System.Drawing.Size(148, 23);
            this.NovoPato.TabIndex = 22;
            this.NovoPato.Text = "Escolher outro Pato";
            this.NovoPato.UseVisualStyleBackColor = true;
            this.NovoPato.Click += new System.EventHandler(this.NovoPato_Click);
            // 
            // Patolino1
            // 
            this.Patolino1.Location = new System.Drawing.Point(278, 30);
            this.Patolino1.Name = "Patolino1";
            this.Patolino1.Size = new System.Drawing.Size(299, 218);
            this.Patolino1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Patolino1.TabIndex = 23;
            this.Patolino1.TabStop = false;
            // 
            // PatolinoSh
            // 
            this.PatolinoSh.Location = new System.Drawing.Point(489, 153);
            this.PatolinoSh.Name = "PatolinoSh";
            this.PatolinoSh.Size = new System.Drawing.Size(299, 218);
            this.PatolinoSh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PatolinoSh.TabIndex = 24;
            this.PatolinoSh.TabStop = false;
            this.PatolinoSh.Visible = false;
            // 
            // FormPatolino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PatolinoSh);
            this.Controls.Add(this.Patolino1);
            this.Controls.Add(this.NovoPato);
            this.Controls.Add(this.PatolinoCalca);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.RoupaPatolino);
            this.Controls.Add(this.btnShopping);
            this.Controls.Add(this.btnFecharTudo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.display_Pato);
            this.Name = "FormPatolino";
            this.Text = "FormPatolino";
            ((System.ComponentModel.ISupportInitialize)(this.PatolinoCalca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Patolino1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatolinoSh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label display_Pato;
        private System.Windows.Forms.Button btnFecharTudo;
        private System.Windows.Forms.Button btnShopping;
        private System.Windows.Forms.Button RoupaPatolino;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox PatolinoCalca;
        private System.Windows.Forms.Button NovoPato;
        private System.Windows.Forms.PictureBox Patolino1;
        private System.Windows.Forms.PictureBox PatolinoSh;

        public Label ControlClick { get; private set; }
    }
}