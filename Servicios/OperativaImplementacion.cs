using mdiarroRecuperacionProgramacion.Controladores;
using mdiarroRecuperacionProgramacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarroRecuperacionProgramacion.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void altaNuevoPropietario(List<PropietarioDto> listaAntigua)
        {
            PropietarioDto nuevoPropietario = new PropietarioDto();
            long idPropietario = 1;
            string dniPropietario;
            do
            {
                Console.WriteLine("Introduzca su DNI completo: ");
                dniPropietario = Console.ReadLine();
            } while (dniPropietario.Length < 9);
            listaAntigua.Add(nuevoPropietario);

        }
       /* private long crearId(List<PropietarioDto> listaAntigua)
        {
            long nuevoId;
            listaAntigua = Program.listaPropietarios;
            long antiguoID = listaAntigua.Count;
            if (antiguoID> 0)
            {
                nuevoId = antiguoID + 1;
            }
            return nuevoId;
        }*/
    }
}
