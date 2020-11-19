namespace GestionJardin
{
    partial class frmAlumnosGrupoFlia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnosGrupoFlia));
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnGF_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnGF_Editar = new FontAwesome.Sharp.IconButton();
            this.btnGF_Agregar = new FontAwesome.Sharp.IconButton();
            this.dgvGrupoFlia = new System.Windows.Forms.DataGridView();
            this.txtGF_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoFlia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInfo.AutoSize = true;
            this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Location = new System.Drawing.Point(41, 909);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(815, 20);
            this.lblInfo.TabIndex = 31;
            this.lblInfo.Text = "* Para poder editar los datos de un familiar o dar de baja al mismo, debe selecci" +
    "onar el registro previamente";
            this.lblInfo.Visible = false;
            // 
            // btnGF_Eliminar
            // 
            this.btnGF_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGF_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGF_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGF_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGF_Eliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnGF_Eliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGF_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGF_Eliminar.IconSize = 100;
            this.btnGF_Eliminar.Location = new System.Drawing.Point(1320, 722);
            this.btnGF_Eliminar.Name = "btnGF_Eliminar";
            this.btnGF_Eliminar.Size = new System.Drawing.Size(293, 134);
            this.btnGF_Eliminar.TabIndex = 30;
            this.btnGF_Eliminar.Text = "PROCESAR BAJA";
            this.btnGF_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGF_Eliminar.UseVisualStyleBackColor = true;
            this.btnGF_Eliminar.Click += new System.EventHandler(this.btnGF_Eliminar_Click);
            // 
            // btnGF_Editar
            // 
            this.btnGF_Editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGF_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGF_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGF_Editar.ForeColor = System.Drawing.Color.Cyan;
            this.btnGF_Editar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnGF_Editar.IconColor = System.Drawing.Color.Cyan;
            this.btnGF_Editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGF_Editar.IconSize = 100;
            this.btnGF_Editar.Location = new System.Drawing.Point(1320, 565);
            this.btnGF_Editar.Name = "btnGF_Editar";
            this.btnGF_Editar.Size = new System.Drawing.Size(293, 134);
            this.btnGF_Editar.TabIndex = 29;
            this.btnGF_Editar.Text = "MODIFICAR";
            this.btnGF_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGF_Editar.UseVisualStyleBackColor = true;
            this.btnGF_Editar.Click += new System.EventHandler(this.btnGF_Editar_Click);
            // 
            // btnGF_Agregar
            // 
            this.btnGF_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGF_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGF_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGF_Agregar.ForeColor = System.Drawing.Color.Lime;
            this.btnGF_Agregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGF_Agregar.IconColor = System.Drawing.Color.Lime;
            this.btnGF_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGF_Agregar.IconSize = 100;
            this.btnGF_Agregar.Location = new System.Drawing.Point(1320, 408);
            this.btnGF_Agregar.Name = "btnGF_Agregar";
            this.btnGF_Agregar.Size = new System.Drawing.Size(293, 134);
            this.btnGF_Agregar.TabIndex = 28;
            this.btnGF_Agregar.Text = "INGRESAR";
            this.btnGF_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGF_Agregar.UseVisualStyleBackColor = true;
            this.btnGF_Agregar.Click += new System.EventHandler(this.btnGF_Agregar_Click);
            // 
            // dgvGrupoFlia
            // 
            this.dgvGrupoFlia.AllowUserToAddRows = false;
            this.dgvGrupoFlia.AllowUserToDeleteRows = false;
            this.dgvGrupoFlia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvGrupoFlia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGrupoFlia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGrupoFlia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrupoFlia.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrupoFlia.Location = new System.Drawing.Point(45, 393);
            this.dgvGrupoFlia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGrupoFlia.MultiSelect = false;
            this.dgvGrupoFlia.Name = "dgvGrupoFlia";
            this.dgvGrupoFlia.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrupoFlia.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGrupoFlia.RowTemplate.Height = 24;
            this.dgvGrupoFlia.Size = new System.Drawing.Size(1236, 495);
            this.dgvGrupoFlia.TabIndex = 44;
            this.dgvGrupoFlia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupoFlia_CellClick);
            // 
            // txtGF_Buscar
            // 
            this.txtGF_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGF_Buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGF_Buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGF_Buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtGF_Buscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGF_Buscar.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtGF_Buscar.CustomButton.Location = new System.Drawing.Point(376, 2);
            this.txtGF_Buscar.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGF_Buscar.CustomButton.Name = "";
            this.txtGF_Buscar.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtGF_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGF_Buscar.CustomButton.TabIndex = 1;
            this.txtGF_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGF_Buscar.CustomButton.UseSelectable = true;
            this.txtGF_Buscar.CustomButton.UseStyleColors = true;
            this.txtGF_Buscar.CustomButton.UseVisualStyleBackColor = true;
            this.txtGF_Buscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtGF_Buscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtGF_Buscar.Lines = new string[0];
            this.txtGF_Buscar.Location = new System.Drawing.Point(45, 293);
            this.txtGF_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGF_Buscar.MaxLength = 32767;
            this.txtGF_Buscar.Name = "txtGF_Buscar";
            this.txtGF_Buscar.PasswordChar = '\0';
            this.txtGF_Buscar.PromptText = "BUSCAR ALUMNO";
            this.txtGF_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGF_Buscar.SelectedText = "";
            this.txtGF_Buscar.SelectionLength = 0;
            this.txtGF_Buscar.SelectionStart = 0;
            this.txtGF_Buscar.ShortcutsEnabled = true;
            this.txtGF_Buscar.ShowButton = true;
            this.txtGF_Buscar.Size = new System.Drawing.Size(424, 50);
            this.txtGF_Buscar.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGF_Buscar.TabIndex = 45;
            this.txtGF_Buscar.UseSelectable = true;
            this.txtGF_Buscar.WaterMark = "BUSCAR ALUMNO";
            this.txtGF_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGF_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGF_Buscar.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtGF_Buscar_ButtonClick);
            this.txtGF_Buscar.TextChanged += new System.EventHandler(this.txtGF_Buscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Yellow;
            this.lblBuscar.Location = new System.Drawing.Point(501, 309);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(392, 20);
            this.lblBuscar.TabIndex = 57;
            this.lblBuscar.Text = "Busque un alumno para visualizar su grupo familiar";
            // 
            // frmAlumnosGrupoFlia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1660, 947);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtGF_Buscar);
            this.Controls.Add(this.dgvGrupoFlia);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnGF_Eliminar);
            this.Controls.Add(this.btnGF_Editar);
            this.Controls.Add(this.btnGF_Agregar);
            this.Name = "frmAlumnosGrupoFlia";
            this.Text = "ESTUDIANTES / GRUPO FAMILIAR";
            this.Load += new System.EventHandler(this.frmAlumnosGrupoFlia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoFlia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInfo;
        private FontAwesome.Sharp.IconButton btnGF_Eliminar;
        private FontAwesome.Sharp.IconButton btnGF_Editar;
        private FontAwesome.Sharp.IconButton btnGF_Agregar;
        public System.Windows.Forms.DataGridView dgvGrupoFlia;
        private MetroFramework.Controls.MetroTextBox txtGF_Buscar;
        private System.Windows.Forms.Label lblBuscar;
    }
}