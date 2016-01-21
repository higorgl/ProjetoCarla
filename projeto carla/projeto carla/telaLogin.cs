using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_carla
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEsqueciMinhaSenha_Click(object sender, EventArgs e)
        {
            telaEsqueciMinhaSenha esqueciMinhaSenha = new telaEsqueciMinhaSenha();
            this.Hide();
            esqueciMinhaSenha.ShowDialog();
            this.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            TelaMenuPrincipal menuPrincipal = new TelaMenuPrincipal();
            this.Hide();
            menuPrincipal.ShowDialog();
            this.Show();
        }

        private void pcbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbFechar_MouseEnter(object sender, EventArgs e)
        {
            pcbFechar.BackgroundImage = projeto_carla.Properties.Resources.fechar_mouse_enter;
        }

        private void pcbFechar_MouseLeave(object sender, EventArgs e)
        {
            pcbFechar.BackgroundImage = projeto_carla.Properties.Resources.fechar;
        }
    }
}
