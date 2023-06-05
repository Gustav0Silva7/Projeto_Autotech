
namespace Projeto_Autotech_2
{
    partial class frm_logon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_logon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_sair = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_autotech = new System.Windows.Forms.Button();
            this.pnl_produtos = new System.Windows.Forms.Panel();
            this.btn_comprovante = new System.Windows.Forms.Button();
            this.btn_vendas = new System.Windows.Forms.Button();
            this.pnl_usuario = new System.Windows.Forms.Panel();
            this.btn_logoff = new System.Windows.Forms.Button();
            this.btn_conferirDados = new System.Windows.Forms.Button();
            this.btn_produtos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.pnl_produtos.SuspendLayout();
            this.pnl_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(178)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.lbl_sair);
            this.panel1.Controls.Add(this.lbl_usuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_login);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 64);
            this.panel1.TabIndex = 2;
            // 
            // lbl_sair
            // 
            this.lbl_sair.AutoSize = true;
            this.lbl_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.lbl_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_sair.Location = new System.Drawing.Point(1298, 22);
            this.lbl_sair.Name = "lbl_sair";
            this.lbl_sair.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_sair.Size = new System.Drawing.Size(44, 20);
            this.lbl_sair.TabIndex = 3;
            this.lbl_sair.Text = "Sair";
            this.lbl_sair.Click += new System.EventHandler(this.lbl_sair_Click);
            this.lbl_sair.MouseEnter += new System.EventHandler(this.lbl_sair_MouseEnter);
            this.lbl_sair.MouseLeave += new System.EventHandler(this.lbl_sair_MouseLeave);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.lbl_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_usuario.Location = new System.Drawing.Point(1168, 22);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_usuario.Size = new System.Drawing.Size(74, 20);
            this.lbl_usuario.TabIndex = 10;
            this.lbl_usuario.Text = "Usuário";
            this.lbl_usuario.Click += new System.EventHandler(this.lbl_usuario_Click);
            this.lbl_usuario.MouseEnter += new System.EventHandler(this.lbl_usuario_MouseEnter);
            this.lbl_usuario.MouseLeave += new System.EventHandler(this.lbl_usuario_MouseLeave);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.lbl_login.Location = new System.Drawing.Point(1000, 22);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_login.Size = new System.Drawing.Size(162, 20);
            this.lbl_login.TabIndex = 2;
            this.lbl_login.Text = "Seja Bem Vindo(a)";
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(112)))), ((int)(((byte)(181)))));
            this.pnl_menu.Controls.Add(this.btn_autotech);
            this.pnl_menu.Controls.Add(this.pnl_produtos);
            this.pnl_menu.Location = new System.Drawing.Point(0, 64);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(176, 686);
            this.pnl_menu.TabIndex = 9;
            // 
            // btn_autotech
            // 
            this.btn_autotech.FlatAppearance.BorderSize = 0;
            this.btn_autotech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autotech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_autotech.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btn_autotech.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_autotech.Location = new System.Drawing.Point(0, 10);
            this.btn_autotech.Name = "btn_autotech";
            this.btn_autotech.Size = new System.Drawing.Size(173, 45);
            this.btn_autotech.TabIndex = 1;
            this.btn_autotech.Text = "Autotech";
            this.btn_autotech.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_autotech.UseVisualStyleBackColor = true;
            // 
            // pnl_produtos
            // 
            this.pnl_produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(95)))));
            this.pnl_produtos.Controls.Add(this.btn_comprovante);
            this.pnl_produtos.Controls.Add(this.btn_vendas);
            this.pnl_produtos.Controls.Add(this.btn_produtos);
            this.pnl_produtos.Location = new System.Drawing.Point(0, 54);
            this.pnl_produtos.MaximumSize = new System.Drawing.Size(176, 110);
            this.pnl_produtos.MinimumSize = new System.Drawing.Size(176, 45);
            this.pnl_produtos.Name = "pnl_produtos";
            this.pnl_produtos.Size = new System.Drawing.Size(176, 45);
            this.pnl_produtos.TabIndex = 9;
            // 
            // btn_comprovante
            // 
            this.btn_comprovante.FlatAppearance.BorderSize = 0;
            this.btn_comprovante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprovante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_comprovante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btn_comprovante.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_comprovante.Location = new System.Drawing.Point(0, 80);
            this.btn_comprovante.Name = "btn_comprovante";
            this.btn_comprovante.Size = new System.Drawing.Size(176, 25);
            this.btn_comprovante.TabIndex = 11;
            this.btn_comprovante.Text = "Comprovante";
            this.btn_comprovante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_comprovante.UseVisualStyleBackColor = true;
            // 
            // btn_vendas
            // 
            this.btn_vendas.FlatAppearance.BorderSize = 0;
            this.btn_vendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_vendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btn_vendas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_vendas.Location = new System.Drawing.Point(0, 51);
            this.btn_vendas.Name = "btn_vendas";
            this.btn_vendas.Size = new System.Drawing.Size(176, 25);
            this.btn_vendas.TabIndex = 10;
            this.btn_vendas.Text = "Venda de produtos";
            this.btn_vendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_vendas.UseVisualStyleBackColor = true;
            // 
            // pnl_usuario
            // 
            this.pnl_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(95)))));
            this.pnl_usuario.Controls.Add(this.btn_logoff);
            this.pnl_usuario.Controls.Add(this.btn_conferirDados);
            this.pnl_usuario.Location = new System.Drawing.Point(1172, 64);
            this.pnl_usuario.MaximumSize = new System.Drawing.Size(176, 55);
            this.pnl_usuario.MinimumSize = new System.Drawing.Size(176, 0);
            this.pnl_usuario.Name = "pnl_usuario";
            this.pnl_usuario.Size = new System.Drawing.Size(176, 0);
            this.pnl_usuario.TabIndex = 12;
            // 
            // btn_logoff
            // 
            this.btn_logoff.FlatAppearance.BorderSize = 0;
            this.btn_logoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_logoff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btn_logoff.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logoff.Location = new System.Drawing.Point(0, 29);
            this.btn_logoff.Name = "btn_logoff";
            this.btn_logoff.Size = new System.Drawing.Size(176, 25);
            this.btn_logoff.TabIndex = 11;
            this.btn_logoff.Text = "Logoff";
            this.btn_logoff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logoff.UseVisualStyleBackColor = true;
            this.btn_logoff.Click += new System.EventHandler(this.btn_logoff_Click);
            // 
            // btn_conferirDados
            // 
            this.btn_conferirDados.FlatAppearance.BorderSize = 0;
            this.btn_conferirDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conferirDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_conferirDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btn_conferirDados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_conferirDados.Location = new System.Drawing.Point(0, 0);
            this.btn_conferirDados.Name = "btn_conferirDados";
            this.btn_conferirDados.Size = new System.Drawing.Size(176, 25);
            this.btn_conferirDados.TabIndex = 10;
            this.btn_conferirDados.Text = "Conferir Dados";
            this.btn_conferirDados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_conferirDados.UseVisualStyleBackColor = true;
            this.btn_conferirDados.Click += new System.EventHandler(this.btn_conferirDados_Click);
            // 
            // btn_produtos
            // 
            this.btn_produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(112)))), ((int)(((byte)(181)))));
            this.btn_produtos.FlatAppearance.BorderSize = 0;
            this.btn_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_produtos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btn_produtos.Image = global::Projeto_Autotech_2.Properties.Resources.seta_horizontal;
            this.btn_produtos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_produtos.Location = new System.Drawing.Point(0, 0);
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Size = new System.Drawing.Size(176, 45);
            this.btn_produtos.TabIndex = 0;
            this.btn_produtos.Text = "Produtos";
            this.btn_produtos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_produtos.UseVisualStyleBackColor = false;
            this.btn_produtos.Click += new System.EventHandler(this.btn_produtos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Projeto_Autotech_2.Properties.Resources.autotech_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pnl_usuario);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_logon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_logon";
            this.Load += new System.EventHandler(this.frm_logon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_menu.ResumeLayout(false);
            this.pnl_produtos.ResumeLayout(false);
            this.pnl_usuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_sair;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Button btn_autotech;
        private System.Windows.Forms.Panel pnl_produtos;
        private System.Windows.Forms.Button btn_comprovante;
        private System.Windows.Forms.Button btn_vendas;
        private System.Windows.Forms.Button btn_produtos;
        private System.Windows.Forms.Panel pnl_usuario;
        private System.Windows.Forms.Button btn_logoff;
        private System.Windows.Forms.Button btn_conferirDados;
    }
}