using Projeto_Autotech_2.DAL;
using System.Globalization;
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
    public partial class frm_atualizarDados : Form
    {
        private SessaoDAO sessao;
        public frm_atualizarDados(SessaoDAO sessao)
        {
            InitializeComponent();
            this.sessao = sessao;
        }
        private void iniciarSessao()
        {
            string email = sessao.Email;
            string senha = sessao.Senha;
            SessaoDAO sessaoDAO = new SessaoDAO();
            if (sessaoDAO.IniciarSessao(email, senha))
            {
                string nomeCliente = sessao.NomeCliente;
                lbl_usuario.Text = nomeCliente;
            }
        }
        private void encerrarSessao()
        {
            sessao.NomeCliente = null;
            sessao.SobrenomeCliente = null;
            sessao.DataNascimentoCliente = default(DateTime);
            sessao.LogradouroCliente = null;
            sessao.EstadoCliente = null;
            sessao.Email = null;
            sessao.Senha = null;
        }
        private void AtualizarCliente()
        {
            string nome = txt_nome.Text;
            string sobrenome = txt_sobrenome.Text;
            DateTime data_nascimento = DateTime.ParseExact(msk_data.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string logradouro = txt_logradouro.Text;
            string estado = cbb_estado.Text;
            string email = txt_email.Text;
            string senha = txt_senha.Text;

            AtualizacaoDAO atualizacaoDAO = new AtualizacaoDAO();
            bool atualizacaoSucesso = atualizacaoDAO.AtualizarCliente(nome, sobrenome, data_nascimento, logradouro, estado, email, senha);

            if (atualizacaoSucesso)
            {
                MessageBox.Show("Cliente atualizado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_dados dados = new frm_dados(sessao);
                dados.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Não foi possível atualizar o cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frm_atualizarDados_Load(object sender, EventArgs e)
        {
            iniciarSessao();
            if (sessao != null)
            {

                txt_nome.Text = sessao.NomeCliente;
                txt_sobrenome.Text = sessao.SobrenomeCliente;
                msk_data.Text = sessao.DataNascimentoCliente.ToString("dd/MM/yyyy");
                txt_logradouro.Text = sessao.LogradouroCliente;
                cbb_estado.Text = sessao.EstadoCliente;
                txt_email.Text = sessao.Email;
                txt_senha.Text = sessao.Senha;
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            {
                frm_dados dados = new frm_dados(sessao);
                dados.Show();
                this.Hide();
            }
        }

        private void lbl_voltar_Click(object sender, EventArgs e)
        {
            frm_logon logon = new frm_logon(sessao);
            this.Hide();
            logon.Show();
        }
        private void lbl_voltar_MouseEnter(object sender, EventArgs e)
        {
            lbl_voltar.ForeColor = Color.FromArgb(85, 112, 181);
        }

        private void lbl_voltar_MouseLeave(object sender, EventArgs e)
        {
            lbl_voltar.ForeColor = Color.FromArgb(23, 24, 26);
        }

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

        private void btn_logoff_Click(object sender, EventArgs e)
        {
            pnl_usuario.Size = pnl_usuario.MinimumSize;
            if (MessageBox.Show("Deseja realizar o Logoff?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                encerrarSessao();
                frm_menu menu = new frm_menu();
                menu.Show();
                this.Hide();
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == sessao.NomeCliente && txt_sobrenome.Text == sessao.SobrenomeCliente && msk_data.Mask == sessao.DataNascimentoCliente.ToString("dd/MM/yyyy") && txt_logradouro.Text == sessao.LogradouroCliente || cbb_estado.Text != sessao.EstadoCliente && txt_email.Text == sessao.Email && txt_senha.Text == sessao.Senha)
            {
                MessageBox.Show("Não houve atualização nos dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frm_dados dados = new frm_dados(sessao);
                dados.Show();
                this.Hide();
            }
            else
            {
                if (txt_nome.TextLength >= 3 && txt_sobrenome.TextLength >= 5 && msk_data.MaskCompleted && txt_logradouro.TextLength >= 10 && cbb_estado.Text != "Selecione o seu estado" && txt_email.TextLength >= 12 && (txt_email.Text.Contains("@gmail.com") || txt_email.Text.Contains("@yahoo.com") || txt_email.Text.Contains("@outlook.com") || txt_email.Text.Contains("uni9.edu.br")) && txt_senha.TextLength >= 5)
                {
                    AtualizarCliente();
                }
                else
                {
                    MessageBox.Show("Dados incompletos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbl_usuario_Click(object sender, EventArgs e)
        {
            pnl_usuario.Size = pnl_usuario.MaximumSize;
        }
        private void lbl_usuario_MouseEnter(object sender, EventArgs e)
        {
            lbl_usuario.ForeColor = Color.FromArgb(85, 112, 181);
        }

        private void lbl_usuario_MouseLeave(object sender, EventArgs e)
        {
            lbl_usuario.ForeColor = Color.FromArgb(23, 24, 26);
        }

        private void btn_conferirDados_Click(object sender, EventArgs e)
        {
            frm_dados dados = new frm_dados(sessao);
            dados.Show();
            this.Hide();
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
            pnl_data.BackColor = Color.FromArgb(237, 235, 240);
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            pnl_email.BackColor = Color.FromArgb(23, 24, 26);
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            pnl_email.BackColor = Color.FromArgb(237, 235, 240);
        }

        private void txt_logradouro_Enter(object sender, EventArgs e)
        {
            pnl_logradouro.BackColor = Color.FromArgb(23, 24, 26);
        }

        private void txt_logradouro_Leave(object sender, EventArgs e)
        {
            pnl_logradouro.BackColor = Color.FromArgb(237, 235, 240);
        }

        private void txt_senha_Enter(object sender, EventArgs e)
        {
            pnl_senha.BackColor = Color.FromArgb(23, 24, 26);
        }

        private void txt_senha_Leave(object sender, EventArgs e)
        {
            pnl_senha.BackColor = Color.FromArgb(237, 235, 240);
        }
    }
}
