
namespace Trabajador
{
    /// <summary>
    /// <para>Clase que representa a un trabajador de una empresa.</para>
    /// <para>Los trabajadores pueden ser de las siguiente secciones:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Crear</description>
    ///     </item>
    ///     <item>
    ///         <description>Jubilacion</description>
    ///     </item>
    /// </list>
    /// </para>
    /// </summary>
    public class Trabajador
    {
        /// <summary>
        /// Edad por defecto de jubilación del trabajador
        /// </summary>
        private const int EdadJubilacionDefecto = 67;

        /// <summary>
        /// Nombre y apellidos del trabajador
        /// </summary>
        private string nombre;

        /// <summary>
        /// Apellidos del trabajador
        /// </summary>
        private string apellido;

        /// <summary>
        /// Edad del trabajador
        /// </summary>
        private int edad;

        /// <summary>
        /// Obtiene y devuelve el nombre del trabajador
        /// </summary>
        /// <value>El nombre </value>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Obtiene y devuelve el apellidos del trabajador
        /// </summary>
        /// <value>El apellidos</value>
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        /// <summary>
        /// Obtiene y devuelve la edad del trabajador.
        /// La edad debe estar entre 1 y 150
        /// </summary>
        /// <value>Edad del trabajador</value>
        public int Edad
        {
            get { return edad; }
            set 
            {
                if (value >= 1 && value <= 150)
                    edad = value;
            }
        }

        /// <summary>
        /// Calcula los años que le quedan al trabajador para su jubilación
        /// </summary>
        /// <remarks>Este método usa sobrecarga</remarks>
        /// <returns>Los años que le quedan al trabajador para su jubilación</returns>
        public int CalculoAnyosJubilacion()
        {
            return EdadJubilacionDefecto - edad;
        }
        /// <summary>
        /// <para>Calcula los años que le quedan al trabajador para su jubilación. </para>
        /// <para>El valor del parámetro <paramref name="edadJubilacion"/> debe ser menor que <see cref="EdadJubilacionDefecto"/> y mayor o
        /// igual que la edad del trabajador</para>
        /// </summary>
        /// <remarks>Este método usa sobrecarga</remarks>
        /// <param name="edadJubilacion">Edad personalizada de jubilación, distinta de la edad por defecto</param>
        /// <returns>Los años que le quedan al trabajador para su jubilación</returns>
        public int CalculoAnyosJubilacion(int edadJubilacion)
        {
            if (edadJubilacion < EdadJubilacionDefecto && edadJubilacion >= edad)
                return edadJubilacion - edad;
            else
                return EdadJubilacionDefecto - edad;
        }

    }
}
