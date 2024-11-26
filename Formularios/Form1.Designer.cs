namespace Unidad5PuntoDeVenta
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCodVta = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVisita = new System.Windows.Forms.Label();
            this.lblTipoCambio = new System.Windows.Forms.Label();
            this.lblNumVent = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblServicios = new System.Windows.Forms.Label();
            this.lblInexistente = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.lblBuscarProd = new System.Windows.Forms.Button();
            this.btnBorrarProd = new System.Windows.Forms.Button();
            this.btnCajon = new System.Windows.Forms.Button();
            this.dtgVenta = new System.Windows.Forms.DataGridView();
            this.lblCantidadmen = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblInpuesto = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gpDetalles = new System.Windows.Forms.GroupBox();
            this.gpbVenta = new System.Windows.Forms.GroupBox();
            this.gpbEscaner = new System.Windows.Forms.GroupBox();
            this.gpbCantidad = new System.Windows.Forms.GroupBox();
            this.gpbCobrar = new System.Windows.Forms.GroupBox();
            this.gpbTotales = new System.Windows.Forms.GroupBox();
            this.gpbCajon = new System.Windows.Forms.GroupBox();
            this.gpbTotal = new System.Windows.Forms.GroupBox();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenta)).BeginInit();
            this.gpDetalles.SuspendLayout();
            this.gpbVenta.SuspendLayout();
            this.gpbEscaner.SuspendLayout();
            this.gpbCantidad.SuspendLayout();
            this.gpbCobrar.SuspendLayout();
            this.gpbTotales.SuspendLayout();
            this.gpbCajon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(16, 25);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 15);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha :";
            this.lblFecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCodVta
            // 
            this.lblCodVta.AutoSize = true;
            this.lblCodVta.Location = new System.Drawing.Point(16, 56);
            this.lblCodVta.Name = "lblCodVta";
            this.lblCodVta.Size = new System.Drawing.Size(51, 13);
            this.lblCodVta.TabIndex = 1;
            this.lblCodVta.Text = "Cod. Vta:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(16, 119);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(60, 13);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Empleado: ";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(16, 85);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente: ";
            // 
            // lblVisita
            // 
            this.lblVisita.AutoSize = true;
            this.lblVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisita.Location = new System.Drawing.Point(290, 25);
            this.lblVisita.Name = "lblVisita";
            this.lblVisita.Size = new System.Drawing.Size(81, 15);
            this.lblVisita.TabIndex = 4;
            this.lblVisita.Text = "Ultima Visita: ";
            // 
            // lblTipoCambio
            // 
            this.lblTipoCambio.AutoSize = true;
            this.lblTipoCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCambio.Location = new System.Drawing.Point(203, 54);
            this.lblTipoCambio.Name = "lblTipoCambio";
            this.lblTipoCambio.Size = new System.Drawing.Size(100, 15);
            this.lblTipoCambio.TabIndex = 5;
            this.lblTipoCambio.Text = "Tipo de Cambio: ";
            // 
            // lblNumVent
            // 
            this.lblNumVent.AutoSize = true;
            this.lblNumVent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVent.Location = new System.Drawing.Point(6, 16);
            this.lblNumVent.Name = "lblNumVent";
            this.lblNumVent.Size = new System.Drawing.Size(83, 15);
            this.lblNumVent.TabIndex = 1;
            this.lblNumVent.Text = "Num. Ventas: ";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(6, 44);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(68, 15);
            this.lblProductos.TabIndex = 2;
            this.lblProductos.Text = "Productos: ";
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicios.Location = new System.Drawing.Point(6, 73);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(62, 15);
            this.lblServicios.TabIndex = 3;
            this.lblServicios.Text = "Servicios: ";
            // 
            // lblInexistente
            // 
            this.lblInexistente.Location = new System.Drawing.Point(92, 98);
            this.lblInexistente.Name = "lblInexistente";
            this.lblInexistente.Size = new System.Drawing.Size(110, 39);
            this.lblInexistente.TabIndex = 4;
            this.lblInexistente.Text = "Agregar producto inexistente";
            this.lblInexistente.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(6, 16);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(62, 15);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad: ";
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProd.Location = new System.Drawing.Point(131, 16);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(90, 15);
            this.lblCodProd.TabIndex = 1;
            this.lblCodProd.Text = "Cód. Producto: ";
            // 
            // lblAdvice
            // 
            this.lblAdvice.AutoSize = true;
            this.lblAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvice.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblAdvice.Location = new System.Drawing.Point(237, 16);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(145, 15);
            this.lblAdvice.TabIndex = 2;
            this.lblAdvice.Text = "Digite o escane el código";
            // 
            // lblBuscarProd
            // 
            this.lblBuscarProd.BackColor = System.Drawing.Color.LightGray;
            this.lblBuscarProd.Location = new System.Drawing.Point(499, 27);
            this.lblBuscarProd.Name = "lblBuscarProd";
            this.lblBuscarProd.Size = new System.Drawing.Size(118, 39);
            this.lblBuscarProd.TabIndex = 3;
            this.lblBuscarProd.Text = "Buscar Producto";
            this.lblBuscarProd.UseVisualStyleBackColor = false;
            // 
            // btnBorrarProd
            // 
            this.btnBorrarProd.BackColor = System.Drawing.Color.LightGray;
            this.btnBorrarProd.Location = new System.Drawing.Point(626, 27);
            this.btnBorrarProd.Name = "btnBorrarProd";
            this.btnBorrarProd.Size = new System.Drawing.Size(118, 39);
            this.btnBorrarProd.TabIndex = 4;
            this.btnBorrarProd.Text = "Borrar Producto";
            this.btnBorrarProd.UseVisualStyleBackColor = false;
            // 
            // btnCajon
            // 
            this.btnCajon.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCajon.Location = new System.Drawing.Point(36, 20);
            this.btnCajon.Name = "btnCajon";
            this.btnCajon.Size = new System.Drawing.Size(66, 63);
            this.btnCajon.TabIndex = 0;
            this.btnCajon.Text = "Abrir Cajón";
            this.btnCajon.UseVisualStyleBackColor = false;
            // 
            // dtgVenta
            // 
            this.dtgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Codigo,
            this.Descripcion,
            this.PrecioPub,
            this.Final,
            this.Importe,
            this.Existencia,
            this.Impuesto});
            this.dtgVenta.Location = new System.Drawing.Point(19, 295);
            this.dtgVenta.Name = "dtgVenta";
            this.dtgVenta.Size = new System.Drawing.Size(846, 170);
            this.dtgVenta.TabIndex = 10;
            this.dtgVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVenta_CellContentClick);
            // 
            // lblCantidadmen
            // 
            this.lblCantidadmen.AutoSize = true;
            this.lblCantidadmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadmen.Location = new System.Drawing.Point(6, 26);
            this.lblCantidadmen.Name = "lblCantidadmen";
            this.lblCantidadmen.Size = new System.Drawing.Size(165, 16);
            this.lblCantidadmen.TabIndex = 3;
            this.lblCantidadmen.Text = "Cantidad de Productos";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGray;
            this.btnExit.Location = new System.Drawing.Point(9, 68);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 39);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Location = new System.Drawing.Point(115, 68);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 39);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar Venta";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCobrar.Location = new System.Drawing.Point(23, 29);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(74, 64);
            this.btnCobrar.TabIndex = 6;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(6, 16);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(52, 13);
            this.lblSub.TabIndex = 4;
            this.lblSub.Text = "Subtotal: ";
            // 
            // lblInpuesto
            // 
            this.lblInpuesto.AutoSize = true;
            this.lblInpuesto.Location = new System.Drawing.Point(6, 39);
            this.lblInpuesto.Name = "lblInpuesto";
            this.lblInpuesto.Size = new System.Drawing.Size(27, 13);
            this.lblInpuesto.TabIndex = 5;
            this.lblInpuesto.Text = "IVA:";
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Location = new System.Drawing.Point(6, 62);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(37, 13);
            this.lblTot.TabIndex = 6;
            this.lblTot.Text = "Total: ";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(6, 37);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(57, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(102, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(289, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(83, 82);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(115, 21);
            this.cbxCliente.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(83, 115);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(115, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // gpDetalles
            // 
            this.gpDetalles.Controls.Add(this.lblInexistente);
            this.gpDetalles.Controls.Add(this.lblProductos);
            this.gpDetalles.Controls.Add(this.lblServicios);
            this.gpDetalles.Controls.Add(this.lblNumVent);
            this.gpDetalles.Location = new System.Drawing.Point(525, 12);
            this.gpDetalles.Name = "gpDetalles";
            this.gpDetalles.Size = new System.Drawing.Size(208, 143);
            this.gpDetalles.TabIndex = 15;
            this.gpDetalles.TabStop = false;
            this.gpDetalles.Text = "Detalles de venta";
            // 
            // gpbVenta
            // 
            this.gpbVenta.Controls.Add(this.lblVisita);
            this.gpbVenta.Controls.Add(this.comboBox2);
            this.gpbVenta.Controls.Add(this.lblTipoCambio);
            this.gpbVenta.Controls.Add(this.lblFecha);
            this.gpbVenta.Controls.Add(this.cbxCliente);
            this.gpbVenta.Controls.Add(this.lblCodVta);
            this.gpbVenta.Controls.Add(this.dateTimePicker1);
            this.gpbVenta.Controls.Add(this.lblCliente);
            this.gpbVenta.Controls.Add(this.lblEmpleado);
            this.gpbVenta.Location = new System.Drawing.Point(12, 9);
            this.gpbVenta.Name = "gpbVenta";
            this.gpbVenta.Size = new System.Drawing.Size(496, 179);
            this.gpbVenta.TabIndex = 16;
            this.gpbVenta.TabStop = false;
            // 
            // gpbEscaner
            // 
            this.gpbEscaner.Controls.Add(this.btnBorrarProd);
            this.gpbEscaner.Controls.Add(this.txtCodigo);
            this.gpbEscaner.Controls.Add(this.lblBuscarProd);
            this.gpbEscaner.Controls.Add(this.lblCantidad);
            this.gpbEscaner.Controls.Add(this.txtCantidad);
            this.gpbEscaner.Controls.Add(this.lblCodProd);
            this.gpbEscaner.Controls.Add(this.lblAdvice);
            this.gpbEscaner.Location = new System.Drawing.Point(12, 194);
            this.gpbEscaner.Name = "gpbEscaner";
            this.gpbEscaner.Size = new System.Drawing.Size(779, 82);
            this.gpbEscaner.TabIndex = 17;
            this.gpbEscaner.TabStop = false;
            // 
            // gpbCantidad
            // 
            this.gpbCantidad.Controls.Add(this.btnCancelar);
            this.gpbCantidad.Controls.Add(this.lblCantidadmen);
            this.gpbCantidad.Controls.Add(this.btnExit);
            this.gpbCantidad.Location = new System.Drawing.Point(19, 483);
            this.gpbCantidad.Name = "gpbCantidad";
            this.gpbCantidad.Size = new System.Drawing.Size(325, 135);
            this.gpbCantidad.TabIndex = 18;
            this.gpbCantidad.TabStop = false;
            // 
            // gpbCobrar
            // 
            this.gpbCobrar.Controls.Add(this.btnCobrar);
            this.gpbCobrar.Location = new System.Drawing.Point(361, 503);
            this.gpbCobrar.Name = "gpbCobrar";
            this.gpbCobrar.Size = new System.Drawing.Size(124, 115);
            this.gpbCobrar.TabIndex = 19;
            this.gpbCobrar.TabStop = false;
            // 
            // gpbTotales
            // 
            this.gpbTotales.Controls.Add(this.lblTot);
            this.gpbTotales.Controls.Add(this.lblSub);
            this.gpbTotales.Controls.Add(this.lblInpuesto);
            this.gpbTotales.Location = new System.Drawing.Point(491, 518);
            this.gpbTotales.Name = "gpbTotales";
            this.gpbTotales.Size = new System.Drawing.Size(200, 100);
            this.gpbTotales.TabIndex = 20;
            this.gpbTotales.TabStop = false;
            // 
            // gpbCajon
            // 
            this.gpbCajon.Controls.Add(this.btnCajon);
            this.gpbCajon.Location = new System.Drawing.Point(813, 176);
            this.gpbCajon.Name = "gpbCajon";
            this.gpbCajon.Size = new System.Drawing.Size(135, 100);
            this.gpbCajon.TabIndex = 21;
            this.gpbCajon.TabStop = false;
            // 
            // gpbTotal
            // 
            this.gpbTotal.Location = new System.Drawing.Point(726, 513);
            this.gpbTotal.Name = "gpbTotal";
            this.gpbTotal.Size = new System.Drawing.Size(189, 105);
            this.gpbTotal.TabIndex = 22;
            this.gpbTotal.TabStop = false;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigó";
            this.Codigo.Name = "Codigo";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // PrecioPub
            // 
            this.PrecioPub.HeaderText = "Precio Publico";
            this.PrecioPub.Name = "PrecioPub";
            // 
            // Final
            // 
            this.Final.HeaderText = "Precio Final";
            this.Final.Name = "Final";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // Existencia
            // 
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            // 
            // Impuesto
            // 
            this.Impuesto.HeaderText = "IVA";
            this.Impuesto.Name = "Impuesto";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 643);
            this.Controls.Add(this.gpbTotal);
            this.Controls.Add(this.gpbCajon);
            this.Controls.Add(this.gpbTotales);
            this.Controls.Add(this.gpbCobrar);
            this.Controls.Add(this.gpbCantidad);
            this.Controls.Add(this.gpbEscaner);
            this.Controls.Add(this.gpbVenta);
            this.Controls.Add(this.gpDetalles);
            this.Controls.Add(this.dtgVenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenta)).EndInit();
            this.gpDetalles.ResumeLayout(false);
            this.gpDetalles.PerformLayout();
            this.gpbVenta.ResumeLayout(false);
            this.gpbVenta.PerformLayout();
            this.gpbEscaner.ResumeLayout(false);
            this.gpbEscaner.PerformLayout();
            this.gpbCantidad.ResumeLayout(false);
            this.gpbCantidad.PerformLayout();
            this.gpbCobrar.ResumeLayout(false);
            this.gpbTotales.ResumeLayout(false);
            this.gpbTotales.PerformLayout();
            this.gpbCajon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCodVta;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblVisita;
        private System.Windows.Forms.Label lblTipoCambio;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblNumVent;
        private System.Windows.Forms.Button lblInexistente;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblAdvice;
        private System.Windows.Forms.Button btnBorrarProd;
        private System.Windows.Forms.Button lblBuscarProd;
        private System.Windows.Forms.Button btnCajon;
        private System.Windows.Forms.DataGridView dtgVenta;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCantidadmen;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lblInpuesto;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.GroupBox gpDetalles;
        private System.Windows.Forms.GroupBox gpbVenta;
        private System.Windows.Forms.GroupBox gpbEscaner;
        private System.Windows.Forms.GroupBox gpbCantidad;
        private System.Windows.Forms.GroupBox gpbCobrar;
        private System.Windows.Forms.GroupBox gpbTotales;
        private System.Windows.Forms.GroupBox gpbCajon;
        private System.Windows.Forms.GroupBox gpbTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
    }
}

