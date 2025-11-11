namespace Desktop.Views
{
    partial class AcreditacionView
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
            panel1 = new Panel();
            label1 = new Label();
            ComboCapacitaciones = new ComboBox();
            label2 = new Label();
            GridInscripciones = new DataGridView();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            TxtBuscarInscriptos = new TextBox();
            ContextMenuInscripcion = new ContextMenuStrip(components);
            SubMenuEliminarInscripcion = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridInscripciones).BeginInit();
            ContextMenuInscripcion.SuspendLayout();
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
            label1.Size = new Size(229, 42);
            label1.TabIndex = 0;
            label1.Text = "Acreditaciones";
            // 
            // ComboCapacitaciones
            // 
            ComboCapacitaciones.Font = new Font("Segoe UI", 12F);
            ComboCapacitaciones.FormattingEnabled = true;
            ComboCapacitaciones.Location = new Point(155, 100);
            ComboCapacitaciones.Name = "ComboCapacitaciones";
            ComboCapacitaciones.Size = new Size(1260, 36);
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
            GridInscripciones.Location = new Point(21, 228);
            GridInscripciones.Name = "GridInscripciones";
            GridInscripciones.RowHeadersVisible = false;
            GridInscripciones.RowHeadersWidth = 51;
            GridInscripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridInscripciones.Size = new Size(1394, 405);
            GridInscripciones.TabIndex = 11;
            GridInscripciones.MouseClick += GridInscripciones_MouseClick;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(1313, 151);
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
            TxtBuscarInscriptos.Location = new Point(155, 156);
            TxtBuscarInscriptos.Name = "TxtBuscarInscriptos";
            TxtBuscarInscriptos.PlaceholderText = "Buscar inscriptos...";
            TxtBuscarInscriptos.Size = new Size(1136, 34);
            TxtBuscarInscriptos.TabIndex = 13;
            TxtBuscarInscriptos.TextChanged += TxtBuscarInscriptos_TextChanged;
            // 
            // ContextMenuInscripcion
            // 
            ContextMenuInscripcion.ImageScalingSize = new Size(20, 20);
            ContextMenuInscripcion.Items.AddRange(new ToolStripItem[] { SubMenuEliminarInscripcion });
            ContextMenuInscripcion.Name = "ContextMenuInscripcion";
            ContextMenuInscripcion.Size = new Size(197, 28);
            // 
            // SubMenuEliminarInscripcion
            // 
            SubMenuEliminarInscripcion.Name = "SubMenuEliminarInscripcion";
            SubMenuEliminarInscripcion.Size = new Size(196, 24);
            SubMenuEliminarInscripcion.Text = "&Anular inscripción";
            // 
            // AcreditacionView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 658);
            Controls.Add(GridInscripciones);
            Controls.Add(BtnBuscar);
            Controls.Add(label2);
            Controls.Add(TxtBuscarInscriptos);
            Controls.Add(ComboCapacitaciones);
            Controls.Add(panel1);
            Name = "AcreditacionView";
            Text = "Inscripciones";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridInscripciones).EndInit();
            ContextMenuInscripcion.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox ComboCapacitaciones;
        private Label label2;
        private DataGridView GridInscripciones;
        private TextBox TxtBuscarInscriptos;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private ContextMenuStrip ContextMenuInscripcion;
        private ToolStripMenuItem SubMenuEliminarInscripcion;
    }
}