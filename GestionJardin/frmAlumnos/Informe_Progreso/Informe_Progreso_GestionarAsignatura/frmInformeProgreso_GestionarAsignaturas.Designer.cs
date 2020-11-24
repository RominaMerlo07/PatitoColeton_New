namespace GestionJardin
{
    partial class frmInformeProgreso_AgregarMateria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAsignatura = new System.Windows.Forms.DataGridView();
            this.lblInfoAsignatura = new System.Windows.Forms.Label();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.lblSala = new System.Windows.Forms.Label();
            this.cbSala = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lbl_panelInforme = new System.Windows.Forms.Label();
            this.btn_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btn_Editar = new FontAwesome.Sharp.IconButton();
            this.btn_Agregar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignatura)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAsignatura
            // 
            this.dgvAsignatura.AllowUserToAddRows = false;
            this.dgvAsignatura.AllowUserToDeleteRows = false;
            this.dgvAsignatura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvAsignatura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAsignatura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsignatura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAsignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsignatura.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAsignatura.Location = new System.Drawing.Point(36, 379);
            this.dgvAsignatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAsignatura.MultiSelect = false;
            this.dgvAsignatura.Name = "dgvAsignatura";
            this.dgvAsignatura.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsignatura.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAsignatura.RowTemplate.Height = 24;
            this.dgvAsignatura.Size = new System.Drawing.Size(1252, 495);
            this.dgvAsignatura.TabIndex = 49;
            this.dgvAsignatura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsignatura_CellClick);
            // 
            // lblInfoAsignatura
            // 
            this.lblInfoAsignatura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInfoAsignatura.AutoSize = true;
            this.lblInfoAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfoAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoAsignatura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfoAsignatura.Location = new System.Drawing.Point(32, 894);
            this.lblInfoAsignatura.Name = "lblInfoAsignatura";
            this.lblInfoAsignatura.Size = new System.Drawing.Size(926, 20);
            this.lblInfoAsignatura.TabIndex = 47;
            this.lblInfoAsignatura.Text = "* Para poder editar los datos de un criterio de aprendizaje o dar de baja el mism" +
    "o, debe seleccionar el registro previamente";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.lblSala);
            this.metroPanel3.Controls.Add(this.cbSala);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(36, 259);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(331, 98);
            this.metroPanel3.TabIndex = 0;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.ForeColor = System.Drawing.Color.Red;
            this.lblSala.Location = new System.Drawing.Point(7, 60);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(46, 17);
            this.lblSala.TabIndex = 46;
            this.lblSala.Text = "label2";
            // 
            // cbSala
            // 
            this.cbSala.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSala.FormattingEnabled = true;
            this.cbSala.ItemHeight = 24;
            this.cbSala.Items.AddRange(new object[] {
            "1 y 2 AÑOS",
            "3 AÑOS",
            "4 AÑOS",
            "5 AÑOS"});
            this.cbSala.Location = new System.Drawing.Point(125, 16);
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
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Fuchsia;
            this.metroLabel3.Location = new System.Drawing.Point(3, 16);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(162, 44);
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "EDAD:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // lbl_panelInforme
            // 
            this.lbl_panelInforme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_panelInforme.AutoSize = true;
            this.lbl_panelInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_panelInforme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_panelInforme.Location = new System.Drawing.Point(43, 379);
            this.lbl_panelInforme.Name = "lbl_panelInforme";
            this.lbl_panelInforme.Size = new System.Drawing.Size(772, 20);
            this.lbl_panelInforme.TabIndex = 55;
            this.lbl_panelInforme.Text = "* Por favor, seleccione una edad del nivel inicial para agregar y/o modificar los" +
    " criterios de aprendizaje";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Eliminar.IconChar = FontAwesome.Sharp.IconChar.FolderMinus;
            this.btn_Eliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Eliminar.IconSize = 100;
            this.btn_Eliminar.Location = new System.Drawing.Point(1311, 707);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(293, 134);
            this.btn_Eliminar.TabIndex = 46;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Editar.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btn_Editar.IconColor = System.Drawing.Color.Cyan;
            this.btn_Editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Editar.IconSize = 100;
            this.btn_Editar.Location = new System.Drawing.Point(1311, 551);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(293, 134);
            this.btn_Editar.TabIndex = 45;
            this.btn_Editar.Text = "EDITAR";
            this.btn_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.Lime;
            this.btn_Agregar.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.btn_Agregar.IconColor = System.Drawing.Color.Lime;
            this.btn_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Agregar.IconSize = 100;
            this.btn_Agregar.Location = new System.Drawing.Point(1311, 393);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(293, 134);
            this.btn_Agregar.TabIndex = 44;
            this.btn_Agregar.Text = "AGREGAR";
            this.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // frmInformeProgreso_AgregarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1660, 947);
            this.Controls.Add(this.lbl_panelInforme);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.dgvAsignatura);
            this.Controls.Add(this.lblInfoAsignatura);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Agregar);
            this.Name = "frmInformeProgreso_AgregarMateria";
            this.Text = "INFORME DE PROGRESO / GEST. CRITERIO APRENDIZAJE";
            this.Load += new System.EventHandler(this.frmInformeProgreso_AgregarMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignatura)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvAsignatura;
        private System.Windows.Forms.Label lblInfoAsignatura;
        private FontAwesome.Sharp.IconButton btn_Eliminar;
        private FontAwesome.Sharp.IconButton btn_Editar;
        private FontAwesome.Sharp.IconButton btn_Agregar;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.Label lblSala;
        private MetroFramework.Controls.MetroComboBox cbSala;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label lbl_panelInforme;
    }
}