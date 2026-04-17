namespace PARQUEO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.dateEntrada = new System.Windows.Forms.DateTimePicker();
            this.dateSalida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataListVehiculos = new System.Windows.Forms.DataGridView();
            this.PlacaVehículo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaVehículo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloVehículo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasVehículo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagoVehículo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Items.AddRange(new object[] {
            "Automóvil",
            "Motocicleta",
            "Camión"});
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(37, 45);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(200, 21);
            this.cmbTipoVehiculo.TabIndex = 0;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(37, 106);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(200, 20);
            this.txtPlaca.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(37, 171);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(200, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(37, 237);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(200, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // dateEntrada
            // 
            this.dateEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateEntrada.Location = new System.Drawing.Point(37, 302);
            this.dateEntrada.Name = "dateEntrada";
            this.dateEntrada.ShowUpDown = true;
            this.dateEntrada.Size = new System.Drawing.Size(200, 20);
            this.dateEntrada.TabIndex = 4;
            // 
            // dateSalida
            // 
            this.dateSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateSalida.Location = new System.Drawing.Point(37, 368);
            this.dateSalida.Name = "dateSalida";
            this.dateSalida.ShowUpDown = true;
            this.dateSalida.Size = new System.Drawing.Size(200, 20);
            this.dateSalida.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese el tipo de vehículo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese la placa del vehículo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese la marca del vehículo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingrese el modelo del vehículo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hora de entrada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hora de salida:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(310, 335);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 53);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataListVehiculos
            // 
            this.dataListVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlacaVehículo,
            this.MarcaVehículo,
            this.ModeloVehículo,
            this.HorasVehículo,
            this.PagoVehículo});
            this.dataListVehiculos.Location = new System.Drawing.Point(259, 45);
            this.dataListVehiculos.Name = "dataListVehiculos";
            this.dataListVehiculos.Size = new System.Drawing.Size(529, 270);
            this.dataListVehiculos.TabIndex = 13;
            // 
            // PlacaVehículo
            // 
            this.PlacaVehículo.HeaderText = "PlacaVehículo";
            this.PlacaVehículo.Name = "PlacaVehículo";
            // 
            // MarcaVehículo
            // 
            this.MarcaVehículo.HeaderText = "MarcaVehículo";
            this.MarcaVehículo.Name = "MarcaVehículo";
            // 
            // ModeloVehículo
            // 
            this.ModeloVehículo.HeaderText = "ModeloVehículo";
            this.ModeloVehículo.Name = "ModeloVehículo";
            // 
            // HorasVehículo
            // 
            this.HorasVehículo.HeaderText = "HorasVehículo";
            this.HorasVehículo.Name = "HorasVehículo";
            // 
            // PagoVehículo
            // 
            this.PagoVehículo.HeaderText = "PagoVehículo";
            this.PagoVehículo.Name = "PagoVehículo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(656, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 14;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(520, 318);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataListVehiculos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateSalida);
            this.Controls.Add(this.dateEntrada);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.DateTimePicker dateEntrada;
        private System.Windows.Forms.DateTimePicker dateSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataListVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaVehículo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaVehículo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloVehículo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasVehículo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagoVehículo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
    }
}

