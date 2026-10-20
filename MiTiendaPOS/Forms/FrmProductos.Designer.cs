namespace MiTiendaPOS.Forms
{
    partial class FrmProductos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpDatos = new GroupBox();
            lblModo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCategoria = new Label();
            cboCategoria = new ComboBox();
            lblPrecio = new Label();
            nudPrecio = new NumericUpDown();
            lblStock = new Label();
            nudStock = new NumericUpDown();
            chkActivo = new CheckBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            lblFiltro = new Label();
            cboFiltroCategoria = new ComboBox();
            dgvProductos = new DataGridView();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(lblModo);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblCategoria);
            grpDatos.Controls.Add(cboCategoria);
            grpDatos.Controls.Add(lblPrecio);
            grpDatos.Controls.Add(nudPrecio);
            grpDatos.Controls.Add(lblStock);
            grpDatos.Controls.Add(nudStock);
            grpDatos.Controls.Add(chkActivo);
            grpDatos.Controls.Add(btnNuevo);
            grpDatos.Controls.Add(btnGuardar);
            grpDatos.Controls.Add(btnEliminar);
            grpDatos.Location = new Point(12, 12);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(340, 530);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del producto";
            // 
            // lblModo
            // 
            lblModo.AutoSize = true;
            lblModo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblModo.Location = new Point(15, 30);
            lblModo.Name = "lblModo";
            lblModo.Size = new Size(96, 15);
            lblModo.TabIndex = 0;
            lblModo.Text = "Producto nuevo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(15, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 67);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(230, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategoria.Location = new Point(15, 110);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(63, 15);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(90, 107);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(230, 23);
            cboCategoria.TabIndex = 4;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrecio.Location = new Point(15, 150);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(45, 15);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio:";
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            nudPrecio.Location = new Point(90, 148);
            nudPrecio.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(120, 23);
            nudPrecio.TabIndex = 6;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStock.Location = new Point(15, 190);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(42, 15);
            lblStock.TabIndex = 7;
            lblStock.Text = "Stock:";
            // 
            // nudStock
            // 
            nudStock.Location = new Point(90, 188);
            nudStock.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(120, 23);
            nudStock.TabIndex = 8;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(90, 228);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 9;
            chkActivo.Text = "Activo";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(15, 270);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 30);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(120, 270);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 30);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(225, 270);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 30);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBuscar.Location = new Point(370, 20);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(47, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(425, 17);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(180, 23);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += Filtros_Changed;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFiltro.Location = new Point(620, 20);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(63, 15);
            lblFiltro.TabIndex = 3;
            lblFiltro.Text = "Categoría:";
            // 
            // cboFiltroCategoria
            // 
            cboFiltroCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltroCategoria.FormattingEnabled = true;
            cboFiltroCategoria.Location = new Point(690, 17);
            cboFiltroCategoria.Name = "cboFiltroCategoria";
            cboFiltroCategoria.Size = new Size(200, 23);
            cboFiltroCategoria.TabIndex = 4;
            cboFiltroCategoria.SelectedIndexChanged += Filtros_Changed;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(370, 50);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(520, 492);
            dgvProductos.TabIndex = 5;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // FrmProductos
            // 
            ClientSize = new Size(904, 561);
            Controls.Add(grpDatos);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblFiltro);
            Controls.Add(cboFiltroCategoria);
            Controls.Add(dgvProductos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Productos";
            Load += FrmProductos_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboFiltroCategoria;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}