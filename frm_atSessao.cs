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
    public partial class frm_atSessao : Form
    {
        private SessaoDAO sessao;
        public frm_atSessao(SessaoDAO sessao)
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

        private void frm_atSessao_Load(object sender, EventArgs e)
        {
            iniciarSessao();
        }

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

        private void btn_produtos_Click(object sender, EventArgs e)
        {
            pnl_produtos.Size = pnl_produtos.MaximumSize;
            btn_produtos.Image = Properties.Resources.seta;
        }
        private void btn_vendas_Click(object sender, EventArgs e)
        {
            frm_comprar comprar = new frm_comprar(sessao);
            comprar.Show();
            this.Hide();
        }
        private void btn_comprovante_Click(object sender, EventArgs e)
        {
            frm_comprovante comprovante = new frm_comprovante(sessao);
            comprovante.Show();
            this.Hide();
        }

        private void btn_conferirDados_Click(object sender, EventArgs e)
        {
            frm_dados dados = new frm_dados(sessao);
            dados.Show();
            this.Hide();
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

    }
}
