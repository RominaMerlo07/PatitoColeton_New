namespace GestionJardin
{
    partial class frmPrincipal
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
            this.panel_Titulo = new System.Windows.Forms.Panel();
            this.btnGestiones = new System.Windows.Forms.PictureBox();
            this.btn_inicio = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximizar = new FontAwesome.Sharp.IconPictureBox();
            this.btn_Cerrar = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.btnCobros = new FontAwesome.Sharp.IconButton();
            this.btnSalas = new FontAwesome.Sharp.IconButton();
            this.btnDocentes = new FontAwesome.Sharp.IconButton();
            this.btnAlumnos = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.panel_Shadow = new System.Windows.Forms.Panel();
            this.panel_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGestiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.panel_Contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Titulo
            // 
            this.panel_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel_Titulo.Controls.Add(this.btnGestiones);
            this.panel_Titulo.Controls.Add(this.btn_inicio);
            this.panel_Titulo.Controls.Add(this.btnMinimizar);
            this.panel_Titulo.Controls.Add(this.btnMaximizar);
            this.panel_Titulo.Controls.Add(this.btn_Cerrar);
            this.panel_Titulo.Controls.Add(this.lbl_Titulo);
            this.panel_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Titulo.Location = new System.Drawing.Point(0, 0);
            this.panel_Titulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Titulo.Name = "panel_Titulo";
            this.panel_Titulo.Size = new System.Drawing.Size(1387, 139);
            this.panel_Titulo.TabIndex = 4;
            this.panel_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Titulo_MouseDown);
            // 
            // btnGestiones
            // 
            this.btnGestiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnGestiones.Image = global::GestionJardin.Properties.Resources.patochusma_removebg_preview;
            this.btnGestiones.Location = new System.Drawing.Point(12, 11);
            this.btnGestiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestiones.Name = "btnGestiones";
            this.btnGestiones.Size = new System.Drawing.Size(117, 124);
            this.btnGestiones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGestiones.TabIndex = 10;
            this.btnGestiones.TabStop = false;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btn_inicio.Image = global::GestionJardin.Properties.Resources.Group_333_removebg_preview;
            this.btn_inicio.Location = new System.Drawing.Point(12, 11);
            this.btn_inicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(117, 124);
            this.btn_inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_inicio.TabIndex = 8;
            this.btn_inicio.TabStop = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMinimizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 27;
            this.btnMinimizar.Location = new System.Drawing.Point(1280, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(29, 27);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMaximizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 27;
            this.btnMaximizar.Location = new System.Drawing.Point(1316, 2);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(29, 27);
            this.btnMaximizar.TabIndex = 6;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btn_Cerrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Cerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btn_Cerrar.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Cerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Cerrar.IconSize = 27;
            this.btn_Cerrar.Location = new System.Drawing.Point(1352, 2);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(32, 27);
            this.btn_Cerrar.TabIndex = 5;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Titulo.Location = new System.Drawing.Point(140, 43);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(104, 36);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "INICIO";
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.AutoSize = true;
            this.panel_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel_Contenedor.Controls.Add(this.btnCobros);
            this.panel_Contenedor.Controls.Add(this.btnSalas);
            this.panel_Contenedor.Controls.Add(this.btnDocentes);
            this.panel_Contenedor.Controls.Add(this.btnAlumnos);
            this.panel_Contenedor.Controls.Add(this.btnUsuarios);
            this.panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Contenedor.Location = new System.Drawing.Point(0, 148);
            this.panel_Contenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(1387, 640);
            this.panel_Contenedor.TabIndex = 6;
            // 
            // btnCobros
            // 
            this.btnCobros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCobros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnCobros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobros.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobros.ForeColor = System.Drawing.Color.Red;
            this.btnCobros.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnCobros.IconColor = System.Drawing.Color.Red;
            this.btnCobros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCobros.IconSize = 160;
            this.btnCobros.Location = new System.Drawing.Point(521, -78);
            this.btnCobros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCobros.Name = "btnCobros";
            this.btnCobros.Size = new System.Drawing.Size(353, 379);
            this.btnCobros.TabIndex = 10;
            this.btnCobros.Text = "GESTIÓN COBROS";
            this.btnCobros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCobros.UseVisualStyleBackColor = false;
            this.btnCobros.Click += new System.EventHandler(this.btnCobros_Click);
            this.btnCobros.MouseLeave += new System.EventHandler(this.btnCobros_MouseLeave);
            this.btnCobros.MouseHover += new System.EventHandler(this.btnCobros_MouseHover);
            // 
            // btnSalas
            // 
            this.btnSalas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSalas.IconChar = FontAwesome.Sharp.IconChar.School;
            this.btnSalas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSalas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalas.IconSize = 180;
            this.btnSalas.Location = new System.Drawing.Point(749, 357);
            this.btnSalas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Size = new System.Drawing.Size(353, 379);
            this.btnSalas.TabIndex = 9;
            this.btnSalas.Text = "GESTIÓN SALAS";
            this.btnSalas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalas.UseVisualStyleBackColor = false;
            this.btnSalas.Click += new System.EventHandler(this.btnSalas_Click);
            this.btnSalas.MouseLeave += new System.EventHandler(this.btnSalas_MouseLeave);
            this.btnSalas.MouseHover += new System.EventHandler(this.btnSalas_MouseHover);
            // 
            // btnDocentes
            // 
            this.btnDocentes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDocentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocentes.ForeColor = System.Drawing.Color.Yellow;
            this.btnDocentes.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btnDocentes.IconColor = System.Drawing.Color.Yellow;
            this.btnDocentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDocentes.IconSize = 180;
            this.btnDocentes.Location = new System.Drawing.Point(985, -78);
            this.btnDocentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(353, 379);
            this.btnDocentes.TabIndex = 8;
            this.btnDocentes.Text = "GESTIÓN DOCENTES";
            this.btnDocentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDocentes.UseVisualStyleBackColor = false;
            this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            this.btnDocentes.MouseLeave += new System.EventHandler(this.btnDocentes_MouseLeave);
            this.btnDocentes.MouseHover += new System.EventHandler(this.btnDocentes_MouseHover);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.Color.Magenta;
            this.btnAlumnos.IconChar = FontAwesome.Sharp.IconChar.Child;
            this.btnAlumnos.IconColor = System.Drawing.Color.Magenta;
            this.btnAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlumnos.IconSize = 160;
            this.btnAlumnos.Location = new System.Drawing.Point(63, -78);
            this.btnAlumnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(353, 379);
            this.btnAlumnos.TabIndex = 7;
            this.btnAlumnos.Text = "GESTIÓN ALUMNOS";
            this.btnAlumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlumnos.UseVisualStyleBackColor = false;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            this.btnAlumnos.MouseLeave += new System.EventHandler(this.btnAlumnos_MouseLeave);
            this.btnAlumnos.MouseHover += new System.EventHandler(this.btnAlumnos_MouseHover);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Lime;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnUsuarios.IconColor = System.Drawing.Color.Lime;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 176;
            this.btnUsuarios.Location = new System.Drawing.Point(291, 357);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(353, 379);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "GESTIÓN USUARIOS";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnUsuarios.MouseLeave += new System.EventHandler(this.btnUsuarios_MouseLeave);
            this.btnUsuarios.MouseHover += new System.EventHandler(this.btnUsuarios_MouseHover);
            // 
            // panel_Shadow
            // 
            this.panel_Shadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel_Shadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Shadow.Location = new System.Drawing.Point(0, 139);
            this.panel_Shadow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Shadow.Name = "panel_Shadow";
            this.panel_Shadow.Size = new System.Drawing.Size(1387, 9);
            this.panel_Shadow.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1387, 788);
            this.Controls.Add(this.panel_Contenedor);
            this.Controls.Add(this.panel_Shadow);
            this.Controls.Add(this.panel_Titulo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PATITO COLETÓN";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel_Titulo.ResumeLayout(false);
            this.panel_Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGestiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.panel_Contenedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Titulo;
        private System.Windows.Forms.Label lbl_Titulo;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private FontAwesome.Sharp.IconPictureBox btnMaximizar;
        private FontAwesome.Sharp.IconPictureBox btn_Cerrar;
        private System.Windows.Forms.Panel panel_Contenedor;
        private System.Windows.Forms.Panel panel_Shadow;
        private System.Windows.Forms.PictureBox btn_inicio;
        public FontAwesome.Sharp.IconButton btnAlumnos;
        public FontAwesome.Sharp.IconButton btnUsuarios;
        public FontAwesome.Sharp.IconButton btnDocentes;
        public FontAwesome.Sharp.IconButton btnSalas;
        public FontAwesome.Sharp.IconButton btnCobros;
        private System.Windows.Forms.PictureBox btnGestiones;
    }
}