using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Autotech_2
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
            pnl_produtos.Size = pnl_produtos.MinimumSize;
        }


        // ---------- produtos ----------
        private void btn_produtos_Click(object sender, EventArgs e)
        {
            pnl_produtos.Size = pnl_produtos.MaximumSize;
            btn_produtos.Image = Properties.Resources.seta;


        }
        // ----------

        //---------- Login ----------

        private void lbl_login_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.Show();
            this.Hide();
        }

        private void lbl_login_MouseEnter(object sender, EventArgs e)
        {
            lbl_login.ForeColor = Color.FromArgb(85, 112, 181);
        }

        private void lbl_login_MouseLeave(object sender, EventArgs e)
        {
            lbl_login.ForeColor = Color.FromArgb(23, 24, 26);
        }
        // ----------

        //---------- Cadastro ----------
        private void lbl_cadastro_Click(object sender, EventArgs e)
        {
            frm_cadastro cadastro = new frm_cadastro();
            cadastro.Show();
            this.Hide();
        }

        private void lbl_cadastro_MouseEnter(object sender, EventArgs e)
        {
            lbl_cadastro.ForeColor = Color.FromArgb(85, 112, 181);
        }

        private void lbl_cadastro_MouseLeave(object sender, EventArgs e)
        {
            lbl_cadastro.ForeColor = Color.FromArgb(23, 24, 26);
        }
        // ----------

        // ----------- Sair -----------
        private void lbl_sair_Click(object sender, EventArgs e)
        {
            lbl_sair.ForeColor = Color.FromArgb(23, 24, 26);
            if (MessageBox.Show("Deseja sair do Sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lbl_sair_MouseEnter(object sender, EventArgs e)
        {
            lbl_sair.ForeColor = Color.FromArgb(85, 112, 181);
        }

        private void lbl_sair_MouseLeave(object sender, EventArgs e)
        {
            lbl_sair.ForeColor = Color.FromArgb(23, 24, 26);
        }

        private void btn_comprovante_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Para verificar seu comprovante, é necessário efetuar o login no sistema. Gostaria de efetuar o Login?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frm_login login = new frm_login();
                login.Show();
                this.Hide();
            }
        }

        private void btn_vendas_Click(object sender, EventArgs e)
        {
            frm_loja loja = new frm_loja();
            loja.Show();
            this.Hide();
        }

        private void btn_autotech_Click(object sender, EventArgs e)
        {
            frm_autotech autotech = new frm_autotech();
            autotech.Show();
            this.Hide();
        }
    }
}
