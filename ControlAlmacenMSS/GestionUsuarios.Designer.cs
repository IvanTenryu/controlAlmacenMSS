namespace ControlAlmacenMSS
{
    partial class GestionUsuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelCerrarGest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BunMatTbNombreGest = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BunMatTbUsuarioGest = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BunMatTbContraGest = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BunMatTbMailGest = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BunMatTbTelGest = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnAgregarGest = new System.Windows.Forms.Button();
            this.BtnEditarGest = new System.Windows.Forms.Button();
            this.BtnBorrarGest = new System.Windows.Forms.Button();
            this.BtnVolverGest = new System.Windows.Forms.Button();
            this.DataGridViewGestionUsuarios = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGestionUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LabelCerrarGest);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 102);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(583, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "CAMSS";
            // 
            // LabelCerrarGest
            // 
            this.LabelCerrarGest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCerrarGest.AutoSize = true;
            this.LabelCerrarGest.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCerrarGest.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LabelCerrarGest.Location = new System.Drawing.Point(1196, 9);
            this.LabelCerrarGest.Name = "LabelCerrarGest";
            this.LabelCerrarGest.Size = new System.Drawing.Size(25, 28);
            this.LabelCerrarGest.TabIndex = 0;
            this.LabelCerrarGest.Text = "X";
            this.LabelCerrarGest.Click += new System.EventHandler(this.LabelCerrarGest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(491, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de usuarios";
            // 
            // BunMatTbNombreGest
            // 
            this.BunMatTbNombreGest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BunMatTbNombreGest.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunMatTbNombreGest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BunMatTbNombreGest.HintForeColor = System.Drawing.Color.Empty;
            this.BunMatTbNombreGest.HintText = "";
            this.BunMatTbNombreGest.isPassword = false;
            this.BunMatTbNombreGest.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.BunMatTbNombreGest.LineIdleColor = System.Drawing.SystemColors.HotTrack;
            this.BunMatTbNombreGest.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.BunMatTbNombreGest.LineThickness = 3;
            this.BunMatTbNombreGest.Location = new System.Drawing.Point(13, 128);
            this.BunMatTbNombreGest.Margin = new System.Windows.Forms.Padding(4);
            this.BunMatTbNombreGest.Name = "BunMatTbNombreGest";
            this.BunMatTbNombreGest.Size = new System.Drawing.Size(237, 30);
            this.BunMatTbNombreGest.TabIndex = 0;
            this.BunMatTbNombreGest.Text = "Nombre";
            this.BunMatTbNombreGest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BunMatTbUsuarioGest
            // 
            this.BunMatTbUsuarioGest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BunMatTbUsuarioGest.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunMatTbUsuarioGest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BunMatTbUsuarioGest.HintForeColor = System.Drawing.Color.Empty;
            this.BunMatTbUsuarioGest.HintText = "";
            this.BunMatTbUsuarioGest.isPassword = false;
            this.BunMatTbUsuarioGest.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.BunMatTbUsuarioGest.LineIdleColor = System.Drawing.SystemColors.HotTrack;
            this.BunMatTbUsuarioGest.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.BunMatTbUsuarioGest.LineThickness = 3;
            this.BunMatTbUsuarioGest.Location = new System.Drawing.Point(13, 166);
            this.BunMatTbUsuarioGest.Margin = new System.Windows.Forms.Padding(4);
            this.BunMatTbUsuarioGest.Name = "BunMatTbUsuarioGest";
            this.BunMatTbUsuarioGest.Size = new System.Drawing.Size(237, 30);
            this.BunMatTbUsuarioGest.TabIndex = 1;
            this.BunMatTbUsuarioGest.Text = "Usuario";
            this.BunMatTbUsuarioGest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BunMatTbContraGest
            // 
            this.BunMatTbContraGest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BunMatTbContraGest.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunMatTbContraGest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BunMatTbContraGest.HintForeColor = System.Drawing.Color.Empty;
            this.BunMatTbContraGest.HintText = "";
            this.BunMatTbContraGest.isPassword = false;
            this.BunMatTbContraGest.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.BunMatTbContraGest.LineIdleColor = System.Drawing.SystemColors.HotTrack;
            this.BunMatTbContraGest.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.BunMatTbContraGest.LineThickness = 3;
            this.BunMatTbContraGest.Location = new System.Drawing.Point(13, 204);
            this.BunMatTbContraGest.Margin = new System.Windows.Forms.Padding(4);
            this.BunMatTbContraGest.Name = "BunMatTbContraGest";
            this.BunMatTbContraGest.Size = new System.Drawing.Size(237, 30);
            this.BunMatTbContraGest.TabIndex = 2;
            this.BunMatTbContraGest.Text = "Contraseña";
            this.BunMatTbContraGest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BunMatTbMailGest
            // 
            this.BunMatTbMailGest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BunMatTbMailGest.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunMatTbMailGest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BunMatTbMailGest.HintForeColor = System.Drawing.Color.Empty;
            this.BunMatTbMailGest.HintText = "";
            this.BunMatTbMailGest.isPassword = false;
            this.BunMatTbMailGest.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.BunMatTbMailGest.LineIdleColor = System.Drawing.SystemColors.HotTrack;
            this.BunMatTbMailGest.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.BunMatTbMailGest.LineThickness = 3;
            this.BunMatTbMailGest.Location = new System.Drawing.Point(13, 242);
            this.BunMatTbMailGest.Margin = new System.Windows.Forms.Padding(4);
            this.BunMatTbMailGest.Name = "BunMatTbMailGest";
            this.BunMatTbMailGest.Size = new System.Drawing.Size(237, 30);
            this.BunMatTbMailGest.TabIndex = 3;
            this.BunMatTbMailGest.Text = "Email";
            this.BunMatTbMailGest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BunMatTbTelGest
            // 
            this.BunMatTbTelGest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BunMatTbTelGest.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunMatTbTelGest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BunMatTbTelGest.HintForeColor = System.Drawing.Color.Empty;
            this.BunMatTbTelGest.HintText = "";
            this.BunMatTbTelGest.isPassword = false;
            this.BunMatTbTelGest.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.BunMatTbTelGest.LineIdleColor = System.Drawing.SystemColors.HotTrack;
            this.BunMatTbTelGest.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.BunMatTbTelGest.LineThickness = 3;
            this.BunMatTbTelGest.Location = new System.Drawing.Point(13, 280);
            this.BunMatTbTelGest.Margin = new System.Windows.Forms.Padding(4);
            this.BunMatTbTelGest.Name = "BunMatTbTelGest";
            this.BunMatTbTelGest.Size = new System.Drawing.Size(237, 30);
            this.BunMatTbTelGest.TabIndex = 4;
            this.BunMatTbTelGest.Text = "Teléfono";
            this.BunMatTbTelGest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnAgregarGest
            // 
            this.BtnAgregarGest.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnAgregarGest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarGest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarGest.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarGest.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnAgregarGest.Location = new System.Drawing.Point(13, 327);
            this.BtnAgregarGest.Name = "BtnAgregarGest";
            this.BtnAgregarGest.Size = new System.Drawing.Size(75, 40);
            this.BtnAgregarGest.TabIndex = 5;
            this.BtnAgregarGest.Text = "Agregar";
            this.BtnAgregarGest.UseVisualStyleBackColor = false;
            this.BtnAgregarGest.Click += new System.EventHandler(this.BtnAgregarGest_Click);
            // 
            // BtnEditarGest
            // 
            this.BtnEditarGest.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnEditarGest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditarGest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarGest.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarGest.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnEditarGest.Location = new System.Drawing.Point(94, 327);
            this.BtnEditarGest.Name = "BtnEditarGest";
            this.BtnEditarGest.Size = new System.Drawing.Size(75, 40);
            this.BtnEditarGest.TabIndex = 6;
            this.BtnEditarGest.Text = "Editar";
            this.BtnEditarGest.UseVisualStyleBackColor = false;
            this.BtnEditarGest.Click += new System.EventHandler(this.BtnEditarGest_Click);
            // 
            // BtnBorrarGest
            // 
            this.BtnBorrarGest.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnBorrarGest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBorrarGest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrarGest.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarGest.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnBorrarGest.Location = new System.Drawing.Point(175, 327);
            this.BtnBorrarGest.Name = "BtnBorrarGest";
            this.BtnBorrarGest.Size = new System.Drawing.Size(75, 40);
            this.BtnBorrarGest.TabIndex = 7;
            this.BtnBorrarGest.Text = "Borrar";
            this.BtnBorrarGest.UseVisualStyleBackColor = false;
            this.BtnBorrarGest.Click += new System.EventHandler(this.BtnBorrarGest_Click);
            // 
            // BtnVolverGest
            // 
            this.BtnVolverGest.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnVolverGest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVolverGest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolverGest.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolverGest.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnVolverGest.Location = new System.Drawing.Point(94, 373);
            this.BtnVolverGest.Name = "BtnVolverGest";
            this.BtnVolverGest.Size = new System.Drawing.Size(75, 40);
            this.BtnVolverGest.TabIndex = 8;
            this.BtnVolverGest.Text = "Volver";
            this.BtnVolverGest.UseVisualStyleBackColor = false;
            // 
            // DataGridViewGestionUsuarios
            // 
            this.DataGridViewGestionUsuarios.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.DataGridViewGestionUsuarios.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DataGridViewGestionUsuarios.Location = new System.Drawing.Point(274, 156);
            this.DataGridViewGestionUsuarios.Name = "DataGridViewGestionUsuarios";
            this.DataGridViewGestionUsuarios.Size = new System.Drawing.Size(927, 505);
            this.DataGridViewGestionUsuarios.TabIndex = 6;
            this.DataGridViewGestionUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewGestionUsuarios_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 686);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1228, 34);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(601, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lista de usuarios";
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1228, 720);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DataGridViewGestionUsuarios);
            this.Controls.Add(this.BtnVolverGest);
            this.Controls.Add(this.BtnBorrarGest);
            this.Controls.Add(this.BtnEditarGest);
            this.Controls.Add(this.BtnAgregarGest);
            this.Controls.Add(this.BunMatTbTelGest);
            this.Controls.Add(this.BunMatTbMailGest);
            this.Controls.Add(this.BunMatTbContraGest);
            this.Controls.Add(this.BunMatTbUsuarioGest);
            this.Controls.Add(this.BunMatTbNombreGest);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionUsuarios";
            this.Load += new System.EventHandler(this.GestionUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGestionUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BunMatTbNombreGest;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BunMatTbUsuarioGest;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BunMatTbContraGest;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BunMatTbMailGest;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BunMatTbTelGest;
        private System.Windows.Forms.Button BtnAgregarGest;
        private System.Windows.Forms.Button BtnEditarGest;
        private System.Windows.Forms.Button BtnBorrarGest;
        private System.Windows.Forms.Button BtnVolverGest;
        private System.Windows.Forms.Label LabelCerrarGest;
        private System.Windows.Forms.DataGridView DataGridViewGestionUsuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}