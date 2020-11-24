namespace GestionJardin
{
    partial class frmCobros_Gestionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobros_Gestionar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.dgvCobros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCob_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnCob_Agregar = new FontAwesome.Sharp.IconButton();
            this.lblBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobros)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_Buscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txt_Buscar.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.txt_Buscar.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Buscar.CustomButton.Name = "";
            this.txt_Buscar.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txt_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Buscar.CustomButton.TabIndex = 1;
            this.txt_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Buscar.CustomButton.UseSelectable = true;
            this.txt_Buscar.CustomButton.UseStyleColors = true;
            this.txt_Buscar.CustomButton.UseVisualStyleBackColor = true;
            this.txt_Buscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_Buscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_Buscar.Lines = new string[0];
            this.txt_Buscar.Location = new System.Drawing.Point(34, 238);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Buscar.MaxLength = 32767;
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.PasswordChar = '\0';
            this.txt_Buscar.PromptText = "BUSCAR ALUMNO";
            this.txt_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Buscar.SelectedText = "";
            this.txt_Buscar.SelectionLength = 0;
            this.txt_Buscar.SelectionStart = 0;
            this.txt_Buscar.ShortcutsEnabled = true;
            this.txt_Buscar.ShowButton = true;
            this.txt_Buscar.Size = new System.Drawing.Size(318, 41);
            this.txt_Buscar.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Buscar.TabIndex = 51;
            this.txt_Buscar.UseSelectable = true;
            this.txt_Buscar.WaterMark = "BUSCAR ALUMNO";
            this.txt_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtCob_Buscar_ButtonClick);
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            this.txt_Buscar.Enter += new System.EventHandler(this.txt_Buscar_Enter);
            // 
            // dgvCobros
            // 
            this.dgvCobros.AllowUserToAddRows = false;
            this.dgvCobros.AllowUserToDeleteRows = false;
            this.dgvCobros.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvCobros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCobros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCobros.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCobros.Location = new System.Drawing.Point(34, 319);
            this.dgvCobros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCobros.MultiSelect = false;
            this.dgvCobros.Name = "dgvCobros";
            this.dgvCobros.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCobros.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCobros.RowTemplate.Height = 24;
            this.dgvCobros.Size = new System.Drawing.Size(927, 402);
            this.dgvCobros.TabIndex = 50;
            this.dgvCobros.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCobros_CellFormatting);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 739);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "* Para realizar un cobro, debe seleccionar la cuota con mayor vencimiento al día " +
    "de la fecha";
            // 
            // btnCob_Eliminar
            // 
            this.btnCob_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCob_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCob_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCob_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCob_Eliminar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCob_Eliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCob_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCob_Eliminar.IconSize = 90;
            this.btnCob_Eliminar.Location = new System.Drawing.Point(998, 543);
            this.btnCob_Eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCob_Eliminar.Name = "btnCob_Eliminar";
            this.btnCob_Eliminar.Size = new System.Drawing.Size(220, 106);
            this.btnCob_Eliminar.TabIndex = 48;
            this.btnCob_Eliminar.Text = "ANULAR";
            this.btnCob_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCob_Eliminar.UseVisualStyleBackColor = true;
            this.btnCob_Eliminar.Click += new System.EventHandler(this.btnCob_Eliminar_Click);
            // 
            // btnCob_Agregar
            // 
            this.btnCob_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCob_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCob_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCob_Agregar.ForeColor = System.Drawing.Color.Lime;
            this.btnCob_Agregar.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnCob_Agregar.IconColor = System.Drawing.Color.Lime;
            this.btnCob_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCob_Agregar.IconSize = 90;
            this.btnCob_Agregar.Location = new System.Drawing.Point(998, 376);
            this.btnCob_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCob_Agregar.Name = "btnCob_Agregar";
            this.btnCob_Agregar.Size = new System.Drawing.Size(220, 109);
            this.btnCob_Agregar.TabIndex = 46;
            this.btnCob_Agregar.Text = "COBRAR";
            this.btnCob_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCob_Agregar.UseVisualStyleBackColor = true;
            this.btnCob_Agregar.Click += new System.EventHandler(this.btnCob_Agregar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Yellow;
            this.lblBuscar.Location = new System.Drawing.Point(382, 252);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(483, 17);
            this.lblBuscar.TabIndex = 56;
            this.lblBuscar.Text = "Busque un alumno para visualizar las cuotas del mismo y procesar el cobro";
            // 
            // frmCobros_Gestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.dgvCobros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCob_Eliminar);
            this.Controls.Add(this.btnCob_Agregar);
            this.Location = new System.Drawing.Point(45, 293);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCobros_Gestionar";
            this.Text = "COBROS / GESTIONAR";
            this.Load += new System.EventHandler(this.frmCobros_Gestionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_Buscar;
        public System.Windows.Forms.DataGridView dgvCobros;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCob_Eliminar;
        private FontAwesome.Sharp.IconButton btnCob_Agregar;
        private System.Windows.Forms.Label lblBuscar;
    }
}