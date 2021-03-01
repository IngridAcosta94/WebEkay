using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ekay.Clases
{
	public class AutorRequestDto
	{
		[Required(ErrorMessage = "Proporcione un nombre.")]
		public string NombreA { get; set; }
		[Required(ErrorMessage = "Proporcione un apellido.")]
		public string ApellidoA { get; set; }
		[Required(ErrorMessage = "Proporcione un correo electronico.")]
		public string CorreoA { get; set; }
		public int EmpresaId { get; set; }
	}
}
