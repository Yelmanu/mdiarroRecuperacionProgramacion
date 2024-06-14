using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarroRecuperacionProgramacion.Servicios
{
    /// <summary>
    /// Interfaz que se encargará del manejo de los ficheros
    /// 140624 - MDN
    /// </summary>
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Método para realizar la carga inicial de los datos del fichero
        /// 140624 - MDN
        /// </summary>
        public void cargaInicial();

        /// <summary>
        /// Método que se encarga de crear un log de fichero
        /// 140624 - MDN
        /// </summary>
        /// <param name="mensaje"></param>
        public void ficheroLog(string mensaje);
    }
}
