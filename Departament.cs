using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongola_Test_Task
{
    // Departament class. Factory Method pattern.
    abstract class Departament
    {
        // Names of workers, who serve in this departament.
        protected List<string> namesOfWorkers { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Departament(List<string> namesOfWorkers)
        {
            this.namesOfWorkers = namesOfWorkers;
        }

        /// <summary>
        /// Add worker to workers list.
        /// </summary>
        public void AddWorker(string name)
        {
            namesOfWorkers.Add(name);
        }

        /// <summary>
        /// Get workers list
        /// </summary>
        /// <returns></returns>
        public List<string> GetWorkers() => namesOfWorkers;

        /// <summary>
        /// Show task of Deparnament;
        /// </summary>
        /// <returns></returns>
        abstract public DepartamentTask ShowTask();

    }
}
