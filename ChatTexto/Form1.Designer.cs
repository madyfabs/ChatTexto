namespace ChatTexto
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblIPMeu = new System.Windows.Forms.Label();
            this.txtIPMeu = new System.Windows.Forms.TextBox();
            this.lblPortaMeu = new System.Windows.Forms.Label();
            this.txtPortaMeu = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.lblIPOutro = new System.Windows.Forms.Label();
            this.lblPortaOutro = new System.Windows.Forms.Label();
            this.txtIPOutro = new System.Windows.Forms.TextBox();
            this.txtPortaOutro = new System.Windows.Forms.TextBox();
            this.lstChat = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPortaMeu);
            this.groupBox1.Controls.Add(this.lblPortaMeu);
            this.groupBox1.Controls.Add(this.txtIPMeu);
            this.groupBox1.Controls.Add(this.lblIPMeu);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Minha Conexão";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPortaOutro);
            this.groupBox2.Controls.Add(this.txtIPOutro);
            this.groupBox2.Controls.Add(this.lblPortaOutro);
            this.groupBox2.Controls.Add(this.lblIPOutro);
            this.groupBox2.Location = new System.Drawing.Point(333, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conexão com Amiguinho";
            // 
            // txtEnviar
            // 
            this.txtEnviar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnviar.Location = new System.Drawing.Point(12, 500);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(496, 20);
            this.txtEnviar.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEnviar.Location = new System.Drawing.Point(516, 500);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(106, 24);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblIPMeu
            // 
            this.lblIPMeu.AutoSize = true;
            this.lblIPMeu.Location = new System.Drawing.Point(27, 31);
            this.lblIPMeu.Name = "lblIPMeu";
            this.lblIPMeu.Size = new System.Drawing.Size(20, 13);
            this.lblIPMeu.TabIndex = 0;
            this.lblIPMeu.Text = "IP:";
            // 
            // txtIPMeu
            // 
            this.txtIPMeu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIPMeu.Location = new System.Drawing.Point(76, 28);
            this.txtIPMeu.Name = "txtIPMeu";
            this.txtIPMeu.Size = new System.Drawing.Size(201, 20);
            this.txtIPMeu.TabIndex = 1;
            // 
            // lblPortaMeu
            // 
            this.lblPortaMeu.AutoSize = true;
            this.lblPortaMeu.Location = new System.Drawing.Point(27, 66);
            this.lblPortaMeu.Name = "lblPortaMeu";
            this.lblPortaMeu.Size = new System.Drawing.Size(35, 13);
            this.lblPortaMeu.TabIndex = 2;
            this.lblPortaMeu.Text = "Porta:";
            // 
            // txtPortaMeu
            // 
            this.txtPortaMeu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPortaMeu.Location = new System.Drawing.Point(76, 58);
            this.txtPortaMeu.Name = "txtPortaMeu";
            this.txtPortaMeu.Size = new System.Drawing.Size(201, 20);
            this.txtPortaMeu.TabIndex = 3;
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(223, 140);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(195, 37);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lblIPOutro
            // 
            this.lblIPOutro.AutoSize = true;
            this.lblIPOutro.Location = new System.Drawing.Point(22, 31);
            this.lblIPOutro.Name = "lblIPOutro";
            this.lblIPOutro.Size = new System.Drawing.Size(20, 13);
            this.lblIPOutro.TabIndex = 0;
            this.lblIPOutro.Text = "IP:";
            // 
            // lblPortaOutro
            // 
            this.lblPortaOutro.AutoSize = true;
            this.lblPortaOutro.Location = new System.Drawing.Point(22, 66);
            this.lblPortaOutro.Name = "lblPortaOutro";
            this.lblPortaOutro.Size = new System.Drawing.Size(35, 13);
            this.lblPortaOutro.TabIndex = 1;
            this.lblPortaOutro.Text = "Porta:";
            // 
            // txtIPOutro
            // 
            this.txtIPOutro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIPOutro.Location = new System.Drawing.Point(75, 31);
            this.txtIPOutro.Name = "txtIPOutro";
            this.txtIPOutro.Size = new System.Drawing.Size(196, 20);
            this.txtIPOutro.TabIndex = 2;
            // 
            // txtPortaOutro
            // 
            this.txtPortaOutro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPortaOutro.Location = new System.Drawing.Point(75, 59);
            this.txtPortaOutro.Name = "txtPortaOutro";
            this.txtPortaOutro.Size = new System.Drawing.Size(196, 20);
            this.txtPortaOutro.TabIndex = 3;
            // 
            // lstChat
            // 
            this.lstChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstChat.FormattingEnabled = true;
            this.lstChat.Location = new System.Drawing.Point(13, 183);
            this.lstChat.Name = "lstChat";
            this.lstChat.Size = new System.Drawing.Size(609, 314);
            this.lstChat.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 536);
            this.Controls.Add(this.lstChat);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MSN de Pobre";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtIPMeu;
        private System.Windows.Forms.Label lblIPMeu;
        private System.Windows.Forms.TextBox txtPortaMeu;
        private System.Windows.Forms.Label lblPortaMeu;
        private System.Windows.Forms.TextBox txtPortaOutro;
        private System.Windows.Forms.TextBox txtIPOutro;
        private System.Windows.Forms.Label lblPortaOutro;
        private System.Windows.Forms.Label lblIPOutro;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ListBox lstChat;
    }
}

