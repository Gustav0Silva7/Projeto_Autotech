using Projeto_Autotech_2.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projeto_Autotech_2
{
    public partial class frm_cadastro : Form
    {

        private cadastroDAO cadastro;
        public frm_cadastro()
        {
            InitializeComponent();
        }
        private void cadastrarSistema()
        {
            string nome = txt_nome.Text;
            string sobrenome = txt_sobrenome.Text;
            long data_nascimento = DateTime.ParseExact(msk_data.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).Ticks;
            string logradouro = txt_logradouro.Text;
            string estado = cbb_estado.Text;
            string email = txt_email.Text;
            string senha = txt_senha.Text;

            cadastro = new cadastroDAO();
            bool retorno = cadastro.verificaCadastro(nome, sobrenome, data_nascimento, logradouro, estado, email, senha);
            if (retorno)
            {
                MessageBox.Show("Cadastro realizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SessaoDAO sessao = new SessaoDAO();
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
                MessageBox.Show("Não foi possível realizar o cadastro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------- Voltar -----------
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

        // ---------- Sair ----------
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
        // ----------

        // ----------- Cadastrar Usuarios ----------
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_nome.TextLength >= 3 && txt_sobrenome.TextLength >= 5 && msk_data.MaskCompleted && txt_logradouro.TextLength >= 10 && cbb_estado.Text != "Selecione o seu estado" && txt_email.TextLength >= 12 && (txt_email.Text.Contains("@gmail.com") || txt_email.Text.Contains("@yahoo.com") || txt_email.Text.Contains("@outlook.com") || txt_email.Text.Contains("uni9.edu.br")) && txt_senha.TextLength >= 5)
            {
                cadastrarSistema();
            }
            else
            {
                MessageBox.Show("Dados incompletos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_senha_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_senha.Checked)
            {
                chk_senha.Image = Properties.Resources.invisivel;
                txt_senha.PasswordChar = default;
            }
            else
            {
                chk_senha.Image = Properties.Resources.visivel;
                txt_senha.PasswordChar = '*';
            }
        }

        private void txt_nome_Enter(object sender, EventArgs e)
        {
            pnl_nome.BackColor = Color.FromArgb(23, 24, 26);
        }

        private void txt_nome_Leave(object sender, EventArgs e)
        {
            pnl_nome.BackColor = Color.FromArgb(237, 235, 240);
        }

        private void txt_sobrenome_Enter(object sender, EventArgs e)
        {
            pnl_sobrenome.BackColor = Color.FromArgb(23, 24, 26);
        }

        private void txt_sobrenome_Leave(object sender, EventArgs e)
        {
            pnl_sobrenome.BackColor = Color.FromArgb(237, 235, 240);
        }

        private void msk_data_Enter(object sender, EventArgs e)
        {
            pnl_data.BackColor = Color.FromArgb(23, 24, 26);
        }

        private void msk_data_Leave(object sender, EventArgs e)
        {
            pnl_data.BackColor= Color.FromArgb(237, 235, 240);
        }

        private void txt_logradouro_Enter(object sender, EventArgs e)
        {
            pnl_logradouro.BackColor = Color.FromArgb(23, 24, 26);
        }

        private void txt_logradouro_Leave(object sender, EventArgs e)
        {
            pnl_logradouro.BackColor = Color.FromArgb(237, 235, 240);
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            pnl_email.BackColor = Color.FromArgb(23, 24, 26);
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            pnl_email.BackColor = Color.FromArgb(237, 235, 240);
        }

        private void txt_senha_Enter(object sender, EventArgs e)
        {
            pnl_senha.BackColor = Color.FromArgb(23, 24, 26);
        }

        private void txt_senha_Leave(object sender, EventArgs e)
        {
            pnl_senha.BackColor = Color.FromArgb(237, 235, 240);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.Show();
            this.Hide();
        }
    }
}
