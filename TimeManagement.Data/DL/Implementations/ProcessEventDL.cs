using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManagement.Data.DTOs;

namespace TimeManagement.Data.DL
{
	public class ProcessEventDL : SqlHelper
	{
		public ProcessEventDL(string server, string password) : base(server, password)
		{
		}

		public int ProcessEventSet(EventDTO dto)
		{
			List<ParameterDTO> parameters = new List<ParameterDTO>()
			{
				new ParameterDTO()
				{

				}
			};

			if (dto != null)
			{
				return ExecuteNonQuery("spEventSet", parameters);
			}

			return -1;
		}
		public List<ProcessEventDTO> ProcessEventReport(ProcessEventReportFilterDTO filter)
		{
			List<ParameterDTO> parameters = new List<ParameterDTO>()
			{
				new ParameterDTO
				{
					Key = "@eventId",
					Value = Convert.ToInt32(filter.EventId),
					Type = System.Data.SqlDbType.Int,
				},
				new ParameterDTO
				{
					Key = "@eventTitle",
					Value = filter.EventTitle,
					Type = System.Data.SqlDbType.NVarChar
				},
				new ParameterDTO
				{
					Key = "@comment",
					Value = filter.EventComment,
					Type = System.Data.SqlDbType.NVarChar
				},
				new ParameterDTO
				{
					Key = "@toCallTime",
					Value = filter.ToCallTime,
					Type = System.Data.SqlDbType.DateTime
				},
				new ParameterDTO
				{
					Key = "@fromCallTime",
					Value = filter.FromCallTime,
					Type = System.Data.SqlDbType.DateTime
				}
			};

			var result = ExecuteSP("spProcessEventReport", parameters);
			return Map(result);
		}

		private List<ProcessEventDTO> Map(DataTable table)
		{
			var lstDTO = new List<ProcessEventDTO>();

			foreach (DataRow row in table.Rows)
			{
				lstDTO.Add(new ProcessEventDTO
				{
					ProcessEventId = Convert.ToInt32(row["EventId"]),
					ProcessEventTitle = row["EventTitle"]?.ToString() ?? "",
					EventComment = row["Comment"]?.ToString() ?? "",
					CreateDate = Convert.ToDateTime(row["CreateDate"]),
					CallTime = Convert.ToDateTime(row["CallTime"]),
					IsRepeat = Convert.ToBoolean(row["IsRepeat"]),
					Interval = Convert.ToInt32(row["Interval"]),
					IsComplete = Convert.ToBoolean(row["IsComplete"]),
					PriorityId = Convert.ToInt32(row["PriorityId"]),
					StatusId = Convert.ToInt32(row["StatusId"]),
					ProcId = Convert.ToInt32(row["ProcessId"]),
					ParentEventId = Convert.ToInt32(row["ParentEventId"]),
					StatusTitle = row["StatusTitle"]?.ToString() ?? "",
					PriorityTitle = row["PriorityTitle"]?.ToString() ?? "",
					ProcTitle = row["ProcessTitle"]?.ToString() ?? "",
				});
			}

			return lstDTO;
		}
	}
}
