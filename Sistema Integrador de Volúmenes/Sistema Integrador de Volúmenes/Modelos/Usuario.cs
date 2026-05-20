using Sistema_Integrador_de_Volúmenes.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Integrador_de_Volúmenes.Models
{
    internal class Usuario : Persona
    {
        public string Contraseña { get; set; }
        public bool IsActivo { get; set; }
        public Rol Rol { get; set; }

        public Usuario() { }

    }   
}
