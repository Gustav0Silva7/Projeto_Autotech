
namespace Projeto_Autotech_2
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.lbl_sair = new System.Windows.Forms.Label();
            this.lbl_cadastro = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.pnl_servicos = new System.Windows.Forms.Panel();
            this.btn_descontos = new System.Windows.Forms.Button();
            this.btn_prestacao = new System.Windows.Forms.Button();
            this.btn_servicos = new System.Windows.Forms.Button();
            this.btn_autotech = new System.Windows.Forms.Button();
            this.pnl_produtos = new System.Windows.Forms.Panel();
            this.btn_comprovante = new System.Windows.Forms.Button();
            this.btn_vendas = new System.Windows.Forms.Button();
            this.btn_produtos = new System.Windows.Forms.Button();
            this.flp_produtos = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_menu.SuspendLayout();
            this.pnl_servicos.SuspendLayout();
            this.pnl_produtos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_sair
            // 
            this.lbl_sair.AutoSize = true;
            this.lbl_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_sair.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.lbl_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_sair.Location = new System.Drawing.Point(1297, 23);
            this.lbl_sair.Name = "lbl_sair";
            this.lbl_sair.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_sair.Size = new System.Drawing.Size(42, 19);
            this.lbl_sair.TabIndex = 3;
            this.lbl_sair.Text = "Sair";
            this.lbl_sair.Click += new System.EventHandler(this.lbl_sair_Click);
            this.lbl_sair.MouseEnter += new System.EventHandler(this.lbl_sair_MouseEnter);
            this.lbl_sair.MouseLeave += new System.EventHandler(this.lbl_sair_MouseLeave);
            // 
            // lbl_cadastro
            // 
            this.lbl_cadastro.AutoSize = true;
            this.lbl_cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cadastro.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.lbl_cadastro.Location = new System.Drawing.Point(1207, 23);
            this.lbl_cadastro.Name = "lbl_cadastro";
            this.lbl_cadastro.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_cadastro.Size = new System.Drawing.Size(84, 19);
            this.lbl_cadastro.TabIndex = 3;
            this.lbl_cadastro.Text = "Cadastro";
            this.lbl_cadastro.Click += new System.EventHandler(this.lbl_cadastro_Click);
            this.lbl_cadastro.MouseEnter += new System.EventHandler(this.lbl_cadastro_MouseEnter);
            this.lbl_cadastro.MouseLeave += new System.EventHandler(this.lbl_cadastro_MouseLeave);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_login.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.lbl_login.Location = new System.Drawing.Point(1146, 23);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_login.Size = new System.Drawing.Size(55, 19);
            this.lbl_login.TabIndex = 2;
            this.lbl_login.Text = "Login";
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
            this.lbl_login.MouseEnter += new System.EventHandler(this.lbl_login_MouseEnter);
            this.lbl_login.MouseLeave += new System.EventHandler(this.lbl_login_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(998, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 50);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(178)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.lbl_sair);
            this.panel1.Controls.Add(this.lbl_cadastro);
            this.panel1.Controls.Add(this.lbl_login);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 64);
            this.panel1.TabIndex = 1;
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
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(112)))), ((int)(((byte)(181)))));
            this.pnl_menu.Controls.Add(this.pnl_servicos);
            this.pnl_menu.Controls.Add(this.btn_autotech);
            this.pnl_menu.Controls.Add(this.pnl_produtos);
            this.pnl_menu.Location = new System.Drawing.Point(0, 64);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(176, 686);
            this.pnl_menu.TabIndex = 8;
            // 
            // pnl_servicos
            // 
            this.pnl_servicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(95)))));
            this.pnl_servicos.Controls.Add(this.btn_descontos);
            this.pnl_servicos.Controls.Add(this.btn_prestacao);
            this.pnl_servicos.Controls.Add(this.btn_servicos);
            this.pnl_servicos.Location = new System.Drawing.Point(0, 100);
            this.pnl_servicos.MaximumSize = new System.Drawing.Size(176, 110);
            this.pnl_servicos.MinimumSize = new System.Drawing.Size(176, 45);
            this.pnl_servicos.Name = "pnl_servicos";
            this.pnl_servicos.Size = new System.Drawing.Size(176, 45);
            this.pnl_servicos.TabIndex = 12;
            // 
            // btn_descontos
            // 
            this.btn_descontos.FlatAppearance.BorderSize = 0;
            this.btn_descontos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_descontos.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold);
            this.btn_descontos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btn_descontos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_descontos.Location = new System.Drawing.Point(0, 82);
            this.btn_descontos.Name = "btn_descontos";
            this.btn_descontos.Size = new System.Drawing.Size(176, 25);
            this.btn_descontos.TabIndex = 11;
            this.btn_descontos.Text = "Descontos";
            this.btn_descontos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_descontos.UseVisualStyleBackColor = true;
            // 
            // btn_prestacao
            // 
            this.btn_prestacao.FlatAppearance.BorderSize = 0;
            this.btn_prestacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prestacao.Font = new System.Drawing.Font("Inter", 8F, System.Drawing.FontStyle.Bold);
            this.btn_prestacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btn_prestacao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_prestacao.Location = new System.Drawing.Point(0, 51);
            this.btn_prestacao.Name = "btn_prestacao";
            this.btn_prestacao.Size = new System.Drawing.Size(176, 25);
            this.btn_prestacao.TabIndex = 10;
            this.btn_prestacao.Text = "Prestação de Serviços";
            this.btn_prestacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_prestacao.UseVisualStyleBackColor = true;
            // 
            // btn_servicos
            // 
            this.btn_servicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(112)))), ((int)(((byte)(181)))));
            this.btn_servicos.FlatAppearance.BorderSize = 0;
            this.btn_servicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_servicos.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.btn_servicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btn_servicos.Image = global::Projeto_Autotech_2.Properties.Resources.seta_horizontal;
            this.btn_servicos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_servicos.Location = new System.Drawing.Point(0, 0);
            this.btn_servicos.Name = "btn_servicos";
            this.btn_servicos.Size = new System.Drawing.Size(176, 45);
            this.btn_servicos.TabIndex = 0;
            this.btn_servicos.Text = "Serviços";
            this.btn_servicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_servicos.UseVisualStyleBackColor = false;
            this.btn_servicos.Click += new System.EventHandler(this.btn_servicos_Click_1);
            // 
            // btn_autotech
            // 
            this.btn_autotech.FlatAppearance.BorderSize = 0;
            this.btn_autotech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autotech.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
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
            this.btn_comprovante.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold);
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
            this.btn_vendas.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold);
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
            // btn_produtos
            // 
            this.btn_produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(112)))), ((int)(((byte)(181)))));
            this.btn_produtos.FlatAppearance.BorderSize = 0;
            this.btn_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produtos.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
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
            // flp_produtos
            // 
            this.flp_produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(112)))), ((int)(((byte)(181)))));
            this.flp_produtos.Location = new System.Drawing.Point(261, 64);
            this.flp_produtos.Name = "flp_produtos";
            this.flp_produtos.Size = new System.Drawing.Size(116, 0);
            this.flp_produtos.TabIndex = 0;
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.flp_produtos);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Inter", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_menu.ResumeLayout(false);
            this.pnl_servicos.ResumeLayout(false);
            this.pnl_produtos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_sair;
        private System.Windows.Forms.Label lbl_cadastro;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flp_produtos;
        private System.Windows.Forms.Button btn_produtos;
        private System.Windows.Forms.Button btn_autotech;
        private System.Windows.Forms.Panel pnl_produtos;
        private System.Windows.Forms.Button btn_comprovante;
        private System.Windows.Forms.Button btn_vendas;
        private System.Windows.Forms.Panel pnl_servicos;
        private System.Windows.Forms.Button btn_descontos;
        private System.Windows.Forms.Button btn_prestacao;
        private System.Windows.Forms.Button btn_servicos;
    }
}