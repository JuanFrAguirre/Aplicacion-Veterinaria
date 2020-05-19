using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialProgHernan
{
    public partial class frmVeterinaria : Form
    {
        public frmVeterinaria()
        {
            InitializeComponent();
        }

        // variables globales
        int cantPerros = 0;
        int cantGatos = 0;
        int cantAves = 0;
        double totalVentas = 0;
        double ventasHembras = 0;
        int cantHembras = 0;

        //---------------------------------------------------
        // metodo cuando hace clic en Registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // instanciando la clase Mascota
            Mascota snoopy = new Mascota(txtNombre.Text, rdoMacho.Checked,
                cboTipo.SelectedIndex + 1, double.Parse(txtPrecio.Text));


            // definiendo el tipo
            switch (snoopy.Tipo)
            {
                case 1: cantPerros++; break;
                case 2: cantGatos++; break;
                default: cantAves++; break;
            }

            // acumulador ventas
            totalVentas += snoopy.Precio;


            //promedio ventas hembras
            if (!snoopy.Sexo)
            {                 
                ventasHembras += snoopy.Precio;
                cantHembras++;
            }

            // asignando los labels
            lblPerros.Text = cantPerros.ToString();
            lblGatos.Text = cantGatos.ToString();
            lblAves.Text = cantAves.ToString();
            lblTotalVentas.Text = totalVentas.ToString();
            lblPromedioHembras.Text = (ventasHembras / cantHembras).ToString();

            // mostrando el mensaje de los datos
            MessageBox.Show(snoopy.MostrarDatos());


        }
    }
}
