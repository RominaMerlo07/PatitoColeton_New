﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionJardin
{
    public partial class frmAsistenciaConsulta : Form
    {
        DateTime fechaCalendar;
        string id_sala;
        string turno;

        metAsistencia metAsistencia = new metAsistencia();

        public frmAsistenciaConsulta()
        {                       
            InitializeComponent();

            var weekends = GetDaysBetween(DateTime.Today.AddMonths(-12), DateTime.Today.AddMonths(12))
            .Where(d => d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday).ToArray();

            calFecha.RemoveAllBoldedDates();
            calFecha.BoldedDates = weekends;
        }

        IEnumerable<DateTime> GetDaysBetween(DateTime start, DateTime end)
        {
            for (DateTime i = start; i <= end; i = i.AddDays(1))
            {
                yield return i;
            }
        }

        private void frmAsistenciaConsulta_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void cargar_cbSala()
        {

            cbSala.SelectedValueChanged -= new EventHandler(cbSala_SelectedValueChanged);


            string indexTurno = cbTurno.SelectedIndex.ToString();
            metSalas objMetSalas = new metSalas();
            DataTable Tabla = new DataTable();
            Tabla = objMetSalas.ListarSalas(indexTurno);

            cbSala.DisplayMember = "SAL_NOMBRE";
            cbSala.ValueMember = "SAL_ID";
            cbSala.DataSource = Tabla;
            cbSala.SelectedItem = null;
            cbSala.Enabled = true;

            cbSala.SelectedValueChanged += new EventHandler(cbSala_SelectedValueChanged);

        }

        private void cbSala_SelectedValueChanged(object sender, EventArgs e)
        {
            id_sala = cbSala.SelectedValue.ToString();             
        }

        private void cbTurno_SelectedValueChanged(object sender, EventArgs e)
        {
            cargar_cbSala();
        }

        private void cbTurno_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbTurno.Text.Trim()) == true)
            {
                cbTurno.Style = MetroFramework.MetroColorStyle.Red;
                cbTurno.Focus();
                lblTurno.Visible = true;
                lblTurno.Text = "Por favor seleccione un turno";
            }
            else
            {
                lblTurno.Visible = false;
            }
        }

        private void cbSala_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == true)
            {
                cbSala.Style = MetroFramework.MetroColorStyle.Red;
                cbSala.Focus();
                lblSala.Visible = true;
                lblSala.Text = "Por favor seleccione una sala";
            }
            else
            {
                lblSala.Visible = false;
            }
        }

        private string ValidaCampos()
        {
            string result = "";

            if (string.IsNullOrWhiteSpace(cbTurno.Text.Trim()) == true)
            {
                cbTurno.Style = MetroFramework.MetroColorStyle.Red;
                cbTurno.Focus();
                lblTurno.Visible = true;
                result = "Por favor seleccione un turno";
                lblTurno.Text = result;
                lblFecha.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == true)
            {
                cbSala.Style = MetroFramework.MetroColorStyle.Red;
                cbSala.Focus();
                lblSala.Visible = true;
                result = "Por favor seleccione una sala";
                lblSala.Text = result;
                lblFecha.Visible = true;
            }
            else
            {
                result = "OK";
            }

            return result;
        }


        private void Inicializar()
        {
            txtGAs_Buscar.Visible = false;
            dgv_Alumnos.Visible = false;

            labelFechError.Visible = false;
            lblTurno.Visible = false;
            lblSala.Visible = false;
            lblFecha.Visible = false;
            
            dgv_Alumnos.ClearSelection();
            cbTurno.Focus();
            cbTurno.SelectedIndex = -1;
            cbSala.SelectedIndex = -1;

            calFecha.MaxSelectionCount = 1;
            calFecha.MaxDate = DateTime.Today;
            calFecha.SetDate(DateTime.Today);
            calFecha.FirstDayOfWeek = Day.Sunday;

        }

        private void calFecha_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

    }
}
