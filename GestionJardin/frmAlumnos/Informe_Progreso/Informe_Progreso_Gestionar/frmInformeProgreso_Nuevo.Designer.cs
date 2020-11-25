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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtObservacion = new MetroFramework.Controls.MetroTextBox();
            this.lblEstado = new MetroFramework.Controls.MetroLabel();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblDescripcion = new MetroFramework.Controls.MetroTextBox();
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
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.txtObservacion.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtObservacion.Lines = new string[0];
            this.txtObservacion.Location = new System.Drawing.Point(44, 451);
            this.txtObservacion.MaxLength = 32767;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasswordChar = '\0';
            this.txtObservacion.PromptText = "TEXTO A INGRESAR POR PROFESOR";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservacion.SelectedText = "";
            this.txtObservacion.SelectionLength = 0;
            this.txtObservacion.SelectionStart = 0;
            this.txtObservacion.ShortcutsEnabled = true;
            this.txtObservacion.Size = new System.Drawing.Size(1480, 270);
            this.txtObservacion.TabIndex = 32;
            this.txtObservacion.UseSelectable = true;
            this.txtObservacion.WaterMark = "TEXTO A INGRESAR POR PROFESOR";
            this.txtObservacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObservacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstado.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEstado.ForeColor = System.Drawing.Color.Yellow;
            this.lblEstado.Location = new System.Drawing.Point(1072, 163);
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
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btncancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.IconSize = 60;
            this.btncancelar.Location = new System.Drawing.Point(1285, 810);
            this.btncancelar.Name = "btncancelar";
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
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 60;
            this.btnguardar.Location = new System.Drawing.Point(974, 810);
            this.btnguardar.Name = "btnguardar";
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
            // lblDescripcion
            // 
            // 
            // 
            // 
            this.lblDescripcion.CustomButton.Image = null;
            this.lblDescripcion.CustomButton.Location = new System.Drawing.Point(1316, 1);
            this.lblDescripcion.CustomButton.Name = "";
            this.lblDescripcion.CustomButton.Size = new System.Drawing.Size(163, 163);
            this.lblDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDescripcion.CustomButton.TabIndex = 1;
            this.lblDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDescripcion.CustomButton.UseSelectable = true;
            this.lblDescripcion.CustomButton.Visible = false;
            this.lblDescripcion.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.lblDescripcion.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblDescripcion.Lines = new string[] {
        " Descripción de los criterios a evaluar"};
            this.lblDescripcion.Location = new System.Drawing.Point(44, 235);
            this.lblDescripcion.MaxLength = 32767;
            this.lblDescripcion.Multiline = true;
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.PasswordChar = '\0';
            this.lblDescripcion.ReadOnly = true;
            this.lblDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblDescripcion.SelectedText = "";
            this.lblDescripcion.SelectionLength = 0;
            this.lblDescripcion.SelectionStart = 0;
            this.lblDescripcion.ShortcutsEnabled = true;
            this.lblDescripcion.Size = new System.Drawing.Size(1480, 165);
            this.lblDescripcion.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblDescripcion.TabIndex = 50;
            this.lblDescripcion.Text = " Descripción de los criterios a evaluar";
            this.lblDescripcion.UseCustomBackColor = true;
            this.lblDescripcion.UseCustomForeColor = true;
            this.lblDescripcion.UseSelectable = true;
            this.lblDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmInformeProgreso_Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1572, 935);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbAsignatura);
            this.MaximizeBox = false;
            this.Name = "frmInformeProgreso_Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GENERAR NUEVO INFORME DE PROGRESO";
            this.Load += new System.EventHandler(this.frmInformeProgreso_Nuevo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cbAsignatura;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtObservacion;
        private MetroFramework.Controls.MetroLabel lblEstado;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox lblDescripcion;
    }
}