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
    public partial class CriarUsuario : Form
    {
        public CriarUsuario()
        {
            InitializeComponent();
        }

        private void lblTipoUsuario_Click(object sender, EventArgs e)
        {

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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //testa campos vazios
            if(txtLogin.Text == "" || txtSenha.Text == "" || txtNome.Text == "" || txtPerguntaSecreta.Text == "" || 
                txtRespostaSecreta.Text == "" || cmbTipoUsuario.SelectedItem == null)
            {
                MessageBox.Show("Algum dos campos está vazio.\nVerifique e tente novamente.");
            }

            //comparar senhas
            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("Senhas incompatíveis! \nTente Novamente.");
                txtSenha.Text = "";
                txtConfirmarSenha.Text = "";
            }

            //testar tamanho da senha
            if (txtSenha.Text.Length > 20) 
            {
                MessageBox.Show("Senhas maiores que 20 caracteres não são aceitas");
                txtSenha.Text = "";
                txtConfirmarSenha.Text = "";
            }
        }
    }
}
