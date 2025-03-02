﻿namespace Vistas
{
    partial class FormVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.dtpVenta = new System.Windows.Forms.DateTimePicker();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMasProducto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lVProductos = new System.Windows.Forms.ListView();
            this.Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxTotalPagar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Venta Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(149, 42);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(200, 21);
            this.comboBoxClientes.TabIndex = 5;
            // 
            // dtpVenta
            // 
            this.dtpVenta.Location = new System.Drawing.Point(149, 131);
            this.dtpVenta.Name = "dtpVenta";
            this.dtpVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpVenta.TabIndex = 6;
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Enabled = false;
            this.txtBoxPrecio.Location = new System.Drawing.Point(149, 223);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(200, 20);
            this.txtBoxPrecio.TabIndex = 7;
            this.txtBoxPrecio.TextChanged += new System.EventHandler(this.txtBoxPrecio_TextChanged);
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Location = new System.Drawing.Point(149, 273);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(200, 20);
            this.txtBoxCantidad.TabIndex = 8;
            this.txtBoxCantidad.TextChanged += new System.EventHandler(this.txtBoxCantidad_TextChanged);
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Enabled = false;
            this.txtBoxTotal.Location = new System.Drawing.Point(149, 315);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.Size = new System.Drawing.Size(200, 20);
            this.txtBoxTotal.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(115, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 35);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Guardar Venta";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBoxProductos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxClientes);
            this.groupBox1.Controls.Add(this.dtpVenta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxPrecio);
            this.groupBox1.Controls.Add(this.txtBoxCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxTotal);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 443);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(254, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Buscar Clientes?";
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(149, 180);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProductos.TabIndex = 15;
            this.comboBoxProductos.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProductos_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Producto";
            // 
            // btnMasProducto
            // 
            this.btnMasProducto.Location = new System.Drawing.Point(464, 410);
            this.btnMasProducto.Name = "btnMasProducto";
            this.btnMasProducto.Size = new System.Drawing.Size(93, 35);
            this.btnMasProducto.TabIndex = 14;
            this.btnMasProducto.Text = "Agregar a la lista";
            this.btnMasProducto.UseVisualStyleBackColor = true;
            this.btnMasProducto.Click += new System.EventHandler(this.btnMasProducto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Productos Escogidos";
            // 
            // lVProductos
            // 
            this.lVProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Total});
            this.lVProductos.Location = new System.Drawing.Point(401, 210);
            this.lVProductos.Name = "lVProductos";
            this.lVProductos.Size = new System.Drawing.Size(215, 142);
            this.lVProductos.TabIndex = 15;
            this.lVProductos.UseCompatibleStateImageBehavior = false;
            this.lVProductos.View = System.Windows.Forms.View.Details;
            // 
            // Producto
            // 
            this.Producto.Text = "Producto";
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.Width = 44;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 54;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total a Pagar:";
            // 
            // txtBoxTotalPagar
            // 
            this.txtBoxTotalPagar.Enabled = false;
            this.txtBoxTotalPagar.Location = new System.Drawing.Point(487, 364);
            this.txtBoxTotalPagar.Name = "txtBoxTotalPagar";
            this.txtBoxTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTotalPagar.TabIndex = 17;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 475);
            this.Controls.Add(this.txtBoxTotalPagar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lVProductos);
            this.Controls.Add(this.btnMasProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.DateTimePicker dtpVenta;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.Button btnMasProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lVProductos;
        private System.Windows.Forms.ColumnHeader Producto;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxTotalPagar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label9;
    }
}