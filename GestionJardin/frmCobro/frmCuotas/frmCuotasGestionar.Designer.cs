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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbTurno = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbSala = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lbl_Continuar = new System.Windows.Forms.Label();
            this.txtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.btnCon_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnCargos = new FontAwesome.Sharp.IconButton();
            this.btnGenerar = new FontAwesome.Sharp.IconButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTurno
            // 
            this.cbTurno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.ItemHeight = 23;
            this.cbTurno.Items.AddRange(new object[] {
            "MAÑANA",
            "TARDE"});
            this.cbTurno.Location = new System.Drawing.Point(273, 214);
            this.cbTurno.Margin = new System.Windows.Forms.Padding(2);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(140, 29);
            this.cbTurno.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbTurno.TabIndex = 57;
            this.cbTurno.UseCustomBackColor = true;
            this.cbTurno.UseSelectable = true;
            this.cbTurno.UseStyleColors = true;
            this.cbTurno.SelectedValueChanged += new System.EventHandler(this.cbTurno_SelectedValueChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.Aqua;
            this.metroLabel4.Location = new System.Drawing.Point(162, 214);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(122, 36);
            this.metroLabel4.TabIndex = 60;
            this.metroLabel4.Text = "TURNO:";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // cbSala
            // 
            this.cbSala.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSala.FormattingEnabled = true;
            this.cbSala.ItemHeight = 23;
            this.cbSala.Location = new System.Drawing.Point(590, 214);
            this.cbSala.Margin = new System.Windows.Forms.Padding(2);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(140, 29);
            this.cbSala.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbSala.TabIndex = 58;
            this.cbSala.UseCustomBackColor = true;
            this.cbSala.UseSelectable = true;
            this.cbSala.UseStyleColors = true;
            this.cbSala.SelectedValueChanged += new System.EventHandler(this.cbSala_SelectedValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Aqua;
            this.metroLabel2.Location = new System.Drawing.Point(494, 214);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(122, 36);
            this.metroLabel2.TabIndex = 59;
            this.metroLabel2.Text = "SALA:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // lbl_Continuar
            // 
            this.lbl_Continuar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Continuar.AutoSize = true;
            this.lbl_Continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Continuar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Continuar.Location = new System.Drawing.Point(15, 268);
            this.lbl_Continuar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Continuar.Name = "lbl_Continuar";
            this.lbl_Continuar.Size = new System.Drawing.Size(368, 17);
            this.lbl_Continuar.TabIndex = 62;
            this.lbl_Continuar.Text = "* Por favor, seleccione turno, sala y etapa para continuar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtBuscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.CustomButton.Image = null;
            this.txtBuscar.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.txtBuscar.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.CustomButton.Name = "";
            this.txtBuscar.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscar.CustomButton.TabIndex = 1;
            this.txtBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscar.CustomButton.UseSelectable = true;
            this.txtBuscar.CustomButton.Visible = false;
            this.txtBuscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBuscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtBuscar.Lines = new string[0];
            this.txtBuscar.Location = new System.Drawing.Point(18, 288);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PromptText = "BUSCAR ALUMNO";
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(318, 41);
            this.txtBuscar.TabIndex = 61;
            this.txtBuscar.UseSelectable = true;
            this.txtBuscar.Visible = false;
            this.txtBuscar.WaterMark = "BUSCAR ALUMNO";
            this.txtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCon_Eliminar
            // 
            this.btnCon_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCon_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCon_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCon_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCon_Eliminar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCon_Eliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCon_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCon_Eliminar.IconSize = 85;
            this.btnCon_Eliminar.Location = new System.Drawing.Point(1049, 538);
            this.btnCon_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCon_Eliminar.Name = "btnCon_Eliminar";
            this.btnCon_Eliminar.Size = new System.Drawing.Size(220, 109);
            this.btnCon_Eliminar.TabIndex = 67;
            this.btnCon_Eliminar.Text = "ANULAR CUOTA";
            this.btnCon_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCon_Eliminar.UseVisualStyleBackColor = true;
            this.btnCon_Eliminar.Visible = false;
            this.btnCon_Eliminar.Click += new System.EventHandler(this.btnCon_Eliminar_Click);
            // 
            // btnCargos
            // 
            this.btnCargos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargos.ForeColor = System.Drawing.Color.Cyan;
            this.btnCargos.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCargos.IconColor = System.Drawing.Color.Cyan;
            this.btnCargos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargos.IconSize = 85;
            this.btnCargos.Location = new System.Drawing.Point(1049, 425);
            this.btnCargos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(220, 109);
            this.btnCargos.TabIndex = 66;
            this.btnCargos.Text = "APLICAR CARGOS";
            this.btnCargos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargos.UseVisualStyleBackColor = true;
            this.btnCargos.Visible = false;
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.Lime;
            this.btnGenerar.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.btnGenerar.IconColor = System.Drawing.Color.Lime;
            this.btnGenerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerar.IconSize = 85;
            this.btnGenerar.Location = new System.Drawing.Point(1049, 312);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(220, 109);
            this.btnGenerar.TabIndex = 65;
            this.btnGenerar.Text = "GENERAR CUOTA";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Visible = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInfo.Location = new System.Drawing.Point(15, 754);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(567, 17);
            this.lblInfo.TabIndex = 64;
            this.lblInfo.Text = "* Para aplicar otros cargos y/o eliminar la cuota debe seleccionar el registro pr" +
    "eviamente";
            this.lblInfo.Visible = false;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnos.Location = new System.Drawing.Point(18, 350);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAlumnos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlumnos.RowTemplate.Height = 24;
            this.dgvAlumnos.Size = new System.Drawing.Size(1003, 402);
            this.dgvAlumnos.TabIndex = 63;
            this.dgvAlumnos.Visible = false;
            // 
            // frmCuotasGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1317, 631);
            this.Controls.Add(this.btnCon_Eliminar);
            this.Controls.Add(this.btnCargos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.lbl_Continuar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbTurno);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.metroLabel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCuotasGestionar";
            this.Text = "CUOTAS / GESTIONAR";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbTurno;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbSala;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label lbl_Continuar;
        private MetroFramework.Controls.MetroTextBox txtBuscar;
        private FontAwesome.Sharp.IconButton btnCon_Eliminar;
        private FontAwesome.Sharp.IconButton btnCargos;
        private FontAwesome.Sharp.IconButton btnGenerar;
        private System.Windows.Forms.Label lblInfo;
        public System.Windows.Forms.DataGridView dgvAlumnos;
    }
}