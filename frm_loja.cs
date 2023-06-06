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
    public partial class frm_loja : Form
    {
        public frm_loja()
        {
            InitializeComponent();
        }



        private void frm_loja_Load(object sender, EventArgs e)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            List<ProdutoDAO.Produto> produtos = produtoDAO.ObterProdutos();

            lst_items.Items.Clear();

            lst_items.DisplayMember = "Nome";

            foreach (ProdutoDAO.Produto produto in produtos)
            {
                lst_items.Items.Add(produto);
            }
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
                if (MessageBox.Show("Para efetuar a compra, é necessário iniciar uma sessão no sistema. Gostaria de realizar o Login?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frm_login login = new frm_login();
                    login.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Selecione um item da Lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void btn_comprovante_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Para verificar seu comprovante, é necessário efetuar o login no sistema. Gostaria de efetuar o Login?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frm_login login = new frm_login();
                login.Show();
                this.Hide();
            }
        }

        private void btn_produtos_Click(object sender, EventArgs e)
        {
            pnl_produtos.Size = pnl_produtos.MaximumSize;
            btn_produtos.Image = Properties.Resources.seta;

        }
    }
}
