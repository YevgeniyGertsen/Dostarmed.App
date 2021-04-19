using Dostarmed.GBD;
using Dostarmed.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dostarmed.App
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceGbd db = new ServiceGbd();
            ServiceLib lib = new ServiceLib();


            List<Organisation> test1 = lib.GetOrganisations();

            foreach (Organisation item in test1)
            {
                Console.WriteLine(item.Id + " | " + item.Name);
            }

            string inputIin = Console.ReadLine();
            
            Patient patient = db.GetPatientByIin(inputIin);

            Console.WriteLine(patient.FirstName+" "+patient.LastName);
            Console.WriteLine(patient.Dob);
            int InputUserIdOrg = int.Parse(Console.ReadLine());
            lib.AttachPatient(InputUserIdOrg, patient);
            foreach (Organisation item in test1)
            {
                Console.WriteLine(item.Id + " | " + item.Name);
                foreach (Patient pat in item.patients)
                {
                    Console.WriteLine(pat.FirstName + " "+pat.LastName);
                    Console.WriteLine(pat.Dob);
                }
            }
        }
    }
}
