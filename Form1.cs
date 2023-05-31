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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmr_load_Tick(object sender, EventArgs e)
        {
            pnl_load.Width += 2;
            if (pnl_load.Width >= 200)
            {
                tmr_load.Stop();
                frm_menu menu = new frm_menu();
                menu.Show();
                this.Hide();

            }
        }
    }
}
