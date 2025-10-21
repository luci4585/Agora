using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ICapacitacionService : IGenericService<Capacitacion>
    {
        public Task<List<Capacitacion>?> GetCapacitacionesAbiertasAsync();
        public Task<List<Capacitacion>?> GetCapacitacionesFuturasAsync();
    }

}
