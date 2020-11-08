namespace GestionJardin
{
    partial class frmInformeProgreso_Nuevo
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
            this.cbAsignatura = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panelDescripcion = new MetroFramework.Controls.MetroPanel();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtObservacion = new MetroFramework.Controls.MetroTextBox();
            this.lblEstado = new MetroFramework.Controls.MetroLabel();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnBloqueo = new FontAwesome.Sharp.IconButton();
            this.panelDescripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAsignatura
            // 
            this.cbAsignatura.FormattingEnabled = true;
            this.cbAsignatura.ItemHeight = 24;
            this.cbAsignatura.Items.AddRange(new object[] {
            "IDENTIDAD Y CONVIVENCIA",
            "LENGIAJE Y LITERATURA",
            "MATEMÁTICA",
            "CIENCIAS SOCIALES, CIENCIAS NATURALES Y TECNOLOGÍA",
            "EDUCACIÓN ARTISTICA",
            "EDUCACIÓN FÍSICA",
            "OBSERVACIONES GENERALES",
            "ASISTENCIA"});
            this.cbAsignatura.Location = new System.Drawing.Point(307, 154);
            this.cbAsignatura.Name = "cbAsignatura";
            this.cbAsignatura.PromptText = "SELECCIONE";
            this.cbAsignatura.Size = new System.Drawing.Size(698, 30);
            this.cbAsignatura.Style = MetroFramework.MetroColorStyle.Green;
            this.cbAsignatura.TabIndex = 4;
            this.cbAsignatura.UseSelectable = true;
            this.cbAsignatura.SelectedValueChanged += new System.EventHandler(this.cbAsignatura_SelectedValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.SpringGreen;
            this.metroLabel1.Location = new System.Drawing.Point(44, 151);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(216, 44);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "ASIGNATURA: ";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // panelDescripcion
            // 
            this.panelDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDescripcion.Controls.Add(this.lblDescripcion);
            this.panelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDescripcion.HorizontalScrollbarBarColor = true;
            this.panelDescripcion.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDescripcion.HorizontalScrollbarSize = 10;
            this.panelDescripcion.Location = new System.Drawing.Point(44, 227);
            this.panelDescripcion.Name = "panelDescripcion";
            this.panelDescripcion.Size = new System.Drawing.Size(1485, 166);
            this.panelDescripcion.TabIndex = 31;
            this.panelDescripcion.UseCustomBackColor = true;
            this.panelDescripcion.VerticalScrollbarBarColor = true;
            this.panelDescripcion.VerticalScrollbarHighlightOnWheel = false;
            this.panelDescripcion.VerticalScrollbarSize = 10;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescripcion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDescripcion.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDescripcion.ForeColor = System.Drawing.Color.Beige;
            this.lblDescripcion.Location = new System.Drawing.Point(26, 12);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(1189, 116);
            this.lblDescripcion.TabIndex = 30;
            this.lblDescripcion.Text = "DESCRIPCIÓN DE APRENDIZAJE";
            this.lblDescripcion.UseCustomBackColor = true;
            this.lblDescripcion.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.SpringGreen;
            this.metroLabel4.Location = new System.Drawing.Point(44, 28);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(1236, 63);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "Informe de progreso del ALUMNO: \"\"  - DNI: \"\" - EDAD: \"\"";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // txtObservacion
            // 
            // 
            // 
            // 
            this.txtObservacion.CustomButton.Image = null;
            this.txtObservacion.CustomButton.Location = new System.Drawing.Point(1212, 2);
            this.txtObservacion.CustomButton.Name = "";
            this.txtObservacion.CustomButton.Size = new System.Drawing.Size(265, 265);
            this.txtObservacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObservacion.CustomButton.TabIndex = 1;
            this.txtObservacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObservacion.CustomButton.UseSelectable = true;
            this.txtObservacion.CustomButton.Visible = false;
            this.txtObservacion.Lines = new string[] {
        "TEXTO A INGRESAR POR PROFESOR"};
            this.txtObservacion.Location = new System.Drawing.Point(44, 426);
            this.txtObservacion.MaxLength = 32767;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasswordChar = '\0';
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservacion.SelectedText = "";
            this.txtObservacion.SelectionLength = 0;
            this.txtObservacion.SelectionStart = 0;
            this.txtObservacion.ShortcutsEnabled = true;
            this.txtObservacion.Size = new System.Drawing.Size(1480, 270);
            this.txtObservacion.TabIndex = 32;
            this.txtObservacion.Text = "TEXTO A INGRESAR POR PROFESOR";
            this.txtObservacion.UseSelectable = true;
            this.txtObservacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObservacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEstado.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEstado.ForeColor = System.Drawing.Color.Yellow;
            this.lblEstado.Location = new System.Drawing.Point(1072, 154);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(224, 44);
            this.lblEstado.TabIndex = 31;
            this.lblEstado.Text = "PENDIENTE";
            this.lblEstado.UseCustomBackColor = true;
            this.lblEstado.UseCustomForeColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btncancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncancelar.IconSize = 60;
            this.btncancelar.Location = new System.Drawing.Point(1285, 750);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Rotation = 0D;
            this.btncancelar.Size = new System.Drawing.Size(239, 76);
            this.btncancelar.TabIndex = 34;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnguardar.IconSize = 60;
            this.btnguardar.Location = new System.Drawing.Point(974, 750);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Rotation = 0D;
            this.btnguardar.Size = new System.Drawing.Size(239, 76);
            this.btnguardar.TabIndex = 33;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.SpringGreen;
            this.metroLabel2.Location = new System.Drawing.Point(44, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(1485, 44);
            this.metroLabel2.TabIndex = 35;
            this.metroLabel2.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // btnBloqueo
            // 
            this.btnBloqueo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnBloqueo.FlatAppearance.BorderSize = 0;
            this.btnBloqueo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloqueo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBloqueo.ForeColor = System.Drawing.Color.Transparent;
            this.btnBloqueo.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnBloqueo.IconColor = System.Drawing.Color.Aqua;
            this.btnBloqueo.IconSize = 55;
            this.btnBloqueo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBloqueo.Location = new System.Drawing.Point(1302, 151);
            this.btnBloqueo.Name = "btnBloqueo";
            this.btnBloqueo.Rotation = 0D;
            this.btnBloqueo.Size = new System.Drawing.Size(59, 65);
            this.btnBloqueo.TabIndex = 55;
            this.btnBloqueo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBloqueo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBloqueo.UseVisualStyleBackColor = false;
            // 
            // frmInformeProgreso_Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1572, 864);
            this.Controls.Add(this.btnBloqueo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.panelDescripcion);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbAsignatura);
            this.MaximizeBox = false;
            this.Name = "frmInformeProgreso_Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GENERAR NUEVO INFORME DE PROGRESO";
            this.Load += new System.EventHandler(this.frmInformeProgreso_Nuevo_Load);
            this.panelDescripcion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cbAsignatura;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel panelDescripcion;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtObservacion;
        private MetroFramework.Controls.MetroLabel lblEstado;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private FontAwesome.Sharp.IconButton btnBloqueo;
    }
}