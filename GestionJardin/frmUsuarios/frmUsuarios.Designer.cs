namespace GestionJardin
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGU_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnGU_Editar = new FontAwesome.Sharp.IconButton();
            this.btnGU_Agregar = new FontAwesome.Sharp.IconButton();
            this.txtGU_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.dgv_UsuariosActivos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsuariosActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(67, 674);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(815, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "* Para poder editar los datos de un usuario o dar de baja al mismo, debe seleccio" +
    "nar el registro previamente";
            // 
            // btnGU_Eliminar
            // 
            this.btnGU_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGU_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGU_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGU_Eliminar.ForeColor = System.Drawing.Color.Gray;
            this.btnGU_Eliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnGU_Eliminar.IconColor = System.Drawing.Color.Gray;
            this.btnGU_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGU_Eliminar.IconSize = 100;
            this.btnGU_Eliminar.Location = new System.Drawing.Point(1379, 486);
            this.btnGU_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGU_Eliminar.Name = "btnGU_Eliminar";
            this.btnGU_Eliminar.Size = new System.Drawing.Size(293, 134);
            this.btnGU_Eliminar.TabIndex = 28;
            this.btnGU_Eliminar.Text = "PROCESAR BAJA";
            this.btnGU_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGU_Eliminar.UseVisualStyleBackColor = true;
            this.btnGU_Eliminar.Click += new System.EventHandler(this.btnGU_Eliminar_Click);
            // 
            // btnGU_Editar
            // 
            this.btnGU_Editar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGU_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGU_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGU_Editar.ForeColor = System.Drawing.Color.Gray;
            this.btnGU_Editar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnGU_Editar.IconColor = System.Drawing.Color.Gray;
            this.btnGU_Editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGU_Editar.IconSize = 100;
            this.btnGU_Editar.Location = new System.Drawing.Point(1379, 331);
            this.btnGU_Editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGU_Editar.Name = "btnGU_Editar";
            this.btnGU_Editar.Size = new System.Drawing.Size(293, 134);
            this.btnGU_Editar.TabIndex = 27;
            this.btnGU_Editar.Text = "MODIFICAR";
            this.btnGU_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGU_Editar.UseVisualStyleBackColor = true;
            this.btnGU_Editar.Click += new System.EventHandler(this.btnGU_Editar_Click);
            // 
            // btnGU_Agregar
            // 
            this.btnGU_Agregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGU_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGU_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGU_Agregar.ForeColor = System.Drawing.Color.Lime;
            this.btnGU_Agregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGU_Agregar.IconColor = System.Drawing.Color.Lime;
            this.btnGU_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGU_Agregar.IconSize = 100;
            this.btnGU_Agregar.Location = new System.Drawing.Point(1379, 174);
            this.btnGU_Agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGU_Agregar.Name = "btnGU_Agregar";
            this.btnGU_Agregar.Size = new System.Drawing.Size(293, 134);
            this.btnGU_Agregar.TabIndex = 26;
            this.btnGU_Agregar.Text = "GENERAR";
            this.btnGU_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGU_Agregar.UseVisualStyleBackColor = true;
            this.btnGU_Agregar.Click += new System.EventHandler(this.btnGU_Agregar_Click);
            // 
            // txtGU_Buscar
            // 
            this.txtGU_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGU_Buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGU_Buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtGU_Buscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGU_Buscar.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtGU_Buscar.CustomButton.Location = new System.Drawing.Point(376, 2);
            this.txtGU_Buscar.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGU_Buscar.CustomButton.Name = "";
            this.txtGU_Buscar.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtGU_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGU_Buscar.CustomButton.TabIndex = 1;
            this.txtGU_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGU_Buscar.CustomButton.UseSelectable = true;
            this.txtGU_Buscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtGU_Buscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtGU_Buscar.Lines = new string[0];
            this.txtGU_Buscar.Location = new System.Drawing.Point(69, 52);
            this.txtGU_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGU_Buscar.MaxLength = 32767;
            this.txtGU_Buscar.Name = "txtGU_Buscar";
            this.txtGU_Buscar.PasswordChar = '\0';
            this.txtGU_Buscar.PromptText = "BUSCAR DOCENTE";
            this.txtGU_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGU_Buscar.SelectedText = "";
            this.txtGU_Buscar.SelectionLength = 0;
            this.txtGU_Buscar.SelectionStart = 0;
            this.txtGU_Buscar.ShortcutsEnabled = true;
            this.txtGU_Buscar.ShowButton = true;
            this.txtGU_Buscar.Size = new System.Drawing.Size(424, 50);
            this.txtGU_Buscar.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtGU_Buscar.TabIndex = 33;
            this.txtGU_Buscar.UseSelectable = true;
            this.txtGU_Buscar.WaterMark = "BUSCAR DOCENTE";
            this.txtGU_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGU_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGU_Buscar.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtGU_Buscar_ButtonClick);
            this.txtGU_Buscar.TextChanged += new System.EventHandler(this.txtGU_Buscar_TextChanged);
            this.txtGU_Buscar.Click += new System.EventHandler(this.txtGU_Buscar_Click);
            this.txtGU_Buscar.Enter += new System.EventHandler(this.txtGU_Buscar_Enter);
            // 
            // dgv_UsuariosActivos
            // 
            this.dgv_UsuariosActivos.AllowUserToAddRows = false;
            this.dgv_UsuariosActivos.AllowUserToDeleteRows = false;
            this.dgv_UsuariosActivos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgv_UsuariosActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_UsuariosActivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UsuariosActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_UsuariosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_UsuariosActivos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_UsuariosActivos.Location = new System.Drawing.Point(69, 153);
            this.dgv_UsuariosActivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_UsuariosActivos.MultiSelect = false;
            this.dgv_UsuariosActivos.Name = "dgv_UsuariosActivos";
            this.dgv_UsuariosActivos.ReadOnly = true;
            this.dgv_UsuariosActivos.RowTemplate.Height = 24;
            this.dgv_UsuariosActivos.Size = new System.Drawing.Size(1140, 489);
            this.dgv_UsuariosActivos.TabIndex = 34;
            this.dgv_UsuariosActivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UsuariosActivos_CellClick_1);
            this.dgv_UsuariosActivos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_UsuariosActivos_CellFormatting);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1729, 750);
            this.Controls.Add(this.dgv_UsuariosActivos);
            this.Controls.Add(this.txtGU_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGU_Eliminar);
            this.Controls.Add(this.btnGU_Editar);
            this.Controls.Add(this.btnGU_Agregar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUsuarios";
            this.Text = "GESTIÓN USUARIOS";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsuariosActivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnGU_Eliminar;
        private FontAwesome.Sharp.IconButton btnGU_Editar;
        private FontAwesome.Sharp.IconButton btnGU_Agregar;
        public System.Windows.Forms.DataGridView dgv_UsuariosActivos;
        public MetroFramework.Controls.MetroTextBox txtGU_Buscar;
    }
}