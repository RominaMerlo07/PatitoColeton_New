﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GestionJardin
{
    public partial class frmDocentesPopUpEliminar : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);
        public frmDocentesPopUpEliminar()
        {
            InitializeComponent();
        }

        private void frmDocentesPopUpEliminar_Load(object sender, EventArgs e)
        {

        }

        private void frmDocentesPopUpEliminar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_sieliminar_Click(object sender, EventArgs e)
        {
            frmDocentes Fdocentes= Owner as frmDocentes;
            var docente = new entPersona();

        }
    }
}
