using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongola_Test_Task
{
    /// <summary>
    /// Sales Departament.
    /// </summary>
    class SalesDepartment : Departament
    {
        public SalesDepartment(List<string> namesOfWorkers) : base(namesOfWorkers) { }

        public override DepartamentTask ShowTask()
        {
            return new FindPersonalTask();
        }
    }
}
