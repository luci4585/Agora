using Desktop.ExtensionMethod;
using Service.Interfaces;
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
            // Toggle acreditación/desacreditación
            return async (sender, e) =>
            {
                if (e.RowIndex < 0 || e.ColumnIndex != GridInscripciones.Columns["Acciones"].Index)
                    return;

                var buttonCell = GridInscripciones.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                var selectedInscripcion = GridInscripciones.Rows[e.RowIndex].DataBoundItem as Inscripcion;
                if (selectedInscripcion == null)
                {
                    MessageBox.Show("Seleccione una inscripción válida.");
                    return;
                }

                bool nuevoEstado = !selectedInscripcion.Acreditado; // toggle
                bool estadoAnterior = selectedInscripcion.Acreditado;
                selectedInscripcion.Acreditado = nuevoEstado;

                try
                {
                    if (await _inscripcionesService.UpdateAsync(selectedInscripcion))
                    {
                        // ajustar texto según nuevo estado
                        if (buttonCell != null)
                        {
                            buttonCell.Value = nuevoEstado ? "Desacreditar inscripción" : "Acreditar inscripción";
                        }
                    }
                    else
                    {
                        // revertir si fallo service
                        selectedInscripcion.Acreditado = estadoAnterior;
                        if (buttonCell != null)
                            buttonCell.Value = estadoAnterior ? "Desacreditar inscripción" : "Acreditar inscripción";
                        MessageBox.Show("No se pudo actualizar la inscripción.");
                    }
                }
                catch (Exception ex)
                {
                    selectedInscripcion.Acreditado = estadoAnterior;
                    if (buttonCell != null)
                        buttonCell.Value = estadoAnterior ? "Desacreditar inscripción" : "Acreditar inscripción";
                    MessageBox.Show($"Error al actualizar la inscripción: {ex.Message}");
                }

                GridInscripciones.Refresh();
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
