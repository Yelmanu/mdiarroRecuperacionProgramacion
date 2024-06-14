using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarroRecuperacionProgramacion.Dtos
{
    internal class PropietarioDto
    {
        long idPropietario;
        string dniPropietario = "aaaaa";
        string matricula = "aaaaa";
        DateTime fchaCompra;
        bool esHistorico = false;

        //Constructores
        public PropietarioDto() { }

        public PropietarioDto(long idPropietario, string dniPropietario, string matricula, DateTime fchaCompra, bool esHistorico)
        {
            this.idPropietario = idPropietario;
            this.dniPropietario = dniPropietario;
            this.matricula = matricula;
            this.fchaCompra = fchaCompra;
            this.esHistorico = esHistorico;
        }

        //Getters y Setters
        public long IdPropietario { get => idPropietario; set => idPropietario = value; }
        public string DniPropietario { get => dniPropietario; set => dniPropietario = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public DateTime FchaCompra { get => fchaCompra; set => fchaCompra = value; }
        public bool EsHistorico { get => esHistorico; set => esHistorico = value; }

        //ToString
        override
        public string ToString()
        {
            string mensaje = "Nuevo propietario: " + this.idPropietario + " - " + this.dniPropietario;
            return mensaje;
        }
    }
}
