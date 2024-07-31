using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManagement.Data.DL;
using TimeManagement.Data.DTOs;

namespace TimeManagement.Data.BL
{
	public class ProcessEventBL
	{
		//public ProcessEventDL ProcessEventDL => _ProcessEventDL ??= new ProcessEventDL();
		//private ProcessEventDL _ProcessEventDL;

		public List<ProcessEventDTO> ProcessEventReport(ProcessEventReportFilterDTO filter)
		{
			//return _ProcessEventDL.ProcessEventReport(filter);
			return null;
		}

		public int ProcessEventSet(EventDTO dto)
		{
			if (dto != null)
				return 1;
			else
				return -1;
				
		}

		public bool CompleteEvent(int eventId)
		{
			if (eventId > 0)
			{
				var procEvent = ProcessEventReport(new ProcessEventReportFilterDTO
				{
					EventId = eventId,
				}).FirstOrDefault();

				if (procEvent != null)
				{
					procEvent.IsComplete = true;
					
				}
			}
			return true;
		}
	}
}
