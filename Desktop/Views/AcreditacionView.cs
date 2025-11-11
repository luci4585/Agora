using Desktop.ExtensionMethod;
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
    public partial class AcreditacionView : Form
    {
        GenericService<Capacitacion> _capacitacionService = new();
        InscripcionService _inscripcionesService = new();
        List<Inscripcion>? _inscripciones = new();

        public AcreditacionView()
        {
            InitializeComponent();
            _ = GetAllData();
        }

        private async Task GetAllData()
        {
            var GetComboTask = GetComboCapacitaciones();
            await Task.WhenAll(GetComboTask);
        }


        private async Task GetComboCapacitaciones()
        {
            //cargamos las capacitaciones en el combo
            var capacitaciones = await _capacitacionService.GetAllAsync();
            ComboCapacitaciones.DataSource = capacitaciones?.Where(c => c.InscripcionAbierta).ToList();
            ComboCapacitaciones.DisplayMember = "Nombre";
            ComboCapacitaciones.ValueMember = "Id";
        }

        private async void ComboCapacitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //controlamos que no sea null y haya una capacitacion
            if (ComboCapacitaciones.SelectedItem is Capacitacion selectedCapacitacion)
            {
                RefreshInscripciones(selectedCapacitacion);
            }
        }

        
        private async void RefreshInscripciones(Capacitacion selectedCapacitacion)
        {
            _inscripciones = selectedCapacitacion.Inscripciones.ToList();
            //_inscripciones = await _inscripcionesService.GetInscriptosAsync(selectedCapacitacion.Id);
            //ordeno las incripciones por apellido y nombre
            _inscripciones = _inscripciones?.OrderBy(i => i.Usuario?.Apellido).ThenBy(i => i.Usuario?.Nombre).ToList();
            GridInscripciones.DataSource = _inscripciones;
            //ocultamos las columnas Id, CapacitacionId, UsuarioId, TipoInscripcionId, Capacitacion
            GridInscripciones.HideColumns("Id", "CapacitacionId", "UsuarioId", "TipoInscripcionId", "Capacitacion", "UsuarioCobroId", "IsDeleted", "UsuarioCobro", "Pagado");
            if (GridInscripciones.Columns.Contains("Importe"))
            {
                GridInscripciones.Columns["Importe"].DefaultCellStyle.Format = "C2";
                GridInscripciones.Columns["Importe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            AgregarBotonAcreditarInscripcion();
        }

        private void AgregarBotonAcreditarInscripcion()
        {
            if (GridInscripciones.Columns["Acciones"] == null)
            {
                // Agrego un botón para agregar la transferencias a la caja del empleado current
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "Acciones"; // Especificamos el nombre para poder referenciarlo luego
                buttonColumn.HeaderText = "Acciones";
                buttonColumn.Text = "Acreditar inscripción";
                buttonColumn.UseColumnTextForButtonValue = true;
                GridInscripciones.Columns.Add(buttonColumn);
                // Defino el evento para el botón.
                GridInscripciones.CellContentClick += AcreditarInscripcion();
            }
        }

        private DataGridViewCellEventHandler AcreditarInscripcion()
        {
            return async (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == GridInscripciones.Columns["Acciones"].Index)
                {
                    var selectedInscripcion = GridInscripciones.Rows[e.RowIndex].DataBoundItem as Inscripcion;
                    // obtenemos la inscripción seleccionada
                    if (selectedInscripcion == null)
                    {
                        MessageBox.Show("Seleccione una inscripción para acreditar.");
                        return;
                    }
                    //preguntamos si está seguro de acreditar la inscripción
                    selectedInscripcion.Acreditado = true;
                    try
                    {
                        if (await _inscripcionesService.UpdateAsync(selectedInscripcion))
                        {
                            //obtenemos el boton y lo deshabilitamos
                            var buttonCell = GridInscripciones.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                            //deshabilitamos el boton
                            buttonCell.ReadOnly = true;

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al acreditar la inscripción: {ex.Message}");
                        selectedInscripcion.Acreditado = false;
                    }
                    RefreshInscripciones((Capacitacion)ComboCapacitaciones.SelectedItem);
                }
            };
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            TxtBuscarInscriptos_TextChanged(sender, e);
        }

        private async void TxtBuscarInscriptos_TextChanged(object sender, EventArgs e)
        {

            GridInscripciones.DataSource = _inscripciones?
                .Where(i => i.Usuario!.Nombre!.Contains(TxtBuscarInscriptos.Text,
                                                StringComparison.OrdinalIgnoreCase) ||
                            i.Usuario!.Apellido!.Contains(TxtBuscarInscriptos.Text,
                                                StringComparison.OrdinalIgnoreCase))
                .OrderBy(i => i.Usuario!.Apellido)
                .ThenBy(i => i.Usuario!.Nombre)
                .ToList();

        }

        private void GridInscripciones_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //llamamos al menu contextual
                ContextMenuInscripcion.Show(GridInscripciones, new Point(e.X, e.Y));

            }
        }
    }
}
