using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagement.Data.DTOs
{
    public class ProcessDTO
    {
        public int ProcessId { get; set; }
        public string ProcessTitle { get; set; }
        public string Comment { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerFullName => CustomerFirstName + " " + CustomerLastName;
        public int CustomerId { get; set; }

    }
}
