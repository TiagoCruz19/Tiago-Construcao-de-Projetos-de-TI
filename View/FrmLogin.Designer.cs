﻿namespace View
{
    partial class FrmLogin
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(48, 30);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // gpbLogin
            // 
            this.gpbLogin.Controls.Add(this.txbSenha);
            this.gpbLogin.Controls.Add(this.txbUsuario);
            this.gpbLogin.Controls.Add(this.lblUsuario);
            this.gpbLogin.Controls.Add(this.label2);
            this.gpbLogin.Location = new System.Drawing.Point(12, 12);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(266, 138);
            this.gpbLogin.TabIndex = 2;
            this.gpbLogin.TabStop = false;
            this.gpbLogin.Text = "Login";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(51, 46);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(157, 20);
            this.txbUsuario.TabIndex = 2;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(51, 96);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(157, 20);
            this.txbSenha.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(146, 164);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(66, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(218, 164);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 199);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.gpbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancelar;
    }
}