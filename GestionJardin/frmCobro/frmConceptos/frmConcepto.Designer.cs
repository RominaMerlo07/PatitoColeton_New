namespace GestionJardin
{
    partial class frmConcepto
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
            this.dgvConceptos = new System.Windows.Forms.DataGridView();
            this.txtCon_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCon_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnCon_Editar = new FontAwesome.Sharp.IconButton();
            this.btnCon_Agregar = new FontAwesome.Sharp.IconButton();
            this.btnLista = new FontAwesome.Sharp.IconButton();
            this.btn_ImprimirConcepto = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConceptos
            // 
            this.dgvConceptos.AllowUserToAddRows = false;
            this.dgvConceptos.AllowUserToDeleteRows = false;
            this.dgvConceptos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvConceptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConceptos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConceptos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConceptos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConceptos.Location = new System.Drawing.Point(41, 383);
            this.dgvConceptos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvConceptos.MultiSelect = false;
            this.dgvConceptos.Name = "dgvConceptos";
            this.dgvConceptos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConceptos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConceptos.RowTemplate.Height = 24;
            this.dgvConceptos.Size = new System.Drawing.Size(1271, 495);
            this.dgvConceptos.TabIndex = 52;
            this.dgvConceptos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConceptos_CellClick);
            // 
            // txtCon_Buscar
            // 
            this.txtCon_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCon_Buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCon_Buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCon_Buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtCon_Buscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCon_Buscar.CustomButton.Image = null;
            this.txtCon_Buscar.CustomButton.Location = new System.Drawing.Point(376, 2);
            this.txtCon_Buscar.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCon_Buscar.CustomButton.Name = "";
            this.txtCon_Buscar.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtCon_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCon_Buscar.CustomButton.TabIndex = 1;
            this.txtCon_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCon_Buscar.CustomButton.UseSelectable = true;
            this.txtCon_Buscar.CustomButton.Visible = false;
            this.txtCon_Buscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCon_Buscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtCon_Buscar.Lines = new string[0];
            this.txtCon_Buscar.Location = new System.Drawing.Point(41, 287);
            this.txtCon_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCon_Buscar.MaxLength = 32767;
            this.txtCon_Buscar.Name = "txtCon_Buscar";
            this.txtCon_Buscar.PasswordChar = '\0';
            this.txtCon_Buscar.PromptText = "BUSCAR CONCEPTO";
            this.txtCon_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCon_Buscar.SelectedText = "";
            this.txtCon_Buscar.SelectionLength = 0;
            this.txtCon_Buscar.SelectionStart = 0;
            this.txtCon_Buscar.ShortcutsEnabled = true;
            this.txtCon_Buscar.Size = new System.Drawing.Size(424, 50);
            this.txtCon_Buscar.TabIndex = 51;
            this.txtCon_Buscar.UseSelectable = true;
            this.txtCon_Buscar.WaterMark = "BUSCAR CONCEPTO";
            this.txtCon_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCon_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCon_Buscar.TextChanged += new System.EventHandler(this.txtCon_Buscar_TextChanged);
            this.txtCon_Buscar.Click += new System.EventHandler(this.txtCon_Buscar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 966);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(828, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "* Para poder editar los datos de un concepto o dar de baja al mismo, debe selecci" +
    "onar el registro previamente";
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
            this.btnCon_Eliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCon_Eliminar.Location = new System.Drawing.Point(1340, 725);
            this.btnCon_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCon_Eliminar.Name = "btnCon_Eliminar";
            this.btnCon_Eliminar.Size = new System.Drawing.Size(293, 134);
            this.btnCon_Eliminar.TabIndex = 46;
            this.btnCon_Eliminar.Text = "DESHABILITAR";
            this.btnCon_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCon_Eliminar.UseVisualStyleBackColor = true;
            this.btnCon_Eliminar.Click += new System.EventHandler(this.btnCon_Eliminar_Click);
            // 
            // btnCon_Editar
            // 
            this.btnCon_Editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCon_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCon_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCon_Editar.ForeColor = System.Drawing.Color.Cyan;
            this.btnCon_Editar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnCon_Editar.IconColor = System.Drawing.Color.Cyan;
            this.btnCon_Editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCon_Editar.IconSize = 85;
            this.btnCon_Editar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCon_Editar.Location = new System.Drawing.Point(1340, 568);
            this.btnCon_Editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCon_Editar.Name = "btnCon_Editar";
            this.btnCon_Editar.Size = new System.Drawing.Size(293, 134);
            this.btnCon_Editar.TabIndex = 45;
            this.btnCon_Editar.Text = "EDITAR";
            this.btnCon_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCon_Editar.UseVisualStyleBackColor = true;
            this.btnCon_Editar.TextChanged += new System.EventHandler(this.btnCon_Editar_TextChanged);
            this.btnCon_Editar.Click += new System.EventHandler(this.btnCon_Editar_Click);
            // 
            // btnCon_Agregar
            // 
            this.btnCon_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCon_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCon_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCon_Agregar.ForeColor = System.Drawing.Color.Lime;
            this.btnCon_Agregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCon_Agregar.IconColor = System.Drawing.Color.Lime;
            this.btnCon_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCon_Agregar.IconSize = 85;
            this.btnCon_Agregar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCon_Agregar.Location = new System.Drawing.Point(1340, 411);
            this.btnCon_Agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCon_Agregar.Name = "btnCon_Agregar";
            this.btnCon_Agregar.Size = new System.Drawing.Size(293, 134);
            this.btnCon_Agregar.TabIndex = 44;
            this.btnCon_Agregar.Text = "AGREGAR";
            this.btnCon_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCon_Agregar.UseVisualStyleBackColor = true;
            this.btnCon_Agregar.Click += new System.EventHandler(this.btnCon_Agregar_Click);
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
            this.btnLista.Location = new System.Drawing.Point(1006, 287);
            this.btnLista.Name = "btnLista";
            this.btnLista.Padding = new System.Windows.Forms.Padding(3);
            this.btnLista.Size = new System.Drawing.Size(74, 63);
            this.btnLista.TabIndex = 54;
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btn_ImprimirConcepto
            // 
            this.btn_ImprimirConcepto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ImprimirConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImprimirConcepto.ForeColor = System.Drawing.Color.Silver;
            this.btn_ImprimirConcepto.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btn_ImprimirConcepto.IconColor = System.Drawing.Color.Silver;
            this.btn_ImprimirConcepto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ImprimirConcepto.IconSize = 40;
            this.btn_ImprimirConcepto.Location = new System.Drawing.Point(1121, 287);
            this.btn_ImprimirConcepto.Name = "btn_ImprimirConcepto";
            this.btn_ImprimirConcepto.Padding = new System.Windows.Forms.Padding(3);
            this.btn_ImprimirConcepto.Size = new System.Drawing.Size(74, 63);
            this.btn_ImprimirConcepto.TabIndex = 53;
            this.btn_ImprimirConcepto.UseVisualStyleBackColor = true;
            this.btn_ImprimirConcepto.Click += new System.EventHandler(this.btn_ImprimirConcepto_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(37, 895);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(844, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "* Para poder modificar el valor de un concepto o deshabilitar al mismo, debe sele" +
    "ccionar el registro previamente";
            // 
            // frmConcepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1660, 947);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btn_ImprimirConcepto);
            this.Controls.Add(this.dgvConceptos);
            this.Controls.Add(this.txtCon_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCon_Eliminar);
            this.Controls.Add(this.btnCon_Editar);
            this.Controls.Add(this.btnCon_Agregar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConcepto";
            this.Text = "CONCEPTOS / GESTIONAR";
            this.Load += new System.EventHandler(this.frmConcepto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvConceptos;
        private MetroFramework.Controls.MetroTextBox txtCon_Buscar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCon_Eliminar;
        private FontAwesome.Sharp.IconButton btnCon_Editar;
        private FontAwesome.Sharp.IconButton btnCon_Agregar;
        private FontAwesome.Sharp.IconButton btnLista;
        private FontAwesome.Sharp.IconButton btn_ImprimirConcepto;
        private System.Windows.Forms.Label label2;
    }
}