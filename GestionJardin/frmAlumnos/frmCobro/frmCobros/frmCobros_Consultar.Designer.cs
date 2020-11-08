namespace GestionJardin
{
    partial class frmCobros_Consultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobros_Consultar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCob_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.dgvCobros = new System.Windows.Forms.DataGridView();
            this.dt_FechaDesde = new MetroFramework.Controls.MetroDateTime();
            this.dt_FechaHasta = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobros)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCob_Buscar
            // 
            this.txtCob_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCob_Buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCob_Buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCob_Buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtCob_Buscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCob_Buscar.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtCob_Buscar.CustomButton.Location = new System.Drawing.Point(376, 2);
            this.txtCob_Buscar.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCob_Buscar.CustomButton.Name = "";
            this.txtCob_Buscar.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtCob_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCob_Buscar.CustomButton.TabIndex = 1;
            this.txtCob_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCob_Buscar.CustomButton.UseSelectable = true;
            this.txtCob_Buscar.CustomButton.UseStyleColors = true;
            this.txtCob_Buscar.CustomButton.UseVisualStyleBackColor = true;
            this.txtCob_Buscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCob_Buscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtCob_Buscar.Lines = new string[0];
            this.txtCob_Buscar.Location = new System.Drawing.Point(45, 293);
            this.txtCob_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCob_Buscar.MaxLength = 32767;
            this.txtCob_Buscar.Name = "txtCob_Buscar";
            this.txtCob_Buscar.PasswordChar = '\0';
            this.txtCob_Buscar.PromptText = "BUSCAR ALUMNO";
            this.txtCob_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCob_Buscar.SelectedText = "";
            this.txtCob_Buscar.SelectionLength = 0;
            this.txtCob_Buscar.SelectionStart = 0;
            this.txtCob_Buscar.ShortcutsEnabled = true;
            this.txtCob_Buscar.ShowButton = true;
            this.txtCob_Buscar.Size = new System.Drawing.Size(424, 50);
            this.txtCob_Buscar.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCob_Buscar.TabIndex = 53;
            this.txtCob_Buscar.UseSelectable = true;
            this.txtCob_Buscar.WaterMark = "BUSCAR ALUMNO";
            this.txtCob_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCob_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvCobros.Location = new System.Drawing.Point(45, 393);
            this.dgvCobros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.dgvCobros.Size = new System.Drawing.Size(1411, 495);
            this.dgvCobros.TabIndex = 52;
            // 
            // dt_FechaDesde
            // 
            this.dt_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FechaDesde.Location = new System.Drawing.Point(847, 320);
            this.dt_FechaDesde.MinimumSize = new System.Drawing.Size(0, 30);
            this.dt_FechaDesde.Name = "dt_FechaDesde";
            this.dt_FechaDesde.Size = new System.Drawing.Size(171, 30);
            this.dt_FechaDesde.TabIndex = 54;
            // 
            // dt_FechaHasta
            // 
            this.dt_FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FechaHasta.Location = new System.Drawing.Point(1186, 320);
            this.dt_FechaHasta.MinimumSize = new System.Drawing.Size(0, 30);
            this.dt_FechaHasta.Name = "dt_FechaHasta";
            this.dt_FechaHasta.Size = new System.Drawing.Size(171, 30);
            this.dt_FechaHasta.TabIndex = 55;
            // 
            // frmCobros_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1558, 947);
            this.Controls.Add(this.dt_FechaHasta);
            this.Controls.Add(this.dt_FechaDesde);
            this.Controls.Add(this.txtCob_Buscar);
            this.Controls.Add(this.dgvCobros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCobros_Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "COBROS / CONSULTAR";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtCob_Buscar;
        public System.Windows.Forms.DataGridView dgvCobros;
        private MetroFramework.Controls.MetroDateTime dt_FechaDesde;
        private MetroFramework.Controls.MetroDateTime dt_FechaHasta;
    }
}