using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagement.Data.DTOs
{
	public class ProcessEventDTO
	{
		public int ProcessEventId { get; set; }
		public string ProcessEventTitle { get; set; }
		public string EventComment { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime CallTime { get; set; }
		public bool IsRepeat { get; set; }
		public int Interval { get; set; }
		public bool IsComplete { get; set; }
		public int PriorityId { get; set; }
		public int StatusId { get; set; }
		public int ProcId { get; set; }
		public int ParentEventId { get; set; }
		public string StatusTitle { get; set; }
		public string PriorityTitle { get; set; }
		public string ProcTitle { get; set; }
	}
}
