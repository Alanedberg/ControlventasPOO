namespace ControlDeVentas
{
    partial class FrmPanelVentas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtDatosClientes = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblFecha = new Label();
            lblHora = new Label();
            groupBox2 = new GroupBox();
            txtCantidad = new TextBox();
            label7 = new Label();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            lblPrecio = new Label();
            label6 = new Label();
            cmbProducto = new ComboBox();
            label5 = new Label();
            lvDetalle = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            lblTotalNeto = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDatosClientes);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DEL CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(17, 23);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "CLIENTE";
            // 
            // txtDatosClientes
            // 
            txtDatosClientes.Location = new Point(17, 41);
            txtDatosClientes.Name = "txtDatosClientes";
            txtDatosClientes.Size = new Size(375, 23);
            txtDatosClientes.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 42);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(259, 7);
            label1.Name = "label1";
            label1.Size = new Size(241, 23);
            label1.TabIndex = 2;
            label1.Text = "CONTROL DE VENTAS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(456, 45);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "FECHA:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(650, 46);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "HORA:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            lblFecha.ForeColor = Color.Black;
            lblFecha.Location = new Point(508, 44);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(64, 17);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "lblFecha";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            lblHora.ForeColor = Color.Black;
            lblHora.Location = new Point(700, 45);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(55, 17);
            lblHora.TabIndex = 5;
            lblHora.Text = "lblHora";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(btnRegistrar);
            groupBox2.Controls.Add(lblPrecio);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cmbProducto);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(754, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATOS DE LA VENTA";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(377, 50);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(83, 23);
            txtCantidad.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(377, 23);
            label7.Name = "label7";
            label7.Size = new Size(76, 17);
            label7.TabIndex = 10;
            label7.Text = "CANTIDAD";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(618, 52);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 30);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.RoyalBlue;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.Control;
            btnRegistrar.Location = new Point(618, 15);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(89, 25);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            lblPrecio.ForeColor = Color.Black;
            lblPrecio.Location = new Point(496, 52);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(36, 17);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "0.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(496, 23);
            label6.Name = "label6";
            label6.Size = new Size(59, 17);
            label6.TabIndex = 6;
            label6.Text = "PRECIO";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(23, 50);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(270, 23);
            cmbProducto.TabIndex = 2;
            cmbProducto.Text = "Seleccione un producto..";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(17, 23);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 1;
            label5.Text = "PRODUCTO";
            // 
            // lvDetalle
            // 
            lvDetalle.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1, columnHeader3, columnHeader4, columnHeader5 });
            lvDetalle.Location = new Point(23, 277);
            lvDetalle.Name = "lvDetalle";
            lvDetalle.Size = new Size(732, 188);
            lvDetalle.TabIndex = 6;
            lvDetalle.UseCompatibleStateImageBehavior = false;
            lvDetalle.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "PRODUCTO";
            columnHeader2.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "CANT.";
            columnHeader1.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "PRECIO";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "DESCUENTO";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "SUB TOTAL NETO";
            columnHeader5.Width = 150;
            // 
            // lblTotalNeto
            // 
            lblTotalNeto.AutoSize = true;
            lblTotalNeto.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            lblTotalNeto.ForeColor = Color.Black;
            lblTotalNeto.Location = new Point(640, 478);
            lblTotalNeto.Name = "lblTotalNeto";
            lblTotalNeto.Size = new Size(88, 17);
            lblTotalNeto.TabIndex = 8;
            lblTotalNeto.Text = "lblTotalNeto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(554, 479);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 7;
            label8.Text = "TOTAL NETO:";
            // 
            // FrmPanelVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(782, 515);
            Controls.Add(lblTotalNeto);
            Controls.Add(label8);
            Controls.Add(lvDetalle);
            Controls.Add(groupBox2);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "FrmPanelVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de Ventas";
            Load += FrmPanelVentas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private Label label1;
        private TextBox txtDatosClientes;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblFecha;
        private Label lblHora;
        private GroupBox groupBox2;
        private Label label6;
        private ComboBox cmbProducto;
        private Label label5;
        private Button btnCancelar;
        private Button btnRegistrar;
        private Label lblPrecio;
        private ListView lvDetalle;
        private Label lblTotalNeto;
        private Label label8;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TextBox txtCantidad;
        private Label label7;
    }
}
