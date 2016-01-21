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
            this.lblMenuPrincipal = abreMenu.lblMenuPrincipal;
            this.button1 = abreMenu.fundo;
        }

        private void pcbFecha_Click(object sender, EventArgs e)
        {
            pcbAbre.Visible = true;
        }

        private void pcbAbre_MouseEnter(object sender, EventArgs e)
        {
            pcbAbre.BackgroundImage = projeto_carla.Properties.Resources.abre_menu_mouse_enter;
        }

        private void pcbAbre_MouseLeave(object sender, EventArgs e)
        {
            pcbAbre.BackgroundImage = projeto_carla.Properties.Resources.abre_menu;
        }

        private void pcbFecha_MouseEnter(object sender, EventArgs e)
        {
            pcbFecha.BackgroundImage = projeto_carla.Properties.Resources.fecha_menu_mouse_enter;
        }

        private void pcbFecha_MouseLeave(object sender, EventArgs e)
        {
            pcbFecha.BackgroundImage = projeto_carla.Properties.Resources.fecha_menu;
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void pcbCriarNovo_MouseEnter(object sender, EventArgs e)
        {
            pcbCriarNovo.BackgroundImage = projeto_carla.Properties.Resources.criar_novo_mouse_enter;
        }

        private void pcbCriarNovo_MouseLeave(object sender, EventArgs e)
        {
            pcbCriarNovo.BackgroundImage = projeto_carla.Properties.Resources.criar_novo;
        }

        private void pcbDeletar_MouseEnter(object sender, EventArgs e)
        {
            pcbDeletar.BackgroundImage = projeto_carla.Properties.Resources.deletar_mouse_enter;
        }

        private void pcbDeletar_MouseLeave(object sender, EventArgs e)
        {
            pcbDeletar.BackgroundImage = projeto_carla.Properties.Resources.deletar;
        }

        private void pcbCriarNovo_Click(object sender, EventArgs e)
        {
            CriarUsuario criarUsuario = new CriarUsuario();
            criarUsuario.ShowDialog();
        }
    }
}
