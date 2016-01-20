﻿using System;
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
            Cliente cliente = new Cliente();
            cliente.bairro = "A";
            cliente.cep = "A";
            cliente.cidade = "A";
            cliente.complemento = "A";
            cliente.cpf = "A";
            cliente.preencherDataCriacaoComDataDeHoje();
            cliente.email = "A";
            cliente.endereco = "A";
            cliente.logradouro = "A";
            cliente.nome = "A";
            cliente.numero = "A";
            cliente.tel1 = "A";
            cliente.tel2 = "A";
            cliente.tel3 = "A";
            cliente.tel4 = "A";
            cliente.uf = "A";

            cliente.cadastrar();
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
    }
}
