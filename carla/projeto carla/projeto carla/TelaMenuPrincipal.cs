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
    public partial class TelaMenuPrincipal : Form
    {
        System.Drawing.Font fonteEnter = new System.Drawing.Font("Copperplate Gothic Light", 18);
        System.Drawing.Font fonteOver = new System.Drawing.Font("Copperplate Gothic Light", 16);

        public TelaMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogoff_MouseEnter(object sender, EventArgs e)
        {
            
            btnLogoff.Font = fonteEnter;
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogoff_MouseLeave(object sender, EventArgs e)
        {
            btnLogoff.Font = fonteOver;
        }

        private void btnClientes_MouseEnter(object sender, EventArgs e)
        {
            btnClientes.Font = fonteEnter;
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
            btnClientes.Font = fonteOver;
        }

        private void brnUsuarios_MouseEnter(object sender, EventArgs e)
        {
            brnUsuarios.Font = fonteEnter;
        }

        private void brnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            brnUsuarios.Font = fonteOver;
        }

        private void btnCarroECambio_MouseEnter(object sender, EventArgs e)
        {
            btnCarroECambio.Font = fonteEnter;
        }

        private void btnCarroECambio_MouseLeave(object sender, EventArgs e)
        {
            btnCarroECambio.Font = fonteOver;
        }

        private void btnOrçamentoEOS_MouseEnter(object sender, EventArgs e)
        {
            btnOrçamentoEOS.Font = fonteEnter;
        }

        private void btnOrçamentoEOS_MouseLeave(object sender, EventArgs e)
        {
            btnOrçamentoEOS.Font = fonteOver;
        }

        private void btnCompras_MouseEnter(object sender, EventArgs e)
        {
            btnCompras.Font = fonteEnter;
        }

        private void btnCompras_MouseLeave(object sender, EventArgs e)
        {
            btnCompras.Font = fonteOver;
        }

        private void btnEstoque_MouseEnter(object sender, EventArgs e)
        {
            btnEstoque.Font = fonteEnter;
        }

        private void btnEstoque_MouseLeave(object sender, EventArgs e)
        {
            btnEstoque.Font = fonteOver;
        }

        private void brnUsuarios_Click(object sender, EventArgs e)
        {
            TelaUsuarios telaUsuario = new TelaUsuarios();
            this.Hide();
            telaUsuario.ShowDialog();
            this.Show();
        }

    }
}
