namespace GestionJardin
{
    partial class frmDocentes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGD_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.dgv_Docentes = new System.Windows.Forms.DataGridView();
            this.btn_ImprimirSala = new FontAwesome.Sharp.IconButton();
            this.btnGD_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnGD_Editar = new FontAwesome.Sharp.IconButton();
            this.btnGD_Agregar = new FontAwesome.Sharp.IconButton();
            this.btnLista = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Docentes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(43, 699);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(819, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "* Para poder editar los datos de un docente o dar de baja al mismo, debe seleccio" +
    "nar el registro previamente";
            // 
            // txtGD_Buscar
            // 
            this.txtGD_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGD_Buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGD_Buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtGD_Buscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGD_Buscar.CustomButton.Image = null;
            this.txtGD_Buscar.CustomButton.Location = new System.Drawing.Point(376, 2);
            this.txtGD_Buscar.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGD_Buscar.CustomButton.Name = "";
            this.txtGD_Buscar.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtGD_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGD_Buscar.CustomButton.TabIndex = 1;
            this.txtGD_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGD_Buscar.CustomButton.UseSelectable = true;
            this.txtGD_Buscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtGD_Buscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtGD_Buscar.Lines = new string[0];
            this.txtGD_Buscar.Location = new System.Drawing.Point(47, 52);
            this.txtGD_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGD_Buscar.MaxLength = 32767;
            this.txtGD_Buscar.Name = "txtGD_Buscar";
            this.txtGD_Buscar.PasswordChar = '\0';
            this.txtGD_Buscar.PromptText = "BUSCAR DOCENTE";
            this.txtGD_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGD_Buscar.SelectedText = "";
            this.txtGD_Buscar.SelectionLength = 0;
            this.txtGD_Buscar.SelectionStart = 0;
            this.txtGD_Buscar.ShortcutsEnabled = true;
            this.txtGD_Buscar.ShowButton = true;
            this.txtGD_Buscar.Size = new System.Drawing.Size(424, 50);
            this.txtGD_Buscar.TabIndex = 34;
            this.txtGD_Buscar.UseSelectable = true;
            this.txtGD_Buscar.WaterMark = "BUSCAR DOCENTE";
            this.txtGD_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGD_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGD_Buscar.TextChanged += new System.EventHandler(this.txtGD_Buscar_TextChanged_1);
            this.txtGD_Buscar.Click += new System.EventHandler(this.txtGD_Buscar_Click);
            // 
            // dgv_Docentes
            // 
            this.dgv_Docentes.AllowUserToAddRows = false;
            this.dgv_Docentes.AllowUserToDeleteRows = false;
            this.dgv_Docentes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgv_Docentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Docentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Docentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Docentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Docentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Docentes.Location = new System.Drawing.Point(47, 165);
            this.dgv_Docentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Docentes.MultiSelect = false;
            this.dgv_Docentes.Name = "dgv_Docentes";
            this.dgv_Docentes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Docentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Docentes.RowTemplate.Height = 24;
            this.dgv_Docentes.Size = new System.Drawing.Size(1240, 495);
            this.dgv_Docentes.TabIndex = 42;
            this.dgv_Docentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Docentes_CellClick);
            // 
            // btn_ImprimirSala
            // 
            this.btn_ImprimirSala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ImprimirSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImprimirSala.ForeColor = System.Drawing.Color.Silver;
            this.btn_ImprimirSala.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btn_ImprimirSala.IconColor = System.Drawing.Color.Silver;
            this.btn_ImprimirSala.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ImprimirSala.IconSize = 40;
            this.btn_ImprimirSala.Location = new System.Drawing.Point(1080, 52);
            this.btn_ImprimirSala.Name = "btn_ImprimirSala";
            this.btn_ImprimirSala.Padding = new System.Windows.Forms.Padding(3);
            this.btn_ImprimirSala.Size = new System.Drawing.Size(74, 63);
            this.btn_ImprimirSala.TabIndex = 45;
            this.btn_ImprimirSala.UseVisualStyleBackColor = true;
            this.btn_ImprimirSala.Click += new System.EventHandler(this.btn_ImprimirSala_Click);
            // 
            // btnGD_Eliminar
            // 
            this.btnGD_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGD_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGD_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGD_Eliminar.ForeColor = System.Drawing.Color.Gray;
            this.btnGD_Eliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnGD_Eliminar.IconColor = System.Drawing.Color.Gray;
            this.btnGD_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGD_Eliminar.IconSize = 100;
            this.btnGD_Eliminar.Location = new System.Drawing.Point(1310, 496);
            this.btnGD_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGD_Eliminar.Name = "btnGD_Eliminar";
            this.btnGD_Eliminar.Size = new System.Drawing.Size(293, 134);
            this.btnGD_Eliminar.TabIndex = 37;
            this.btnGD_Eliminar.Text = "PROCESAR BAJA";
            this.btnGD_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGD_Eliminar.UseVisualStyleBackColor = true;
            this.btnGD_Eliminar.Click += new System.EventHandler(this.btnGD_Eliminar_Click);
            // 
            // btnGD_Editar
            // 
            this.btnGD_Editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGD_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGD_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGD_Editar.ForeColor = System.Drawing.Color.Gray;
            this.btnGD_Editar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnGD_Editar.IconColor = System.Drawing.Color.Gray;
            this.btnGD_Editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGD_Editar.IconSize = 100;
            this.btnGD_Editar.Location = new System.Drawing.Point(1310, 338);
            this.btnGD_Editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGD_Editar.Name = "btnGD_Editar";
            this.btnGD_Editar.Size = new System.Drawing.Size(293, 134);
            this.btnGD_Editar.TabIndex = 36;
            this.btnGD_Editar.Text = "MODIFICAR";
            this.btnGD_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGD_Editar.UseVisualStyleBackColor = true;
            this.btnGD_Editar.Click += new System.EventHandler(this.btnGD_Editar_Click);
            // 
            // btnGD_Agregar
            // 
            this.btnGD_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGD_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGD_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGD_Agregar.ForeColor = System.Drawing.Color.Lime;
            this.btnGD_Agregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGD_Agregar.IconColor = System.Drawing.Color.Lime;
            this.btnGD_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGD_Agregar.IconSize = 100;
            this.btnGD_Agregar.Location = new System.Drawing.Point(1310, 182);
            this.btnGD_Agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGD_Agregar.Name = "btnGD_Agregar";
            this.btnGD_Agregar.Size = new System.Drawing.Size(293, 134);
            this.btnGD_Agregar.TabIndex = 35;
            this.btnGD_Agregar.Text = "INGRESAR";
            this.btnGD_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGD_Agregar.UseVisualStyleBackColor = true;
            this.btnGD_Agregar.Click += new System.EventHandler(this.btnGD_Agregar_Click);
            // 
            // btnLista
            // 
            this.btnLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.ForeColor = System.Drawing.Color.Yellow;
            this.btnLista.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnLista.IconColor = System.Drawing.Color.Yellow;
            this.btnLista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLista.IconSize = 40;
            this.btnLista.Location = new System.Drawing.Point(965, 52);
            this.btnLista.Name = "btnLista";
            this.btnLista.Padding = new System.Windows.Forms.Padding(3);
            this.btnLista.Size = new System.Drawing.Size(74, 63);
            this.btnLista.TabIndex = 46;
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // frmDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1615, 750);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btn_ImprimirSala);
            this.Controls.Add(this.dgv_Docentes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGD_Eliminar);
            this.Controls.Add(this.btnGD_Editar);
            this.Controls.Add(this.btnGD_Agregar);
            this.Controls.Add(this.txtGD_Buscar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDocentes";
            this.Text = "GESTIÓN DOCENTES";
            this.Load += new System.EventHandler(this.frmDocentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Docentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnGD_Eliminar;
        private FontAwesome.Sharp.IconButton btnGD_Editar;
        private FontAwesome.Sharp.IconButton btnGD_Agregar;
        private MetroFramework.Controls.MetroTextBox txtGD_Buscar;
        public System.Windows.Forms.DataGridView dgv_Docentes;
        private FontAwesome.Sharp.IconButton btn_ImprimirSala;
        private FontAwesome.Sharp.IconButton btnLista;
    }
}