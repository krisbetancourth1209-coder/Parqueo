using ClassLibrary1;
using DataAccesss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace PARQUEO
{
    public partial class Form1 : Form
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        double totalRecaudado = 0;

        VehiculoDAL dal = new VehiculoDAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text == "" || txtMarca.Text == "" || txtModelo.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (dateSalida.Value < dateEntrada.Value)
            {
                MessageBox.Show("La hora de salida es incorrecta");
                return;
            }

            foreach (Vehiculo v in vehiculos)
            {
                if (v.Placa == txtPlaca.Text)
                {
                    MessageBox.Show("La placa ya existe");
                    return;
                }
            }

            Vehiculo vehiculo;

            if (cmbTipoVehiculo.Text == "Automovil")
            {
                vehiculo = new Automovil();
            }
            else if (cmbTipoVehiculo.Text == "Motocicleta")
            {
                vehiculo = new Motocicleta();
            }
            else
            {
                vehiculo = new Camion();
            }

            vehiculo.Placa = txtPlaca.Text;
            vehiculo.Marca = txtMarca.Text;
            vehiculo.Modelo = txtModelo.Text;
            vehiculo.HoraEntrada = dateEntrada.Value;
            vehiculo.HoraSalida = dateSalida.Value;

            dal.Insertar(vehiculo);

            MessageBox.Show("Guardado en la base de datos");

            double pago = Math.Round(Math.Abs((vehiculo.CalcularPago())), 2);
            totalRecaudado += pago;

            vehiculos.Add(vehiculo);

            dataListVehiculos.Rows.Add(
                vehiculo.Placa,
                vehiculo.Marca,
                vehiculo.Modelo,
                Math.Round(Math.Abs((vehiculo.CalcularHoras())), 2),
                Math.Round(Math.Abs((pago)), 2)
            );

            lblTotal.Text = "Total: " + Math.Round(Math.Abs((totalRecaudado)), 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
