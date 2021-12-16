using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongola_Test_Task
{
    /// <summary>
    /// Company class.
    /// </summary>
    class Company : ICompany
    {
        // Name of company.
        private Name name { get; set; }
        // Departaments of company.
        public List<Departament> departaments { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"> Name of company. </param>
        public Company(string name)
        {
            this.name = Name.getInstance(name);
            departaments = new List<Departament>();
        }

        /// <summary>
        /// Add new departament to company.
        /// </summary>
        /// <param name="departament"> Departament, which we add. </param>
        public void AddDepartament(Departament departament)
        {
            departaments.Add(departament);
        }

        /// <summary>
        /// Try to change name.
        /// </summary>
        /// <param name="name"> New name. </param>
        public void ChangeName(Name name)
        {
            this.name = name;
        }

        /// <summary>
        /// Get name of company.
        /// </summary>
        /// <returns> Name of company. </returns>
        public Name ShowName() =>  name;
    }
}
