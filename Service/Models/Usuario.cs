using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Apellido { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Enums.TipoUsuarioEnum TipoUsuario { get; set; } = Enums.TipoUsuarioEnum.Asistente;
        public DateTime DeleteDate { get; set; } = DateTime.MinValue;
        public bool IsDeleted {get; set;} = false;

        public override string ToString()
        {
            return $"{ Apellido} { Nombre}";
        }
    }
}
