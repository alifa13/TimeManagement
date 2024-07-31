using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagement.Data.DTOs
{
	public class EventDTO
	{
		public int EventId { get; set; }
		public string Title { get; set; }
		public string Comment { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime CallTime { get; set; }
		public byte IsRepeat { get; set; }
		public int Interval { get; set; }
		public byte IsComplete { get; set; }
		public int PriorityId { get; set; }
		public int StatusId { get; set; }
		public int ProcessId { get; set; }
		public int ParentEventId { get; set; }
	}
}
