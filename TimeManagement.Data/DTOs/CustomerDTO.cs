using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagement.Data.DTOs
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerFullName => CustomerFirstName + " " + CustomerLastName;
		public string MobileNumber { get; set; }
        public string TelNumber { get; set; }
        public string Address { get; set; }
    }
}
