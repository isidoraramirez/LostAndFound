﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound
{
    abstract class Usuario
    {
        string rut;
        char contrasenia;
        string nombre_usuario;
        float calificacion;
        string mail;

        Usuario(string rut, char contrasenia, string nombre_usuario, float calificacion, string mail)
        {
            this.rut = rut;
            this.contrasenia = contrasenia;
            this.nombre_usuario = nombre_usuario;
            this.calificacion = calificacion;
            this.mail = mail;
            List<float> lista_calificacion = new List<float>();
        }
        public abstract void Registrarse()
        {

        }
    }
}
