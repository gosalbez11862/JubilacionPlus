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
        Trabajador PrimerTrabajador = new Trabajador();

        private void BCrear_Click(object sender, EventArgs e)
        {
            PrimerTrabajador.Nombre = TName.Text;
            PrimerTrabajador.Edad = int.Parse(TupDownEdad.Text);
        }

        private void BJubilacion_Click(object sender, EventArgs e)
        {
            string DatosTrabajador = FNombreEdadJubliacion(PrimerTrabajador.Nombre, PrimerTrabajador.Edad, PrimerTrabajador.CalculoAnyosJubilacion());
        }

        string FNombreEdadJubliacion(string nombre, int edad, int jubilacion)
        {
            string DatosTrabajador ="";

            DatosTrabajador += "Nombre: " + nombre + "\n\n";
            DatosTrabajador += "Edad: " + edad + "\n\n";
            DatosTrabajador += "Años para jubilarse: " + jubilacion + "\n\n";

            return DatosTrabajador;
        }
    }
}
