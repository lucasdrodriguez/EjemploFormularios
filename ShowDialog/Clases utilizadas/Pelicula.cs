using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowDialog
{
    public class Pelicula
    {

        string nombre;
        int año;
        string personajePrincipal;

        public Pelicula(string nomb, int año, string personaje)
        {
            this.nombre = nomb;
            this.año = año;
            this.personajePrincipal = personaje;
        }

        public string PersonajePrincipal
        {
            get { return personajePrincipal; }
            set { personajePrincipal = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Año
        {
            get { return año; }
            set { año = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El nombre de la pelicula es: {this.nombre}");
            sb.AppendLine($"El año de la pelicula es: {this.año}");
            sb.AppendLine($"El personaje principal de la pelicula es: {this.personajePrincipal}");

            return sb.ToString();
        }

    }
}
