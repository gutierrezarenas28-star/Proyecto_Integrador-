using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Integrador_de_Volúmenes.Models
{
    internal class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public long Telefono { get; set; }
        public string Direccion { get; set; }

        public Persona()
        {
        }

        public Persona(int id, string nombre, string correoElectronico, long telefono, string direccion)
        {
            Id = id;
            Nombre = nombre;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
            Direccion = direccion;
        }
        public override string ToString()
        {
            return $"{Id},{Nombre},{CorreoElectronico},{Telefono},{Direccion}";
        }
    }
}
