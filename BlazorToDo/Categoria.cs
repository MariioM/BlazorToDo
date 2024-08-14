﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorToDo
{
        public class Categoria
        {
            public string Nombre { get; set; }
            public string Descripcion { get; set; }

            public Categoria(string nombre, string descripcion)
            {
                Nombre = nombre;
                Descripcion = descripcion;
            }

            public Categoria() { }
        }

}
