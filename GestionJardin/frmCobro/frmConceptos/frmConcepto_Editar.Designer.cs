namespace GestionJardin
{
    partial class frmConcepto_Editar
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
            this.btnBloqueo = new FontAwesome.Sharp.IconButton();
            this.txtSigno = new MetroFramework.Controls.MetroTextBox();
            this.txt_valor_actualizar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lbl_titulo_conceptos = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnBloqueo
            // 
            this.btnBloqueo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnBloqueo.FlatAppearance.BorderSize = 0;
            this.btnBloqueo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBloqueo.ForeColor = System.Drawing.Color.Transparent;
            this.btnBloqueo.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnBloqueo.IconColor = System.Drawing.Color.Aqua;
            this.btnBloqueo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBloqueo.IconSize = 45;
            this.btnBloqueo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBloqueo.Location = new System.Drawing.Point(444, 130);
            this.btnBloqueo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBloqueo.Name = "btnBloqueo";
            this.btnBloqueo.Size = new System.Drawing.Size(77, 66);
            this.btnBloqueo.TabIndex = 55;
            this.btnBloqueo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBloqueo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBloqueo.UseVisualStyleBackColor = false;
            this.btnBloqueo.Click += new System.EventHandler(this.btnBloqueo_Click);
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
            this.txtSigno.Location = new System.Drawing.Point(377, 145);
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
            // txt_valor_actualizar
            // 
            // 
            // 
            // 
            this.txt_valor_actualizar.CustomButton.Image = null;
            this.txt_valor_actualizar.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.txt_valor_actualizar.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_valor_actualizar.CustomButton.Name = "";
            this.txt_valor_actualizar.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txt_valor_actualizar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_valor_actualizar.CustomButton.TabIndex = 1;
            this.txt_valor_actualizar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_valor_actualizar.CustomButton.UseSelectable = true;
            this.txt_valor_actualizar.CustomButton.Visible = false;
            this.txt_valor_actualizar.Enabled = false;
            this.txt_valor_actualizar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_valor_actualizar.ForeColor = System.Drawing.Color.Yellow;
            this.txt_valor_actualizar.Lines = new string[0];
            this.txt_valor_actualizar.Location = new System.Drawing.Point(200, 145);
            this.txt_valor_actualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_valor_actualizar.MaxLength = 32767;
            this.txt_valor_actualizar.Name = "txt_valor_actualizar";
            this.txt_valor_actualizar.PasswordChar = '\0';
            this.txt_valor_actualizar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_valor_actualizar.SelectedText = "";
            this.txt_valor_actualizar.SelectionLength = 0;
            this.txt_valor_actualizar.SelectionStart = 0;
            this.txt_valor_actualizar.ShortcutsEnabled = true;
            this.txt_valor_actualizar.Size = new System.Drawing.Size(177, 34);
            this.txt_valor_actualizar.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_valor_actualizar.TabIndex = 29;
            this.txt_valor_actualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_valor_actualizar.UseCustomBackColor = true;
            this.txt_valor_actualizar.UseCustomForeColor = true;
            this.txt_valor_actualizar.UseSelectable = true;
            this.txt_valor_actualizar.UseStyleColors = true;
            this.txt_valor_actualizar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_valor_actualizar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_valor_actualizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_actualizar_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.Yellow;
            this.metroLabel4.Location = new System.Drawing.Point(21, 139);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(173, 44);
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "VALOR:";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
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
            this.btnCancelar.Location = new System.Drawing.Point(1052, 270);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(239, 76);
            this.btnCancelar.TabIndex = 45;
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
            this.btnGuardar.Location = new System.Drawing.Point(723, 270);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(239, 76);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Aqua;
            this.metroLabel2.Location = new System.Drawing.Point(12, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(1485, 44);
            this.metroLabel2.TabIndex = 57;
            this.metroLabel2.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // lbl_titulo_conceptos
            // 
            this.lbl_titulo_conceptos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_titulo_conceptos.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_titulo_conceptos.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_titulo_conceptos.Location = new System.Drawing.Point(12, 23);
            this.lbl_titulo_conceptos.Name = "lbl_titulo_conceptos";
            this.lbl_titulo_conceptos.Size = new System.Drawing.Size(1236, 44);
            this.lbl_titulo_conceptos.TabIndex = 56;
            this.lbl_titulo_conceptos.Text = "CONCEPTO: \"\"- AÑO: \"\" \r\n";
            this.lbl_titulo_conceptos.UseCustomBackColor = true;
            this.lbl_titulo_conceptos.UseCustomForeColor = true;
            // 
            // frmConcepto_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1365, 391);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lbl_titulo_conceptos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBloqueo);
            this.Controls.Add(this.txtSigno);
            this.Controls.Add(this.txt_valor_actualizar);
            this.Controls.Add(this.metroLabel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmConcepto_Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtSigno;
        private MetroFramework.Controls.MetroTextBox txt_valor_actualizar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnBloqueo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lbl_titulo_conceptos;
    }
}