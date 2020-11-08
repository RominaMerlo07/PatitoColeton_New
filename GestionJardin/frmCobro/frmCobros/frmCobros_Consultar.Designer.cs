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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCob_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.dgvCobros = new System.Windows.Forms.DataGridView();
            this.dt_FechaDesde = new MetroFramework.Controls.MetroDateTime();
            this.dt_FechaHasta = new MetroFramework.Controls.MetroDateTime();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnFiltro = new FontAwesome.Sharp.IconButton();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
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
            this.txtCob_Buscar.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtCob_Buscar_ButtonClick);
            this.txtCob_Buscar.TextChanged += new System.EventHandler(this.txtCob_Buscar_TextChanged);
            // 
            // dgvCobros
            // 
            this.dgvCobros.AllowUserToAddRows = false;
            this.dgvCobros.AllowUserToDeleteRows = false;
            this.dgvCobros.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvCobros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCobros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCobros.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCobros.Location = new System.Drawing.Point(45, 395);
            this.dgvCobros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCobros.MultiSelect = false;
            this.dgvCobros.Name = "dgvCobros";
            this.dgvCobros.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCobros.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCobros.RowTemplate.Height = 24;
            this.dgvCobros.Size = new System.Drawing.Size(1432, 495);
            this.dgvCobros.TabIndex = 52;
            // 
            // dt_FechaDesde
            // 
            this.dt_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FechaDesde.Location = new System.Drawing.Point(791, 314);
            this.dt_FechaDesde.MinimumSize = new System.Drawing.Size(0, 30);
            this.dt_FechaDesde.Name = "dt_FechaDesde";
            this.dt_FechaDesde.Size = new System.Drawing.Size(171, 30);
            this.dt_FechaDesde.TabIndex = 54;
            this.dt_FechaDesde.Visible = false;
            // 
            // dt_FechaHasta
            // 
            this.dt_FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FechaHasta.Location = new System.Drawing.Point(1052, 314);
            this.dt_FechaHasta.MinimumSize = new System.Drawing.Size(0, 30);
            this.dt_FechaHasta.Name = "dt_FechaHasta";
            this.dt_FechaHasta.Size = new System.Drawing.Size(171, 30);
            this.dt_FechaHasta.TabIndex = 55;
            this.dt_FechaHasta.Visible = false;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.ForeColor = System.Drawing.Color.Yellow;
            this.lblDesde.Location = new System.Drawing.Point(845, 276);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(55, 17);
            this.lblDesde.TabIndex = 56;
            this.lblDesde.Text = "DESDE";
            this.lblDesde.Visible = false;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.ForeColor = System.Drawing.Color.Yellow;
            this.lblHasta.Location = new System.Drawing.Point(1111, 276);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(54, 17);
            this.lblHasta.TabIndex = 57;
            this.lblHasta.Text = "HASTA";
            this.lblHasta.Visible = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Yellow;
            this.lblBuscar.Location = new System.Drawing.Point(504, 308);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(671, 20);
            this.lblBuscar.TabIndex = 58;
            this.lblBuscar.Text = "Busque un alumno para visualizar los pagos, del ciclo lectivo actual, asociados a" +
    "l mismo";
            // 
            // btnFiltro
            // 
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.ForeColor = System.Drawing.Color.Yellow;
            this.btnFiltro.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFiltro.IconColor = System.Drawing.Color.Yellow;
            this.btnFiltro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltro.IconSize = 35;
            this.btnFiltro.Location = new System.Drawing.Point(1298, 291);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Rotation = 0D;
            this.btnFiltro.Size = new System.Drawing.Size(172, 63);
            this.btnFiltro.TabIndex = 59;
            this.btnFiltro.Text = "BUSCAR";
            this.btnFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Visible = false;
            // 
            // lblFiltro
            // 
            this.lblFiltro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.Yellow;
            this.lblFiltro.Location = new System.Drawing.Point(791, 357);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(360, 20);
            this.lblFiltro.TabIndex = 60;
            this.lblFiltro.Text = "Filtre por fecha si desea visualizar otro periodo";
            this.lblFiltro.Visible = false;
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
            this.lblInfo.Size = new System.Drawing.Size(322, 20);
            this.lblInfo.TabIndex = 61;
            this.lblInfo.Text = "* Seleccione un registro para ver el recibo";
            this.lblInfo.Visible = false;
            // 
            // frmCobros_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1558, 947);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dt_FechaHasta);
            this.Controls.Add(this.dt_FechaDesde);
            this.Controls.Add(this.txtCob_Buscar);
            this.Controls.Add(this.dgvCobros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCobros_Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "COBROS / CONSULTAR";
            this.Load += new System.EventHandler(this.frmCobros_Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtCob_Buscar;
        public System.Windows.Forms.DataGridView dgvCobros;
        private MetroFramework.Controls.MetroDateTime dt_FechaDesde;
        private MetroFramework.Controls.MetroDateTime dt_FechaHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblBuscar;
        private FontAwesome.Sharp.IconButton btnFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblInfo;
    }
}