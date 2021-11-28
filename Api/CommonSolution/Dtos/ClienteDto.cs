using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.Dtos
{
    public class ClienteDto
    {
        public string Documento { get; set; }
        public string Telefono { get; set; }
        public int Tipo_documento { get; set; }
        public string Localidad { get; set; }
        public string Calle { get; set; }
        public string Detalle_direccion { get; set; }
        public string Email { get; set; }
        public int id_condado { get; set; }

        public EmpresaDto Empresa { get; set; }
        public PersonaDto Persona { get; set; }
    }
}
