using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaNotas.Clases
{
    internal class Estudiante
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Laboratorio { get; set; }
        public decimal Parcial { get; set; }
        public decimal Asistencia { get; set; }
        public decimal NotaFinal { get; set; }

        public void CalcularNotaFinal()
        {
            NotaFinal = (Laboratorio * 0.5m) + (Parcial * 0.4m) + (Asistencia * 0.1m);
        }
    }
}
