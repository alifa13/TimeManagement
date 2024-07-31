using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManagement.Data.DL;
using TimeManagement.Data.DTOs;

namespace TimeManagement.Data.BL
{
	public class ProcessBL
	{
		private ProcessDL _processDL;

		public ProcessBL(ProcessDL processDL)
		{
			_processDL = processDL;
		}

		public List<ProcessDTO> ReportProcesses(ProcessReportFilterDTO filter)
		{
			return _processDL.ProcessReport(filter);
		}

		public int SetProcess(ProcessDTO dto)
		{
			return _processDL.SetProcess(dto);
		}
	}
}
