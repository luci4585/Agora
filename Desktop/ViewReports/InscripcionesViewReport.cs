using Microsoft.Reporting.WinForms;
using Service.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.ViewReports
{
    public partial class InscripcionesViewReport : Form
    {
        ReportViewer _report;
        Capacitacion _capacitacion;

        public InscripcionesViewReport(Capacitacion capacitacion)
        {
            InitializeComponent();
            _report = new ReportViewer();
            _report.Dock = DockStyle.Fill;
            _capacitacion = capacitacion;
            this.Controls.Add(_report);
        }

        private void InscripcionesViewReport_Load(object sender, EventArgs e)
        {
            _report.LocalReport.ReportEmbeddedResource = "Desktop.Reports.InscripcionesReport.rdlc";
            var inscripciones = _capacitacion.Inscripciones.Select(i => new
            { 
                Inscripto=$"{i.Usuario?.Apellido} {i.Usuario?.Nombre}",
                TipoInscripcion=i?.TipoInscripcion?.Nombre,
                FechaHora=i?.FechaInscripcion.ToString("dd/MM/yyyy HH:mm"),
                Importe=i?.Importe.ToString("C2"),
                Pagado=i?.Pagado
            });
            _report.LocalReport.DataSources.Add(new ReportDataSource("DsInscripciones", inscripciones));
            _report.SetDisplayMode(DisplayMode.PrintLayout);
            _report.ZoomMode = ZoomMode.Percent;
            _report.ZoomPercent = 100;

            _report.RefreshReport();
        }
    }
}
