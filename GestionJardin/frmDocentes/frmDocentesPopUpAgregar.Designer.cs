﻿namespace GestionJardin
{
    partial class frmDocentesPopUpAgregar
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
            this.cbSala = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbTurno = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.panelDatos = new MetroFramework.Controls.MetroPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtNacimiento = new MetroFramework.Controls.MetroDateTime();
            this.lblDatosPersonales = new MetroFramework.Controls.MetroLabel();
            this.cbGenero = new MetroFramework.Controls.MetroComboBox();
            this.txtDocumento = new MetroFramework.Controls.MetroTextBox();
            this.txtApellidos = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.panelContacto = new MetroFramework.Controls.MetroPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtCelular = new MetroFramework.Controls.MetroTextBox();
            this.txtTelefono = new MetroFramework.Controls.MetroTextBox();
            this.txtCPostal = new MetroFramework.Controls.MetroTextBox();
            this.txtDepto = new MetroFramework.Controls.MetroTextBox();
            this.txtNumero = new MetroFramework.Controls.MetroTextBox();
            this.lblDatosContacto = new MetroFramework.Controls.MetroLabel();
            this.txtBarrio = new MetroFramework.Controls.MetroTextBox();
            this.txtPiso = new MetroFramework.Controls.MetroTextBox();
            this.txtCalle = new MetroFramework.Controls.MetroTextBox();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel3.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.panelContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.cbSala);
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.Controls.Add(this.cbTurno);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(158, 30);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1099, 126);
            this.metroPanel3.TabIndex = 32;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // cbSala
            // 
            this.cbSala.Enabled = false;
            this.cbSala.FormattingEnabled = true;
            this.cbSala.ItemHeight = 24;
            this.cbSala.Items.AddRange(new object[] {
            "VERDE ",
            "NARANJA ",
            "ROSA"});
            this.cbSala.Location = new System.Drawing.Point(858, 46);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(185, 30);
            this.cbSala.Style = MetroFramework.MetroColorStyle.Green;
            this.cbSala.TabIndex = 25;
            this.cbSala.UseCustomBackColor = true;
            this.cbSala.UseSelectable = true;
            this.cbSala.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Lime;
            this.metroLabel2.Location = new System.Drawing.Point(531, 46);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(287, 44);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "SELECCIONE SALA";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // cbTurno
            // 
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.ItemHeight = 24;
            this.cbTurno.Items.AddRange(new object[] {
            "MAÑANA",
            "TARDE"});
            this.cbTurno.Location = new System.Drawing.Point(255, 46);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.PromptText = "TURNO";
            this.cbTurno.Size = new System.Drawing.Size(185, 30);
            this.cbTurno.Style = MetroFramework.MetroColorStyle.Green;
            this.cbTurno.TabIndex = 23;
            this.cbTurno.UseCustomBackColor = true;
            this.cbTurno.UseSelectable = true;
            this.cbTurno.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Lime;
            this.metroLabel3.Location = new System.Drawing.Point(24, 46);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(294, 44);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "SELECCIONE:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // panelDatos
            // 
            this.panelDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panelDatos.Controls.Add(this.label5);
            this.panelDatos.Controls.Add(this.label4);
            this.panelDatos.Controls.Add(this.label3);
            this.panelDatos.Controls.Add(this.label2);
            this.panelDatos.Controls.Add(this.label6);
            this.panelDatos.Controls.Add(this.metroPanel1);
            this.panelDatos.Controls.Add(this.lblDatosPersonales);
            this.panelDatos.Controls.Add(this.cbGenero);
            this.panelDatos.Controls.Add(this.txtDocumento);
            this.panelDatos.Controls.Add(this.txtApellidos);
            this.panelDatos.Controls.Add(this.txtNombre);
            this.panelDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDatos.HorizontalScrollbarBarColor = true;
            this.panelDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDatos.HorizontalScrollbarSize = 10;
            this.panelDatos.Location = new System.Drawing.Point(33, 212);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(493, 478);
            this.panelDatos.TabIndex = 33;
            this.panelDatos.UseCustomBackColor = true;
            this.panelDatos.VerticalScrollbarBarColor = true;
            this.panelDatos.VerticalScrollbarHighlightOnWheel = false;
            this.panelDatos.VerticalScrollbarSize = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(416, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(416, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(416, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(416, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(416, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "*";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.dtNacimiento);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(16, 304);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(365, 50);
            this.metroPanel1.TabIndex = 19;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(11, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(154, 30);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Fecha de Nac.";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNacimiento.Location = new System.Drawing.Point(169, 10);
            this.dtNacimiento.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dtNacimiento.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dtNacimiento.MinimumSize = new System.Drawing.Size(0, 27);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(184, 27);
            this.dtNacimiento.Style = MetroFramework.MetroColorStyle.Green;
            this.dtNacimiento.TabIndex = 20;
            this.dtNacimiento.Value = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dtNacimiento.Leave += new System.EventHandler(this.dtNacimiento_Leave);
            // 
            // lblDatosPersonales
            // 
            this.lblDatosPersonales.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDatosPersonales.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDatosPersonales.Location = new System.Drawing.Point(27, 25);
            this.lblDatosPersonales.Name = "lblDatosPersonales";
            this.lblDatosPersonales.Size = new System.Drawing.Size(325, 37);
            this.lblDatosPersonales.TabIndex = 21;
            this.lblDatosPersonales.Text = "Datos Personales";
            this.lblDatosPersonales.UseCustomBackColor = true;
            // 
            // cbGenero
            // 
            this.cbGenero.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.ItemHeight = 21;
            this.cbGenero.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cbGenero.Location = new System.Drawing.Point(51, 396);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.PromptText = "Género";
            this.cbGenero.Size = new System.Drawing.Size(330, 27);
            this.cbGenero.Style = MetroFramework.MetroColorStyle.Green;
            this.cbGenero.TabIndex = 20;
            this.cbGenero.UseSelectable = true;
            // 
            // txtDocumento
            // 
            this.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtDocumento.CustomButton.Image = null;
            this.txtDocumento.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.txtDocumento.CustomButton.Name = "";
            this.txtDocumento.CustomButton.Size = new System.Drawing.Size(29, 26);
            this.txtDocumento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocumento.CustomButton.TabIndex = 1;
            this.txtDocumento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocumento.CustomButton.UseSelectable = true;
            this.txtDocumento.CustomButton.Visible = false;
            this.txtDocumento.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDocumento.Lines = new string[0];
            this.txtDocumento.Location = new System.Drawing.Point(49, 101);
            this.txtDocumento.MaxLength = 32767;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.PromptText = "Documento Ej: 30123456";
            this.txtDocumento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.ShortcutsEnabled = true;
            this.txtDocumento.Size = new System.Drawing.Size(332, 35);
            this.txtDocumento.Style = MetroFramework.MetroColorStyle.Green;
            this.txtDocumento.TabIndex = 2;
            this.txtDocumento.UseSelectable = true;
            this.txtDocumento.WaterMark = "Documento Ej: 30123456";
            this.txtDocumento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocumento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtApellidos.CustomButton.Image = null;
            this.txtApellidos.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtApellidos.CustomButton.Name = "";
            this.txtApellidos.CustomButton.Size = new System.Drawing.Size(29, 26);
            this.txtApellidos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellidos.CustomButton.TabIndex = 1;
            this.txtApellidos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellidos.CustomButton.UseSelectable = true;
            this.txtApellidos.CustomButton.Visible = false;
            this.txtApellidos.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtApellidos.Lines = new string[0];
            this.txtApellidos.Location = new System.Drawing.Point(51, 231);
            this.txtApellidos.MaxLength = 32767;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.PromptText = "Apellidos";
            this.txtApellidos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.SelectionLength = 0;
            this.txtApellidos.SelectionStart = 0;
            this.txtApellidos.ShortcutsEnabled = true;
            this.txtApellidos.Size = new System.Drawing.Size(330, 35);
            this.txtApellidos.Style = MetroFramework.MetroColorStyle.Green;
            this.txtApellidos.TabIndex = 4;
            this.txtApellidos.UseSelectable = true;
            this.txtApellidos.WaterMark = "Apellidos";
            this.txtApellidos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellidos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(29, 26);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(51, 166);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PromptText = "Nombres";
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(330, 35);
            this.txtNombre.Style = MetroFramework.MetroColorStyle.Green;
            this.txtNombre.TabIndex = 3;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMark = "Nombres";
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // panelContacto
            // 
            this.panelContacto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panelContacto.Controls.Add(this.label1);
            this.panelContacto.Controls.Add(this.label10);
            this.panelContacto.Controls.Add(this.label9);
            this.panelContacto.Controls.Add(this.label8);
            this.panelContacto.Controls.Add(this.label7);
            this.panelContacto.Controls.Add(this.label11);
            this.panelContacto.Controls.Add(this.txtEmail);
            this.panelContacto.Controls.Add(this.txtCelular);
            this.panelContacto.Controls.Add(this.txtTelefono);
            this.panelContacto.Controls.Add(this.txtCPostal);
            this.panelContacto.Controls.Add(this.txtDepto);
            this.panelContacto.Controls.Add(this.txtNumero);
            this.panelContacto.Controls.Add(this.lblDatosContacto);
            this.panelContacto.Controls.Add(this.txtBarrio);
            this.panelContacto.Controls.Add(this.txtPiso);
            this.panelContacto.Controls.Add(this.txtCalle);
            this.panelContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContacto.HorizontalScrollbarBarColor = true;
            this.panelContacto.HorizontalScrollbarHighlightOnWheel = false;
            this.panelContacto.HorizontalScrollbarSize = 10;
            this.panelContacto.Location = new System.Drawing.Point(609, 212);
            this.panelContacto.Name = "panelContacto";
            this.panelContacto.Size = new System.Drawing.Size(824, 478);
            this.panelContacto.TabIndex = 45;
            this.panelContacto.UseCustomBackColor = true;
            this.panelContacto.VerticalScrollbarBarColor = true;
            this.panelContacto.VerticalScrollbarHighlightOnWheel = false;
            this.panelContacto.VerticalScrollbarSize = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(764, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 25);
            this.label10.TabIndex = 33;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(764, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(573, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(384, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(384, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "*";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(252, 2);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(47, 333);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "E-mail";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(321, 40);
            this.txtEmail.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.TabIndex = 10;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "E-mail";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtCelular
            // 
            this.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtCelular.CustomButton.Image = null;
            this.txtCelular.CustomButton.Location = new System.Drawing.Point(250, 2);
            this.txtCelular.CustomButton.Name = "";
            this.txtCelular.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtCelular.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCelular.CustomButton.TabIndex = 1;
            this.txtCelular.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCelular.CustomButton.UseSelectable = true;
            this.txtCelular.CustomButton.Visible = false;
            this.txtCelular.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCelular.Lines = new string[0];
            this.txtCelular.Location = new System.Drawing.Point(49, 270);
            this.txtCelular.MaxLength = 32767;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.PasswordChar = '\0';
            this.txtCelular.PromptText = "Celular Ej: 3512345678";
            this.txtCelular.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCelular.SelectedText = "";
            this.txtCelular.SelectionLength = 0;
            this.txtCelular.SelectionStart = 0;
            this.txtCelular.ShortcutsEnabled = true;
            this.txtCelular.Size = new System.Drawing.Size(319, 40);
            this.txtCelular.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCelular.TabIndex = 9;
            this.txtCelular.UseSelectable = true;
            this.txtCelular.WaterMark = "Celular Ej: 3512345678";
            this.txtCelular.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCelular.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtTelefono.CustomButton.Image = null;
            this.txtTelefono.CustomButton.Location = new System.Drawing.Point(250, 2);
            this.txtTelefono.CustomButton.Name = "";
            this.txtTelefono.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefono.CustomButton.TabIndex = 1;
            this.txtTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefono.CustomButton.UseSelectable = true;
            this.txtTelefono.CustomButton.Visible = false;
            this.txtTelefono.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTelefono.Lines = new string[0];
            this.txtTelefono.Location = new System.Drawing.Point(439, 270);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PromptText = "Teléfono  Ej: 3512345678";
            this.txtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.ShortcutsEnabled = true;
            this.txtTelefono.Size = new System.Drawing.Size(319, 40);
            this.txtTelefono.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.UseSelectable = true;
            this.txtTelefono.WaterMark = "Teléfono  Ej: 3512345678";
            this.txtTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtCPostal
            // 
            this.txtCPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtCPostal.CustomButton.Image = null;
            this.txtCPostal.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtCPostal.CustomButton.Name = "";
            this.txtCPostal.CustomButton.Size = new System.Drawing.Size(29, 26);
            this.txtCPostal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCPostal.CustomButton.TabIndex = 1;
            this.txtCPostal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCPostal.CustomButton.UseSelectable = true;
            this.txtCPostal.CustomButton.Visible = false;
            this.txtCPostal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCPostal.Lines = new string[0];
            this.txtCPostal.Location = new System.Drawing.Point(608, 134);
            this.txtCPostal.MaxLength = 32767;
            this.txtCPostal.Name = "txtCPostal";
            this.txtCPostal.PasswordChar = '\0';
            this.txtCPostal.PromptText = "C. Postal";
            this.txtCPostal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCPostal.SelectedText = "";
            this.txtCPostal.SelectionLength = 0;
            this.txtCPostal.SelectionStart = 0;
            this.txtCPostal.ShortcutsEnabled = true;
            this.txtCPostal.Size = new System.Drawing.Size(150, 35);
            this.txtCPostal.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCPostal.TabIndex = 4;
            this.txtCPostal.UseSelectable = true;
            this.txtCPostal.WaterMark = "C. Postal";
            this.txtCPostal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCPostal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPostal_KeyPress);
            // 
            // txtDepto
            // 
            this.txtDepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtDepto.CustomButton.Image = null;
            this.txtDepto.CustomButton.Location = new System.Drawing.Point(60, 2);
            this.txtDepto.CustomButton.Name = "";
            this.txtDepto.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtDepto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDepto.CustomButton.TabIndex = 1;
            this.txtDepto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDepto.CustomButton.UseSelectable = true;
            this.txtDepto.CustomButton.Visible = false;
            this.txtDepto.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDepto.Lines = new string[0];
            this.txtDepto.Location = new System.Drawing.Point(207, 203);
            this.txtDepto.MaxLength = 32767;
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.PasswordChar = '\0';
            this.txtDepto.PromptText = "Depto.";
            this.txtDepto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDepto.SelectedText = "";
            this.txtDepto.SelectionLength = 0;
            this.txtDepto.SelectionStart = 0;
            this.txtDepto.ShortcutsEnabled = true;
            this.txtDepto.Size = new System.Drawing.Size(105, 40);
            this.txtDepto.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDepto.TabIndex = 6;
            this.txtDepto.UseSelectable = true;
            this.txtDepto.WaterMark = "Depto.";
            this.txtDepto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDepto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtNumero.CustomButton.Image = null;
            this.txtNumero.CustomButton.Location = new System.Drawing.Point(84, 1);
            this.txtNumero.CustomButton.Name = "";
            this.txtNumero.CustomButton.Size = new System.Drawing.Size(29, 26);
            this.txtNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumero.CustomButton.TabIndex = 1;
            this.txtNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumero.CustomButton.UseSelectable = true;
            this.txtNumero.CustomButton.Visible = false;
            this.txtNumero.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNumero.Lines = new string[0];
            this.txtNumero.Location = new System.Drawing.Point(439, 134);
            this.txtNumero.MaxLength = 32767;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.PromptText = "Número";
            this.txtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.ShortcutsEnabled = true;
            this.txtNumero.Size = new System.Drawing.Size(128, 35);
            this.txtNumero.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumero.TabIndex = 3;
            this.txtNumero.UseSelectable = true;
            this.txtNumero.WaterMark = "Número";
            this.txtNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblDatosContacto
            // 
            this.lblDatosContacto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatosContacto.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDatosContacto.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDatosContacto.Location = new System.Drawing.Point(47, 25);
            this.lblDatosContacto.Name = "lblDatosContacto";
            this.lblDatosContacto.Size = new System.Drawing.Size(458, 44);
            this.lblDatosContacto.TabIndex = 21;
            this.lblDatosContacto.Text = "Datos de Contacto";
            this.lblDatosContacto.UseCustomBackColor = true;
            // 
            // txtBarrio
            // 
            this.txtBarrio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtBarrio.CustomButton.Image = null;
            this.txtBarrio.CustomButton.Location = new System.Drawing.Point(250, 2);
            this.txtBarrio.CustomButton.Name = "";
            this.txtBarrio.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtBarrio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBarrio.CustomButton.TabIndex = 1;
            this.txtBarrio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBarrio.CustomButton.UseSelectable = true;
            this.txtBarrio.CustomButton.Visible = false;
            this.txtBarrio.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBarrio.Lines = new string[0];
            this.txtBarrio.Location = new System.Drawing.Point(439, 203);
            this.txtBarrio.MaxLength = 32767;
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.PasswordChar = '\0';
            this.txtBarrio.PromptText = "Barrio";
            this.txtBarrio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarrio.SelectedText = "";
            this.txtBarrio.SelectionLength = 0;
            this.txtBarrio.SelectionStart = 0;
            this.txtBarrio.ShortcutsEnabled = true;
            this.txtBarrio.Size = new System.Drawing.Size(319, 40);
            this.txtBarrio.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBarrio.TabIndex = 7;
            this.txtBarrio.UseSelectable = true;
            this.txtBarrio.WaterMark = "Barrio";
            this.txtBarrio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarrio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtPiso
            // 
            this.txtPiso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtPiso.CustomButton.Image = null;
            this.txtPiso.CustomButton.Location = new System.Drawing.Point(60, 2);
            this.txtPiso.CustomButton.Name = "";
            this.txtPiso.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtPiso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPiso.CustomButton.TabIndex = 1;
            this.txtPiso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPiso.CustomButton.UseSelectable = true;
            this.txtPiso.CustomButton.Visible = false;
            this.txtPiso.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPiso.Lines = new string[0];
            this.txtPiso.Location = new System.Drawing.Point(49, 203);
            this.txtPiso.MaxLength = 32767;
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.PasswordChar = '\0';
            this.txtPiso.PromptText = "Piso";
            this.txtPiso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPiso.SelectedText = "";
            this.txtPiso.SelectionLength = 0;
            this.txtPiso.SelectionStart = 0;
            this.txtPiso.ShortcutsEnabled = true;
            this.txtPiso.Size = new System.Drawing.Size(105, 40);
            this.txtPiso.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPiso.TabIndex = 5;
            this.txtPiso.UseSelectable = true;
            this.txtPiso.WaterMark = "Piso";
            this.txtPiso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPiso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtCalle
            // 
            this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtCalle.CustomButton.Image = null;
            this.txtCalle.CustomButton.Location = new System.Drawing.Point(255, 1);
            this.txtCalle.CustomButton.Name = "";
            this.txtCalle.CustomButton.Size = new System.Drawing.Size(29, 26);
            this.txtCalle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCalle.CustomButton.TabIndex = 1;
            this.txtCalle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCalle.CustomButton.UseSelectable = true;
            this.txtCalle.CustomButton.Visible = false;
            this.txtCalle.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCalle.Lines = new string[0];
            this.txtCalle.Location = new System.Drawing.Point(47, 134);
            this.txtCalle.MaxLength = 32767;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.PasswordChar = '\0';
            this.txtCalle.PromptText = "Calle";
            this.txtCalle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCalle.SelectedText = "";
            this.txtCalle.SelectionLength = 0;
            this.txtCalle.SelectionStart = 0;
            this.txtCalle.ShortcutsEnabled = true;
            this.txtCalle.Size = new System.Drawing.Size(321, 35);
            this.txtCalle.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCalle.TabIndex = 2;
            this.txtCalle.UseSelectable = true;
            this.txtCalle.WaterMark = "Calle";
            this.txtCalle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCalle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalle_KeyPress);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btncancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncancelar.IconSize = 60;
            this.btncancelar.Location = new System.Drawing.Point(954, 740);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Rotation = 0D;
            this.btncancelar.Size = new System.Drawing.Size(239, 76);
            this.btncancelar.TabIndex = 47;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnguardar.IconSize = 60;
            this.btnguardar.Location = new System.Drawing.Point(618, 740);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Rotation = 0D;
            this.btnguardar.Size = new System.Drawing.Size(239, 76);
            this.btnguardar.TabIndex = 46;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(384, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "*";
            // 
            // frmDocentesPopUpAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1478, 840);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.panelContacto);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.metroPanel3);
            this.Name = "frmDocentesPopUpAgregar";
            this.Text = "GESTIÓN DOCENTES / AGREGAR NUEVO DOCENTE";
            this.metroPanel3.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.panelContacto.ResumeLayout(false);
            this.panelContacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroComboBox cbSala;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbTurno;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel panelDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtNacimiento;
        private MetroFramework.Controls.MetroLabel lblDatosPersonales;
        private MetroFramework.Controls.MetroComboBox cbGenero;
        private MetroFramework.Controls.MetroTextBox txtDocumento;
        private MetroFramework.Controls.MetroTextBox txtApellidos;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroPanel panelContacto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtCelular;
        private MetroFramework.Controls.MetroTextBox txtTelefono;
        private MetroFramework.Controls.MetroTextBox txtCPostal;
        private MetroFramework.Controls.MetroTextBox txtDepto;
        private MetroFramework.Controls.MetroTextBox txtNumero;
        private MetroFramework.Controls.MetroLabel lblDatosContacto;
        private MetroFramework.Controls.MetroTextBox txtBarrio;
        private MetroFramework.Controls.MetroTextBox txtPiso;
        private MetroFramework.Controls.MetroTextBox txtCalle;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.Label label1;
    }
}