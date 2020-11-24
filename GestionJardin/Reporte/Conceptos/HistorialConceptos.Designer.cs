namespace GestionJardin
{
    partial class HistorialConceptos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTurno = new MetroFramework.Controls.MetroPanel();
            this.dtHasta = new MetroFramework.Controls.MetroDateTime();
            this.dtDesde = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbConcepto = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.dgv_Concepto = new System.Windows.Forms.DataGridView();
            this.panelTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Concepto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTurno
            // 
            this.panelTurno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelTurno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTurno.Controls.Add(this.dtHasta);
            this.panelTurno.Controls.Add(this.dtDesde);
            this.panelTurno.Controls.Add(this.metroLabel2);
            this.panelTurno.Controls.Add(this.metroLabel1);
            this.panelTurno.Controls.Add(this.cbConcepto);
            this.panelTurno.Controls.Add(this.metroLabel3);
            this.panelTurno.Controls.Add(this.btnImprimir);
            this.panelTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTurno.HorizontalScrollbarBarColor = true;
            this.panelTurno.HorizontalScrollbarHighlightOnWheel = false;
            this.panelTurno.HorizontalScrollbarSize = 10;
            this.panelTurno.Location = new System.Drawing.Point(38, 45);
            this.panelTurno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTurno.Name = "panelTurno";
            this.panelTurno.Size = new System.Drawing.Size(1343, 287);
            this.panelTurno.TabIndex = 2;
            this.panelTurno.UseCustomBackColor = true;
            this.panelTurno.VerticalScrollbarBarColor = true;
            this.panelTurno.VerticalScrollbarHighlightOnWheel = false;
            this.panelTurno.VerticalScrollbarSize = 11;
            // 
            // dtHasta
            // 
            this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHasta.Location = new System.Drawing.Point(325, 193);
            this.dtHasta.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(200, 30);
            this.dtHasta.TabIndex = 31;
            this.dtHasta.ValueChanged += new System.EventHandler(this.dtHasta_ValueChanged);
            // 
            // dtDesde
            // 
            this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesde.Location = new System.Drawing.Point(325, 113);
            this.dtDesde.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(200, 30);
            this.dtDesde.TabIndex = 30;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Lime;
            this.metroLabel2.Location = new System.Drawing.Point(78, 193);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(293, 44);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "FECHA HASTA:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Lime;
            this.metroLabel1.Location = new System.Drawing.Point(78, 113);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(293, 44);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "FECHA DESDE:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // cbConcepto
            // 
            this.cbConcepto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbConcepto.FormattingEnabled = true;
            this.cbConcepto.ItemHeight = 24;
            this.cbConcepto.Items.AddRange(new object[] {
            "CUOTA SALA 1",
            "CUOTA SALA 2",
            "CUOTA SALA 3",
            "CUOTA SALA 4",
            "CUOTA SALA 5",
            "INTERES POR MORA",
            "MATERIAL DIDACTICO",
            "MATRICULA"});
            this.cbConcepto.Location = new System.Drawing.Point(325, 40);
            this.cbConcepto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbConcepto.Name = "cbConcepto";
            this.cbConcepto.PromptText = "Seleccione";
            this.cbConcepto.Size = new System.Drawing.Size(329, 30);
            this.cbConcepto.Style = MetroFramework.MetroColorStyle.Green;
            this.cbConcepto.TabIndex = 26;
            this.cbConcepto.UseCustomBackColor = true;
            this.cbConcepto.UseSelectable = true;
            this.cbConcepto.UseStyleColors = true;
            this.cbConcepto.SelectedValueChanged += new System.EventHandler(this.cbConcepto_SelectedValueChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Lime;
            this.metroLabel3.Location = new System.Drawing.Point(78, 40);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(293, 44);
            this.metroLabel3.TabIndex = 27;
            this.metroLabel3.Text = "CONCEPTO:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.ForeColor = System.Drawing.Color.Yellow;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimir.IconColor = System.Drawing.Color.Yellow;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.Location = new System.Drawing.Point(938, 96);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(247, 68);
            this.btnImprimir.TabIndex = 25;
            this.btnImprimir.Text = "IMPRIMIR LISTA";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dgv_Concepto
            // 
            this.dgv_Concepto.AllowUserToAddRows = false;
            this.dgv_Concepto.AllowUserToDeleteRows = false;
            this.dgv_Concepto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Concepto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Concepto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Concepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Concepto.Location = new System.Drawing.Point(69, 392);
            this.dgv_Concepto.Name = "dgv_Concepto";
            this.dgv_Concepto.ReadOnly = true;
            this.dgv_Concepto.RowTemplate.Height = 24;
            this.dgv_Concepto.Size = new System.Drawing.Size(1271, 439);
            this.dgv_Concepto.TabIndex = 3;
            this.dgv_Concepto.Visible = false;
            // 
            // HistorialConceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1426, 909);
            this.Controls.Add(this.dgv_Concepto);
            this.Controls.Add(this.panelTurno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "HistorialConceptos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panelTurno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Concepto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelTurno;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private MetroFramework.Controls.MetroDateTime dtHasta;
        private MetroFramework.Controls.MetroDateTime dtDesde;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbConcepto;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView dgv_Concepto;
    }
}