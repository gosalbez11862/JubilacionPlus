using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajador;


namespace Trabajador
{
    public partial class Trabajador : Form
    {
        public Trabajador()
        {
            InitializeComponent();
        }
        Trabajador_Jubilacion PrimerTrabajador = new Trabajador_Jubilacion();

        private void BCrear_Click(object sender, EventArgs e)
        {
            PrimerTrabajador.Nombre = TNombre.Text;
            PrimerTrabajador.Apellido = TApellido.Text;
            PrimerTrabajador.Edad = int.Parse(TupDownEdad.Text);
        }

        private void BJubilacion_Click(object sender, EventArgs e)
        {
            string DatosTrabajador = FNombreEdadJubilacion(PrimerTrabajador.Nombre, PrimerTrabajador.Apellido, PrimerTrabajador.Edad, PrimerTrabajador.CalculoAnyosJubilacion());
            MessageBox.Show(DatosTrabajador);
        }

        string FNombreEdadJubilacion(string nombre, string apellido, int edad, int jubilacion)
        {
            string DatosTrabajador ="";

            DatosTrabajador += "Nombre: " + nombre + "\n\n";
            DatosTrabajador += "Apellidos: " + apellido + "\n\n";
            DatosTrabajador += "Edad: " + edad + "\n\n";
            DatosTrabajador += "Años para jubilarse: " + jubilacion + "\n\n";

            return DatosTrabajador;
        }
    }
}
