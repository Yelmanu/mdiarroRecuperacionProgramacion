using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarroRecuperacionProgramacion.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuPrincipal()
        {
            int opcion;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("0.- Cerrar App");
            Console.WriteLine("1.- Número de históricos");
            Console.WriteLine("2.- Alta nuevo propietario");
            Console.WriteLine("-----------------------------");

            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
