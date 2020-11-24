namespace GestionJardin
{
    partial class frmUsuariosPopUpEditar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblEditarUsu = new System.Windows.Forms.Label();
            this.metroTextBoxContrasenaEdit = new MetroFramework.Controls.MetroTextBox();
            this.btn_CancelarUsuMod = new FontAwesome.Sharp.IconButton();
            this.btn_GuardarUsuMod = new FontAwesome.Sharp.IconButton();
            this.lblnombreusuario = new System.Windows.Forms.Label();
            this.btnBloqueo = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(115, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE NUEVA CONTRASEÑA PARA:";
            // 
            // lblEditarUsu
            // 
            this.lblEditarUsu.AutoSize = true;
            this.lblEditarUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarUsu.ForeColor = System.Drawing.Color.Cyan;
            this.lblEditarUsu.Location = new System.Drawing.Point(379, 126);
            this.lblEditarUsu.Name = "lblEditarUsu";
            this.lblEditarUsu.Size = new System.Drawing.Size(102, 25);
            this.lblEditarUsu.TabIndex = 1;
            this.lblEditarUsu.Text = "USUARIO";
            // 
            // metroTextBoxContrasenaEdit
            // 
            // 
            // 
            // 
            this.metroTextBoxContrasenaEdit.CustomButton.FlatAppearance.BorderSize = 0;
            this.metroTextBoxContrasenaEdit.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextBoxContrasenaEdit.CustomButton.Image = null;
            this.metroTextBoxContrasenaEdit.CustomButton.Location = new System.Drawing.Point(274, 1);
            this.metroTextBoxContrasenaEdit.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTextBoxContrasenaEdit.CustomButton.Name = "";
            this.metroTextBoxContrasenaEdit.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.metroTextBoxContrasenaEdit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxContrasenaEdit.CustomButton.TabIndex = 1;
            this.metroTextBoxContrasenaEdit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxContrasenaEdit.CustomButton.UseSelectable = true;
            this.metroTextBoxContrasenaEdit.CustomButton.Visible = false;
            this.metroTextBoxContrasenaEdit.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxContrasenaEdit.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBoxContrasenaEdit.ForeColor = System.Drawing.Color.White;
            this.metroTextBoxContrasenaEdit.IconRight = true;
            this.metroTextBoxContrasenaEdit.Lines = new string[0];
            this.metroTextBoxContrasenaEdit.Location = new System.Drawing.Point(191, 213);
            this.metroTextBoxContrasenaEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTextBoxContrasenaEdit.MaxLength = 32767;
            this.metroTextBoxContrasenaEdit.Name = "metroTextBoxContrasenaEdit";
            this.metroTextBoxContrasenaEdit.PasswordChar = '\0';
            this.metroTextBoxContrasenaEdit.PromptText = "NUEVA CONTRASEÑA";
            this.metroTextBoxContrasenaEdit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxContrasenaEdit.SelectedText = "";
            this.metroTextBoxContrasenaEdit.SelectionLength = 0;
            this.metroTextBoxContrasenaEdit.SelectionStart = 0;
            this.metroTextBoxContrasenaEdit.ShortcutsEnabled = true;
            this.metroTextBoxContrasenaEdit.Size = new System.Drawing.Size(312, 39);
            this.metroTextBoxContrasenaEdit.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxContrasenaEdit.TabIndex = 48;
            this.metroTextBoxContrasenaEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBoxContrasenaEdit.UseCustomBackColor = true;
            this.metroTextBoxContrasenaEdit.UseCustomForeColor = true;
            this.metroTextBoxContrasenaEdit.UseSelectable = true;
            this.metroTextBoxContrasenaEdit.UseStyleColors = true;
            this.metroTextBoxContrasenaEdit.WaterMark = "NUEVA CONTRASEÑA";
            this.metroTextBoxContrasenaEdit.WaterMarkColor = System.Drawing.Color.Cyan;
            this.metroTextBoxContrasenaEdit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextBoxContrasenaEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxContrasenaEdit_KeyPress);
            // 
            // btn_CancelarUsuMod
            // 
            this.btn_CancelarUsuMod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CancelarUsuMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarUsuMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarUsuMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_CancelarUsuMod.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btn_CancelarUsuMod.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_CancelarUsuMod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CancelarUsuMod.IconSize = 50;
            this.btn_CancelarUsuMod.Location = new System.Drawing.Point(369, 330);
            this.btn_CancelarUsuMod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CancelarUsuMod.Name = "btn_CancelarUsuMod";
            this.btn_CancelarUsuMod.Size = new System.Drawing.Size(216, 66);
            this.btn_CancelarUsuMod.TabIndex = 50;
            this.btn_CancelarUsuMod.Text = "CANCELAR";
            this.btn_CancelarUsuMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelarUsuMod.UseVisualStyleBackColor = true;
            this.btn_CancelarUsuMod.Click += new System.EventHandler(this.btn_CancelarUsuMod_Click);
            // 
            // btn_GuardarUsuMod
            // 
            this.btn_GuardarUsuMod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_GuardarUsuMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarUsuMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarUsuMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_GuardarUsuMod.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_GuardarUsuMod.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_GuardarUsuMod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_GuardarUsuMod.IconSize = 50;
            this.btn_GuardarUsuMod.Location = new System.Drawing.Point(119, 330);
            this.btn_GuardarUsuMod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GuardarUsuMod.Name = "btn_GuardarUsuMod";
            this.btn_GuardarUsuMod.Size = new System.Drawing.Size(216, 66);
            this.btn_GuardarUsuMod.TabIndex = 49;
            this.btn_GuardarUsuMod.Text = "GUARDAR";
            this.btn_GuardarUsuMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarUsuMod.UseVisualStyleBackColor = true;
            this.btn_GuardarUsuMod.Click += new System.EventHandler(this.btn_GuardarUsuMod_Click);
            // 
            // lblnombreusuario
            // 
            this.lblnombreusuario.AutoSize = true;
            this.lblnombreusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreusuario.ForeColor = System.Drawing.Color.Yellow;
            this.lblnombreusuario.Location = new System.Drawing.Point(204, 126);
            this.lblnombreusuario.Name = "lblnombreusuario";
            this.lblnombreusuario.Size = new System.Drawing.Size(108, 25);
            this.lblnombreusuario.TabIndex = 52;
            this.lblnombreusuario.Text = "USUARIO:";
            // 
            // btnBloqueo
            // 
            this.btnBloqueo.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnBloqueo.FlatAppearance.BorderSize = 0;
            this.btnBloqueo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloqueo.ForeColor = System.Drawing.Color.Transparent;
            this.btnBloqueo.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnBloqueo.IconColor = System.Drawing.Color.Gray;
            this.btnBloqueo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBloqueo.IconSize = 45;
            this.btnBloqueo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBloqueo.Location = new System.Drawing.Point(508, 213);
            this.btnBloqueo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBloqueo.Name = "btnBloqueo";
            this.btnBloqueo.Size = new System.Drawing.Size(57, 57);
            this.btnBloqueo.TabIndex = 82;
            this.btnBloqueo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBloqueo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBloqueo.UseVisualStyleBackColor = true;
            this.btnBloqueo.Click += new System.EventHandler(this.btnBloqueo_Click);
            // 
            // frmUsuariosPopUpEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(697, 486);
            this.Controls.Add(this.btnBloqueo);
            this.Controls.Add(this.lblnombreusuario);
            this.Controls.Add(this.btn_CancelarUsuMod);
            this.Controls.Add(this.btn_GuardarUsuMod);
            this.Controls.Add(this.metroTextBoxContrasenaEdit);
            this.Controls.Add(this.lblEditarUsu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuariosPopUpEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GESTIÓN USUARIO / MODIFICAR CONTRASEÑA";
            this.Load += new System.EventHandler(this.frmUsuariosPopUpEditar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmUsuariosPopUpEditar_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxContrasenaEdit;
        private FontAwesome.Sharp.IconButton btn_CancelarUsuMod;
        private FontAwesome.Sharp.IconButton btn_GuardarUsuMod;
        public System.Windows.Forms.Label lblEditarUsu;
        public System.Windows.Forms.Label lblnombreusuario;
        private FontAwesome.Sharp.IconButton btnBloqueo;
    }
}