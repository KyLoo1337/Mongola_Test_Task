using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongola_Test_Task
{
    /// <summary>
    /// Name (singleton). Sets one time and doesn't change anymore.
    /// </summary>
    class Name
    {
        // Instance of our name (singleton pattern).
        private static Name instance;
        // Our name.
        public string name { get; private set; }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name"> Name to set. </param>
        public Name(string name)
        {
            this.name = name;
        }
        
        /// <summary>
        /// Try to change name. If name haven't been set, set name, else nothing change.
        /// </summary>
        /// <param name="name"> Name, which we want to set.</param>
        /// <returns> Name final name.</returns>
        public static Name getInstance(string name)
        {
            if (instance == null)
                instance = new Name(name);
            return instance;
        }

        /// <summary>
        /// Override ToString for correct System.WriteLine working.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return name;
        }
    }
}
