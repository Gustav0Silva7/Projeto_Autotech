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
    public partial class frm_dados : Form
    {
        private SessaoDAO sessao;

        public frm_dados(SessaoDAO sessao)
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
        private void deletarDados()
        {
            string emailCliente = txt_email.Text;
            deleteDAO delete = new deleteDAO();

            bool exclusaoSucesso = delete.DeletarCliente(emailCliente);

            if (exclusaoSucesso)
            {
                MessageBox.Show("Cliente excluído com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                encerrarSessao();
                frm_menu menu = new frm_menu();
                menu.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Não foi possível excluir o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frm_dados_Load(object sender, EventArgs e)
        {
            iniciarSessao();
            if (sessao != null)
            {

                txt_nome.Text = sessao.NomeCliente;
                txt_sobrenome.Text = sessao.SobrenomeCliente;
                msk_data.Text = sessao.DataNascimentoCliente.ToString("dd/MM/yyyy");
                txt_logradouro.Text = sessao.LogradouroCliente;
                txt_estado.Text = sessao.EstadoCliente;
                txt_email.Text = sessao.Email;
                txt_senha.Text = sessao.Senha;
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

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            frm_atualizarDados atualizarDados = new frm_atualizarDados(sessao);
            atualizarDados.Show();
            this.Hide();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que gostaria de apagar seus dados?","Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                deletarDados();
            }
        }
    }
}
