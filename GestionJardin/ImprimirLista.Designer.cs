namespace GestionJardin
{
    partial class ImprimirLista
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
            this.panelTurno = new MetroFramework.Controls.MetroPanel();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.cbSala = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbTurno = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dgvAlumnosSala = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.panelTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosSala)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTurno
            // 
            this.panelTurno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelTurno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTurno.Controls.Add(this.lblSala);
            this.panelTurno.Controls.Add(this.lblTurno);
            this.panelTurno.Controls.Add(this.btnImprimir);
            this.panelTurno.Controls.Add(this.cbSala);
            this.panelTurno.Controls.Add(this.metroLabel2);
            this.panelTurno.Controls.Add(this.cbTurno);
            this.panelTurno.Controls.Add(this.metroLabel3);
            this.panelTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTurno.HorizontalScrollbarBarColor = true;
            this.panelTurno.HorizontalScrollbarHighlightOnWheel = false;
            this.panelTurno.HorizontalScrollbarSize = 10;
            this.panelTurno.Location = new System.Drawing.Point(32, 36);
            this.panelTurno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTurno.Name = "panelTurno";
            this.panelTurno.Size = new System.Drawing.Size(1354, 126);
            this.panelTurno.TabIndex = 1;
            this.panelTurno.UseCustomBackColor = true;
            this.panelTurno.VerticalScrollbarBarColor = true;
            this.panelTurno.VerticalScrollbarHighlightOnWheel = false;
            this.panelTurno.VerticalScrollbarSize = 11;
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.ForeColor = System.Drawing.Color.Yellow;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimir.IconColor = System.Drawing.Color.Yellow;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.Location = new System.Drawing.Point(1060, 32);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(247, 68);
            this.btnImprimir.TabIndex = 25;
            this.btnImprimir.Text = "IMPRIMIR LISTA";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cbSala
            // 
            this.cbSala.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSala.Enabled = false;
            this.cbSala.FormattingEnabled = true;
            this.cbSala.ItemHeight = 24;
            this.cbSala.Location = new System.Drawing.Point(644, 44);
            this.cbSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(185, 30);
            this.cbSala.Style = MetroFramework.MetroColorStyle.Green;
            this.cbSala.TabIndex = 1;
            this.cbSala.UseCustomBackColor = true;
            this.cbSala.UseSelectable = true;
            this.cbSala.UseStyleColors = true;
            this.cbSala.SelectedValueChanged += new System.EventHandler(this.cbSala_SelectedValueChanged);
            this.cbSala.Leave += new System.EventHandler(this.cbSala_Leave);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Lime;
            this.metroLabel2.Location = new System.Drawing.Point(511, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(127, 44);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "SALA";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // cbTurno
            // 
            this.cbTurno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.ItemHeight = 24;
            this.cbTurno.Items.AddRange(new object[] {
            "MAÑANA",
            "TARDE"});
            this.cbTurno.Location = new System.Drawing.Point(173, 44);
            this.cbTurno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.PromptText = "Seleccione";
            this.cbTurno.Size = new System.Drawing.Size(185, 30);
            this.cbTurno.Style = MetroFramework.MetroColorStyle.Green;
            this.cbTurno.TabIndex = 0;
            this.cbTurno.UseCustomBackColor = true;
            this.cbTurno.UseSelectable = true;
            this.cbTurno.UseStyleColors = true;
            this.cbTurno.SelectedValueChanged += new System.EventHandler(this.cbTurno_SelectedValueChanged);
            this.cbTurno.Leave += new System.EventHandler(this.cbTurno_Leave);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Lime;
            this.metroLabel3.Location = new System.Drawing.Point(35, 44);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(132, 44);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "TURNO:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // dgvAlumnosSala
            // 
            this.dgvAlumnosSala.AllowUserToAddRows = false;
            this.dgvAlumnosSala.AllowUserToDeleteRows = false;
            this.dgvAlumnosSala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlumnosSala.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnosSala.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnosSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosSala.Location = new System.Drawing.Point(32, 211);
            this.dgvAlumnosSala.Name = "dgvAlumnosSala";
            this.dgvAlumnosSala.ReadOnly = true;
            this.dgvAlumnosSala.RowTemplate.Height = 24;
            this.dgvAlumnosSala.Size = new System.Drawing.Size(658, 418);
            this.dgvAlumnosSala.TabIndex = 2;
            this.dgvAlumnosSala.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(65, 173);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(422, 18);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Seleccione turno y sala para visualizar los alumnos registrados";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.ForeColor = System.Drawing.Color.Red;
            this.lblTurno.Location = new System.Drawing.Point(41, 97);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(14, 18);
            this.lblTurno.TabIndex = 4;
            this.lblTurno.Text = "*";
            this.lblTurno.Visible = false;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.ForeColor = System.Drawing.Color.Red;
            this.lblSala.Location = new System.Drawing.Point(517, 97);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(14, 18);
            this.lblSala.TabIndex = 26;
            this.lblSala.Text = "*";
            this.lblSala.Visible = false;
            // 
            // ImprimirLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1429, 727);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvAlumnosSala);
            this.Controls.Add(this.panelTurno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ImprimirLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panelTurno.ResumeLayout(false);
            this.panelTurno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosSala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelTurno;
        private MetroFramework.Controls.MetroComboBox cbSala;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbTurno;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.DataGridView dgvAlumnosSala;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblTurno;
    }
}