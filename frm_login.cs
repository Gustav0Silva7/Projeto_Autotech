using Projeto_Autotech_2.DAL;
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
    public partial class frm_login : Form
    {
        //oi :)

        private loginDAO login;
        public frm_login()
        {
            InitializeComponent();
        }

        private void entrarSistema()
        {
            string email = txt_email.Text;
            string senha = txt_senha.Text;

            login = new loginDAO();
            bool retorno = login.verificaLogin(email, senha);

            if (retorno)
            {
                MessageBox.Show("Seja bem vindo(a) a Autotech", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SessaoDAO sessao = new SessaoDAO();
                sessao.Email = email;
                sessao.Senha = senha;
                bool sessaoIniciada = sessao.IniciarSessao(email, senha);
                if (sessaoIniciada)
                {

                    string emailSessao = sessao.Email;
                    string senhaSessao = sessao.Senha;

                    frm_logon logon = new frm_logon(sessao);
                    this.Hide();
                    logon.Show();
                }
                else
                {
                    MessageBox.Show("Erro ao iniciar a sessão", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------- Email ----------
        private void txt_email_Enter(object sender, EventArgs e)
        {
            pnl_email.BackColor = Color.FromArgb(23, 24, 26);
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            pnl_email.BackColor = Color.FromArgb(237, 235, 240);
        }
        // ----------

        // ---------- Senha ------------
        private void txt_senha_Enter(object sender, EventArgs e)
        {
            pnl_senha.BackColor = Color.FromArgb(23, 24, 26);
        }

        private void txt_senha_Leave(object sender, EventArgs e)
        {
            pnl_senha.BackColor = Color.FromArgb(237, 235, 240);
        }

        // ----------

        // ---------- CheckBox da Senha -----------
        private void chk_senha_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_senha.Checked)
            {
                chk_senha.Image = Properties.Resources.invisivel;
                txt_senha.PasswordChar = default;
                txt_senha.Font = new Font(txt_senha.Font, FontStyle.Regular);
            }
            else
            {
                chk_senha.Image = Properties.Resources.visivel;
                txt_senha.PasswordChar = '*';
                txt_senha.Font = new Font(txt_senha.Font, FontStyle.Bold);
            }
        }

        // -----------

        // ---------- Voltar para o menu -----------
        private void lbl_voltar_Click(object sender, EventArgs e)
        {
            frm_menu menu = new frm_menu();
            menu.Show();
            this.Hide();
        }

        private void lbl_voltar_MouseEnter(object sender, EventArgs e)
        {
            lbl_voltar.ForeColor = Color.FromArgb(85, 112, 181);
        }

        private void lbl_voltar_MouseLeave(object sender, EventArgs e)
        {
            lbl_voltar.ForeColor = Color.FromArgb(23, 24, 26);
        }
        // -----------

        // ---------- Sair
        private void lbl_sair_Click(object sender, EventArgs e)
        {
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

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            frm_cadastro cadastro = new frm_cadastro();
            cadastro.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_email.TextLength >= 10 && (txt_email.Text.Contains("@gmail.com") || txt_email.Text.Contains("@yahoo.com") || txt_email.Text.Contains("@outlook.com") || txt_email.Text.Contains("uni9.edu.br")) && txt_senha.TextLength >= 5)
            {
                entrarSistema();
            }
            else
            {
                MessageBox.Show("Dados incompletos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
