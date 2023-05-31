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
    public partial class frm_cadastro : Form
    {

        private cadastroDAO cadastro;
        public frm_cadastro()
        {
            InitializeComponent();
        }
        private void cadastrarSistema()
        {
            int id_cliente = int.Parse(txt_id.Text);
            string nome = txt_nome.Text;
            string sobrenome = txt_sobrenome.Text;
            string data_nascimento = msk_data.Mask;
            string logradouro = txt_logradouro.Text;
            string estado = cbb_estado.Text;
            string email = txt_email.Text;
            string senha = txt_senha.Text;

            cadastro = new cadastroDAO();
            bool retorno = cadastro.verificaCadastro(id_cliente, nome, sobrenome, data_nascimento, logradouro, estado, email, senha);
            if (retorno)
            {
                MessageBox.Show("Cadastro realizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_menu menu = new frm_menu();
                this.Hide();
                menu.Show();
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

        }

        private void lbl_voltar_MouseLeave(object sender, EventArgs e)
        {

        }

        // -----------

        // ---------- Sair ----------
        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_sair_MouseEnter(object sender, EventArgs e)
        {

        }

        private void lbl_sair_MouseLeave(object sender, EventArgs e)
        {

        }
        // ----------

        // ----------- Cadastrar Usuarios ----------
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_nome.TextLength >= 3 && txt_sobrenome.TextLength >= 5 && msk_data.MaskCompleted && txt_logradouro.TextLength >= 10 && cbb_estado.Text != "Selecione o seu estado" && txt_email.TextLength >= 10 && (txt_email.Text.Contains("@gmail.com") || (txt_email.Text.Contains("@yahoo.com") || (txt_email.Text.Contains("@outlook.com") || (txt_email.Text.Contains("uni9.edu.br")) && txt_senha.TextLength >= 5))))
            {
                cadastrarSistema();
            }
        }

    }
}
