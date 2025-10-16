namespace Desktop.Views
{
    partial class InscripcionesView
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
            panel1 = new Panel();
            label1 = new Label();
            ComboCapacitaciones = new ComboBox();
            label2 = new Label();
            GridInscripciones = new DataGridView();
            panel2 = new Panel();
            label4 = new Label();
            ComboTipoInscripcion = new ComboBox();
            BtnAgregarUsuario = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            TxtBuscarInscriptos = new TextBox();
            GridUsuarios = new DataGridView();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridInscripciones).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1447, 77);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20F);
            label1.Location = new Point(10, 18);
            label1.Name = "label1";
            label1.Size = new Size(212, 42);
            label1.TabIndex = 0;
            label1.Text = "Inscripciones";
            // 
            // ComboCapacitaciones
            // 
            ComboCapacitaciones.Font = new Font("Segoe UI", 12F);
            ComboCapacitaciones.FormattingEnabled = true;
            ComboCapacitaciones.Location = new Point(155, 100);
            ComboCapacitaciones.Name = "ComboCapacitaciones";
            ComboCapacitaciones.Size = new Size(429, 36);
            ComboCapacitaciones.TabIndex = 9;
            ComboCapacitaciones.SelectedIndexChanged += ComboCapacitaciones_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(21, 103);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 10;
            label2.Text = "Capacitación:";
            // 
            // GridInscripciones
            // 
            GridInscripciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridInscripciones.Location = new Point(21, 219);
            GridInscripciones.Name = "GridInscripciones";
            GridInscripciones.RowHeadersVisible = false;
            GridInscripciones.RowHeadersWidth = 51;
            GridInscripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridInscripciones.Size = new Size(581, 414);
            GridInscripciones.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(ComboTipoInscripcion);
            panel2.Controls.Add(BtnAgregarUsuario);
            panel2.Controls.Add(BtnBuscar);
            panel2.Controls.Add(TxtBuscarInscriptos);
            panel2.Controls.Add(GridUsuarios);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(640, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(773, 546);
            panel2.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(38, 341);
            label4.Name = "label4";
            label4.Size = new Size(177, 28);
            label4.TabIndex = 20;
            label4.Text = "Tipo de inscripción";
            // 
            // ComboTipoInscripcion
            // 
            ComboTipoInscripcion.Anchor = AnchorStyles.Left;
            ComboTipoInscripcion.Font = new Font("Segoe UI", 12F);
            ComboTipoInscripcion.FormattingEnabled = true;
            ComboTipoInscripcion.Location = new Point(38, 387);
            ComboTipoInscripcion.Name = "ComboTipoInscripcion";
            ComboTipoInscripcion.Size = new Size(331, 36);
            ComboTipoInscripcion.TabIndex = 19;
            // 
            // BtnAgregarUsuario
            // 
            BtnAgregarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregarUsuario.IconColor = Color.Black;
            BtnAgregarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregarUsuario.Location = new Point(609, 50);
            BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            BtnAgregarUsuario.Size = new Size(128, 51);
            BtnAgregarUsuario.TabIndex = 18;
            BtnAgregarUsuario.Text = "&Agregar inscripto";
            BtnAgregarUsuario.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregarUsuario.UseCompatibleTextRendering = true;
            BtnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(475, 50);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(102, 50);
            BtnBuscar.TabIndex = 17;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBuscarInscriptos
            // 
            TxtBuscarInscriptos.Font = new Font("Segoe UI", 12F);
            TxtBuscarInscriptos.Location = new Point(38, 66);
            TxtBuscarInscriptos.Name = "TxtBuscarInscriptos";
            TxtBuscarInscriptos.PlaceholderText = "Buscar inscriptos...";
            TxtBuscarInscriptos.Size = new Size(331, 34);
            TxtBuscarInscriptos.TabIndex = 13;
            TxtBuscarInscriptos.TextChanged += TxtBuscarInscriptos_TextChanged;
            TxtBuscarInscriptos.KeyPress += TxtBuscarInscriptos_KeyPress;
            // 
            // GridUsuarios
            // 
            GridUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridUsuarios.Location = new Point(38, 117);
            GridUsuarios.Name = "GridUsuarios";
            GridUsuarios.RowHeadersVisible = false;
            GridUsuarios.RowHeadersWidth = 51;
            GridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridUsuarios.Size = new Size(699, 210);
            GridUsuarios.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(38, 15);
            label3.Name = "label3";
            label3.Size = new Size(182, 28);
            label3.TabIndex = 11;
            label3.Text = "Agregar inscripción";
            // 
            // InscripcionesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 658);
            Controls.Add(panel2);
            Controls.Add(GridInscripciones);
            Controls.Add(label2);
            Controls.Add(ComboCapacitaciones);
            Controls.Add(panel1);
            Name = "InscripcionesView";
            Text = "Inscripciones";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridInscripciones).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox ComboCapacitaciones;
        private Label label2;
        private DataGridView GridInscripciones;
        private Panel panel2;
        private Label label3;
        private DataGridView GridUsuarios;
        private TextBox TxtBuscarInscriptos;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private FontAwesome.Sharp.IconButton BtnAgregarUsuario;
        private ComboBox ComboTipoInscripcion;
        private Label label4;
    }
}