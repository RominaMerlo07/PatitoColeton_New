namespace GestionJardin
{
    partial class frmAlumnosGestionar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGA_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.btnGA_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnGA_Editar = new FontAwesome.Sharp.IconButton();
            this.btnGA_Agregar = new FontAwesome.Sharp.IconButton();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btn_ImprimirSala = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 868);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(814, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "* Para poder editar los datos de un alumno o dar de baja al mismo, debe seleccion" +
    "ar el registro previamente";
            // 
            // txtGA_Buscar
            // 
            this.txtGA_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGA_Buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGA_Buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGA_Buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtGA_Buscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGA_Buscar.CustomButton.Image = null;
            this.txtGA_Buscar.CustomButton.Location = new System.Drawing.Point(376, 2);
            this.txtGA_Buscar.CustomButton.Name = "";
            this.txtGA_Buscar.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtGA_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGA_Buscar.CustomButton.TabIndex = 1;
            this.txtGA_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGA_Buscar.CustomButton.UseSelectable = true;
            this.txtGA_Buscar.CustomButton.Visible = false;
            this.txtGA_Buscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtGA_Buscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtGA_Buscar.Lines = new string[0];
            this.txtGA_Buscar.Location = new System.Drawing.Point(38, 257);
            this.txtGA_Buscar.MaxLength = 32767;
            this.txtGA_Buscar.Name = "txtGA_Buscar";
            this.txtGA_Buscar.PasswordChar = '\0';
            this.txtGA_Buscar.PromptText = "BUSCAR ALUMNO";
            this.txtGA_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGA_Buscar.SelectedText = "";
            this.txtGA_Buscar.SelectionLength = 0;
            this.txtGA_Buscar.SelectionStart = 0;
            this.txtGA_Buscar.ShortcutsEnabled = true;
            this.txtGA_Buscar.Size = new System.Drawing.Size(424, 50);
            this.txtGA_Buscar.TabIndex = 26;
            this.txtGA_Buscar.UseSelectable = true;
            this.txtGA_Buscar.WaterMark = "BUSCAR ALUMNO";
            this.txtGA_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGA_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGA_Buscar.TextChanged += new System.EventHandler(this.txtGA_Buscar_TextChanged);
            this.txtGA_Buscar.Click += new System.EventHandler(this.txtGA_Buscar_Click);
            // 
            // btnGA_Eliminar
            // 
            this.btnGA_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGA_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGA_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGA_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGA_Eliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnGA_Eliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGA_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGA_Eliminar.IconSize = 100;
            this.btnGA_Eliminar.Location = new System.Drawing.Point(1313, 681);
            this.btnGA_Eliminar.Name = "btnGA_Eliminar";
            this.btnGA_Eliminar.Size = new System.Drawing.Size(293, 134);
            this.btnGA_Eliminar.TabIndex = 8;
            this.btnGA_Eliminar.Text = "PROCESAR BAJA";
            this.btnGA_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGA_Eliminar.UseVisualStyleBackColor = true;
            this.btnGA_Eliminar.Click += new System.EventHandler(this.btnGA_Eliminar_Click);
            // 
            // btnGA_Editar
            // 
            this.btnGA_Editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGA_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGA_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGA_Editar.ForeColor = System.Drawing.Color.Cyan;
            this.btnGA_Editar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnGA_Editar.IconColor = System.Drawing.Color.Cyan;
            this.btnGA_Editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGA_Editar.IconSize = 100;
            this.btnGA_Editar.Location = new System.Drawing.Point(1313, 525);
            this.btnGA_Editar.Name = "btnGA_Editar";
            this.btnGA_Editar.Size = new System.Drawing.Size(293, 134);
            this.btnGA_Editar.TabIndex = 7;
            this.btnGA_Editar.Text = "MODIFICAR";
            this.btnGA_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGA_Editar.UseVisualStyleBackColor = true;
            this.btnGA_Editar.Click += new System.EventHandler(this.btnGA_Editar_Click);
            // 
            // btnGA_Agregar
            // 
            this.btnGA_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGA_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGA_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGA_Agregar.ForeColor = System.Drawing.Color.Lime;
            this.btnGA_Agregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGA_Agregar.IconColor = System.Drawing.Color.Lime;
            this.btnGA_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGA_Agregar.IconSize = 100;
            this.btnGA_Agregar.Location = new System.Drawing.Point(1313, 367);
            this.btnGA_Agregar.Name = "btnGA_Agregar";
            this.btnGA_Agregar.Size = new System.Drawing.Size(293, 134);
            this.btnGA_Agregar.TabIndex = 6;
            this.btnGA_Agregar.Text = "INGRESAR";
            this.btnGA_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGA_Agregar.UseVisualStyleBackColor = true;
            this.btnGA_Agregar.Click += new System.EventHandler(this.btnGA_Agregar_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvAlumnos.Location = new System.Drawing.Point(38, 353);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAlumnos.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvAlumnos.RowTemplate.Height = 24;
            this.dgvAlumnos.Size = new System.Drawing.Size(1252, 495);
            this.dgvAlumnos.TabIndex = 43;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellClick);
            // 
            // btn_ImprimirSala
            // 
            this.btn_ImprimirSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImprimirSala.ForeColor = System.Drawing.Color.Silver;
            this.btn_ImprimirSala.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btn_ImprimirSala.IconColor = System.Drawing.Color.Silver;
            this.btn_ImprimirSala.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ImprimirSala.IconSize = 40;
            this.btn_ImprimirSala.Location = new System.Drawing.Point(1208, 260);
            this.btn_ImprimirSala.Name = "btn_ImprimirSala";
            this.btn_ImprimirSala.Padding = new System.Windows.Forms.Padding(3);
            this.btn_ImprimirSala.Size = new System.Drawing.Size(74, 63);
            this.btn_ImprimirSala.TabIndex = 44;
            this.btn_ImprimirSala.UseVisualStyleBackColor = true;
            this.btn_ImprimirSala.Click += new System.EventHandler(this.btn_ImprimirSala_Click);
            // 
            // frmAlumnosGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1660, 947);
            this.Controls.Add(this.btn_ImprimirSala);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.txtGA_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGA_Eliminar);
            this.Controls.Add(this.btnGA_Editar);
            this.Controls.Add(this.btnGA_Agregar);
            this.Name = "frmAlumnosGestionar";
            this.Text = "ESTUDIANTES / GESTIONAR ALUMNOS";
            this.Load += new System.EventHandler(this.frmAlumnosGestionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnGA_Agregar;
        private FontAwesome.Sharp.IconButton btnGA_Editar;
        private FontAwesome.Sharp.IconButton btnGA_Eliminar;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtGA_Buscar;
        public System.Windows.Forms.DataGridView dgvAlumnos;
        private FontAwesome.Sharp.IconButton btn_ImprimirSala;
    }
}