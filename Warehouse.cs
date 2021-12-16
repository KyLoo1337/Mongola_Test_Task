using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongola_Test_Task
{
    /// <summary>
    /// Warehouse Departament.
    /// </summary>
    class Warehouse : Departament
    {
        public Warehouse(List<string> namesOfWorkers) : base(namesOfWorkers) { }

        public override DepartamentTask ShowTask()
        {
            return new FindPlaceTask();
        }
    }
}
