using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_carla
{
    class AbreMenu
    {
        private Timer timer = new Timer();
        public PictureBox btnAbre, btnFecha;
        public Button lblMenuPrincipal, fundo, btn1, btn2, btn3, btn4, btn5;

        int larguraMenu = 335;

        public AbreMenu()
        {
            this.timer.Tick += new System.EventHandler(this.eventoTimer);
            timer.Interval = 5;
        }

        public void iniciar()
        {
            this.timer.Start();
        }

        public void aparecerMenu(PictureBox btnAbre, PictureBox btnFecha, Button lblMenuPrincipal, Button fundo,
            Button btn1, Button btn2, Button btn3, Button btn4, Button btn5)
        {
            this.btn1 = btn1;
            this.btn2 = btn2;
            this.btn3 = btn3;
            this.btn4 = btn4;
            this.btn5 = btn5;
            this.btnAbre = btnAbre;
            this.btnFecha = btnFecha;
            this.lblMenuPrincipal = lblMenuPrincipal;
            this.fundo = fundo;
        }

        public void eventoTimer(object Sender, EventArgs e){
            int tamanho = 0;
            if (tamanho != this.larguraMenu)
            {
                tamanho += 5;
                btn1.Height = tamanho;
                btn2.Height = tamanho;
                btn3.Height = tamanho;
                btn4.Height = tamanho;
                btn5.Height = tamanho;
                lblMenuPrincipal.Height = tamanho;
                fundo.Height = tamanho;
                //btnAbre.Height = tamanho;
                //btnFecha.Height = tamanho;
            }
            else
            {
                this.timer.Stop();
            }
        }
    }
}