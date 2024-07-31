using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManagement.Data.DL;
using TimeManagement.Data.DTOs;

namespace TimeManagement.Data.BL
{
	public class StuffBL
	{
		private StuffDL _StuffDL;
		public StuffBL(StuffDL stuffDL)
		{
			_StuffDL = stuffDL;
		}

		public List<StuffDTO> ReportStuffes(string title)
		{
			return _StuffDL.StuffReport(title);
		}

		public int SetStuff(StuffDTO stuff)
		{
			return _StuffDL.StuffSet(stuff);
		}
	}
}
