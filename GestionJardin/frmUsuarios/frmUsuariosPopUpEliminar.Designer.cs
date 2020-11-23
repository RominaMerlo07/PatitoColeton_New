namespace GestionJardin
{
    partial class frmUsuariosPopUpEliminar
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
            this.lblUSUARIOELIMINAR = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_CancelarUsuNuevo = new FontAwesome.Sharp.IconButton();
            this.btn_GuardarUsuNuevo = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿Esta seguro que desea ELIMINAR a";
            // 
            // lblUSUARIOELIMINAR
            // 
            this.lblUSUARIOELIMINAR.AutoSize = true;
            this.lblUSUARIOELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSUARIOELIMINAR.ForeColor = System.Drawing.Color.Yellow;
            this.lblUSUARIOELIMINAR.Location = new System.Drawing.Point(353, 135);
            this.lblUSUARIOELIMINAR.Name = "lblUSUARIOELIMINAR";
            this.lblUSUARIOELIMINAR.Size = new System.Drawing.Size(165, 32);
            this.lblUSUARIOELIMINAR.TabIndex = 2;
            this.lblUSUARIOELIMINAR.Text = "USUARIO ?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(269, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tenga en cuenta que al confirmar,";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(296, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "NO podrá reactivar el mismo. ";
            // 
            // btn_CancelarUsuNuevo
            // 
            this.btn_CancelarUsuNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CancelarUsuNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarUsuNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarUsuNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarUsuNuevo.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_CancelarUsuNuevo.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btn_CancelarUsuNuevo.IconColor = System.Drawing.Color.DarkGray;
            this.btn_CancelarUsuNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CancelarUsuNuevo.IconSize = 36;
            this.btn_CancelarUsuNuevo.Location = new System.Drawing.Point(475, 347);
            this.btn_CancelarUsuNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CancelarUsuNuevo.Name = "btn_CancelarUsuNuevo";
            this.btn_CancelarUsuNuevo.Size = new System.Drawing.Size(125, 52);
            this.btn_CancelarUsuNuevo.TabIndex = 16;
            this.btn_CancelarUsuNuevo.Text = "NO";
            this.btn_CancelarUsuNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelarUsuNuevo.UseVisualStyleBackColor = false;
            this.btn_CancelarUsuNuevo.Click += new System.EventHandler(this.btn_CancelarUsuNuevo_Click);
            // 
            // btn_GuardarUsuNuevo
            // 
            this.btn_GuardarUsuNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_GuardarUsuNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btn_GuardarUsuNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarUsuNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarUsuNuevo.ForeColor = System.Drawing.Color.Red;
            this.btn_GuardarUsuNuevo.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btn_GuardarUsuNuevo.IconColor = System.Drawing.Color.Red;
            this.btn_GuardarUsuNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_GuardarUsuNuevo.IconSize = 36;
            this.btn_GuardarUsuNuevo.Location = new System.Drawing.Point(273, 347);
            this.btn_GuardarUsuNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GuardarUsuNuevo.Name = "btn_GuardarUsuNuevo";
            this.btn_GuardarUsuNuevo.Size = new System.Drawing.Size(125, 52);
            this.btn_GuardarUsuNuevo.TabIndex = 15;
            this.btn_GuardarUsuNuevo.Text = "SI";
            this.btn_GuardarUsuNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarUsuNuevo.UseVisualStyleBackColor = false;
            this.btn_GuardarUsuNuevo.Click += new System.EventHandler(this.btn_GuardarUsuNuevo_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 170;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 135);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.iconPictureBox1.Size = new System.Drawing.Size(189, 170);
            this.iconPictureBox1.TabIndex = 14;
            this.iconPictureBox1.TabStop = false;
            // 
            // frmUsuariosPopUpEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(771, 463);
            this.Controls.Add(this.btn_CancelarUsuNuevo);
            this.Controls.Add(this.btn_GuardarUsuNuevo);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUSUARIOELIMINAR);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuariosPopUpEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GESTIÓN USUARIOS / PROCESAR BAJA USUARIO";
            this.Load += new System.EventHandler(this.frmUsuariosPopUpEliminar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmUsuariosPopUpEliminar_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btn_CancelarUsuNuevo;
        private FontAwesome.Sharp.IconButton btn_GuardarUsuNuevo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public System.Windows.Forms.Label lblUSUARIOELIMINAR;
    }
}