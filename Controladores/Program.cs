using mdiarroRecuperacionProgramacion.Dtos;
using mdiarroRecuperacionProgramacion.Servicios;

namespace mdiarroRecuperacionProgramacion.Controladores
{
    class Program
    {
        public static List<VehiculoDto> listavehiculos = new List<VehiculoDto>();
        public static List<PropietarioDto> listaPropietarios = new List<PropietarioDto>();
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();

            int opcionSeleccionada;
            bool cerrarMenu = false;
            do
            {
                opcionSeleccionada = mi.mostrarMenuPrincipal();
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] Se cerrará la app.");
                        //fi.ficheroLog("Se cerró la app.");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] Selecccionó la opción número de históricos.");
                        //fi.ficheroLog("Selecccionó la opción número de históricos.");
                        break;
                    case 2:
                        Console.WriteLine("[INFO] Seleccionó la opción nueva alta propietario.");
                        oi.altaNuevoPropietario(listaPropietarios);
                        foreach (PropietarioDto propietario in listaPropietarios)
                        {
                            Console.WriteLine(propietario.ToString());
                        }
                        //fi.ficheroLog("Seleccionó la opción nueva alta propietario.");
                        break;
                    default:
                        Console.WriteLine("[INFO] La opción seleccionada no existe.");
                        //fi.ficheroLog("La opción que seleccionó no existe.");
                        break;
                }
            }while (!cerrarMenu);
        }
    }
}