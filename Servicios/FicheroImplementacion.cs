using mdiarroRecuperacionProgramacion.Controladores;
using mdiarroRecuperacionProgramacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarroRecuperacionProgramacion.Servicios
{
    internal class FicheroImplementacion : FicheroInterfaz
    {
        /// <summary>
        /// Método para el fichero log 
        /// 140624 - MDN
        /// </summary>
        /// <param name="mensaje"></param>
        public void ficheroLog(string mensaje)
        {
            try
            {
                DateTime fchaHoy = DateTime.Today;
                string ruta = $"C:\\Users\\csi22-mdiarro\\Desktop\\Programacion\\mdiarroRecuperacionProgramacion\\Logs\\log--{fchaHoy.ToString("dd-MM-yyyy")}.txt";
                StreamWriter sr = new StreamWriter(ruta, true);
                sr.WriteLine(mensaje);
                sr.Close();
            }catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al escribir el log");
            }

        }
        /// <summary>
        /// Método para realizar la carga de datos inicial
        /// 140624 - MDN
        /// </summary>
        public void cargaInicial()
        {
            try { 
            string ruta = $"C:\\Users\\csi22-mdiarro\\Desktop\\Ficheros\\datosIniciales.txt";
            string[] fichero = File.ReadAllLines(ruta);
            long id = 0;
                foreach (string s in fichero)
                {
                PropietarioDto propietario = new PropietarioDto();
                string[] campos = s.Split(':');
                propietario.Matricula = campos[0];
                propietario.DniPropietario = campos[2];
                propietario.FchaCompra = Convert.ToDateTime(campos[3]);
                Program.listaPropietarios.Add(propietario);
                }
                foreach (string s in fichero)
                {
                    VehiculoDto vehiculo = new VehiculoDto();
                    string[] campos = s.Split(':');
                    vehiculo.MatriculaVehiculo = campos[0];
                    vehiculo.FchaMatriculacion = Convert.ToDateTime(campos[1]);
                    Program.listavehiculos.Add(vehiculo);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No hay datos anteriores");
                ficheroLog("No hay datos anteriores");
                ficheroLog($"Error:{e}");
            }
        }
    }
}
