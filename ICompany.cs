using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongola_Test_Task
{
    /// <summary>
    /// Interface for company.
    /// </summary>
    interface ICompany
    {
        public void AddDepartament(Departament departament);
        public void ChangeName(Name name);
        public Name ShowName();
    }
}
