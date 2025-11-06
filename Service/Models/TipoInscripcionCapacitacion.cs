using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class TipoInscripcionCapacitacion
    {
        public int Id { get; set; }
        public int CapacitacionId { get; set; }
        public Capacitacion? Capacitacion { get; set; }
        public int TipoInscripcionId { get; set; }
        public TipoInscripcion? TipoInscripcion { get; set; }
        public decimal Costo { get; set; }
        public bool IsDeleted { get; set; } = false;
        [NotMapped]
        public string TipoInscripcionConImporte
        {
            get
            {
                return $"{TipoInscripcion?.Nombre} - Costo: {Costo}";
            }
        }

        public override string ToString()
        {
            return $"{TipoInscripcion?.Nombre} - Costo: {Costo}";
        }
    }
}
