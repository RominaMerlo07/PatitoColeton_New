namespace GestionJardin
{
    partial class frmCuotasGestionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuotasGestionar));
            this.lblAyuda = new MetroFramework.Controls.MetroLabel();
            this.cbPeriodo = new MetroFramework.Controls.MetroComboBox();
            this.cbAnoEjercicio = new MetroFramework.Controls.MetroComboBox();
            this.cbSalas = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.panelCbos = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panelGrilla = new MetroFramework.Controls.MetroPanel();
            this.txtMatriculados = new MetroFramework.Controls.MetroTextBox();
            this.cboOpcionMasivo = new MetroFramework.Controls.MetroComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnParticular = new FontAwesome.Sharp.IconButton();
            this.btnMasivo = new FontAwesome.Sharp.IconButton();
            this.btnGenerar = new FontAwesome.Sharp.IconButton();
            this.panelConceptos = new MetroFramework.Controls.MetroPanel();
            this.lblConceptos = new MetroFramework.Controls.MetroLabel();
            this.listConceptos = new System.Windows.Forms.ListView();
            this.btnAplicarIntereses = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.panelCbos.SuspendLayout();
            this.panelGrilla.SuspendLayout();
            this.panelConceptos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAyuda.ForeColor = System.Drawing.Color.White;
            this.lblAyuda.Location = new System.Drawing.Point(24, 241);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(560, 20);
            this.lblAyuda.TabIndex = 15;
            this.lblAyuda.Text = "Por favor, elija una modalidad para la generación de cuotas (Masivo/Particular)";
            this.lblAyuda.UseCustomBackColor = true;
            this.lblAyuda.UseCustomForeColor = true;
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.ItemHeight = 24;
            this.cbPeriodo.Items.AddRange(new object[] {
            "MATRICULA",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.cbPeriodo.Location = new System.Drawing.Point(38, 80);
            this.cbPeriodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.PromptText = "Periodo";
            this.cbPeriodo.Size = new System.Drawing.Size(190, 30);
            this.cbPeriodo.TabIndex = 20;
            this.cbPeriodo.UseSelectable = true;
            // 
            // cbAnoEjercicio
            // 
            this.cbAnoEjercicio.FormattingEnabled = true;
            this.cbAnoEjercicio.ItemHeight = 24;
            this.cbAnoEjercicio.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021"});
            this.cbAnoEjercicio.Location = new System.Drawing.Point(38, 163);
            this.cbAnoEjercicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAnoEjercicio.Name = "cbAnoEjercicio";
            this.cbAnoEjercicio.PromptText = "Año";
            this.cbAnoEjercicio.Size = new System.Drawing.Size(122, 30);
            this.cbAnoEjercicio.TabIndex = 19;
            this.cbAnoEjercicio.UseSelectable = true;
            // 
            // cbSalas
            // 
            this.cbSalas.FormattingEnabled = true;
            this.cbSalas.ItemHeight = 24;
            this.cbSalas.Items.AddRange(new object[] {
            "ParaPrueba"});
            this.cbSalas.Location = new System.Drawing.Point(38, 319);
            this.cbSalas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSalas.Name = "cbSalas";
            this.cbSalas.PromptText = "Sala";
            this.cbSalas.Size = new System.Drawing.Size(152, 30);
            this.cbSalas.TabIndex = 18;
            this.cbSalas.UseSelectable = true;
            this.cbSalas.SelectedValueChanged += new System.EventHandler(this.cbSalas_SelectedValueChanged);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(38, 241);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.PromptText = "Turno";
            this.metroComboBox1.Size = new System.Drawing.Size(152, 30);
            this.metroComboBox1.TabIndex = 21;
            this.metroComboBox1.UseSelectable = true;
            // 
            // panelCbos
            // 
            this.panelCbos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelCbos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelCbos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCbos.Controls.Add(this.metroLabel4);
            this.panelCbos.Controls.Add(this.metroComboBox1);
            this.panelCbos.Controls.Add(this.cbSalas);
            this.panelCbos.Controls.Add(this.cbPeriodo);
            this.panelCbos.Controls.Add(this.cbAnoEjercicio);
            this.panelCbos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCbos.HorizontalScrollbarBarColor = true;
            this.panelCbos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCbos.HorizontalScrollbarSize = 10;
            this.panelCbos.Location = new System.Drawing.Point(24, 472);
            this.panelCbos.Name = "panelCbos";
            this.panelCbos.Size = new System.Drawing.Size(296, 393);
            this.panelCbos.TabIndex = 22;
            this.panelCbos.UseCustomBackColor = true;
            this.panelCbos.VerticalScrollbarBarColor = true;
            this.panelCbos.VerticalScrollbarHighlightOnWheel = false;
            this.panelCbos.VerticalScrollbarSize = 10;
            this.panelCbos.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.Aqua;
            this.metroLabel4.Location = new System.Drawing.Point(11, 24);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(163, 44);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "SELECCIONE";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // panelGrilla
            // 
            this.panelGrilla.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelGrilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelGrilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrilla.Controls.Add(this.txtMatriculados);
            this.panelGrilla.Controls.Add(this.cboOpcionMasivo);
            this.panelGrilla.Controls.Add(this.listView1);
            this.panelGrilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelGrilla.HorizontalScrollbarBarColor = true;
            this.panelGrilla.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGrilla.HorizontalScrollbarSize = 10;
            this.panelGrilla.Location = new System.Drawing.Point(338, 478);
            this.panelGrilla.Name = "panelGrilla";
            this.panelGrilla.Size = new System.Drawing.Size(790, 393);
            this.panelGrilla.TabIndex = 24;
            this.panelGrilla.UseCustomBackColor = true;
            this.panelGrilla.VerticalScrollbarBarColor = true;
            this.panelGrilla.VerticalScrollbarHighlightOnWheel = false;
            this.panelGrilla.VerticalScrollbarSize = 10;
            this.panelGrilla.Visible = false;
            // 
            // txtMatriculados
            // 
            // 
            // 
            // 
            this.txtMatriculados.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMatriculados.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtMatriculados.CustomButton.Location = new System.Drawing.Point(415, 1);
            this.txtMatriculados.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatriculados.CustomButton.Name = "";
            this.txtMatriculados.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtMatriculados.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtMatriculados.CustomButton.TabIndex = 1;
            this.txtMatriculados.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMatriculados.CustomButton.UseSelectable = true;
            this.txtMatriculados.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtMatriculados.Lines = new string[0];
            this.txtMatriculados.Location = new System.Drawing.Point(14, 24);
            this.txtMatriculados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatriculados.MaxLength = 32767;
            this.txtMatriculados.Name = "txtMatriculados";
            this.txtMatriculados.PasswordChar = '\0';
            this.txtMatriculados.PromptText = "Matriculado";
            this.txtMatriculados.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatriculados.SelectedText = "";
            this.txtMatriculados.SelectionLength = 0;
            this.txtMatriculados.SelectionStart = 0;
            this.txtMatriculados.ShortcutsEnabled = true;
            this.txtMatriculados.ShowButton = true;
            this.txtMatriculados.ShowClearButton = true;
            this.txtMatriculados.Size = new System.Drawing.Size(451, 37);
            this.txtMatriculados.TabIndex = 40;
            this.txtMatriculados.UseSelectable = true;
            this.txtMatriculados.UseStyleColors = true;
            this.txtMatriculados.Visible = false;
            this.txtMatriculados.WaterMark = "Matriculado";
            this.txtMatriculados.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMatriculados.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cboOpcionMasivo
            // 
            this.cboOpcionMasivo.FormattingEnabled = true;
            this.cboOpcionMasivo.ItemHeight = 24;
            this.cboOpcionMasivo.Items.AddRange(new object[] {
            "GENERAR NUEVAS CUOTAS PARA ALUMNOS",
            "VISUALIZAR CUOTAS DEL PERIODO POR ALUMNOS"});
            this.cboOpcionMasivo.Location = new System.Drawing.Point(14, 24);
            this.cboOpcionMasivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboOpcionMasivo.Name = "cboOpcionMasivo";
            this.cboOpcionMasivo.PromptText = "Seleccione una opción";
            this.cboOpcionMasivo.Size = new System.Drawing.Size(598, 30);
            this.cboOpcionMasivo.TabIndex = 32;
            this.cboOpcionMasivo.UseSelectable = true;
            this.cboOpcionMasivo.Visible = false;
            this.cboOpcionMasivo.SelectedValueChanged += new System.EventHandler(this.cboOpcionMasivo_SelectedValueChanged);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 87);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(757, 286);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnParticular
            // 
            this.btnParticular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParticular.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnParticular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParticular.ForeColor = System.Drawing.Color.Aqua;
            this.btnParticular.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnParticular.IconColor = System.Drawing.Color.Aqua;
            this.btnParticular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnParticular.IconSize = 55;
            this.btnParticular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnParticular.Location = new System.Drawing.Point(227, 298);
            this.btnParticular.Name = "btnParticular";
            this.btnParticular.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnParticular.Rotation = 0D;
            this.btnParticular.Size = new System.Drawing.Size(172, 117);
            this.btnParticular.TabIndex = 17;
            this.btnParticular.Text = "PARTICULAR";
            this.btnParticular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnParticular.UseVisualStyleBackColor = true;
            this.btnParticular.Click += new System.EventHandler(this.btnParticular_Click);
            // 
            // btnMasivo
            // 
            this.btnMasivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasivo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMasivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasivo.ForeColor = System.Drawing.Color.Aqua;
            this.btnMasivo.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnMasivo.IconColor = System.Drawing.Color.Aqua;
            this.btnMasivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMasivo.IconSize = 70;
            this.btnMasivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMasivo.Location = new System.Drawing.Point(24, 298);
            this.btnMasivo.Name = "btnMasivo";
            this.btnMasivo.Padding = new System.Windows.Forms.Padding(3);
            this.btnMasivo.Rotation = 0D;
            this.btnMasivo.Size = new System.Drawing.Size(172, 117);
            this.btnMasivo.TabIndex = 16;
            this.btnMasivo.Text = "MASIVO";
            this.btnMasivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMasivo.UseVisualStyleBackColor = true;
            this.btnMasivo.Click += new System.EventHandler(this.btnMasivo_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGenerar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnGenerar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGenerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerar.IconSize = 60;
            this.btnGenerar.Location = new System.Drawing.Point(1588, 534);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Rotation = 0D;
            this.btnGenerar.Size = new System.Drawing.Size(239, 76);
            this.btnGenerar.TabIndex = 36;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Visible = false;
            // 
            // panelConceptos
            // 
            this.panelConceptos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelConceptos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelConceptos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConceptos.Controls.Add(this.lblConceptos);
            this.panelConceptos.Controls.Add(this.listConceptos);
            this.panelConceptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelConceptos.HorizontalScrollbarBarColor = true;
            this.panelConceptos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelConceptos.HorizontalScrollbarSize = 10;
            this.panelConceptos.Location = new System.Drawing.Point(1146, 478);
            this.panelConceptos.Name = "panelConceptos";
            this.panelConceptos.Size = new System.Drawing.Size(397, 393);
            this.panelConceptos.TabIndex = 37;
            this.panelConceptos.UseCustomBackColor = true;
            this.panelConceptos.VerticalScrollbarBarColor = true;
            this.panelConceptos.VerticalScrollbarHighlightOnWheel = false;
            this.panelConceptos.VerticalScrollbarSize = 10;
            this.panelConceptos.Visible = false;
            // 
            // lblConceptos
            // 
            this.lblConceptos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConceptos.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblConceptos.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblConceptos.ForeColor = System.Drawing.Color.Aqua;
            this.lblConceptos.Location = new System.Drawing.Point(25, 30);
            this.lblConceptos.Name = "lblConceptos";
            this.lblConceptos.Size = new System.Drawing.Size(345, 44);
            this.lblConceptos.TabIndex = 32;
            this.lblConceptos.Text = "SELECCIONE CONCEPTOS";
            this.lblConceptos.UseCustomBackColor = true;
            this.lblConceptos.UseCustomForeColor = true;
            // 
            // listConceptos
            // 
            this.listConceptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listConceptos.HideSelection = false;
            this.listConceptos.Location = new System.Drawing.Point(25, 87);
            this.listConceptos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listConceptos.Name = "listConceptos";
            this.listConceptos.Size = new System.Drawing.Size(345, 286);
            this.listConceptos.TabIndex = 11;
            this.listConceptos.UseCompatibleStateImageBehavior = false;
            this.listConceptos.View = System.Windows.Forms.View.Details;
            // 
            // btnAplicarIntereses
            // 
            this.btnAplicarIntereses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAplicarIntereses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarIntereses.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAplicarIntereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarIntereses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAplicarIntereses.IconChar = FontAwesome.Sharp.IconChar.Percent;
            this.btnAplicarIntereses.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAplicarIntereses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAplicarIntereses.IconSize = 45;
            this.btnAplicarIntereses.Location = new System.Drawing.Point(1588, 636);
            this.btnAplicarIntereses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAplicarIntereses.Name = "btnAplicarIntereses";
            this.btnAplicarIntereses.Rotation = 0D;
            this.btnAplicarIntereses.Size = new System.Drawing.Size(239, 76);
            this.btnAplicarIntereses.TabIndex = 38;
            this.btnAplicarIntereses.Text = "APLICAR INTERÉS";
            this.btnAplicarIntereses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAplicarIntereses.UseVisualStyleBackColor = true;
            this.btnAplicarIntereses.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnEliminar.IconColor = System.Drawing.Color.Red;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 60;
            this.btnEliminar.Location = new System.Drawing.Point(1588, 745);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Rotation = 0D;
            this.btnEliminar.Size = new System.Drawing.Size(239, 76);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            // 
            // frmCuotasGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1865, 947);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAplicarIntereses);
            this.Controls.Add(this.panelConceptos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.panelGrilla);
            this.Controls.Add(this.panelCbos);
            this.Controls.Add(this.btnParticular);
            this.Controls.Add(this.btnMasivo);
            this.Controls.Add(this.lblAyuda);
            this.Name = "frmCuotasGestionar";
            this.Text = "CUOTAS / GESTIONAR";
            this.panelCbos.ResumeLayout(false);
            this.panelGrilla.ResumeLayout(false);
            this.panelConceptos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblAyuda;
        private FontAwesome.Sharp.IconButton btnMasivo;
        private FontAwesome.Sharp.IconButton btnParticular;
        private MetroFramework.Controls.MetroComboBox cbPeriodo;
        private MetroFramework.Controls.MetroComboBox cbAnoEjercicio;
        private MetroFramework.Controls.MetroComboBox cbSalas;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroPanel panelCbos;
        private MetroFramework.Controls.MetroPanel panelGrilla;
        private System.Windows.Forms.ListView listView1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private FontAwesome.Sharp.IconButton btnGenerar;
        private MetroFramework.Controls.MetroPanel panelConceptos;
        private MetroFramework.Controls.MetroLabel lblConceptos;
        private System.Windows.Forms.ListView listConceptos;
        private FontAwesome.Sharp.IconButton btnAplicarIntereses;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private MetroFramework.Controls.MetroTextBox txtMatriculados;
        private MetroFramework.Controls.MetroComboBox cboOpcionMasivo;
    }
}