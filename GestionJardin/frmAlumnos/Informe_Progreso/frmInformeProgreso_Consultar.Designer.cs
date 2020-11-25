namespace GestionJardin
{
    partial class frmInformeProgreso_Consultar
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
            this.lblInformeEdit = new System.Windows.Forms.Label();
            this.lbl_panelInforme = new System.Windows.Forms.Label();
            this.btnGInf_Editar = new FontAwesome.Sharp.IconButton();
            this.txtGInf_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.dgv_Informe = new System.Windows.Forms.DataGridView();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.lblEdad = new System.Windows.Forms.Label();
            this.cbEdad = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblEtapa = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.cbEtapa = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbTurno = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbSala = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Informe)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInformeEdit
            // 
            this.lblInformeEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInformeEdit.AutoSize = true;
            this.lblInformeEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInformeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformeEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInformeEdit.Location = new System.Drawing.Point(41, 912);
            this.lblInformeEdit.Name = "lblInformeEdit";
            this.lblInformeEdit.Size = new System.Drawing.Size(716, 20);
            this.lblInformeEdit.TabIndex = 50;
            this.lblInformeEdit.Text = "* Para poder redactar o editar un informe de progreso debe seleccionar el registr" +
    "o previamente";
            // 
            // lbl_panelInforme
            // 
            this.lbl_panelInforme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_panelInforme.AutoSize = true;
            this.lbl_panelInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_panelInforme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_panelInforme.Location = new System.Drawing.Point(24, 371);
            this.lbl_panelInforme.Name = "lbl_panelInforme";
            this.lbl_panelInforme.Size = new System.Drawing.Size(431, 20);
            this.lbl_panelInforme.TabIndex = 49;
            this.lbl_panelInforme.Text = "* Por favor, seleccione turno, sala y etapa para continuar";
            // 
            // btnGInf_Editar
            // 
            this.btnGInf_Editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGInf_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGInf_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGInf_Editar.ForeColor = System.Drawing.Color.Yellow;
            this.btnGInf_Editar.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnGInf_Editar.IconColor = System.Drawing.Color.Yellow;
            this.btnGInf_Editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGInf_Editar.IconSize = 100;
            this.btnGInf_Editar.Location = new System.Drawing.Point(1355, 623);
            this.btnGInf_Editar.Name = "btnGInf_Editar";
            this.btnGInf_Editar.Size = new System.Drawing.Size(293, 134);
            this.btnGInf_Editar.TabIndex = 48;
            this.btnGInf_Editar.Text = "IMPRIMIR INFORME";
            this.btnGInf_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGInf_Editar.UseVisualStyleBackColor = true;
            this.btnGInf_Editar.Click += new System.EventHandler(this.btnGInf_Editar_Click);
            // 
            // txtGInf_Buscar
            // 
            this.txtGInf_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGInf_Buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGInf_Buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGInf_Buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtGInf_Buscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGInf_Buscar.CustomButton.Image = null;
            this.txtGInf_Buscar.CustomButton.Location = new System.Drawing.Point(376, 2);
            this.txtGInf_Buscar.CustomButton.Name = "";
            this.txtGInf_Buscar.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtGInf_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGInf_Buscar.CustomButton.TabIndex = 1;
            this.txtGInf_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGInf_Buscar.CustomButton.UseSelectable = true;
            this.txtGInf_Buscar.CustomButton.Visible = false;
            this.txtGInf_Buscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtGInf_Buscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtGInf_Buscar.Lines = new string[0];
            this.txtGInf_Buscar.Location = new System.Drawing.Point(45, 404);
            this.txtGInf_Buscar.MaxLength = 32767;
            this.txtGInf_Buscar.Name = "txtGInf_Buscar";
            this.txtGInf_Buscar.PasswordChar = '\0';
            this.txtGInf_Buscar.PromptText = "BUSCAR ALUMNO";
            this.txtGInf_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGInf_Buscar.SelectedText = "";
            this.txtGInf_Buscar.SelectionLength = 0;
            this.txtGInf_Buscar.SelectionStart = 0;
            this.txtGInf_Buscar.ShortcutsEnabled = true;
            this.txtGInf_Buscar.Size = new System.Drawing.Size(424, 50);
            this.txtGInf_Buscar.TabIndex = 47;
            this.txtGInf_Buscar.UseSelectable = true;
            this.txtGInf_Buscar.WaterMark = "BUSCAR ALUMNO";
            this.txtGInf_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGInf_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dgv_Informe
            // 
            this.dgv_Informe.AllowUserToAddRows = false;
            this.dgv_Informe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Informe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Informe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Informe.Location = new System.Drawing.Point(28, 493);
            this.dgv_Informe.Name = "dgv_Informe";
            this.dgv_Informe.ReadOnly = true;
            this.dgv_Informe.RowTemplate.Height = 24;
            this.dgv_Informe.Size = new System.Drawing.Size(1300, 416);
            this.dgv_Informe.TabIndex = 46;
            this.dgv_Informe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Informe_CellClick);
            this.dgv_Informe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Informe_CellContentClick);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.lblEdad);
            this.metroPanel3.Controls.Add(this.cbEdad);
            this.metroPanel3.Controls.Add(this.metroLabel1);
            this.metroPanel3.Controls.Add(this.lblEtapa);
            this.metroPanel3.Controls.Add(this.lblTurno);
            this.metroPanel3.Controls.Add(this.lblSala);
            this.metroPanel3.Controls.Add(this.cbEtapa);
            this.metroPanel3.Controls.Add(this.metroLabel5);
            this.metroPanel3.Controls.Add(this.cbTurno);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.cbSala);
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(15, 258);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1641, 98);
            this.metroPanel3.TabIndex = 45;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.Color.Red;
            this.lblEdad.Location = new System.Drawing.Point(895, 62);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(46, 17);
            this.lblEdad.TabIndex = 50;
            this.lblEdad.Text = "label4";
            // 
            // cbEdad
            // 
            this.cbEdad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbEdad.FormattingEnabled = true;
            this.cbEdad.ItemHeight = 24;
            this.cbEdad.Items.AddRange(new object[] {
            "1 y 2 AÑOS",
            "3 AÑOS",
            "4 AÑOS",
            "5 AÑOS"});
            this.cbEdad.Location = new System.Drawing.Point(1016, 18);
            this.cbEdad.Name = "cbEdad";
            this.cbEdad.Size = new System.Drawing.Size(185, 30);
            this.cbEdad.Style = MetroFramework.MetroColorStyle.Magenta;
            this.cbEdad.TabIndex = 3;
            this.cbEdad.UseCustomBackColor = true;
            this.cbEdad.UseSelectable = true;
            this.cbEdad.UseStyleColors = true;
            this.cbEdad.Leave += new System.EventHandler(this.cbEdad_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Fuchsia;
            this.metroLabel1.Location = new System.Drawing.Point(888, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(162, 44);
            this.metroLabel1.TabIndex = 49;
            this.metroLabel1.Text = "EDAD:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // lblEtapa
            // 
            this.lblEtapa.AutoSize = true;
            this.lblEtapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtapa.ForeColor = System.Drawing.Color.Red;
            this.lblEtapa.Location = new System.Drawing.Point(1302, 64);
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(46, 17);
            this.lblEtapa.TabIndex = 47;
            this.lblEtapa.Text = "label3";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.ForeColor = System.Drawing.Color.Red;
            this.lblTurno.Location = new System.Drawing.Point(35, 64);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(46, 17);
            this.lblTurno.TabIndex = 45;
            this.lblTurno.Text = "label1";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.ForeColor = System.Drawing.Color.Red;
            this.lblSala.Location = new System.Drawing.Point(475, 64);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(46, 17);
            this.lblSala.TabIndex = 46;
            this.lblSala.Text = "label2";
            // 
            // cbEtapa
            // 
            this.cbEtapa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbEtapa.FormattingEnabled = true;
            this.cbEtapa.ItemHeight = 24;
            this.cbEtapa.Items.AddRange(new object[] {
            "PRIMERA",
            "SEGUNDA"});
            this.cbEtapa.Location = new System.Drawing.Point(1418, 18);
            this.cbEtapa.Name = "cbEtapa";
            this.cbEtapa.Size = new System.Drawing.Size(176, 30);
            this.cbEtapa.Style = MetroFramework.MetroColorStyle.Magenta;
            this.cbEtapa.TabIndex = 4;
            this.cbEtapa.UseCustomBackColor = true;
            this.cbEtapa.UseSelectable = true;
            this.cbEtapa.UseStyleColors = true;
            this.cbEtapa.SelectedValueChanged += new System.EventHandler(this.cbEtapa_SelectedValueChanged);
            this.cbEtapa.Leave += new System.EventHandler(this.cbEtapa_Leave);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.Fuchsia;
            this.metroLabel5.Location = new System.Drawing.Point(1293, 18);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(212, 44);
            this.metroLabel5.TabIndex = 32;
            this.metroLabel5.Text = "ETAPA:";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // cbTurno
            // 
            this.cbTurno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.ItemHeight = 24;
            this.cbTurno.Items.AddRange(new object[] {
            "MAÑANA",
            "TARDE"});
            this.cbTurno.Location = new System.Drawing.Point(175, 18);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(185, 30);
            this.cbTurno.Style = MetroFramework.MetroColorStyle.Magenta;
            this.cbTurno.TabIndex = 1;
            this.cbTurno.UseCustomBackColor = true;
            this.cbTurno.UseSelectable = true;
            this.cbTurno.UseStyleColors = true;
            this.cbTurno.SelectedValueChanged += new System.EventHandler(this.cbTurno_SelectedValueChanged);
            this.cbTurno.TextChanged += new System.EventHandler(this.cbTurno_TextChanged);
            this.cbTurno.Leave += new System.EventHandler(this.cbTurno_Leave);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.Fuchsia;
            this.metroLabel4.Location = new System.Drawing.Point(27, 18);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(163, 44);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "TURNO:";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // cbSala
            // 
            this.cbSala.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSala.Enabled = false;
            this.cbSala.FormattingEnabled = true;
            this.cbSala.ItemHeight = 24;
            this.cbSala.Location = new System.Drawing.Point(597, 18);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(185, 30);
            this.cbSala.Style = MetroFramework.MetroColorStyle.Magenta;
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
            this.metroLabel2.ForeColor = System.Drawing.Color.Fuchsia;
            this.metroLabel2.Location = new System.Drawing.Point(469, 18);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(162, 44);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "SALA:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // frmInformeProgreso_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1660, 947);
            this.Controls.Add(this.lblInformeEdit);
            this.Controls.Add(this.lbl_panelInforme);
            this.Controls.Add(this.btnGInf_Editar);
            this.Controls.Add(this.txtGInf_Buscar);
            this.Controls.Add(this.dgv_Informe);
            this.Controls.Add(this.metroPanel3);
            this.Name = "frmInformeProgreso_Consultar";
            this.Text = "INFORME DE PROGESO / CONSULTAR INFORMES";
            this.Load += new System.EventHandler(this.frmInformeProgreso_Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Informe)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformeEdit;
        private System.Windows.Forms.Label lbl_panelInforme;
        private FontAwesome.Sharp.IconButton btnGInf_Editar;
        private MetroFramework.Controls.MetroTextBox txtGInf_Buscar;
        private System.Windows.Forms.DataGridView dgv_Informe;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.Label lblEdad;
        private MetroFramework.Controls.MetroComboBox cbEdad;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label lblEtapa;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblSala;
        private MetroFramework.Controls.MetroComboBox cbEtapa;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cbTurno;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbSala;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}