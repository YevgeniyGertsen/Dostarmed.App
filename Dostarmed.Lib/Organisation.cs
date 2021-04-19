using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dostarmed.Lib
{
    public class Organisation
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Patient> patients = new List<Patient>();
    }
}
