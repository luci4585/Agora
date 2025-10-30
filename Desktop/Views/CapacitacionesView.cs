using Desktop.ExtensionMethod;
using Service.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Controls;

namespace Desktop.Views
{
    public partial class CapacitacionesView : Form
    {
        GenericService<Capacitacion> _capacitacionService = new GenericService<Capacitacion>();
        GenericService<TipoInscripcion> _tipoInscripcionService = new();
        Capacitacion _currentCapacitacion;
        List<Capacitacion>? _capacitaciones;

        public CapacitacionesView()
        {
            InitializeComponent();
            _ = GetAllData();
            CheckVerEliminados.CheckedChanged += DisplayHideControlsRestoreButton;
        }

        private void DisplayHideControlsRestoreButton(object sender, EventArgs e)
        {
            BtnRestaurar.Visible = CheckVerEliminados.Checked;
            BtnEliminar.Enabled = !CheckVerEliminados.Checked;
            BtnModificar.Enabled = !CheckVerEliminados.Checked;
            BtnAgregar.Enabled = !CheckVerEliminados.Checked;
            BtnModificar.Enabled = !CheckVerEliminados.Checked;
            BtnBuscar.Enabled = !CheckVerEliminados.Checked;

        }

        private async Task GetAllData()
        {
            if (CheckVerEliminados.Checked)
            {
                _capacitaciones = await _capacitacionService.GetAllDeletedsAsync();
            }
            else
            {
                _capacitaciones = await _capacitacionService.GetAllAsync();
            }
            DataGrid.DataSource = _capacitaciones;
            DataGrid.Columns["Id"].Visible = false;
            DataGrid.Columns["IsDeleted"].Visible = false;
            await GetComboTiposDeInscripciones();
        }

        private async Task GetComboTiposDeInscripciones()
        {
            ComboTiposInscripciones.DataSource = await _tipoInscripcionService.GetAllAsync();
            ComboTiposInscripciones.DisplayMember = "Nombre";
            ComboTiposInscripciones.ValueMember = "Id";
        }

        private void GridPeliculas_SelectionChanged_1(object sender, EventArgs e)
        {
            if (DataGrid.RowCount > 0 && DataGrid.SelectedRows.Count > 0)
            {
                //Capacitacion _curr = (Pelicula)GridPeliculas.SelectedRows[0].DataBoundItem;
                //FilmPicture.ImageLocation = peliculaSeleccionada.portada;
            }
        }

        private async void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            //chequeamos que haya películas seleccionadas
            if (DataGrid.Rows.Count > 0 && DataGrid.SelectedRows.Count > 0)
            {
                Capacitacion entitySelected = (Capacitacion)DataGrid.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Está seguro de eliminar la capacitación {entitySelected.Nombre} seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await _capacitacionService.DeleteAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Capacitación {entitySelected.Nombre} eliminada correctamente";
                        TimerStatusBar.Start();
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la capacitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una capacitación para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarControlesAgregarEditar();
            TabControl.SelectedTab = TabPageAgregarEditar;
        }
        private void LimpiarControlesAgregarEditar()
        {
            TxtNombre.Clear();
            TxtPonente.Clear();
            DateTimeFechaHora.Value = DateTime.Now;
            checkInscripcionAbierta.Checked = false;
            NumericCupo.Value = 0;
            TxtDetalle.Clear();
            GridTiposInscripciones.DataSource = null;
        }


        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //checheamos que haya capacitacion seleccionadas
            if (DataGrid.RowCount > 0 && DataGrid.SelectedRows.Count > 0)
            {
                _currentCapacitacion = (Capacitacion)DataGrid.SelectedRows[0].DataBoundItem;
                TxtNombre.Text = _currentCapacitacion.Nombre;
                TxtDetalle.Text = _currentCapacitacion.Detalle;
                TxtPonente.Text = _currentCapacitacion.Ponente;
                DateTimeFechaHora.Value = _currentCapacitacion.FechaHora;
                NumericCupo.Value = _currentCapacitacion.Cupo;
                checkInscripcionAbierta.Checked = _currentCapacitacion.InscripcionAbierta;
                TabControl.SelectedTab = TabPageAgregarEditar;
                GridTiposInscripciones.DataSource = _currentCapacitacion.TiposDeInscripciones;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Capacitacion para modificarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataGrid.DataSource = _capacitaciones.Where(p => p.Nombre.ToUpper().Contains(TxtBuscar.Text.ToUpper())).ToList();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            //BtnBuscar.PerformClick();
        }

        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            LabelStatusMessage.Text = string.Empty;
            TimerStatusBar.Stop();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void CheckVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            await GetAllData();
        }

        private async void BtnRestaurar_Click(object sender, EventArgs e)
        {
            if (!CheckVerEliminados.Checked) return;
            //chequeamos que haya películas seleccionadas
            if (DataGrid.Rows.Count > 0 && DataGrid.SelectedRows.Count > 0)
            {
                Capacitacion entitySelected = (Capacitacion)DataGrid.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Está seguro de recuperar la capacitación {entitySelected.Nombre} seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await _capacitacionService.RestoreAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Capacitación {entitySelected.Nombre} restaurada correctamente";
                        TimerStatusBar.Start();
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al restaurar la capacitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una capacitación para restaurar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnGuardar_Click_1(object sender, EventArgs e)
        {

            Capacitacion capacitacionAGuardar = new Capacitacion
            {
                Id = _currentCapacitacion?.Id ?? 0,
                Nombre = TxtNombre.Text,
                Detalle = TxtDetalle.Text,
                Ponente = TxtPonente.Text,
                FechaHora = DateTimeFechaHora.Value,
                Cupo = (int)NumericCupo.Value,
                InscripcionAbierta = checkInscripcionAbierta.Checked

            };
            bool response = false;
            if (_currentCapacitacion != null)
            {
                response = await _capacitacionService.UpdateAsync(capacitacionAGuardar);
            }
            else
            {
                var nuevacapacitacion = await _capacitacionService.AddAsync(capacitacionAGuardar);
                response = nuevacapacitacion != null;
            }
            if (response)
            {
                _currentCapacitacion = null; // Reset the modified movie after saving
                LabelStatusMessage.Text = $"Capacitacion {capacitacionAGuardar.Nombre} guardada correctamente";
                TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                await GetAllData();
                LimpiarControlesAgregarEditar();
                TabControl.SelectedTab = TabPageLista;
            }
            else
            {
                MessageBox.Show("Error al agregar la capacitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            TabControl.SelectedTab = TabPageLista;
        }

        private void BtnAniadir_Click(object sender, EventArgs e)
        {
            var tipoInscripcionCapacitacion = new TipoInscripcionCapacitacion
            {
                TipoInscripcionId = (int)ComboTiposInscripciones.SelectedValue,
                TipoInscripcion = (TipoInscripcion)ComboTiposInscripciones.SelectedItem,
                CapacitacionId = _currentCapacitacion?.Id ?? 0,
                Capacitacion = _currentCapacitacion,
                Costo = NumericCosto.Value
            };
            _currentCapacitacion?.TiposDeInscripciones.Add(tipoInscripcionCapacitacion);
            GridTiposInscripciones.DataSource = _currentCapacitacion?.TiposDeInscripciones.ToList();
            GridTiposInscripciones.HideColumns("Id", "CapacitacionId", "Capacitacion", "TipoInscripcionId", "IsDeleted");
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            var tipoInscripcionCapacitacionSeleccionada = (TipoInscripcionCapacitacion)GridTiposInscripciones.SelectedRows[0].DataBoundItem;
            _currentCapacitacion?.TiposDeInscripciones.Remove(tipoInscripcionCapacitacionSeleccionada);
            GridTiposInscripciones.DataSource = _currentCapacitacion?.TiposDeInscripciones.ToList();
        }
    }
} 
