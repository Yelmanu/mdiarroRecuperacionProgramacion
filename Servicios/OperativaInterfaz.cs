using mdiarroRecuperacionProgramacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarroRecuperacionProgramacion.Servicios
{
    internal interface OperativaInterfaz
    {
        public void altaNuevoPropietario(List<PropietarioDto> listaAntigua);
    }
}
