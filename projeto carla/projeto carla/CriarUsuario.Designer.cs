namespace projeto_carla
{
    partial class CriarUsuario
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblPerguntaSecreta = new System.Windows.Forms.Label();
            this.txtPerguntaSecreta = new System.Windows.Forms.TextBox();
            this.lblRespostaSecreta = new System.Windows.Forms.Label();
            this.txtRespostaSecreta = new System.Windows.Forms.TextBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.pcbFechar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(326, 423);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(147, 54);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(60, 108);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(75, 22);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.Silver;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(156, 107);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(558, 28);
            this.txtLogin.TabIndex = 6;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(392, 166);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(81, 22);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Silver;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(513, 165);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(201, 28);
            this.txtSenha.TabIndex = 9;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.ForeColor = System.Drawing.Color.White;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(371, 214);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(131, 44);
            this.lblConfirmarSenha.TabIndex = 12;
            this.lblConfirmarSenha.Text = "Confirmar\r\n     Senha";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.BackColor = System.Drawing.Color.Silver;
            this.txtConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.Location = new System.Drawing.Point(513, 224);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '•';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(201, 28);
            this.txtConfirmarSenha.TabIndex = 11;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(60, 166);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(73, 22);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Silver;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(156, 165);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(183, 28);
            this.txtNome.TabIndex = 13;
            // 
            // lblPerguntaSecreta
            // 
            this.lblPerguntaSecreta.AutoSize = true;
            this.lblPerguntaSecreta.BackColor = System.Drawing.Color.Transparent;
            this.lblPerguntaSecreta.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerguntaSecreta.ForeColor = System.Drawing.Color.White;
            this.lblPerguntaSecreta.Location = new System.Drawing.Point(59, 317);
            this.lblPerguntaSecreta.Name = "lblPerguntaSecreta";
            this.lblPerguntaSecreta.Size = new System.Drawing.Size(220, 22);
            this.lblPerguntaSecreta.TabIndex = 16;
            this.lblPerguntaSecreta.Text = "Pergunta Secreta";
            // 
            // txtPerguntaSecreta
            // 
            this.txtPerguntaSecreta.BackColor = System.Drawing.Color.Silver;
            this.txtPerguntaSecreta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPerguntaSecreta.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerguntaSecreta.Location = new System.Drawing.Point(293, 317);
            this.txtPerguntaSecreta.Name = "txtPerguntaSecreta";
            this.txtPerguntaSecreta.Size = new System.Drawing.Size(421, 28);
            this.txtPerguntaSecreta.TabIndex = 15;
            // 
            // lblRespostaSecreta
            // 
            this.lblRespostaSecreta.AutoSize = true;
            this.lblRespostaSecreta.BackColor = System.Drawing.Color.Transparent;
            this.lblRespostaSecreta.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespostaSecreta.ForeColor = System.Drawing.Color.White;
            this.lblRespostaSecreta.Location = new System.Drawing.Point(60, 376);
            this.lblRespostaSecreta.Name = "lblRespostaSecreta";
            this.lblRespostaSecreta.Size = new System.Drawing.Size(219, 22);
            this.lblRespostaSecreta.TabIndex = 18;
            this.lblRespostaSecreta.Text = "Resposta Secreta";
            // 
            // txtRespostaSecreta
            // 
            this.txtRespostaSecreta.BackColor = System.Drawing.Color.Silver;
            this.txtRespostaSecreta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRespostaSecreta.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespostaSecreta.Location = new System.Drawing.Point(293, 376);
            this.txtRespostaSecreta.Name = "txtRespostaSecreta";
            this.txtRespostaSecreta.Size = new System.Drawing.Size(421, 28);
            this.txtRespostaSecreta.TabIndex = 17;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.lblTipoUsuario.Location = new System.Drawing.Point(48, 214);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(101, 44);
            this.lblTipoUsuario.TabIndex = 19;
            this.lblTipoUsuario.Text = " Tipo de\r\nUsuário";
            this.lblTipoUsuario.Click += new System.EventHandler(this.lblTipoUsuario_Click);
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.BackColor = System.Drawing.Color.Silver;
            this.cmbTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTipoUsuario.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Comum"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(156, 223);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(183, 29);
            this.cmbTipoUsuario.TabIndex = 20;
            // 
            // pcbFechar
            // 
            this.pcbFechar.BackColor = System.Drawing.Color.Transparent;
            this.pcbFechar.BackgroundImage = global::projeto_carla.Properties.Resources.fechar;
            this.pcbFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbFechar.Location = new System.Drawing.Point(699, 27);
            this.pcbFechar.Name = "pcbFechar";
            this.pcbFechar.Size = new System.Drawing.Size(55, 55);
            this.pcbFechar.TabIndex = 21;
            this.pcbFechar.TabStop = false;
            this.pcbFechar.Click += new System.EventHandler(this.pcbFechar_Click);
            this.pcbFechar.MouseEnter += new System.EventHandler(this.pcbFechar_MouseEnter);
            this.pcbFechar.MouseLeave += new System.EventHandler(this.pcbFechar_MouseLeave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Copperplate Gothic Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(261, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 30);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Criar novo Usuário";
            // 
            // CriarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::projeto_carla.Properties.Resources.fundo_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 509);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pcbFechar);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.lblRespostaSecreta);
            this.Controls.Add(this.txtRespostaSecreta);
            this.Controls.Add(this.lblPerguntaSecreta);
            this.Controls.Add(this.txtPerguntaSecreta);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CriarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CriarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPerguntaSecreta;
        private System.Windows.Forms.TextBox txtPerguntaSecreta;
        private System.Windows.Forms.Label lblRespostaSecreta;
        private System.Windows.Forms.TextBox txtRespostaSecreta;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.PictureBox pcbFechar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtSenha;
    }
}