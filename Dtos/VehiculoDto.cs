using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarroRecuperacionProgramacion.Dtos
{
    internal class VehiculoDto
    {
        //Atributos
        long idVehiculo;
        string matriculaVehiculo = "aaaaa";
        DateTime fchaMatriculacion = new DateTime(1999-31-12);

        //Constructores
        public VehiculoDto()
        {

        }

        //Getters y Setters
        public long IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string MatriculaVehiculo { get => matriculaVehiculo; set => matriculaVehiculo = value; }
        public DateTime FchaMatriculacion { get => fchaMatriculacion; set => fchaMatriculacion = value; }
    }
}
