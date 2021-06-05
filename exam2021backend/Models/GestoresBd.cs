using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace exam2021backend.Models
{
    public class GestoresBd
    {	
		[Key]
        public int usuarioId { get; set; }
		public string username { get; set; }
		public string password { get; set; }
		public string nombre { get; set; }
		public string direccion { get; set; }
		public int telefono { get; set; }
		public int codigoPostal { get; set; }
		public string tipoUsuario { get; set; }
		public int EdoMunId { get; set; }
	}
}
