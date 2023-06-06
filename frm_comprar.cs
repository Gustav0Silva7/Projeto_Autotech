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
    public partial class frm_comprar : Form
    {

        private SessaoDAO sessao;

        public frm_comprar(SessaoDAO sessao)
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

        private void frm_comprar_Load(object sender, EventArgs e)
        {
            iniciarSessao();

            ProdutoDAO produtoDAO = new ProdutoDAO();
            List<ProdutoDAO.Produto> produtos = produtoDAO.ObterProdutos();

            lst_items.Items.Clear();

            lst_items.DisplayMember = "Nome";

            foreach (ProdutoDAO.Produto produto in produtos)
            {
                lst_items.Items.Add(produto);
            }
        }

        private void lst_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_items.SelectedIndex != -1)
            {
                ProdutoDAO.Produto produtoSelecionado = (ProdutoDAO.Produto)lst_items.SelectedItem;


                lbl_id.Text = produtoSelecionado.Id.ToString();
                lbl_nome.Text = produtoSelecionado.Nome;
                lbl_marca.Text = produtoSelecionado.Marca;
                lbl_data.Text = produtoSelecionado.DataProducao.ToShortDateString();
                lbl_garantia.Text = produtoSelecionado.GarantiaAnos.ToString();
                lbl_estoque.Text = produtoSelecionado.Estoque.ToString();
                lbl_preco.Text = produtoSelecionado.Preco.ToString("C");

            }
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            if (lst_items.SelectedIndex != -1)
            {
                ProdutoDAO.Produto produtoSelecionado = (ProdutoDAO.Produto)lst_items.SelectedItem;

                SessaoDAO sessaoDAO = new SessaoDAO();
                sessaoDAO.IniciarSessao(sessao.Email, sessao.Senha); 

                if (sessaoDAO.IdCliente != 0)
                {
                    if(MessageBox.Show("Gostaria de efetuar a sua compra?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PedidoDAO pedidoDAO = new PedidoDAO();
                        pedidoDAO.InserirPedido(produtoSelecionado.Id, produtoSelecionado.Preco, sessaoDAO.IdCliente);
                        MessageBox.Show("Compra efetivada com sucesso?", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lst_items.SelectedIndex = -1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um produto antes de realizar o pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_comprovante_Click(object sender, EventArgs e)
        {
            frm_comprovante comprovante = new frm_comprovante(sessao);
            comprovante.Show();
            this.Hide();
        }

        private void btn_produtos_Click(object sender, EventArgs e)
        {
            pnl_produtos.Size = pnl_produtos.MaximumSize;
            btn_produtos.Image = Properties.Resources.seta;

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
                frm_loja loja = new frm_loja();
                loja.Show();
                this.Hide();
            }
        }

        private void btn_autotech_Click(object sender, EventArgs e)
        {
            frm_atSessao atSessao = new frm_atSessao(sessao);
            atSessao.Show();
            this.Hide();
        }
    }
}
