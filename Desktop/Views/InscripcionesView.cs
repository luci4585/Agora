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
    public partial class InscripcionesView : Form
    {
        GenericService<Capacitacion> _capacitacionService = new();
        GenericService<Usuario> _usuarioService = new();
        InscripcionService _inscripcionesService = new();
        List<Inscripcion>? _inscripciones = new();
        List<Usuario>? _usuarios = new();

        public InscripcionesView()
        {
            InitializeComponent();
            _ = GetAllData();
        }

        private async Task GetAllData()
        {
            var GetComboTask = GetComboCapacitaciones();
            var GetGrillaTask = GetGrillaUsuarios();
            await Task.WhenAll(GetComboTask, GetGrillaTask);
        }

        private async Task GetGrillaUsuarios()
        {
            _usuarios = (await _usuarioService.GetAllAsync());
            _usuarios = _usuarios?.Where(u => _inscripciones != null && !_inscripciones.Any(i => i.UsuarioId == u.Id)).ToList();
            GridUsuarios.DataSource = _usuarios;
            GridUsuarios.HideColumns("Id", "DeleteDate", "IsDeleted");
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
                GetComboTiposDeInscripciones(selectedCapacitacion);
            }
        }

        private void GetComboTiposDeInscripciones(Capacitacion selectedCapacitacion)
        {
            ComboTipoInscripcion.DataSource = selectedCapacitacion.TiposDeInscripciones.ToList();
            ComboTipoInscripcion.DisplayMember = "TipoInscripcion";
            ComboTipoInscripcion.ValueMember = "TipoInscripcionId";
            ComboTipoInscripcion.SelectedIndex = -1;
        }

        private async void RefreshInscripciones(Capacitacion selectedCapacitacion)
        {
            _inscripciones = selectedCapacitacion.Inscripciones.ToList();
            //_inscripciones = await _inscripcionesService.GetInscriptosAsync(selectedCapacitacion.Id);
            GridInscripciones.DataSource = _inscripciones;
            //ocultamos las columnas Id, CapacitacionId, UsuarioId, TipoInscripcionId, Capacitacion
            GridInscripciones.HideColumns("Id", "CapacitacionId", "UsuarioId", "TipoInscripcionId", "Capacitacion", "UsuarioCobroId", "IsDeleted");
            await GetGrillaUsuarios();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            _usuarios = _usuarios?.Where(u => u.Nombre.Contains(TxtBuscarInscriptos.Text, StringComparison.OrdinalIgnoreCase) || u.Apellido.Contains(TxtBuscarInscriptos.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            GridUsuarios.DataSource = null;
            GridUsuarios.DataSource = _usuarios;
            GridUsuarios.HideColumns("Id", "DeleteDate", "IsDeleted");
        }

        private async void TxtBuscarInscriptos_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBuscarInscriptos.Text))
            {
                await GetGrillaUsuarios();
            }
        }

        private void TxtBuscarInscriptos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnBuscar.PerformClick();
                e.Handled = true; // Evita el sonido de "ding" al presionar Enter
            }
        }

        private async void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            //si no hay un usuario seleccionado advierte y sale
            if (GridUsuarios.CurrentRow?.DataBoundItem is not Usuario selectedUsuario)
            {
                MessageBox.Show("Seleccione un usuario para inscribir.");
                return;
            }
            //si no hay una capacitación seleccionada advierte y sale
            if (ComboCapacitaciones.SelectedItem is not Capacitacion selectedCapacitacion)
            {
                MessageBox.Show("Seleccione una capacitación para inscribir el usuario.");
                return;
            }
            //si no hay un tipo de inscripción seleccionado advierte y sale
            if (ComboTipoInscripcion.SelectedItem is not TipoInscripcionCapacitacion selectedTipoInscripcion)
            {
                MessageBox.Show("Seleccione un tipo de inscripción para el usuario.");
                return;
            }
            var nuevaInscripcion = new Inscripcion
            {
                UsuarioId = selectedUsuario.Id,
                Usuario = selectedUsuario,
                CapacitacionId = selectedCapacitacion.Id,
                TipoInscripcionId = selectedTipoInscripcion.TipoInscripcionId,
                TipoInscripcion = selectedTipoInscripcion.TipoInscripcion,
                UsuarioCobroId = null // Asignar el ID del usuario que realiza el cobro si es necesario
            };
            selectedCapacitacion.Inscripciones.Add(nuevaInscripcion);
            RefreshInscripciones(selectedCapacitacion);
            try
            {
                await _capacitacionService.UpdateAsync(selectedCapacitacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inscribir el usuario: {ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
    }
}
