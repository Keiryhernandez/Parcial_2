using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaNotas.Repositorios;

namespace SistemaNotas.UoW
{
    internal class Uow
    {
        public EstudianteRepositorio Estudiantes { get; private set; }

        public Uow()
        {
            Estudiantes = new EstudianteRepositorio();
        }
    }
}
