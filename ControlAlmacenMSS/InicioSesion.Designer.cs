namespace ControlAlmacenMSS
{
    partial class InicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BunMatTextboxContraLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BunMatTextboxUsuarioLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CheckBoxVerContra = new System.Windows.Forms.CheckBox();
            this.LabelLimpiar = new System.Windows.Forms.Label();
            this.ButtonEntLogin = new System.Windows.Forms.Button();
            this.LabelCerrarLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(110, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar sesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(32, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Control de Almacén MSS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.BunMatTextboxContraLogin);
            this.panel1.Controls.Add(this.BunMatTextboxUsuarioLogin);
            this.panel1.Controls.Add(this.CheckBoxVerContra);
            this.panel1.Controls.Add(this.LabelLimpiar);
            this.panel1.Controls.Add(this.ButtonEntLogin);
            this.panel1.Location = new System.Drawing.Point(237, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 202);
            this.panel1.TabIndex = 3;
            // 
            // BunMatTextboxContraLogin
            // 
            this.BunMatTextboxContraLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BunMatTextboxContraLogin.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunMatTextboxContraLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BunMatTextboxContraLogin.HintForeColor = System.Drawing.Color.Empty;
            this.BunMatTextboxContraLogin.HintText = "";
            this.BunMatTextboxContraLogin.isPassword = true;
            this.BunMatTextboxContraLogin.LineFocusedColor = System.Drawing.Color.Blue;
            this.BunMatTextboxContraLogin.LineIdleColor = System.Drawing.SystemColors.ControlLight;
            this.BunMatTextboxContraLogin.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.BunMatTextboxContraLogin.LineThickness = 3;
            this.BunMatTextboxContraLogin.Location = new System.Drawing.Point(24, 63);
            this.BunMatTextboxContraLogin.Margin = new System.Windows.Forms.Padding(4);
            this.BunMatTextboxContraLogin.Name = "BunMatTextboxContraLogin";
            this.BunMatTextboxContraLogin.Size = new System.Drawing.Size(192, 39);
            this.BunMatTextboxContraLogin.TabIndex = 7;
            this.BunMatTextboxContraLogin.Text = "Contraseña";
            this.BunMatTextboxContraLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BunMatTextboxContraLogin.OnValueChanged += new System.EventHandler(this.BunMatTextboxContraLogin_OnValueChanged);
            // 
            // BunMatTextboxUsuarioLogin
            // 
            this.BunMatTextboxUsuarioLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BunMatTextboxUsuarioLogin.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunMatTextboxUsuarioLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BunMatTextboxUsuarioLogin.HintForeColor = System.Drawing.Color.Empty;
            this.BunMatTextboxUsuarioLogin.HintText = "";
            this.BunMatTextboxUsuarioLogin.isPassword = false;
            this.BunMatTextboxUsuarioLogin.LineFocusedColor = System.Drawing.Color.Blue;
            this.BunMatTextboxUsuarioLogin.LineIdleColor = System.Drawing.SystemColors.ControlLight;
            this.BunMatTextboxUsuarioLogin.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.BunMatTextboxUsuarioLogin.LineThickness = 3;
            this.BunMatTextboxUsuarioLogin.Location = new System.Drawing.Point(24, 22);
            this.BunMatTextboxUsuarioLogin.Margin = new System.Windows.Forms.Padding(4);
            this.BunMatTextboxUsuarioLogin.Name = "BunMatTextboxUsuarioLogin";
            this.BunMatTextboxUsuarioLogin.Size = new System.Drawing.Size(192, 39);
            this.BunMatTextboxUsuarioLogin.TabIndex = 7;
            this.BunMatTextboxUsuarioLogin.Text = "Usuario";
            this.BunMatTextboxUsuarioLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BunMatTextboxUsuarioLogin.OnValueChanged += new System.EventHandler(this.BunMatTextboxUsuarioLogin_OnValueChanged);
            // 
            // CheckBoxVerContra
            // 
            this.CheckBoxVerContra.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxVerContra.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CheckBoxVerContra.Location = new System.Drawing.Point(104, 104);
            this.CheckBoxVerContra.Name = "CheckBoxVerContra";
            this.CheckBoxVerContra.Size = new System.Drawing.Size(112, 24);
            this.CheckBoxVerContra.TabIndex = 0;
            this.CheckBoxVerContra.Text = "Ver contraseña";
            this.CheckBoxVerContra.CheckedChanged += new System.EventHandler(this.CheckBoxVerContra_CheckedChanged);
            // 
            // LabelLimpiar
            // 
            this.LabelLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.LabelLimpiar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLimpiar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LabelLimpiar.Location = new System.Drawing.Point(46, 109);
            this.LabelLimpiar.Name = "LabelLimpiar";
            this.LabelLimpiar.Size = new System.Drawing.Size(52, 15);
            this.LabelLimpiar.TabIndex = 8;
            this.LabelLimpiar.Text = "Limpiar";
            this.LabelLimpiar.Click += new System.EventHandler(this.LabelLimpiar_Click);
            // 
            // ButtonEntLogin
            // 
            this.ButtonEntLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonEntLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEntLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEntLogin.Location = new System.Drawing.Point(64, 149);
            this.ButtonEntLogin.Name = "ButtonEntLogin";
            this.ButtonEntLogin.Size = new System.Drawing.Size(100, 30);
            this.ButtonEntLogin.TabIndex = 6;
            this.ButtonEntLogin.Text = "Entrar";
            this.ButtonEntLogin.UseVisualStyleBackColor = false;
            this.ButtonEntLogin.Click += new System.EventHandler(this.ButtonEntLogin_Click);
            // 
            // LabelCerrarLogin
            // 
            this.LabelCerrarLogin.AutoSize = true;
            this.LabelCerrarLogin.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCerrarLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LabelCerrarLogin.Location = new System.Drawing.Point(453, 7);
            this.LabelCerrarLogin.Name = "LabelCerrarLogin";
            this.LabelCerrarLogin.Size = new System.Drawing.Size(25, 28);
            this.LabelCerrarLogin.TabIndex = 4;
            this.LabelCerrarLogin.Text = "X";
            this.LabelCerrarLogin.Click += new System.EventHandler(this.LabelCerrarLogin_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(484, 434);
            this.Controls.Add(this.LabelCerrarLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIAR SESION CAMSS";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonEntLogin;
        private System.Windows.Forms.CheckBox CheckBoxVerContra;
        private System.Windows.Forms.Label LabelLimpiar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BunMatTextboxContraLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BunMatTextboxUsuarioLogin;
        private System.Windows.Forms.Label LabelCerrarLogin;
    }
}

