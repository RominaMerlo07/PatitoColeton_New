﻿namespace GestionJardin
{
    partial class frmDocentes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGD_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.btnGD_Filtrar = new FontAwesome.Sharp.IconPictureBox();
            this.btnGD_Excel = new FontAwesome.Sharp.IconPictureBox();
            this.btnGD_Pdf = new FontAwesome.Sharp.IconPictureBox();
            this.btnGD_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnGD_Editar = new FontAwesome.Sharp.IconButton();
            this.btnGD_Agregar = new FontAwesome.Sharp.IconButton();
            this.dgv_Docentes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Filtrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Excel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Pdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Docentes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 570);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "* Para poder editar los datos de un docente o dar de baja al mismo, debe seleccio" +
    "nar el registro previamente";
            // 
            // txtGD_Buscar
            // 
            this.txtGD_Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGD_Buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGD_Buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtGD_Buscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGD_Buscar.CustomButton.Image = null;
            this.txtGD_Buscar.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.txtGD_Buscar.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtGD_Buscar.CustomButton.Name = "";
            this.txtGD_Buscar.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtGD_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGD_Buscar.CustomButton.TabIndex = 1;
            this.txtGD_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGD_Buscar.CustomButton.UseSelectable = true;
            this.txtGD_Buscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtGD_Buscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtGD_Buscar.Lines = new string[0];
            this.txtGD_Buscar.Location = new System.Drawing.Point(43, 44);
            this.txtGD_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtGD_Buscar.MaxLength = 32767;
            this.txtGD_Buscar.Name = "txtGD_Buscar";
            this.txtGD_Buscar.PasswordChar = '\0';
            this.txtGD_Buscar.PromptText = "BUSCAR DOCENTE";
            this.txtGD_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGD_Buscar.SelectedText = "";
            this.txtGD_Buscar.SelectionLength = 0;
            this.txtGD_Buscar.SelectionStart = 0;
            this.txtGD_Buscar.ShortcutsEnabled = true;
            this.txtGD_Buscar.ShowButton = true;
            this.txtGD_Buscar.Size = new System.Drawing.Size(318, 41);
            this.txtGD_Buscar.TabIndex = 34;
            this.txtGD_Buscar.UseSelectable = true;
            this.txtGD_Buscar.WaterMark = "BUSCAR DOCENTE";
            this.txtGD_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGD_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGD_Buscar.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtGD_Buscar_ButtonClick);
            this.txtGD_Buscar.Click += new System.EventHandler(this.txtGD_Buscar_Click);
            this.txtGD_Buscar.Enter += new System.EventHandler(this.txtGD_Buscar_Enter);
            // 
            // btnGD_Filtrar
            // 
            this.btnGD_Filtrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGD_Filtrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGD_Filtrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGD_Filtrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGD_Filtrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnGD_Filtrar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnGD_Filtrar.IconSize = 66;
            this.btnGD_Filtrar.Location = new System.Drawing.Point(659, 44);
            this.btnGD_Filtrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGD_Filtrar.Name = "btnGD_Filtrar";
            this.btnGD_Filtrar.Padding = new System.Windows.Forms.Padding(4);
            this.btnGD_Filtrar.Size = new System.Drawing.Size(69, 66);
            this.btnGD_Filtrar.TabIndex = 41;
            this.btnGD_Filtrar.TabStop = false;
            // 
            // btnGD_Excel
            // 
            this.btnGD_Excel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGD_Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGD_Excel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGD_Excel.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnGD_Excel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnGD_Excel.IconColor = System.Drawing.Color.Chartreuse;
            this.btnGD_Excel.IconSize = 66;
            this.btnGD_Excel.Location = new System.Drawing.Point(749, 44);
            this.btnGD_Excel.Margin = new System.Windows.Forms.Padding(2);
            this.btnGD_Excel.Name = "btnGD_Excel";
            this.btnGD_Excel.Padding = new System.Windows.Forms.Padding(4);
            this.btnGD_Excel.Size = new System.Drawing.Size(69, 66);
            this.btnGD_Excel.TabIndex = 40;
            this.btnGD_Excel.TabStop = false;
            // 
            // btnGD_Pdf
            // 
            this.btnGD_Pdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGD_Pdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGD_Pdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGD_Pdf.ForeColor = System.Drawing.Color.Salmon;
            this.btnGD_Pdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnGD_Pdf.IconColor = System.Drawing.Color.Salmon;
            this.btnGD_Pdf.IconSize = 66;
            this.btnGD_Pdf.Location = new System.Drawing.Point(831, 44);
            this.btnGD_Pdf.Margin = new System.Windows.Forms.Padding(2);
            this.btnGD_Pdf.Name = "btnGD_Pdf";
            this.btnGD_Pdf.Padding = new System.Windows.Forms.Padding(4);
            this.btnGD_Pdf.Size = new System.Drawing.Size(69, 66);
            this.btnGD_Pdf.TabIndex = 39;
            this.btnGD_Pdf.TabStop = false;
            // 
            // btnGD_Eliminar
            // 
            this.btnGD_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGD_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGD_Eliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGD_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGD_Eliminar.ForeColor = System.Drawing.Color.Gray;
            this.btnGD_Eliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnGD_Eliminar.IconColor = System.Drawing.Color.Gray;
            this.btnGD_Eliminar.IconSize = 100;
            this.btnGD_Eliminar.Location = new System.Drawing.Point(1012, 406);
            this.btnGD_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGD_Eliminar.Name = "btnGD_Eliminar";
            this.btnGD_Eliminar.Rotation = 0D;
            this.btnGD_Eliminar.Size = new System.Drawing.Size(220, 109);
            this.btnGD_Eliminar.TabIndex = 37;
            this.btnGD_Eliminar.Text = "ELIMINAR";
            this.btnGD_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGD_Eliminar.UseVisualStyleBackColor = true;
            this.btnGD_Eliminar.Click += new System.EventHandler(this.btnGD_Eliminar_Click);
            // 
            // btnGD_Editar
            // 
            this.btnGD_Editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGD_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGD_Editar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGD_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGD_Editar.ForeColor = System.Drawing.Color.Gray;
            this.btnGD_Editar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnGD_Editar.IconColor = System.Drawing.Color.Gray;
            this.btnGD_Editar.IconSize = 100;
            this.btnGD_Editar.Location = new System.Drawing.Point(1012, 278);
            this.btnGD_Editar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGD_Editar.Name = "btnGD_Editar";
            this.btnGD_Editar.Rotation = 0D;
            this.btnGD_Editar.Size = new System.Drawing.Size(220, 109);
            this.btnGD_Editar.TabIndex = 36;
            this.btnGD_Editar.Text = "EDITAR";
            this.btnGD_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGD_Editar.UseVisualStyleBackColor = true;
            this.btnGD_Editar.Click += new System.EventHandler(this.btnGD_Editar_Click);
            // 
            // btnGD_Agregar
            // 
            this.btnGD_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGD_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGD_Agregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGD_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGD_Agregar.ForeColor = System.Drawing.Color.Lime;
            this.btnGD_Agregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGD_Agregar.IconColor = System.Drawing.Color.Lime;
            this.btnGD_Agregar.IconSize = 100;
            this.btnGD_Agregar.Location = new System.Drawing.Point(1012, 151);
            this.btnGD_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGD_Agregar.Name = "btnGD_Agregar";
            this.btnGD_Agregar.Rotation = 0D;
            this.btnGD_Agregar.Size = new System.Drawing.Size(220, 109);
            this.btnGD_Agregar.TabIndex = 35;
            this.btnGD_Agregar.Text = "AGREGAR";
            this.btnGD_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGD_Agregar.UseVisualStyleBackColor = true;
            this.btnGD_Agregar.Click += new System.EventHandler(this.btnGD_Agregar_Click);
            // 
            // dgv_Docentes
            // 
            this.dgv_Docentes.AllowUserToAddRows = false;
            this.dgv_Docentes.AllowUserToDeleteRows = false;
            this.dgv_Docentes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Docentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Docentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Docentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Docentes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Docentes.Location = new System.Drawing.Point(44, 136);
            this.dgv_Docentes.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Docentes.Name = "dgv_Docentes";
            this.dgv_Docentes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Docentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Docentes.RowTemplate.Height = 24;
            this.dgv_Docentes.Size = new System.Drawing.Size(856, 402);
            this.dgv_Docentes.TabIndex = 42;
            this.dgv_Docentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Docentes_CellClick);
            // 
            // frmDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.dgv_Docentes);
            this.Controls.Add(this.btnGD_Filtrar);
            this.Controls.Add(this.btnGD_Excel);
            this.Controls.Add(this.btnGD_Pdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGD_Eliminar);
            this.Controls.Add(this.btnGD_Editar);
            this.Controls.Add(this.btnGD_Agregar);
            this.Controls.Add(this.txtGD_Buscar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDocentes";
            this.Text = "GESTIÓN DOCENTES";
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Filtrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Excel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Pdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Docentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnGD_Filtrar;
        private FontAwesome.Sharp.IconPictureBox btnGD_Excel;
        private FontAwesome.Sharp.IconPictureBox btnGD_Pdf;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnGD_Eliminar;
        private FontAwesome.Sharp.IconButton btnGD_Editar;
        private FontAwesome.Sharp.IconButton btnGD_Agregar;
        private MetroFramework.Controls.MetroTextBox txtGD_Buscar;
        public System.Windows.Forms.DataGridView dgv_Docentes;
    }
}