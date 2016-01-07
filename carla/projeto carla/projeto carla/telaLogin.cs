using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.Net;
using MySql.Data.MySqlClient;

namespace projeto_carla
{
    public partial class telaLogin : Form
    {
        private int numTentativasDeLogin = 1;
        private int numMaximoTentativasLogin = 4;

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
            while(this.numTentativasDeLogin < this.numMaximoTentativasLogin){
                BancoDeDados bancoDeDados = new BancoDeDados();

                String login = Criptografia.getMD5Hash(this.txtUsuario.Text);
                String senha = Criptografia.getMD5Hash(this.txtSenha.Text);
                String resultadoConsulta = "";

                try
                {
                    resultadoConsulta = bancoDeDados.consultarUnicoRegistro("SELECT tipousuario FROM usuario WHERE loginusuario = @login AND senhausuario = @senha;", new MySqlParameter("@login", login), new MySqlParameter("@senha", senha)).ToString();
                }
                catch
                {
                    MessageBox.Show("Por favor, tente novamente. Você tem apenas " + (numMaximoTentativasLogin - numTentativasDeLogin) + " tentativas restantes até que o programa seja fechado.", "Usuário ou senha incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numTentativasDeLogin++;
                    return;
                }

                if (resultadoConsulta.Equals("adm"))
                {
                    TelaMenuPrincipal menuPrincipal = new TelaMenuPrincipal();
                    this.Hide();
                    menuPrincipal.ShowDialog();
                    this.Show();
                    return;
                }
                else
                {
                    TelaMenuPrincipal menuPrincipal = new TelaMenuPrincipal();
                    this.Hide();
                    menuPrincipal.ShowDialog();
                    this.Show();
                    return;
                }
            }
            this.Close();
        }
    }
}
