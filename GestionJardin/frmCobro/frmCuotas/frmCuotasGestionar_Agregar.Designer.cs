namespace GestionJardin
{
    partial class frmCuotasGestionar_Agregar
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvCargos = new System.Windows.Forms.DataGridView();
            this.lbHorasExtras = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtCantHsEx = new MetroFramework.Controls.MetroTextBox();
            this.cbCargos = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.txt_importe_sala = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblCargos = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.listConceptos = new System.Windows.Forms.ListView();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txt_fecha_venc = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.txt_fecha_venc);
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.dgvCargos);
            this.metroPanel1.Controls.Add(this.lbHorasExtras);
            this.metroPanel1.Controls.Add(this.iconButton1);
            this.metroPanel1.Controls.Add(this.txtCantHsEx);
            this.metroPanel1.Controls.Add(this.cbCargos);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.txtTotal);
            this.metroPanel1.Controls.Add(this.txt_importe_sala);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.lblCargos);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(22, 28);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(891, 397);
            this.metroPanel1.TabIndex = 26;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvCargos
            // 
            this.dgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargos.Location = new System.Drawing.Point(23, 246);
            this.dgvCargos.Name = "dgvCargos";
            this.dgvCargos.Size = new System.Drawing.Size(451, 130);
            this.dgvCargos.TabIndex = 57;
            // 
            // lbHorasExtras
            // 
            this.lbHorasExtras.AutoSize = true;
            this.lbHorasExtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbHorasExtras.Location = new System.Drawing.Point(200, 182);
            this.lbHorasExtras.Name = "lbHorasExtras";
            this.lbHorasExtras.Size = new System.Drawing.Size(153, 17);
            this.lbHorasExtras.TabIndex = 56;
            this.lbHorasExtras.Text = "Cantidad Horas Extras:";
            this.lbHorasExtras.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(399, 182);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 58);
            this.iconButton1.TabIndex = 55;
            this.iconButton1.Text = "APLICAR";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtCantHsEx
            // 
            // 
            // 
            // 
            this.txtCantHsEx.CustomButton.Image = null;
            this.txtCantHsEx.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.txtCantHsEx.CustomButton.Name = "";
            this.txtCantHsEx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCantHsEx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantHsEx.CustomButton.TabIndex = 1;
            this.txtCantHsEx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantHsEx.CustomButton.UseSelectable = true;
            this.txtCantHsEx.CustomButton.Visible = false;
            this.txtCantHsEx.Lines = new string[0];
            this.txtCantHsEx.Location = new System.Drawing.Point(353, 182);
            this.txtCantHsEx.MaxLength = 32767;
            this.txtCantHsEx.Name = "txtCantHsEx";
            this.txtCantHsEx.PasswordChar = '\0';
            this.txtCantHsEx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantHsEx.SelectedText = "";
            this.txtCantHsEx.SelectionLength = 0;
            this.txtCantHsEx.SelectionStart = 0;
            this.txtCantHsEx.ShortcutsEnabled = true;
            this.txtCantHsEx.Size = new System.Drawing.Size(40, 23);
            this.txtCantHsEx.TabIndex = 54;
            this.txtCantHsEx.UseSelectable = true;
            this.txtCantHsEx.Visible = false;
            this.txtCantHsEx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantHsEx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbCargos
            // 
            this.cbCargos.FormattingEnabled = true;
            this.cbCargos.ItemHeight = 23;
            this.cbCargos.Items.AddRange(new object[] {
            "HORAS EXTRAS",
            "MATERIAL DIDACTICO"});
            this.cbCargos.Location = new System.Drawing.Point(23, 182);
            this.cbCargos.Name = "cbCargos";
            this.cbCargos.Size = new System.Drawing.Size(144, 29);
            this.cbCargos.TabIndex = 53;
            this.cbCargos.UseSelectable = true;
            this.cbCargos.SelectedValueChanged += new System.EventHandler(this.cbCargos_SelectedValueChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.Color.Yellow;
            this.metroLabel6.Location = new System.Drawing.Point(589, 340);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(105, 36);
            this.metroLabel6.TabIndex = 52;
            this.metroLabel6.Text = "TOTAL:";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // txtTotal
            // 
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(69, 2);
            this.txtTotal.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTotal.Lines = new string[] {
        "$"};
            this.txtTotal.Location = new System.Drawing.Point(757, 340);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(95, 28);
            this.txtTotal.TabIndex = 51;
            this.txtTotal.Text = "$";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.UseSelectable = true;
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_importe_sala
            // 
            // 
            // 
            // 
            this.txt_importe_sala.CustomButton.Image = null;
            this.txt_importe_sala.CustomButton.Location = new System.Drawing.Point(69, 2);
            this.txt_importe_sala.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_importe_sala.CustomButton.Name = "";
            this.txt_importe_sala.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_importe_sala.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_importe_sala.CustomButton.TabIndex = 1;
            this.txt_importe_sala.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_importe_sala.CustomButton.UseSelectable = true;
            this.txt_importe_sala.CustomButton.Visible = false;
            this.txt_importe_sala.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_importe_sala.Lines = new string[0];
            this.txt_importe_sala.Location = new System.Drawing.Point(239, 97);
            this.txt_importe_sala.Margin = new System.Windows.Forms.Padding(2);
            this.txt_importe_sala.MaxLength = 32767;
            this.txt_importe_sala.Name = "txt_importe_sala";
            this.txt_importe_sala.PasswordChar = '\0';
            this.txt_importe_sala.ReadOnly = true;
            this.txt_importe_sala.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_importe_sala.SelectedText = "";
            this.txt_importe_sala.SelectionLength = 0;
            this.txt_importe_sala.SelectionStart = 0;
            this.txt_importe_sala.ShortcutsEnabled = true;
            this.txt_importe_sala.Size = new System.Drawing.Size(95, 28);
            this.txt_importe_sala.TabIndex = 50;
            this.txt_importe_sala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_importe_sala.UseSelectable = true;
            this.txt_importe_sala.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_importe_sala.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.SpringGreen;
            this.metroLabel3.Location = new System.Drawing.Point(23, 97);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(180, 36);
            this.metroLabel3.TabIndex = 49;
            this.metroLabel3.Text = "IMPORTE CUOTA SALA:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Checked = false;
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(232, 453);
            this.metroDateTime1.Margin = new System.Windows.Forms.Padding(2);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(144, 29);
            this.metroDateTime1.TabIndex = 48;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.SpringGreen;
            this.metroLabel5.Location = new System.Drawing.Point(442, 99);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(237, 36);
            this.metroLabel5.TabIndex = 47;
            this.metroLabel5.Text = "FECHA VENCIMIENTO:";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.SpringGreen;
            this.metroLabel2.Location = new System.Drawing.Point(23, 54);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(829, 36);
            this.metroLabel2.TabIndex = 39;
            this.metroLabel2.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------------";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // lblCargos
            // 
            this.lblCargos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCargos.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCargos.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblCargos.Location = new System.Drawing.Point(23, 18);
            this.lblCargos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargos.Name = "lblCargos";
            this.lblCargos.Size = new System.Drawing.Size(850, 36);
            this.lblCargos.TabIndex = 38;
            this.lblCargos.Text = "CUOTA N°: - del ALUMNO: \"\" , DNI: \"\"";
            this.lblCargos.UseCustomBackColor = true;
            this.lblCargos.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Aqua;
            this.metroLabel1.Location = new System.Drawing.Point(23, 162);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(259, 36);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "SELECCIONE CONCEPTOS";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // listConceptos
            // 
            this.listConceptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listConceptos.HideSelection = false;
            this.listConceptos.Location = new System.Drawing.Point(22, 453);
            this.listConceptos.Margin = new System.Windows.Forms.Padding(2);
            this.listConceptos.Name = "listConceptos";
            this.listConceptos.Size = new System.Drawing.Size(189, 66);
            this.listConceptos.TabIndex = 11;
            this.listConceptos.UseCompatibleStateImageBehavior = false;
            this.listConceptos.View = System.Windows.Forms.View.Details;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnCancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 60;
            this.btnCancelar.Location = new System.Drawing.Point(734, 474);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(179, 62);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnGuardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 60;
            this.btnGuardar.Location = new System.Drawing.Point(466, 474);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(179, 62);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "GENERAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txt_fecha_venc
            // 
            // 
            // 
            // 
            this.txt_fecha_venc.CustomButton.Image = null;
            this.txt_fecha_venc.CustomButton.Location = new System.Drawing.Point(132, 2);
            this.txt_fecha_venc.CustomButton.Name = "";
            this.txt_fecha_venc.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_fecha_venc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_fecha_venc.CustomButton.TabIndex = 1;
            this.txt_fecha_venc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_fecha_venc.CustomButton.UseSelectable = true;
            this.txt_fecha_venc.CustomButton.Visible = false;
            this.txt_fecha_venc.Lines = new string[0];
            this.txt_fecha_venc.Location = new System.Drawing.Point(615, 97);
            this.txt_fecha_venc.MaxLength = 32767;
            this.txt_fecha_venc.Name = "txt_fecha_venc";
            this.txt_fecha_venc.PasswordChar = '\0';
            this.txt_fecha_venc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_fecha_venc.SelectedText = "";
            this.txt_fecha_venc.SelectionLength = 0;
            this.txt_fecha_venc.SelectionStart = 0;
            this.txt_fecha_venc.ShortcutsEnabled = true;
            this.txt_fecha_venc.Size = new System.Drawing.Size(154, 24);
            this.txt_fecha_venc.TabIndex = 59;
            this.txt_fecha_venc.UseSelectable = true;
            this.txt_fecha_venc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_fecha_venc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmCuotasGestionar_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(934, 556);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.listConceptos);
            this.Controls.Add(this.metroDateTime1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCuotasGestionar_Agregar";
            this.Load += new System.EventHandler(this.frmCuotasGestionar_Agregar_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListView listConceptos;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private MetroFramework.Controls.MetroLabel lblCargos;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_importe_sala;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        private FontAwesome.Sharp.IconButton iconButton1;
        private MetroFramework.Controls.MetroTextBox txtCantHsEx;
        private MetroFramework.Controls.MetroComboBox cbCargos;
        private System.Windows.Forms.Label lbHorasExtras;
        private System.Windows.Forms.DataGridView dgvCargos;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox txt_fecha_venc;
    }
}