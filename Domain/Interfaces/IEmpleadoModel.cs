using pratica.Entities.Empleados;
using System;
using System.Collections.Generic;
using System.Text;

namespace pratica.Interfaces
{
    public interface IEmpleadoModel : IModel<Empleado>
    {
        Empleado FindById(int id);
        int GetLastEmpleadoId();

    }
}
