namespace GestionJardin
{
    partial class frmCobro
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
            this.panelContenedor_GC = new System.Windows.Forms.Panel();
            this.lbl_Ruta = new System.Windows.Forms.Label();
            this.btn_VolverGA = new FontAwesome.Sharp.IconButton();
            this.panelConceptos = new System.Windows.Forms.Panel();
            this.Ind_PnlConcepto = new System.Windows.Forms.Panel();
            this.btnCon_Gestionar = new FontAwesome.Sharp.IconButton();
            this.panelCuotas = new System.Windows.Forms.Panel();
            this.btnCuo_Consultar = new FontAwesome.Sharp.IconButton();
            this.btnCuo_Gestionar = new FontAwesome.Sharp.IconButton();
            this.Ind_PnlCuota = new System.Windows.Forms.Panel();
            this.panelCobros = new System.Windows.Forms.Panel();
            this.btnCob_Gestionar = new FontAwesome.Sharp.IconButton();
            this.btnCob_Consultar = new FontAwesome.Sharp.IconButton();
            this.Ind_PnlCobro = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCobros = new FontAwesome.Sharp.IconButton();
            this.btnConceptos = new FontAwesome.Sharp.IconButton();
            this.panelIndiceNavbar = new System.Windows.Forms.Panel();
            this.btnCuotas = new FontAwesome.Sharp.IconButton();
            this.panelContenedor_GC.SuspendLayout();
            this.panelConceptos.SuspendLayout();
            this.panelCuotas.SuspendLayout();
            this.panelCobros.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor_GC
            // 
            this.panelContenedor_GC.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedor_GC.Controls.Add(this.lbl_Ruta);
            this.panelContenedor_GC.Controls.Add(this.btn_VolverGA);
            this.panelContenedor_GC.Controls.Add(this.panelConceptos);
            this.panelContenedor_GC.Controls.Add(this.panelCuotas);
            this.panelContenedor_GC.Controls.Add(this.panelCobros);
            this.panelContenedor_GC.Controls.Add(this.panel1);
            this.panelContenedor_GC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor_GC.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor_GC.Name = "panelContenedor_GC";
            this.panelContenedor_GC.Size = new System.Drawing.Size(1654, 853);
            this.panelContenedor_GC.TabIndex = 89;
            // 
            // lbl_Ruta
            // 
            this.lbl_Ruta.AutoSize = true;
            this.lbl_Ruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ruta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_Ruta.Location = new System.Drawing.Point(31, 193);
            this.lbl_Ruta.Name = "lbl_Ruta";
            this.lbl_Ruta.Size = new System.Drawing.Size(15, 20);
            this.lbl_Ruta.TabIndex = 90;
            this.lbl_Ruta.Text = "*";
            this.lbl_Ruta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Ruta.Visible = false;
            // 
            // btn_VolverGA
            // 
            this.btn_VolverGA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_VolverGA.BackColor = System.Drawing.Color.Transparent;
            this.btn_VolverGA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_VolverGA.FlatAppearance.BorderSize = 0;
            this.btn_VolverGA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_VolverGA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_VolverGA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VolverGA.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_VolverGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VolverGA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_VolverGA.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft;
            this.btn_VolverGA.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_VolverGA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_VolverGA.IconSize = 50;
            this.btn_VolverGA.Location = new System.Drawing.Point(1037, 124);
            this.btn_VolverGA.Name = "btn_VolverGA";
            this.btn_VolverGA.Rotation = 0D;
            this.btn_VolverGA.Size = new System.Drawing.Size(60, 57);
            this.btn_VolverGA.TabIndex = 89;
            this.btn_VolverGA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_VolverGA.UseVisualStyleBackColor = false;
            this.btn_VolverGA.Visible = false;
            this.btn_VolverGA.Click += new System.EventHandler(this.btn_VolverGA_Click);
            // 
            // panelConceptos
            // 
            this.panelConceptos.BackColor = System.Drawing.Color.Transparent;
            this.panelConceptos.Controls.Add(this.Ind_PnlConcepto);
            this.panelConceptos.Controls.Add(this.btnCon_Gestionar);
            this.panelConceptos.Location = new System.Drawing.Point(821, 129);
            this.panelConceptos.Name = "panelConceptos";
            this.panelConceptos.Size = new System.Drawing.Size(394, 120);
            this.panelConceptos.TabIndex = 88;
            this.panelConceptos.Visible = false;
            this.panelConceptos.MouseEnter += new System.EventHandler(this.panelConceptos_MouseEnter);
            this.panelConceptos.MouseLeave += new System.EventHandler(this.panelConceptos_MouseLeave);
            this.panelConceptos.MouseHover += new System.EventHandler(this.panelConceptos_MouseHover);
            // 
            // Ind_PnlConcepto
            // 
            this.Ind_PnlConcepto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ind_PnlConcepto.BackColor = System.Drawing.Color.Fuchsia;
            this.Ind_PnlConcepto.Location = new System.Drawing.Point(7, 4);
            this.Ind_PnlConcepto.Name = "Ind_PnlConcepto";
            this.Ind_PnlConcepto.Size = new System.Drawing.Size(26, 112);
            this.Ind_PnlConcepto.TabIndex = 85;
            this.Ind_PnlConcepto.Visible = false;
            // 
            // btnCon_Gestionar
            // 
            this.btnCon_Gestionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCon_Gestionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnCon_Gestionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCon_Gestionar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCon_Gestionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCon_Gestionar.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btnCon_Gestionar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCon_Gestionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCon_Gestionar.IconSize = 65;
            this.btnCon_Gestionar.Location = new System.Drawing.Point(22, 4);
            this.btnCon_Gestionar.Name = "btnCon_Gestionar";
            this.btnCon_Gestionar.Rotation = 0D;
            this.btnCon_Gestionar.Size = new System.Drawing.Size(366, 112);
            this.btnCon_Gestionar.TabIndex = 86;
            this.btnCon_Gestionar.Text = "GESTIONAR            ";
            this.btnCon_Gestionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCon_Gestionar.UseVisualStyleBackColor = false;
            this.btnCon_Gestionar.Click += new System.EventHandler(this.btnCon_Gestionar_Click);
            this.btnCon_Gestionar.MouseLeave += new System.EventHandler(this.btnCon_Gestionar_MouseLeave);
            this.btnCon_Gestionar.MouseHover += new System.EventHandler(this.btnCon_Gestionar_MouseHover);
            // 
            // panelCuotas
            // 
            this.panelCuotas.BackColor = System.Drawing.Color.Transparent;
            this.panelCuotas.Controls.Add(this.btnCuo_Consultar);
            this.panelCuotas.Controls.Add(this.btnCuo_Gestionar);
            this.panelCuotas.Controls.Add(this.Ind_PnlCuota);
            this.panelCuotas.Location = new System.Drawing.Point(422, 128);
            this.panelCuotas.Name = "panelCuotas";
            this.panelCuotas.Size = new System.Drawing.Size(392, 234);
            this.panelCuotas.TabIndex = 4;
            this.panelCuotas.Visible = false;
            this.panelCuotas.MouseLeave += new System.EventHandler(this.panelCuotas_MouseLeave);
            this.panelCuotas.MouseHover += new System.EventHandler(this.panelCuotas_MouseHover);
            // 
            // btnCuo_Consultar
            // 
            this.btnCuo_Consultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCuo_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnCuo_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCuo_Consultar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCuo_Consultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCuo_Consultar.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnCuo_Consultar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCuo_Consultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCuo_Consultar.IconSize = 65;
            this.btnCuo_Consultar.Location = new System.Drawing.Point(19, 112);
            this.btnCuo_Consultar.Name = "btnCuo_Consultar";
            this.btnCuo_Consultar.Rotation = 0D;
            this.btnCuo_Consultar.Size = new System.Drawing.Size(370, 112);
            this.btnCuo_Consultar.TabIndex = 86;
            this.btnCuo_Consultar.Text = "CONSULTAR";
            this.btnCuo_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuo_Consultar.UseVisualStyleBackColor = false;
            this.btnCuo_Consultar.Click += new System.EventHandler(this.btnCuo_Consultar_Click);
            this.btnCuo_Consultar.MouseLeave += new System.EventHandler(this.btnCuo_Consultar_MouseLeave);
            this.btnCuo_Consultar.MouseHover += new System.EventHandler(this.btnCuo_Consultar_MouseHover);
            // 
            // btnCuo_Gestionar
            // 
            this.btnCuo_Gestionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCuo_Gestionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnCuo_Gestionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCuo_Gestionar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCuo_Gestionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCuo_Gestionar.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnCuo_Gestionar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCuo_Gestionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCuo_Gestionar.IconSize = 65;
            this.btnCuo_Gestionar.Location = new System.Drawing.Point(19, 3);
            this.btnCuo_Gestionar.Name = "btnCuo_Gestionar";
            this.btnCuo_Gestionar.Rotation = 0D;
            this.btnCuo_Gestionar.Size = new System.Drawing.Size(370, 112);
            this.btnCuo_Gestionar.TabIndex = 85;
            this.btnCuo_Gestionar.Text = "GESTIONAR              ";
            this.btnCuo_Gestionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuo_Gestionar.UseVisualStyleBackColor = false;
            this.btnCuo_Gestionar.Click += new System.EventHandler(this.btnCuo_Gestionar_Click);
            this.btnCuo_Gestionar.MouseLeave += new System.EventHandler(this.btnCuo_Gestionar_MouseLeave);
            this.btnCuo_Gestionar.MouseHover += new System.EventHandler(this.btnCuo_Gestionar_MouseHover);
            // 
            // Ind_PnlCuota
            // 
            this.Ind_PnlCuota.BackColor = System.Drawing.Color.Cyan;
            this.Ind_PnlCuota.Location = new System.Drawing.Point(3, 3);
            this.Ind_PnlCuota.Name = "Ind_PnlCuota";
            this.Ind_PnlCuota.Size = new System.Drawing.Size(26, 112);
            this.Ind_PnlCuota.TabIndex = 84;
            this.Ind_PnlCuota.Visible = false;
            // 
            // panelCobros
            // 
            this.panelCobros.BackColor = System.Drawing.Color.Transparent;
            this.panelCobros.Controls.Add(this.btnCob_Gestionar);
            this.panelCobros.Controls.Add(this.btnCob_Consultar);
            this.panelCobros.Controls.Add(this.Ind_PnlCobro);
            this.panelCobros.Location = new System.Drawing.Point(21, 127);
            this.panelCobros.Name = "panelCobros";
            this.panelCobros.Size = new System.Drawing.Size(392, 235);
            this.panelCobros.TabIndex = 3;
            this.panelCobros.Visible = false;
            this.panelCobros.MouseEnter += new System.EventHandler(this.panelCobros_MouseEnter);
            this.panelCobros.MouseLeave += new System.EventHandler(this.panelCobros_MouseLeave);
            // 
            // btnCob_Gestionar
            // 
            this.btnCob_Gestionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCob_Gestionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnCob_Gestionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCob_Gestionar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCob_Gestionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCob_Gestionar.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnCob_Gestionar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCob_Gestionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCob_Gestionar.IconSize = 80;
            this.btnCob_Gestionar.Location = new System.Drawing.Point(18, 2);
            this.btnCob_Gestionar.Name = "btnCob_Gestionar";
            this.btnCob_Gestionar.Rotation = 0D;
            this.btnCob_Gestionar.Size = new System.Drawing.Size(371, 112);
            this.btnCob_Gestionar.TabIndex = 79;
            this.btnCob_Gestionar.Text = "GESTIONAR";
            this.btnCob_Gestionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCob_Gestionar.UseVisualStyleBackColor = false;
            this.btnCob_Gestionar.Click += new System.EventHandler(this.btnCob_Gestionar_Click);
            this.btnCob_Gestionar.MouseLeave += new System.EventHandler(this.btnCob_Gestionar_MouseLeave);
            this.btnCob_Gestionar.MouseHover += new System.EventHandler(this.btnCob_Gestionar_MouseHover);
            // 
            // btnCob_Consultar
            // 
            this.btnCob_Consultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCob_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnCob_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCob_Consultar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCob_Consultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCob_Consultar.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnCob_Consultar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCob_Consultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCob_Consultar.IconSize = 70;
            this.btnCob_Consultar.Location = new System.Drawing.Point(18, 113);
            this.btnCob_Consultar.Name = "btnCob_Consultar";
            this.btnCob_Consultar.Rotation = 0D;
            this.btnCob_Consultar.Size = new System.Drawing.Size(371, 112);
            this.btnCob_Consultar.TabIndex = 80;
            this.btnCob_Consultar.Text = "   CONSULTAR   ";
            this.btnCob_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCob_Consultar.UseVisualStyleBackColor = false;
            this.btnCob_Consultar.Click += new System.EventHandler(this.btnCob_Consultar_Click);
            this.btnCob_Consultar.MouseLeave += new System.EventHandler(this.btnCob_Consultar_MouseLeave);
            this.btnCob_Consultar.MouseHover += new System.EventHandler(this.btnCob_Consultar_MouseHover);
            // 
            // Ind_PnlCobro
            // 
            this.Ind_PnlCobro.BackColor = System.Drawing.Color.Yellow;
            this.Ind_PnlCobro.Location = new System.Drawing.Point(3, 2);
            this.Ind_PnlCobro.Name = "Ind_PnlCobro";
            this.Ind_PnlCobro.Size = new System.Drawing.Size(24, 105);
            this.Ind_PnlCobro.TabIndex = 84;
            this.Ind_PnlCobro.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCobros);
            this.panel1.Controls.Add(this.btnConceptos);
            this.panel1.Controls.Add(this.panelIndiceNavbar);
            this.panel1.Controls.Add(this.btnCuotas);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1634, 161);
            this.panel1.TabIndex = 1;
            // 
            // btnCobros
            // 
            this.btnCobros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnCobros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCobros.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCobros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobros.ForeColor = System.Drawing.Color.Yellow;
            this.btnCobros.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.btnCobros.IconColor = System.Drawing.Color.Yellow;
            this.btnCobros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCobros.IconSize = 80;
            this.btnCobros.Location = new System.Drawing.Point(21, 12);
            this.btnCobros.Name = "btnCobros";
            this.btnCobros.Rotation = 0D;
            this.btnCobros.Size = new System.Drawing.Size(394, 143);
            this.btnCobros.TabIndex = 77;
            this.btnCobros.Text = "COBROS";
            this.btnCobros.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCobros.UseVisualStyleBackColor = false;
            this.btnCobros.Click += new System.EventHandler(this.btnCobros_Click);
            this.btnCobros.MouseHover += new System.EventHandler(this.btnCobros_MouseHover);
            // 
            // btnConceptos
            // 
            this.btnConceptos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConceptos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConceptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConceptos.ForeColor = System.Drawing.Color.Magenta;
            this.btnConceptos.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnConceptos.IconColor = System.Drawing.Color.Magenta;
            this.btnConceptos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConceptos.IconSize = 80;
            this.btnConceptos.Location = new System.Drawing.Point(821, 12);
            this.btnConceptos.Name = "btnConceptos";
            this.btnConceptos.Rotation = 0D;
            this.btnConceptos.Size = new System.Drawing.Size(394, 143);
            this.btnConceptos.TabIndex = 76;
            this.btnConceptos.Text = "CONCEPTOS";
            this.btnConceptos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConceptos.UseVisualStyleBackColor = false;
            this.btnConceptos.Click += new System.EventHandler(this.btnConceptos_Click);
            this.btnConceptos.MouseHover += new System.EventHandler(this.btnConceptos_MouseHover);
            // 
            // panelIndiceNavbar
            // 
            this.panelIndiceNavbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelIndiceNavbar.BackColor = System.Drawing.Color.Yellow;
            this.panelIndiceNavbar.Location = new System.Drawing.Point(18, 3);
            this.panelIndiceNavbar.Name = "panelIndiceNavbar";
            this.panelIndiceNavbar.Size = new System.Drawing.Size(399, 13);
            this.panelIndiceNavbar.TabIndex = 78;
            this.panelIndiceNavbar.Visible = false;
            // 
            // btnCuotas
            // 
            this.btnCuotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCuotas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuotas.ForeColor = System.Drawing.Color.Aqua;
            this.btnCuotas.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnCuotas.IconColor = System.Drawing.Color.Aqua;
            this.btnCuotas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCuotas.IconSize = 80;
            this.btnCuotas.Location = new System.Drawing.Point(421, 12);
            this.btnCuotas.Name = "btnCuotas";
            this.btnCuotas.Rotation = 0D;
            this.btnCuotas.Size = new System.Drawing.Size(394, 143);
            this.btnCuotas.TabIndex = 70;
            this.btnCuotas.Text = "CUOTAS";
            this.btnCuotas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCuotas.UseVisualStyleBackColor = false;
            this.btnCuotas.Click += new System.EventHandler(this.btnCuotas_Click);
            this.btnCuotas.MouseHover += new System.EventHandler(this.btnCuotas_MouseHover);
            // 
            // frmCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1654, 853);
            this.Controls.Add(this.panelContenedor_GC);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmCobro";
            this.Text = "GESTIÓN COBROS";
            this.panelContenedor_GC.ResumeLayout(false);
            this.panelContenedor_GC.PerformLayout();
            this.panelConceptos.ResumeLayout(false);
            this.panelCuotas.ResumeLayout(false);
            this.panelCobros.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor_GC;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCobros;
        private FontAwesome.Sharp.IconButton btnConceptos;
        private System.Windows.Forms.Panel panelIndiceNavbar;
        private FontAwesome.Sharp.IconButton btnCuotas;
        private System.Windows.Forms.Panel panelCobros;
        private FontAwesome.Sharp.IconButton btnCob_Gestionar;
        private FontAwesome.Sharp.IconButton btnCob_Consultar;
        private System.Windows.Forms.Panel Ind_PnlCobro;
        private System.Windows.Forms.Panel panelCuotas;
        private FontAwesome.Sharp.IconButton btnCuo_Consultar;
        private FontAwesome.Sharp.IconButton btnCuo_Gestionar;
        private System.Windows.Forms.Panel Ind_PnlCuota;
        private System.Windows.Forms.Panel panelConceptos;
        private System.Windows.Forms.Panel Ind_PnlConcepto;
        private FontAwesome.Sharp.IconButton btnCon_Gestionar;
        private FontAwesome.Sharp.IconButton btn_VolverGA;
        private System.Windows.Forms.Label lbl_Ruta;
    }
}