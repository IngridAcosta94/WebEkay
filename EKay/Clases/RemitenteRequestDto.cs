using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ekay.Clases
{
	public class RemitenteRequestDto
	{
		[Required(ErrorMessage = "Proporcione un nombre.")]
		public string NombreR { get; set; }
		[Required(ErrorMessage = "Proporcione un apellido.")]
		public string ApellidoR { get; set; }
		[Required(ErrorMessage = "Proporcione un correo electronico.")]
		public string CorreoR { get; set; }
		







	}
}
