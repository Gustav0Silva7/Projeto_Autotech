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
            pnl_servicos.Size = pnl_servicos.MinimumSize;
            pnl_servicos.Location = new Point(0, 100);
        }
        //---------- Sobre a Autotech ----------
        private void lbl_autotech_Click(object sender, EventArgs e)
        {

        }

        private void lbl_autotech_MouseEnter(object sender, EventArgs e)
        {

        }

        private void lbl_autotech_MouseLeave(object sender, EventArgs e)
        {

        }

        // ----------

        // ---------- produtos ----------
        private void btn_produtos_Click(object sender, EventArgs e)
        {
            pnl_produtos.Size = pnl_produtos.MaximumSize;
            pnl_servicos.Size = pnl_servicos.MinimumSize;
            pnl_servicos.Location = new Point(0, 165);
            btn_produtos.Image = Properties.Resources.seta;
            btn_servicos.Image = Properties.Resources.seta_horizontal;

        }
        // ----------

        // ---------- Serviços ----------
        private void btn_servicos_Click_1(object sender, EventArgs e)
        {
            pnl_produtos.Size = pnl_produtos.MinimumSize;
            pnl_servicos.Size = pnl_servicos.MaximumSize;
            pnl_servicos.Location = new Point(0, 100);
            btn_servicos.Image = Properties.Resources.seta;
            btn_produtos.Image = Properties.Resources.seta_horizontal;
        }

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
            Application.Exit();
        }

        private void lbl_sair_MouseEnter(object sender, EventArgs e)
        {
            lbl_sair.ForeColor = Color.FromArgb(85, 112, 181);
        }

        private void lbl_sair_MouseLeave(object sender, EventArgs e)
        {
            lbl_cadastro.ForeColor = Color.FromArgb(23, 24, 26);
        }
    
    }
}
