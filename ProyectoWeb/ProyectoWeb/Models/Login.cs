using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoWeb.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Tipo { get; set; }
    }
}