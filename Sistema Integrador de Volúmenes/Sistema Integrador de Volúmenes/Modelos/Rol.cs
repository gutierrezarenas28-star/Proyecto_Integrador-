using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Integrador_de_Volúmenes.Modelos
{
    internal class Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Rol(string nombre)
        {
            Nombre = nombre;
        }
    }
}
