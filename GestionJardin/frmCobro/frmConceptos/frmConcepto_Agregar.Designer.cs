namespace GestionJardin
{
    partial class frmConcepto_Agregar
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
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtSigno = new MetroFramework.Controls.MetroTextBox();
            this.cbConcepto = new MetroFramework.Controls.MetroComboBox();
            this.txt_valor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.lblValor);
            this.metroPanel3.Controls.Add(this.lblConcepto);
            this.metroPanel3.Controls.Add(this.txtSigno);
            this.metroPanel3.Controls.Add(this.cbConcepto);
            this.metroPanel3.Controls.Add(this.txt_valor);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(45, 39);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1261, 322);
            this.metroPanel3.TabIndex = 1;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 11;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.Red;
            this.lblValor.Location = new System.Drawing.Point(769, 188);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 17);
            this.lblValor.TabIndex = 32;
            this.lblValor.Text = "label2";
            this.lblValor.Visible = false;
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.ForeColor = System.Drawing.Color.Red;
            this.lblConcepto.Location = new System.Drawing.Point(52, 188);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(46, 17);
            this.lblConcepto.TabIndex = 31;
            this.lblConcepto.Text = "label1";
            this.lblConcepto.Visible = false;
            // 
            // txtSigno
            // 
            // 
            // 
            // 
            this.txtSigno.CustomButton.Image = null;
            this.txtSigno.CustomButton.Location = new System.Drawing.Point(8, 2);
            this.txtSigno.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSigno.CustomButton.Name = "";
            this.txtSigno.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSigno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSigno.CustomButton.TabIndex = 1;
            this.txtSigno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSigno.CustomButton.UseSelectable = true;
            this.txtSigno.CustomButton.Visible = false;
            this.txtSigno.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSigno.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSigno.Lines = new string[] {
        "$"};
            this.txtSigno.Location = new System.Drawing.Point(941, 144);
            this.txtSigno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSigno.MaxLength = 32767;
            this.txtSigno.Name = "txtSigno";
            this.txtSigno.PasswordChar = '\0';
            this.txtSigno.ReadOnly = true;
            this.txtSigno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSigno.SelectedText = "";
            this.txtSigno.SelectionLength = 0;
            this.txtSigno.SelectionStart = 0;
            this.txtSigno.ShortcutsEnabled = true;
            this.txtSigno.Size = new System.Drawing.Size(40, 34);
            this.txtSigno.Style = MetroFramework.MetroColorStyle.Green;
            this.txtSigno.TabIndex = 30;
            this.txtSigno.Text = "$";
            this.txtSigno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSigno.UseCustomBackColor = true;
            this.txtSigno.UseCustomForeColor = true;
            this.txtSigno.UseSelectable = true;
            this.txtSigno.WaterMarkColor = System.Drawing.Color.White;
            this.txtSigno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.cbConcepto.Location = new System.Drawing.Point(263, 140);
            this.cbConcepto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbConcepto.Name = "cbConcepto";
            this.cbConcepto.PromptText = "Seleccione";
            this.cbConcepto.Size = new System.Drawing.Size(311, 30);
            this.cbConcepto.Style = MetroFramework.MetroColorStyle.Green;
            this.cbConcepto.TabIndex = 0;
            this.cbConcepto.UseCustomBackColor = true;
            this.cbConcepto.UseSelectable = true;
            this.cbConcepto.UseStyleColors = true;
            this.cbConcepto.SelectedValueChanged += new System.EventHandler(this.cbConcepto_SelectedValueChanged);
            this.cbConcepto.Leave += new System.EventHandler(this.cbConcepto_Leave);
            // 
            // txt_valor
            // 
            // 
            // 
            // 
            this.txt_valor.CustomButton.Image = null;
            this.txt_valor.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.txt_valor.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_valor.CustomButton.Name = "";
            this.txt_valor.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txt_valor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_valor.CustomButton.TabIndex = 1;
            this.txt_valor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_valor.CustomButton.UseSelectable = true;
            this.txt_valor.CustomButton.Visible = false;
            this.txt_valor.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_valor.ForeColor = System.Drawing.Color.Yellow;
            this.txt_valor.Lines = new string[0];
            this.txt_valor.Location = new System.Drawing.Point(986, 144);
            this.txt_valor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_valor.MaxLength = 32767;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.PasswordChar = '\0';
            this.txt_valor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_valor.SelectedText = "";
            this.txt_valor.SelectionLength = 0;
            this.txt_valor.SelectionStart = 0;
            this.txt_valor.ShortcutsEnabled = true;
            this.txt_valor.Size = new System.Drawing.Size(177, 34);
            this.txt_valor.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_valor.TabIndex = 1;
            this.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_valor.UseCustomBackColor = true;
            this.txt_valor.UseCustomForeColor = true;
            this.txt_valor.UseSelectable = true;
            this.txt_valor.UseStyleColors = true;
            this.txt_valor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_valor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_KeyPress);
            this.txt_valor.Leave += new System.EventHandler(this.txt_valor_Leave);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.Yellow;
            this.metroLabel4.Location = new System.Drawing.Point(762, 140);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(173, 40);
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "VALOR:";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Lime;
            this.metroLabel3.Location = new System.Drawing.Point(52, 140);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(293, 44);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "CONCEPTO:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnCancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 60;
            this.btnCancelar.Location = new System.Drawing.Point(1052, 421);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(239, 76);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 60;
            this.btnGuardar.Location = new System.Drawing.Point(723, 421);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(239, 76);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmConcepto_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1365, 546);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.metroPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConcepto_Agregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmConcepto_Agregar_Load);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroComboBox cbConcepto;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_valor;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtSigno;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblConcepto;
    }
}