namespace Desktop.Views
{
    partial class UsuariosView
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
            components = new System.ComponentModel.Container();
            TabControl = new TabControl();
            TabPageLista = new TabPage();
            BtnRestaurar = new FontAwesome.Sharp.IconButton();
            CheckVerEliminados = new CheckBox();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            TxtBuscar = new TextBox();
            label2 = new Label();
            BtnSalir = new FontAwesome.Sharp.IconButton();
            BtnModificar = new FontAwesome.Sharp.IconButton();
            BtnAgregar = new FontAwesome.Sharp.IconButton();
            DataGrid = new DataGridView();
            TabPageAgregarEditar = new TabPage();
            TxtPassword2 = new TextBox();
            LabelPassword2 = new Label();
            TxtPassword = new TextBox();
            LabelPassword = new Label();
            TxtEmail = new TextBox();
            label5 = new Label();
            ComboTiposDeUsuarios = new ComboBox();
            label8 = new Label();
            label3 = new Label();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            TxtDni = new TextBox();
            TxtNombre = new TextBox();
            label6 = new Label();
            label4 = new Label();
            TxtApellido = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            LabelStatusMessage = new ToolStripStatusLabel();
            TimerStatusBar = new System.Windows.Forms.Timer(components);
            TabControl.SuspendLayout();
            TabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            TabPageAgregarEditar.SuspendLayout();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(TabPageLista);
            TabControl.Controls.Add(TabPageAgregarEditar);
            TabControl.Location = new Point(12, 80);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1158, 521);
            TabControl.TabIndex = 6;
            // 
            // TabPageLista
            // 
            TabPageLista.Controls.Add(BtnRestaurar);
            TabPageLista.Controls.Add(CheckVerEliminados);
            TabPageLista.Controls.Add(BtnEliminar);
            TabPageLista.Controls.Add(BtnBuscar);
            TabPageLista.Controls.Add(TxtBuscar);
            TabPageLista.Controls.Add(label2);
            TabPageLista.Controls.Add(BtnSalir);
            TabPageLista.Controls.Add(BtnModificar);
            TabPageLista.Controls.Add(BtnAgregar);
            TabPageLista.Controls.Add(DataGrid);
            TabPageLista.Location = new Point(4, 29);
            TabPageLista.Name = "TabPageLista";
            TabPageLista.Padding = new Padding(3);
            TabPageLista.Size = new Size(1150, 488);
            TabPageLista.TabIndex = 0;
            TabPageLista.Text = "Lista";
            TabPageLista.UseVisualStyleBackColor = true;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Right;
            BtnRestaurar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            BtnRestaurar.IconColor = Color.Black;
            BtnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRestaurar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRestaurar.Location = new Point(987, 291);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(137, 53);
            BtnRestaurar.TabIndex = 19;
            BtnRestaurar.Text = "&Restaurar";
            BtnRestaurar.TextAlign = ContentAlignment.MiddleRight;
            BtnRestaurar.UseVisualStyleBackColor = true;
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // CheckVerEliminados
            // 
            CheckVerEliminados.AutoSize = true;
            CheckVerEliminados.Location = new Point(782, 24);
            CheckVerEliminados.Name = "CheckVerEliminados";
            CheckVerEliminados.Size = new Size(129, 24);
            CheckVerEliminados.TabIndex = 18;
            CheckVerEliminados.Text = "Ver eliminados";
            CheckVerEliminados.UseVisualStyleBackColor = true;
            CheckVerEliminados.CheckedChanged += CheckVerEliminados_CheckedChanged;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Right;
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BtnEliminar.IconColor = Color.Black;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(987, 223);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(137, 53);
            BtnEliminar.TabIndex = 17;
            BtnEliminar.Text = "&Eliminar";
            BtnEliminar.TextAlign = ContentAlignment.MiddleRight;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click_1;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(987, 20);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(137, 50);
            BtnBuscar.TabIndex = 16;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(82, 21);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(681, 27);
            TxtBuscar.TabIndex = 15;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 20);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 14;
            label2.Text = "Buscar:";
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            BtnSalir.IconColor = Color.Black;
            BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalir.Location = new Point(1020, 424);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(115, 48);
            BtnSalir.TabIndex = 13;
            BtnSalir.Text = "Salir";
            BtnSalir.TextAlign = ContentAlignment.MiddleRight;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Anchor = AnchorStyles.Right;
            BtnModificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            BtnModificar.IconColor = Color.Black;
            BtnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnModificar.Location = new Point(987, 162);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(137, 55);
            BtnModificar.TabIndex = 12;
            BtnModificar.Text = "Modificar";
            BtnModificar.TextAlign = ContentAlignment.MiddleRight;
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Right;
            BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregar.IconColor = Color.Black;
            BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(987, 103);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(137, 53);
            BtnAgregar.TabIndex = 11;
            BtnAgregar.Text = "&Agregar";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // DataGrid
            // 
            DataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Location = new Point(3, 68);
            DataGrid.MultiSelect = false;
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersWidth = 51;
            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid.Size = new Size(958, 404);
            DataGrid.TabIndex = 1;
            DataGrid.SelectionChanged += GridPeliculas_SelectionChanged_1;
            // 
            // TabPageAgregarEditar
            // 
            TabPageAgregarEditar.Controls.Add(TxtPassword2);
            TabPageAgregarEditar.Controls.Add(LabelPassword2);
            TabPageAgregarEditar.Controls.Add(TxtPassword);
            TabPageAgregarEditar.Controls.Add(LabelPassword);
            TabPageAgregarEditar.Controls.Add(TxtEmail);
            TabPageAgregarEditar.Controls.Add(label5);
            TabPageAgregarEditar.Controls.Add(ComboTiposDeUsuarios);
            TabPageAgregarEditar.Controls.Add(label8);
            TabPageAgregarEditar.Controls.Add(label3);
            TabPageAgregarEditar.Controls.Add(BtnGuardar);
            TabPageAgregarEditar.Controls.Add(BtnCancelar);
            TabPageAgregarEditar.Controls.Add(TxtDni);
            TabPageAgregarEditar.Controls.Add(TxtNombre);
            TabPageAgregarEditar.Controls.Add(label6);
            TabPageAgregarEditar.Controls.Add(label4);
            TabPageAgregarEditar.Controls.Add(TxtApellido);
            TabPageAgregarEditar.Location = new Point(4, 29);
            TabPageAgregarEditar.Name = "TabPageAgregarEditar";
            TabPageAgregarEditar.Padding = new Padding(3);
            TabPageAgregarEditar.Size = new Size(1150, 488);
            TabPageAgregarEditar.TabIndex = 1;
            TabPageAgregarEditar.Text = "Agregar/Editar";
            TabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // TxtPassword2
            // 
            TxtPassword2.ForeColor = Color.Black;
            TxtPassword2.Location = new Point(304, 251);
            TxtPassword2.Margin = new Padding(2);
            TxtPassword2.Name = "TxtPassword2";
            TxtPassword2.PasswordChar = '*';
            TxtPassword2.PlaceholderText = "Mínimo 6 caracteres";
            TxtPassword2.Size = new Size(718, 27);
            TxtPassword2.TabIndex = 44;
            // 
            // LabelPassword2
            // 
            LabelPassword2.Location = new Point(85, 254);
            LabelPassword2.Margin = new Padding(2, 0, 2, 0);
            LabelPassword2.Name = "LabelPassword2";
            LabelPassword2.Size = new Size(186, 24);
            LabelPassword2.TabIndex = 45;
            LabelPassword2.Text = "Repetir contraseña:";
            LabelPassword2.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtPassword
            // 
            TxtPassword.ForeColor = Color.Black;
            TxtPassword.Location = new Point(304, 208);
            TxtPassword.Margin = new Padding(2);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.PlaceholderText = "Mínimo 6 caracteres";
            TxtPassword.Size = new Size(718, 27);
            TxtPassword.TabIndex = 42;
            // 
            // LabelPassword
            // 
            LabelPassword.Location = new Point(85, 208);
            LabelPassword.Margin = new Padding(2, 0, 2, 0);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(186, 20);
            LabelPassword.TabIndex = 43;
            LabelPassword.Text = "Contraseña:";
            LabelPassword.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtEmail
            // 
            TxtEmail.ForeColor = Color.Black;
            TxtEmail.Location = new Point(304, 163);
            TxtEmail.Margin = new Padding(2);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(718, 27);
            TxtEmail.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(228, 163);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 41;
            label5.Text = "Email:";
            // 
            // ComboTiposDeUsuarios
            // 
            ComboTiposDeUsuarios.FormattingEnabled = true;
            ComboTiposDeUsuarios.Location = new Point(304, 292);
            ComboTiposDeUsuarios.Name = "ComboTiposDeUsuarios";
            ComboTiposDeUsuarios.Size = new Size(266, 28);
            ComboTiposDeUsuarios.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(156, 295);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 38;
            label8.Text = "Tipo de usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 27);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 30;
            label3.Text = "Nombre:";
            // 
            // BtnGuardar
            // 
            BtnGuardar.Anchor = AnchorStyles.Bottom;
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.Black;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(436, 423);
            BtnGuardar.Margin = new Padding(2);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(118, 43);
            BtnGuardar.TabIndex = 6;
            BtnGuardar.Text = "&Guardar";
            BtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click_1;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Bottom;
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(594, 423);
            BtnCancelar.Margin = new Padding(2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(116, 49);
            BtnCancelar.TabIndex = 7;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click_1;
            // 
            // TxtDni
            // 
            TxtDni.ForeColor = Color.Black;
            TxtDni.Location = new Point(304, 118);
            TxtDni.Margin = new Padding(2);
            TxtDni.Name = "TxtDni";
            TxtDni.Size = new Size(718, 27);
            TxtDni.TabIndex = 2;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(304, 24);
            TxtNombre.Margin = new Padding(2);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(718, 27);
            TxtNombre.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(236, 121);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 35;
            label6.Text = "Dni:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(202, 71);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 33;
            label4.Text = "Apellido:";
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(304, 71);
            TxtApellido.Margin = new Padding(2);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(718, 27);
            TxtApellido.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(16, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1137, 62);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20F);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(142, 42);
            label1.TabIndex = 0;
            label1.Text = "Usuarios";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { LabelStatusMessage });
            statusStrip1.Location = new Point(0, 603);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1201, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // LabelStatusMessage
            // 
            LabelStatusMessage.Name = "LabelStatusMessage";
            LabelStatusMessage.Size = new Size(0, 16);
            // 
            // TimerStatusBar
            // 
            TimerStatusBar.Interval = 5000;
            TimerStatusBar.Tick += TimerStatusBar_Tick;
            // 
            // UsuariosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 625);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(TabControl);
            Name = "UsuariosView";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            TabControl.ResumeLayout(false);
            TabPageLista.ResumeLayout(false);
            TabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            TabPageAgregarEditar.ResumeLayout(false);
            TabPageAgregarEditar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl TabControl;
        private TabPage TabPageLista;
        private TabPage TabPageAgregarEditar;
        private DataGridView DataGrid;
        private FontAwesome.Sharp.IconButton BtnModificar;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private TextBox TxtBuscar;
        private Label label2;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LabelStatusMessage;
        private System.Windows.Forms.Timer TimerStatusBar;
        private CheckBox CheckVerEliminados;
        private FontAwesome.Sharp.IconButton BtnRestaurar;
        private Label label3;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private TextBox TxtDni;
        private TextBox TxtNombre;
        private Label label6;
        private Label label4;
        private TextBox TxtApellido;
        private ComboBox ComboTiposDeUsuarios;
        private Label label8;
        private TextBox TxtEmail;
        private Label label5;
        private TextBox TxtPassword;
        private Label LabelPassword;
        private TextBox TxtPassword2;
        private Label LabelPassword2;
    }
}