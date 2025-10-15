using Service.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class InscripcionesView : Form
    {
        GenericService<Capacitacion> _capacitacionService = new();
        InscripcionService _inscripcionesService = new();

        public InscripcionesView()
        {
            InitializeComponent();
            _ = GetAllData();
        }

        private async Task GetAllData()
        {
            //cargamos las capacitaciones en el combo
            var capacitaciones = await _capacitacionService.GetAllAsync();
            ComboCapacitaciones.DataSource = capacitaciones?.Where(c => c.InscripcionAbierta).ToList();
            ComboCapacitaciones.DisplayMember = "Nombre";
            ComboCapacitaciones.ValueMember = "Id";
            //cargamos las inscripciones de la capacitacion seleccionada
        }

        private async void ComboCapacitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //controlamos que no sea null y haya una capacitacion
            if (ComboCapacitaciones.SelectedItem is Capacitacion selectedCapacitacion)
            {
                GridView.DataSource = await _inscripcionesService.GetInscriptosAsync(selectedCapacitacion.Id);
            }
        }
    }
}
