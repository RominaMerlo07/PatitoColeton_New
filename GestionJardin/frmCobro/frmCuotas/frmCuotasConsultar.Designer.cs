namespace GestionJardin
{
    partial class frmCuotasConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuotasConsultar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.dgvCuotas = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).BeginInit();
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
            this.txt_Buscar.CustomButton.Location = new System.Drawing.Point(376, 2);
            this.txt_Buscar.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Buscar.CustomButton.Name = "";
            this.txt_Buscar.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txt_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Buscar.CustomButton.TabIndex = 1;
            this.txt_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Buscar.CustomButton.UseSelectable = true;
            this.txt_Buscar.CustomButton.UseStyleColors = true;
            this.txt_Buscar.CustomButton.UseVisualStyleBackColor = true;
            this.txt_Buscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_Buscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_Buscar.Lines = new string[0];
            this.txt_Buscar.Location = new System.Drawing.Point(45, 293);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txt_Buscar.Size = new System.Drawing.Size(424, 50);
            this.txt_Buscar.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Buscar.TabIndex = 53;
            this.txt_Buscar.UseSelectable = true;
            this.txt_Buscar.WaterMark = "BUSCAR ALUMNO";
            this.txt_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtCob_Buscar_ButtonClick);
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txtCob_Buscar_TextChanged);
            // 
            // dgvCuotas
            // 
            this.dgvCuotas.AllowUserToAddRows = false;
            this.dgvCuotas.AllowUserToDeleteRows = false;
            this.dgvCuotas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvCuotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCuotas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuotas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuotas.Location = new System.Drawing.Point(45, 393);
            this.dgvCuotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCuotas.MultiSelect = false;
            this.dgvCuotas.Name = "dgvCuotas";
            this.dgvCuotas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCuotas.RowTemplate.Height = 24;
            this.dgvCuotas.Size = new System.Drawing.Size(1603, 495);
            this.dgvCuotas.TabIndex = 52;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInfo.AutoSize = true;
            this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Location = new System.Drawing.Point(41, 908);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(412, 20);
            this.lblInfo.TabIndex = 54;
            this.lblInfo.Text = "* Seleccione un registro para ver el detalle de la cuota";
            this.lblInfo.Visible = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Aqua;
            this.lblBuscar.Location = new System.Drawing.Point(510, 308);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(426, 20);
            this.lblBuscar.TabIndex = 55;
            this.lblBuscar.Text = "Busque un alumno para visualizar las cuotas del mismo";
            // 
            // frmCuotasConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1660, 947);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.dgvCuotas);
            this.Name = "frmCuotasConsultar";
            this.Text = "CUOTAS / CONSULTAR";
            this.Load += new System.EventHandler(this.frmCuotasConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_Buscar;
        public System.Windows.Forms.DataGridView dgvCuotas;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblBuscar;
    }
}