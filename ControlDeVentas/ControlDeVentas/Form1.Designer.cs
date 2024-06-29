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
            txtDatosClientes = new MaterialSkin.Controls.MaterialTextBox2();
            label3 = new Label();
            label4 = new Label();
            lblFecha = new Label();
            lblHora = new Label();
            groupBox2 = new GroupBox();
            txtCantidad = new MaterialSkin.Controls.MaterialTextBox2();
            lblPrecio = new MaterialSkin.Controls.MaterialLabel();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            cmbProducto = new MaterialSkin.Controls.MaterialComboBox();
            btnRegistrar = new MaterialSkin.Controls.MaterialButton();
            label6 = new Label();
            lvDetalle = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            lblTotalNeto = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDatosClientes);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 83);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DEL CLIENTE";
            // 
            // txtDatosClientes
            // 
            txtDatosClientes.AnimateReadOnly = false;
            txtDatosClientes.BackgroundImageLayout = ImageLayout.None;
            txtDatosClientes.CharacterCasing = CharacterCasing.Normal;
            txtDatosClientes.Depth = 0;
            txtDatosClientes.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDatosClientes.HideSelection = true;
            txtDatosClientes.Hint = "Nombre del cliente";
            txtDatosClientes.LeadingIcon = null;
            txtDatosClientes.Location = new Point(17, 22);
            txtDatosClientes.MaxLength = 32767;
            txtDatosClientes.MouseState = MaterialSkin.MouseState.OUT;
            txtDatosClientes.Name = "txtDatosClientes";
            txtDatosClientes.PasswordChar = '\0';
            txtDatosClientes.PrefixSuffixText = null;
            txtDatosClientes.ReadOnly = false;
            txtDatosClientes.RightToLeft = RightToLeft.No;
            txtDatosClientes.SelectedText = "";
            txtDatosClientes.SelectionLength = 0;
            txtDatosClientes.SelectionStart = 0;
            txtDatosClientes.ShortcutsEnabled = true;
            txtDatosClientes.Size = new Size(348, 48);
            txtDatosClientes.TabIndex = 12;
            txtDatosClientes.TabStop = false;
            txtDatosClientes.TextAlign = HorizontalAlignment.Left;
            txtDatosClientes.TrailingIcon = null;
            txtDatosClientes.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(540, 46);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "FECHA:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(690, 46);
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
            lblFecha.Location = new Point(602, 44);
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
            lblHora.Location = new Point(740, 44);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(55, 17);
            lblHora.TabIndex = 5;
            lblHora.Text = "lblHora";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(lblPrecio);
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(cmbProducto);
            groupBox2.Controls.Add(btnRegistrar);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 154);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(754, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATOS DE LA VENTA";
            // 
            // txtCantidad
            // 
            txtCantidad.AnimateReadOnly = false;
            txtCantidad.BackgroundImageLayout = ImageLayout.None;
            txtCantidad.CharacterCasing = CharacterCasing.Normal;
            txtCantidad.Depth = 0;
            txtCantidad.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCantidad.HideSelection = true;
            txtCantidad.Hint = "Cantidad";
            txtCantidad.LeadingIcon = null;
            txtCantidad.Location = new Point(286, 42);
            txtCantidad.MaxLength = 32767;
            txtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PasswordChar = '\0';
            txtCantidad.PrefixSuffixText = null;
            txtCantidad.ReadOnly = false;
            txtCantidad.RightToLeft = RightToLeft.No;
            txtCantidad.SelectedText = "";
            txtCantidad.SelectionLength = 0;
            txtCantidad.SelectionStart = 0;
            txtCantidad.ShortcutsEnabled = true;
            txtCantidad.Size = new Size(97, 48);
            txtCantidad.TabIndex = 9;
            txtCantidad.TabStop = false;
            txtCantidad.TextAlign = HorizontalAlignment.Left;
            txtCantidad.TrailingIcon = null;
            txtCantidad.UseSystemPasswordChar = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Depth = 0;
            lblPrecio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPrecio.Location = new Point(435, 69);
            lblPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(32, 19);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "0.00";
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = false;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(630, 52);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(105, 32);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbProducto
            // 
            cmbProducto.AutoResize = false;
            cmbProducto.BackColor = Color.FromArgb(255, 255, 255);
            cmbProducto.Depth = 0;
            cmbProducto.DrawMode = DrawMode.OwnerDrawVariable;
            cmbProducto.DropDownHeight = 174;
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.DropDownWidth = 121;
            cmbProducto.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbProducto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Hint = "Seleccione un producto...";
            cmbProducto.IntegralHeight = false;
            cmbProducto.ItemHeight = 43;
            cmbProducto.Location = new Point(17, 41);
            cmbProducto.MaxDropDownItems = 4;
            cmbProducto.MouseState = MaterialSkin.MouseState.OUT;
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(228, 49);
            cmbProducto.StartIndex = 0;
            cmbProducto.TabIndex = 9;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged_1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.AutoSize = false;
            btnRegistrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegistrar.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btnRegistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnRegistrar.Depth = 0;
            btnRegistrar.HighEmphasis = true;
            btnRegistrar.Icon = null;
            btnRegistrar.Location = new Point(519, 52);
            btnRegistrar.Margin = new Padding(4, 6, 4, 6);
            btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.NoAccentTextColor = Color.Empty;
            btnRegistrar.Size = new Size(105, 32);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegistrar.UseAccentColor = false;
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(425, 41);
            label6.Name = "label6";
            label6.Size = new Size(59, 17);
            label6.TabIndex = 6;
            label6.Text = "PRECIO";
            // 
            // lvDetalle
            // 
            lvDetalle.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1, columnHeader3, columnHeader4, columnHeader5 });
            lvDetalle.Location = new Point(23, 260);
            lvDetalle.Name = "lvDetalle";
            lvDetalle.Size = new Size(732, 205);
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
            ClientSize = new Size(816, 515);
            Controls.Add(lblTotalNeto);
            Controls.Add(label8);
            Controls.Add(lvDetalle);
            Controls.Add(groupBox2);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "FrmPanelVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de Ventas";
            Load += FrmPanelVentas_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private Label lblFecha;
        private Label lblHora;
        private GroupBox groupBox2;
        private Label label6;
        private ListView lvDetalle;
        private Label lblTotalNeto;
        private Label label8;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialButton btnRegistrar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialComboBox cmbProducto;
        private MaterialSkin.Controls.MaterialLabel lblPrecio;
        private MaterialSkin.Controls.MaterialTextBox2 txtCantidad;
        private MaterialSkin.Controls.MaterialTextBox2 txtDatosClientes;
    }
}
