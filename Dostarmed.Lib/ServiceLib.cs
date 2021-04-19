using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dostarmed.Lib
{
    public class ServiceLib
    {
        public List<Organisation> organisations { get; set; }

        //возвращает мед организации
        public List<Organisation> GetOrganisations()
        {
            organisations = new List<Organisation>();
            for (int i = 0; i < 5; i++)
            {
                organisations.Add(GetOrganisation());
            }

            return organisations;
        }

        public void AttachPatient(int OrgId, Patient patient)
        {
            // нужно найти оргнизацию в списке
            // обногвить список пационтов в данной организации
            foreach (Organisation org in organisations)
            {
                if(org.Id == OrgId)
                {
                    org.patients.Add(patient);
                }
            }           
        }

        private Organisation GetOrganisation()
        {
            Random rnd = new Random();
            Organisation company = new Organisation();
            company.Id = rnd.Next();
            company.Name = "Organistion #" + rnd.Next(1, 100);
            return company;
        }
    }
}
