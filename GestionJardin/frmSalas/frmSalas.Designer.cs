namespace GestionJardin
{
    partial class frmSalas
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGS_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnGS_Editar = new FontAwesome.Sharp.IconButton();
            this.btnGS_Agregar = new FontAwesome.Sharp.IconButton();
            this.txtGS_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.dgv_Salas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Salas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 701);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "* Para poder editar los datos de una sala o dar de baja la misma, debe selecciona" +
    "r el registro previamente";
            // 
            // btnGS_Eliminar
            // 
            this.btnGS_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGS_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGS_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGS_Eliminar.ForeColor = System.Drawing.Color.Gray;
            this.btnGS_Eliminar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnGS_Eliminar.IconColor = System.Drawing.Color.Gray;
            this.btnGS_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGS_Eliminar.IconSize = 75;
            this.btnGS_Eliminar.Location = new System.Drawing.Point(1343, 525);
            this.btnGS_Eliminar.Name = "btnGS_Eliminar";
            this.btnGS_Eliminar.Size = new System.Drawing.Size(293, 134);
            this.btnGS_Eliminar.TabIndex = 46;
            this.btnGS_Eliminar.Text = "PROCESAR BAJA";
            this.btnGS_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGS_Eliminar.UseVisualStyleBackColor = true;
            this.btnGS_Eliminar.Click += new System.EventHandler(this.btnGS_Eliminar_Click);
            // 
            // btnGS_Editar
            // 
            this.btnGS_Editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGS_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGS_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGS_Editar.ForeColor = System.Drawing.Color.Gray;
            this.btnGS_Editar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGS_Editar.IconColor = System.Drawing.Color.Gray;
            this.btnGS_Editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGS_Editar.IconSize = 75;
            this.btnGS_Editar.Location = new System.Drawing.Point(1343, 367);
            this.btnGS_Editar.Name = "btnGS_Editar";
            this.btnGS_Editar.Size = new System.Drawing.Size(293, 134);
            this.btnGS_Editar.TabIndex = 45;
            this.btnGS_Editar.Text = "MODIFICAR";
            this.btnGS_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGS_Editar.UseVisualStyleBackColor = true;
            this.btnGS_Editar.Click += new System.EventHandler(this.btnGS_Editar_Click);
            // 
            // btnGS_Agregar
            // 
            this.btnGS_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGS_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGS_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGS_Agregar.ForeColor = System.Drawing.Color.Lime;
            this.btnGS_Agregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnGS_Agregar.IconColor = System.Drawing.Color.Lime;
            this.btnGS_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGS_Agregar.IconSize = 75;
            this.btnGS_Agregar.Location = new System.Drawing.Point(1343, 211);
            this.btnGS_Agregar.Name = "btnGS_Agregar";
            this.btnGS_Agregar.Size = new System.Drawing.Size(293, 134);
            this.btnGS_Agregar.TabIndex = 44;
            this.btnGS_Agregar.Text = "AGREGAR";
            this.btnGS_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGS_Agregar.UseVisualStyleBackColor = true;
            this.btnGS_Agregar.Click += new System.EventHandler(this.btnGS_Agregar_Click);
            // 
            // txtGS_Buscar
            // 
            this.txtGS_Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGS_Buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGS_Buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGS_Buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtGS_Buscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGS_Buscar.CustomButton.Image = null;
            this.txtGS_Buscar.CustomButton.Location = new System.Drawing.Point(376, 2);
            this.txtGS_Buscar.CustomButton.Name = "";
            this.txtGS_Buscar.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtGS_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGS_Buscar.CustomButton.TabIndex = 1;
            this.txtGS_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGS_Buscar.CustomButton.UseSelectable = true;
            this.txtGS_Buscar.CustomButton.Visible = false;
            this.txtGS_Buscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtGS_Buscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtGS_Buscar.Lines = new string[0];
            this.txtGS_Buscar.Location = new System.Drawing.Point(58, 79);
            this.txtGS_Buscar.MaxLength = 32767;
            this.txtGS_Buscar.Name = "txtGS_Buscar";
            this.txtGS_Buscar.PasswordChar = '\0';
            this.txtGS_Buscar.PromptText = "BUSCAR SALA";
            this.txtGS_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGS_Buscar.SelectedText = "";
            this.txtGS_Buscar.SelectionLength = 0;
            this.txtGS_Buscar.SelectionStart = 0;
            this.txtGS_Buscar.ShortcutsEnabled = true;
            this.txtGS_Buscar.Size = new System.Drawing.Size(424, 50);
            this.txtGS_Buscar.TabIndex = 43;
            this.txtGS_Buscar.UseSelectable = true;
            this.txtGS_Buscar.WaterMark = "BUSCAR SALA";
            this.txtGS_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGS_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGS_Buscar.TextChanged += new System.EventHandler(this.txtGS_Buscar_TextChanged);
            // 
            // dgv_Salas
            // 
            this.dgv_Salas.AllowUserToAddRows = false;
            this.dgv_Salas.AllowUserToDeleteRows = false;
            this.dgv_Salas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Salas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Salas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Salas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Salas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Salas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Salas.Location = new System.Drawing.Point(58, 187);
            this.dgv_Salas.MultiSelect = false;
            this.dgv_Salas.Name = "dgv_Salas";
            this.dgv_Salas.ReadOnly = true;
            this.dgv_Salas.RowTemplate.Height = 24;
            this.dgv_Salas.Size = new System.Drawing.Size(1175, 487);
            this.dgv_Salas.TabIndex = 51;
            this.dgv_Salas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Salas_CellClick);
            // 
            // frmSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1697, 774);
            this.Controls.Add(this.dgv_Salas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGS_Eliminar);
            this.Controls.Add(this.btnGS_Editar);
            this.Controls.Add(this.btnGS_Agregar);
            this.Controls.Add(this.txtGS_Buscar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmSalas";
            this.ShowInTaskbar = false;
            this.Text = "GESTIÓN SALAS";
            this.Load += new System.EventHandler(this.frmSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Salas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtGS_Buscar;
        private System.Windows.Forms.DataGridView dgv_Salas;
        public FontAwesome.Sharp.IconButton btnGS_Eliminar;
        public FontAwesome.Sharp.IconButton btnGS_Editar;
        public FontAwesome.Sharp.IconButton btnGS_Agregar;
    }
}