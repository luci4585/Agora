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
            GridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 62);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20F);
            label1.Location = new Point(3, 10);
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
            ComboCapacitaciones.Size = new Size(290, 36);
            ComboCapacitaciones.TabIndex = 9;
            ComboCapacitaciones.SelectedIndexChanged += ComboCapacitaciones_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 110);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 10;
            label2.Text = "Capacitación:";
            // 
            // GridView
            // 
            GridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridView.Location = new Point(35, 159);
            GridView.Name = "GridView";
            GridView.RowHeadersWidth = 51;
            GridView.Size = new Size(843, 352);
            GridView.TabIndex = 11;
            // 
            // InscripcionesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 523);
            Controls.Add(GridView);
            Controls.Add(label2);
            Controls.Add(ComboCapacitaciones);
            Controls.Add(panel1);
            Name = "InscripcionesView";
            Text = "Inscripciones";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox ComboCapacitaciones;
        private Label label2;
        private DataGridView GridView;
    }
}