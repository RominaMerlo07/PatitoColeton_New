namespace GestionJardin
{
    partial class frmAlumnosPopUpEliminar
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
            this.btn_CancelarUsuNuevo = new FontAwesome.Sharp.IconButton();
            this.btn_GuardarUsuNuevo = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblidPersona = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btn_CancelarUsuNuevo.Location = new System.Drawing.Point(732, 362);
            this.btn_CancelarUsuNuevo.Name = "btn_CancelarUsuNuevo";
            this.btn_CancelarUsuNuevo.Size = new System.Drawing.Size(125, 52);
            this.btn_CancelarUsuNuevo.TabIndex = 13;
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
            this.btn_GuardarUsuNuevo.Location = new System.Drawing.Point(527, 362);
            this.btn_GuardarUsuNuevo.Name = "btn_GuardarUsuNuevo";
            this.btn_GuardarUsuNuevo.Size = new System.Drawing.Size(125, 52);
            this.btn_GuardarUsuNuevo.TabIndex = 12;
            this.btn_GuardarUsuNuevo.Text = "SI";
            this.btn_GuardarUsuNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarUsuNuevo.UseVisualStyleBackColor = false;
            this.btn_GuardarUsuNuevo.Click += new System.EventHandler(this.btn_GuardarUsuNuevo_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(289, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "ALUMNO ?";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "¿Esta seguro que desea DAR DE BAJA al alumno";
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
            this.iconPictureBox1.Location = new System.Drawing.Point(54, 145);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.iconPictureBox1.Size = new System.Drawing.Size(190, 170);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblidPersona
            // 
            this.lblidPersona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblidPersona.AutoSize = true;
            this.lblidPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidPersona.ForeColor = System.Drawing.Color.Yellow;
            this.lblidPersona.Location = new System.Drawing.Point(97, 368);
            this.lblidPersona.Name = "lblidPersona";
            this.lblidPersona.Size = new System.Drawing.Size(156, 32);
            this.lblidPersona.TabIndex = 14;
            this.lblidPersona.Text = "id_persona";
            this.lblidPersona.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(291, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tenga en cuenta que al procesar la baja, NO podrá acceder";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(292, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "a sus datos, hasta procesar su alta nuevamente.";
            // 
            // frmAlumnosPopUpEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(996, 491);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblidPersona);
            this.Controls.Add(this.btn_CancelarUsuNuevo);
            this.Controls.Add(this.btn_GuardarUsuNuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlumnosPopUpEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_CancelarUsuNuevo;
        private FontAwesome.Sharp.IconButton btn_GuardarUsuNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblidPersona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}