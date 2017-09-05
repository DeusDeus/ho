﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace policlinico__con_migracion.Models
{
   
    public class ActividadViewModel
    {
        public int IdActividad { get; set; }

        public string Descripcion { get; set; }

        public DateTime FechaInicial { get; set; }

        public int idtipexam { get; set; }

        public int IdEmpresa { get; set; }

        public string nombre { get; set; }

        public string NombreTipo { get; set; }

        public string Telefonos { get; set; }

        public string Emails { get; set; }

  
    }
}