using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagement.Data.DTOs
{
	public class ProcessEventReportFilterDTO
	{
		public int EventId { get; set; }
		public string EventTitle { get; set; }
		public string EventComment { get; set; }
		public DateTime FromCallTime { get; set; }
		public DateTime ToCallTime { get; set; }
	}
}
