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
    public partial class TelaUsuarios : Form
    {
        AbreMenu abreMenu = new AbreMenu();

        public TelaUsuarios()
        {
            InitializeComponent();
            abreMenu.aparecerMenu(pcbAbre, pcbFecha, lblMenuPrincipal, button1, this.btnOrçamentoEOS, 
                this.btnCompras, this.btnEstoque, this.btnCarroECambio, this.btnClientes);
        }

        private void timerSlideMenu_Tick(object sender, EventArgs e)
        {

        }

        private void pcbAbre_Click(object sender, EventArgs e)
        {
            this.abreMenu.iniciar();
            this.pcbAbre.Visible = false;
            this.pcbFecha.Visible = true;
            this.btnOrçamentoEOS = abreMenu.btn1;
            this.btnCompras = abreMenu.btn2;
            this.btnEstoque = abreMenu.btn3;
            this.btnCarroECambio = abreMenu.btn4;
            this.btnClientes = abreMenu.btn5;
        }

        private void pcbFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
