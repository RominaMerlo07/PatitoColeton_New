namespace GestionJardin
{
    partial class frmAsistencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.labelFechError = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblFecha = new MetroFramework.Controls.MetroLabel();
            this.cbTurno = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.calFecha = new System.Windows.Forms.MonthCalendar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbSala = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dgv_Alumnos = new System.Windows.Forms.DataGridView();
            this.txtGAs_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.lblJustificado = new System.Windows.Forms.Label();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.cboJustificado = new MetroFramework.Controls.MetroComboBox();
            this.cboAsistencia = new MetroFramework.Controls.MetroComboBox();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.lbl_ErrorAsistencia = new System.Windows.Forms.Label();
            this.lblErrorJustificado = new System.Windows.Forms.Label();
            this.lblAusencias = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btn_Informe = new FontAwesome.Sharp.IconPictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Informe)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.labelFechError);
            this.metroPanel3.Controls.Add(this.lblSala);
            this.metroPanel3.Controls.Add(this.lblTurno);
            this.metroPanel3.Controls.Add(this.lblFecha);
            this.metroPanel3.Controls.Add(this.cbTurno);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.calFecha);
            this.metroPanel3.Controls.Add(this.metroLabel1);
            this.metroPanel3.Controls.Add(this.cbSala);
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(30, 280);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(473, 675);
            this.metroPanel3.TabIndex = 1;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // labelFechError
            // 
            this.labelFechError.AutoSize = true;
            this.labelFechError.ForeColor = System.Drawing.Color.Red;
            this.labelFechError.Location = new System.Drawing.Point(49, 586);
            this.labelFechError.Name = "labelFechError";
            this.labelFechError.Size = new System.Drawing.Size(53, 20);
            this.labelFechError.TabIndex = 35;
            this.labelFechError.Text = "label1";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.ForeColor = System.Drawing.Color.Red;
            this.lblSala.Location = new System.Drawing.Point(49, 221);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(53, 20);
            this.lblSala.TabIndex = 34;
            this.lblSala.Text = "label1";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.ForeColor = System.Drawing.Color.Red;
            this.lblTurno.Location = new System.Drawing.Point(49, 136);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(53, 20);
            this.lblTurno.TabIndex = 33;
            this.lblTurno.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFecha.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblFecha.ForeColor = System.Drawing.Color.Aqua;
            this.lblFecha.Location = new System.Drawing.Point(49, 606);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(341, 32);
            this.lblFecha.TabIndex = 32;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFecha.UseCustomBackColor = true;
            this.lblFecha.UseCustomForeColor = true;
            // 
            // cbTurno
            // 
            this.cbTurno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.ItemHeight = 24;
            this.cbTurno.Items.AddRange(new object[] {
            "MAÑANA",
            "TARDE"});
            this.cbTurno.Location = new System.Drawing.Point(232, 82);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(185, 30);
            this.cbTurno.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbTurno.TabIndex = 1;
            this.cbTurno.UseCustomBackColor = true;
            this.cbTurno.UseSelectable = true;
            this.cbTurno.UseStyleColors = true;
            this.cbTurno.SelectedValueChanged += new System.EventHandler(this.cbTurno_SelectedValueChanged);
            this.cbTurno.Leave += new System.EventHandler(this.cbTurno_Leave);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.Aqua;
            this.metroLabel4.Location = new System.Drawing.Point(49, 82);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(163, 44);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "TURNO";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // calFecha
            // 
            this.calFecha.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.calFecha.Location = new System.Drawing.Point(72, 319);
            this.calFecha.Name = "calFecha";
            this.calFecha.TabIndex = 3;
            this.calFecha.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.calFecha.Leave += new System.EventHandler(this.calFecha_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Aqua;
            this.metroLabel1.Location = new System.Drawing.Point(148, 253);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(144, 44);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "FECHA:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // cbSala
            // 
            this.cbSala.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSala.Enabled = false;
            this.cbSala.FormattingEnabled = true;
            this.cbSala.ItemHeight = 24;
            this.cbSala.Location = new System.Drawing.Point(232, 168);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(185, 30);
            this.cbSala.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbSala.TabIndex = 2;
            this.cbSala.UseCustomBackColor = true;
            this.cbSala.UseSelectable = true;
            this.cbSala.UseStyleColors = true;
            this.cbSala.SelectedValueChanged += new System.EventHandler(this.cbSala_SelectedValueChanged);
            this.cbSala.Leave += new System.EventHandler(this.cbSala_Leave);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Aqua;
            this.metroLabel2.Location = new System.Drawing.Point(49, 168);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(212, 44);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "SALA";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Aqua;
            this.metroLabel3.Location = new System.Drawing.Point(123, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(294, 44);
            this.metroLabel3.TabIndex = 27;
            this.metroLabel3.Text = "SELECCIONE";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // dgv_Alumnos
            // 
            this.dgv_Alumnos.AllowUserToAddRows = false;
            this.dgv_Alumnos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Alumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Alumnos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgv_Alumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Alumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Alumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Alumnos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Alumnos.Location = new System.Drawing.Point(593, 417);
            this.dgv_Alumnos.Name = "dgv_Alumnos";
            this.dgv_Alumnos.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Alumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Alumnos.RowTemplate.Height = 24;
            this.dgv_Alumnos.Size = new System.Drawing.Size(1181, 416);
            this.dgv_Alumnos.TabIndex = 2;
            this.dgv_Alumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Alumnos_CellClick);
            // 
            // txtGAs_Buscar
            // 
            this.txtGAs_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGAs_Buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGAs_Buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGAs_Buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtGAs_Buscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGAs_Buscar.CustomButton.Image = null;
            this.txtGAs_Buscar.CustomButton.Location = new System.Drawing.Point(376, 2);
            this.txtGAs_Buscar.CustomButton.Name = "";
            this.txtGAs_Buscar.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtGAs_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGAs_Buscar.CustomButton.TabIndex = 1;
            this.txtGAs_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGAs_Buscar.CustomButton.UseSelectable = true;
            this.txtGAs_Buscar.CustomButton.Visible = false;
            this.txtGAs_Buscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtGAs_Buscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtGAs_Buscar.Lines = new string[0];
            this.txtGAs_Buscar.Location = new System.Drawing.Point(593, 294);
            this.txtGAs_Buscar.MaxLength = 32767;
            this.txtGAs_Buscar.Name = "txtGAs_Buscar";
            this.txtGAs_Buscar.PasswordChar = '\0';
            this.txtGAs_Buscar.PromptText = "BUSCAR ALUMNO";
            this.txtGAs_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGAs_Buscar.SelectedText = "";
            this.txtGAs_Buscar.SelectionLength = 0;
            this.txtGAs_Buscar.SelectionStart = 0;
            this.txtGAs_Buscar.ShortcutsEnabled = true;
            this.txtGAs_Buscar.Size = new System.Drawing.Size(424, 50);
            this.txtGAs_Buscar.TabIndex = 27;
            this.txtGAs_Buscar.UseSelectable = true;
            this.txtGAs_Buscar.WaterMark = "BUSCAR ALUMNO";
            this.txtGAs_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGAs_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGAs_Buscar.TextChanged += new System.EventHandler(this.txtGAs_Buscar_TextChanged);
            // 
            // lblJustificado
            // 
            this.lblJustificado.AutoSize = true;
            this.lblJustificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJustificado.ForeColor = System.Drawing.Color.Aqua;
            this.lblJustificado.Location = new System.Drawing.Point(1455, 228);
            this.lblJustificado.Name = "lblJustificado";
            this.lblJustificado.Size = new System.Drawing.Size(129, 20);
            this.lblJustificado.TabIndex = 31;
            this.lblJustificado.Text = "JUSTIFICADO";
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.ForeColor = System.Drawing.Color.Aqua;
            this.lblAsistencia.Location = new System.Drawing.Point(1219, 228);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(116, 20);
            this.lblAsistencia.TabIndex = 32;
            this.lblAsistencia.Text = "ASISTENCIA";
            // 
            // cboJustificado
            // 
            this.cboJustificado.FormattingEnabled = true;
            this.cboJustificado.ItemHeight = 24;
            this.cboJustificado.Items.AddRange(new object[] {
            "JUSTIFICADO",
            "INJUSTIFICADO"});
            this.cboJustificado.Location = new System.Drawing.Point(1435, 261);
            this.cboJustificado.Name = "cboJustificado";
            this.cboJustificado.PromptText = "SELECCIONE";
            this.cboJustificado.Size = new System.Drawing.Size(209, 30);
            this.cboJustificado.Style = MetroFramework.MetroColorStyle.Blue;
            this.cboJustificado.TabIndex = 36;
            this.cboJustificado.UseSelectable = true;
            this.cboJustificado.Leave += new System.EventHandler(this.cboJustificado_Leave);
            // 
            // cboAsistencia
            // 
            this.cboAsistencia.FormattingEnabled = true;
            this.cboAsistencia.ItemHeight = 24;
            this.cboAsistencia.Items.AddRange(new object[] {
            "PRESENTE",
            "AUSENTE"});
            this.cboAsistencia.Location = new System.Drawing.Point(1195, 261);
            this.cboAsistencia.Name = "cboAsistencia";
            this.cboAsistencia.PromptText = "SELECCIONE";
            this.cboAsistencia.Size = new System.Drawing.Size(209, 30);
            this.cboAsistencia.Style = MetroFramework.MetroColorStyle.Blue;
            this.cboAsistencia.TabIndex = 35;
            this.cboAsistencia.UseSelectable = true;
            this.cboAsistencia.SelectedValueChanged += new System.EventHandler(this.cboAsistencia_SelectedValueChanged);
            this.cboAsistencia.Leave += new System.EventHandler(this.cboAsistencia_Leave);
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
            this.btncancelar.Location = new System.Drawing.Point(1470, 900);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Rotation = 0D;
            this.btncancelar.Size = new System.Drawing.Size(239, 76);
            this.btncancelar.TabIndex = 38;
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
            this.btnguardar.Location = new System.Drawing.Point(1171, 900);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Rotation = 0D;
            this.btnguardar.Size = new System.Drawing.Size(239, 76);
            this.btnguardar.TabIndex = 37;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // lbl_ErrorAsistencia
            // 
            this.lbl_ErrorAsistencia.AutoSize = true;
            this.lbl_ErrorAsistencia.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorAsistencia.Location = new System.Drawing.Point(1192, 311);
            this.lbl_ErrorAsistencia.Name = "lbl_ErrorAsistencia";
            this.lbl_ErrorAsistencia.Size = new System.Drawing.Size(46, 17);
            this.lbl_ErrorAsistencia.TabIndex = 39;
            this.lbl_ErrorAsistencia.Text = "label1";
            this.lbl_ErrorAsistencia.Visible = false;
            // 
            // lblErrorJustificado
            // 
            this.lblErrorJustificado.AutoSize = true;
            this.lblErrorJustificado.ForeColor = System.Drawing.Color.Red;
            this.lblErrorJustificado.Location = new System.Drawing.Point(1432, 311);
            this.lblErrorJustificado.Name = "lblErrorJustificado";
            this.lblErrorJustificado.Size = new System.Drawing.Size(46, 17);
            this.lblErrorJustificado.TabIndex = 40;
            this.lblErrorJustificado.Text = "label1";
            this.lblErrorJustificado.Visible = false;
            // 
            // lblAusencias
            // 
            this.lblAusencias.AutoSize = true;
            this.lblAusencias.ForeColor = System.Drawing.Color.Cyan;
            this.lblAusencias.Location = new System.Drawing.Point(590, 820);
            this.lblAusencias.Name = "lblAusencias";
            this.lblAusencias.Size = new System.Drawing.Size(46, 17);
            this.lblAusencias.TabIndex = 41;
            this.lblAusencias.Text = "label1";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(590, 347);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(554, 17);
            this.lblInfo.TabIndex = 43;
            this.lblInfo.Text = "Para registrar o modificar las asistencias debe seleccionar el/los registros prev" +
    "iamente";
            // 
            // btn_Informe
            // 
            this.btn_Informe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Informe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btn_Informe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_Informe.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Informe.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btn_Informe.IconColor = System.Drawing.Color.Yellow;
            this.btn_Informe.IconSize = 81;
            this.btn_Informe.Location = new System.Drawing.Point(1643, 263);
            this.btn_Informe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Informe.Name = "btn_Informe";
            this.btn_Informe.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Informe.Size = new System.Drawing.Size(91, 81);
            this.btn_Informe.TabIndex = 54;
            this.btn_Informe.TabStop = false;
            this.btn_Informe.Click += new System.EventHandler(this.btn_Informe_Click);
            // 
            // frmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1781, 1042);
            this.Controls.Add(this.btn_Informe);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblAusencias);
            this.Controls.Add(this.lblErrorJustificado);
            this.Controls.Add(this.lbl_ErrorAsistencia);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.cboAsistencia);
            this.Controls.Add(this.cboJustificado);
            this.Controls.Add(this.lblAsistencia);
            this.Controls.Add(this.lblJustificado);
            this.Controls.Add(this.txtGAs_Buscar);
            this.Controls.Add(this.dgv_Alumnos);
            this.Controls.Add(this.metroPanel3);
            this.Name = "frmAsistencia";
            this.Text = "ASISTENCIAS / GESTIONAR ASISTENCIAS";
            this.Load += new System.EventHandler(this.frmAsistencia_Load);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Informe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.DataGridView dgv_Alumnos;
        private System.Windows.Forms.MonthCalendar calFecha;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbSala;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbTurno;
        private MetroFramework.Controls.MetroTextBox txtGAs_Buscar;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label labelFechError;
        private MetroFramework.Controls.MetroLabel lblFecha;
        private System.Windows.Forms.Label lblJustificado;
        private System.Windows.Forms.Label lblAsistencia;
        private MetroFramework.Controls.MetroComboBox cboJustificado;
        private MetroFramework.Controls.MetroComboBox cboAsistencia;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.Label lbl_ErrorAsistencia;
        private System.Windows.Forms.Label lblErrorJustificado;
        private System.Windows.Forms.Label lblAusencias;
        private System.Windows.Forms.Label lblInfo;
        private FontAwesome.Sharp.IconPictureBox btn_Informe;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}