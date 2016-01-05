namespace projeto_carla
{
    partial class TelaUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pcbAbre = new System.Windows.Forms.PictureBox();
            this.lblMenuPrincipal = new System.Windows.Forms.Button();
            this.btnOrçamentoEOS = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnCarroECambio = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pcbFecha = new System.Windows.Forms.PictureBox();
            this.timerSlideMenu = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAbre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbAbre
            // 
            this.pcbAbre.BackColor = System.Drawing.Color.Transparent;
            this.pcbAbre.BackgroundImage = global::projeto_carla.Properties.Resources.abrir_menu;
            this.pcbAbre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbAbre.Location = new System.Drawing.Point(29, 25);
            this.pcbAbre.Name = "pcbAbre";
            this.pcbAbre.Size = new System.Drawing.Size(65, 65);
            this.pcbAbre.TabIndex = 0;
            this.pcbAbre.TabStop = false;
            this.pcbAbre.Click += new System.EventHandler(this.pcbAbre_Click);
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuPrincipal.BackgroundImage = global::projeto_carla.Properties.Resources.fundo_translucido;
            this.lblMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblMenuPrincipal.FlatAppearance.BorderSize = 0;
            this.lblMenuPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lblMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Copperplate Gothic Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.ForeColor = System.Drawing.Color.Black;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(-1, 2);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(1, 143);
            this.lblMenuPrincipal.TabIndex = 34;
            this.lblMenuPrincipal.Text = "Menu Principal";
            this.lblMenuPrincipal.UseVisualStyleBackColor = false;
            this.lblMenuPrincipal.Visible = false;
            // 
            // btnOrçamentoEOS
            // 
            this.btnOrçamentoEOS.BackColor = System.Drawing.Color.Transparent;
            this.btnOrçamentoEOS.BackgroundImage = global::projeto_carla.Properties.Resources.fundo_botão;
            this.btnOrçamentoEOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrçamentoEOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrçamentoEOS.FlatAppearance.BorderSize = 0;
            this.btnOrçamentoEOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnOrçamentoEOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrçamentoEOS.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrçamentoEOS.ForeColor = System.Drawing.Color.White;
            this.btnOrçamentoEOS.Location = new System.Drawing.Point(-1, 317);
            this.btnOrçamentoEOS.Name = "btnOrçamentoEOS";
            this.btnOrçamentoEOS.Size = new System.Drawing.Size(1, 87);
            this.btnOrçamentoEOS.TabIndex = 40;
            this.btnOrçamentoEOS.Text = "Orçamentos e OS";
            this.btnOrçamentoEOS.UseVisualStyleBackColor = false;
            this.btnOrçamentoEOS.Visible = false;
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.Transparent;
            this.btnCompras.BackgroundImage = global::projeto_carla.Properties.Resources.fundo_botão;
            this.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Location = new System.Drawing.Point(-1, 401);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(1, 87);
            this.btnCompras.TabIndex = 39;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Visible = false;
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.Transparent;
            this.btnEstoque.BackgroundImage = global::projeto_carla.Properties.Resources.fundo_botão;
            this.btnEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Location = new System.Drawing.Point(-1, 485);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(1, 87);
            this.btnEstoque.TabIndex = 38;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Visible = false;
            // 
            // btnCarroECambio
            // 
            this.btnCarroECambio.BackColor = System.Drawing.Color.Transparent;
            this.btnCarroECambio.BackgroundImage = global::projeto_carla.Properties.Resources.fundo_botão;
            this.btnCarroECambio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarroECambio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarroECambio.FlatAppearance.BorderSize = 0;
            this.btnCarroECambio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCarroECambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarroECambio.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarroECambio.ForeColor = System.Drawing.Color.White;
            this.btnCarroECambio.Location = new System.Drawing.Point(-1, 234);
            this.btnCarroECambio.Name = "btnCarroECambio";
            this.btnCarroECambio.Size = new System.Drawing.Size(1, 87);
            this.btnCarroECambio.TabIndex = 37;
            this.btnCarroECambio.Text = "Carros e Câmbios";
            this.btnCarroECambio.UseVisualStyleBackColor = false;
            this.btnCarroECambio.Visible = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackgroundImage = global::projeto_carla.Properties.Resources.fundo_botão;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(-1, 151);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(1, 87);
            this.btnClientes.TabIndex = 35;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::projeto_carla.Properties.Resources.fundo_translucido;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-1, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1, 734);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // pcbFecha
            // 
            this.pcbFecha.BackColor = System.Drawing.Color.Transparent;
            this.pcbFecha.BackgroundImage = global::projeto_carla.Properties.Resources.fechar_menu;
            this.pcbFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbFecha.Image = global::projeto_carla.Properties.Resources.fechar_menu;
            this.pcbFecha.Location = new System.Drawing.Point(360, 25);
            this.pcbFecha.Name = "pcbFecha";
            this.pcbFecha.Size = new System.Drawing.Size(65, 65);
            this.pcbFecha.TabIndex = 41;
            this.pcbFecha.TabStop = false;
            this.pcbFecha.Visible = false;
            this.pcbFecha.Click += new System.EventHandler(this.pcbFecha_Click);
            // 
            // timerSlideMenu
            // 
            this.timerSlideMenu.Tick += new System.EventHandler(this.timerSlideMenu_Tick);
            // 
            // TelaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto_carla.Properties.Resources.papel_de_parede_triangulos_aqua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 692);
            this.Controls.Add(this.pcbFecha);
            this.Controls.Add(this.pcbAbre);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Controls.Add(this.btnOrçamentoEOS);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnCarroECambio);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "TelaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcbAbre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFecha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbAbre;
        private System.Windows.Forms.Button lblMenuPrincipal;
        private System.Windows.Forms.Button btnOrçamentoEOS;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnCarroECambio;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pcbFecha;
        private System.Windows.Forms.Timer timerSlideMenu;
    }
}