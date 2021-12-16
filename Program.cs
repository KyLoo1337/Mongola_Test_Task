using System;
using System.Collections.Generic;

namespace Mongola_Test_Task
{
    class Program
    {
        /// <summary>
        /// Main program
        /// </summary>
        static void Main(string[] args)
        {
            // Create company.
            Company trader = new Company("OOO Traders");
            // Show company name.
            Console.WriteLine(trader.ShowName());
            // Try to change name of company.
            trader.ChangeName(Name.getInstance("OOO New Traders"));
            // Show result of trying.
            Console.WriteLine(trader.ShowName());
            // Create list of workers.
            List<string> workers = new List<string> { "Pavel", "Fedor" };
            // Create Sale Departament.
            SalesDepartment SD = new SalesDepartment(workers);
            // Add departament to company.
            trader.AddDepartament(SD);
            // Show workers of departament.
            var workersList = SD.GetWorkers();
            foreach (var name in workersList){
                Console.Write($"{name} ");
            }
            Console.WriteLine();
            // Add new worker.
            SD.AddWorker("Anna");
            // Show list of workers from company instance.
            workersList = trader.departaments[0].GetWorkers();
            foreach (var name in workersList)
            {
                Console.Write($"{name} ");
            }
            Console.WriteLine();
            // Show task of departament
            DepartamentTask DTSD = trader.departaments[0].ShowTask();
            // Create Warehouse departament.
            Warehouse Wh = new Warehouse(workers);
            // Add departament to company.
            trader.AddDepartament(Wh);
            // Show task of departament.
            DepartamentTask DTW = trader.departaments[1].ShowTask();
        }
    }
}
