using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dostarmed.Lib
{
    public class AttachRequests
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DateOfProcessing { get; set; }
        public Patient Patient { get; set; }
        public string Status { get; set; }
    }
}
