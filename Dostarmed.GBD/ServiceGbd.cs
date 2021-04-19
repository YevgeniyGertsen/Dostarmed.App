using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using Dostarmed.Lib;


namespace Dostarmed.GBD
{
    public class ServiceGbd
    {
        RestClient client = new RestClient("https://randomuser.me/");
        RestRequest request = new RestRequest("api/?nat=us&randomapi");

        private bool GetData(out string result)
        {
            result = "";
            try
            {
                IRestResponse response = client.Get(request);

                if (response.IsSuccessful)
                {
                    result = response.Content;

                    if (!string.IsNullOrWhiteSpace(result))
                        return true;
                    else
                        return false;
                }
                else
                {
                    result = "";
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Patient GetPatientByIin(string Iin)
        {
            Patient patient = null;

            string result = "";
            if (GetData(out result))
            {
                var data = JsonConvert.DeserializeObject<data>(result);
                patient = (Patient)data;
                patient.Iin = Iin;
            }

            return patient;
        }
    }


    public class data
    {
        public List<results> results { get; set; }

        public static explicit operator Patient(data dat)
        {
            Patient patient = new Patient();
            patient.FirstName = dat.results[0].name.first;
            patient.LastName = dat.results[0].name.last;
            patient.Dob = dat.results[0].dob.date;

            return patient;
        }
    }

    public class results
    {
        public string gender { get; set; }
        public name name { get; set; }
        public dob dob { get; set; }
    }
    public class name
    {
        public string first { get; set; }
        public string last { get; set; }
    }
    public class dob
    {
        public DateTime date { get; set; }
    }
}
