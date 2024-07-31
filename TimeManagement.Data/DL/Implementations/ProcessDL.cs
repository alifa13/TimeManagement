using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManagement.Data.DTOs;

namespace TimeManagement.Data.DL
{
	public class ProcessDL
	{
		private SqlHelper _sqlHelper;

		public ProcessDL(SqlHelper sqlHelper)
		{
			_sqlHelper = sqlHelper;
		}

		public int SetProcess(ProcessDTO process)
		{
			List<ParameterDTO> parameters = new List<ParameterDTO>
			{
				new ParameterDTO
				{
					Key = "@title",
					Value = process.ProcessTitle,
					Type = System.Data.SqlDbType.NVarChar
				},
				new ParameterDTO
				{
					Key = "@comment",
					Value = process.Comment,
					Type = System.Data.SqlDbType.NVarChar
				},
				new ParameterDTO
				{
					Key = "@customerId",
					Value = process.CustomerId,
					Type = System.Data.SqlDbType.Int
				},
				new ParameterDTO
				{
					Key = "@id",
					Value = process.ProcessId,
					Type = System.Data.SqlDbType.Int
				}
			};

			return _sqlHelper.ExecuteNonQuery("spProcessSet", parameters);
		}

		public List<ProcessDTO> ProcessReport(ProcessReportFilterDTO filter)
		{
			List<ParameterDTO> parameters = new List<ParameterDTO>
			{
				new ParameterDTO
				{
					Key = "@customerName",
					Value = filter.CustomerName,
					Type = System.Data.SqlDbType.NVarChar
				},
				new ParameterDTO
				{
					Key = "@stuffTitle",
					Value = filter.StuffTitle,
					Type = System.Data.SqlDbType.NVarChar
				},
				new ParameterDTO
				{
					Key = "@comment",
					Value = filter.ProcessComment,
					Type = System.Data.SqlDbType.NVarChar
				},
				new ParameterDTO
				{
					Key = "@processTitle",
					Value = filter.ProcessTitle,
					Type = System.Data.SqlDbType.NVarChar
				}
			};

			var result = _sqlHelper.ExecuteSP("spProcessReport", parameters);
			return Map(result);
		}

		private List<ProcessDTO> Map(DataTable dataTable)
		{
			List<ProcessDTO> processDTOs = new List<ProcessDTO>();

			foreach (DataRow row in dataTable.Rows)
			{
				processDTOs.Add(new ProcessDTO
				{
					ProcessId = Convert.ToInt32(row["ProcessId"]),
					ProcessTitle = row["ProcessTitle"]?.ToString() ?? string.Empty,
					Comment = row["Comment"]?.ToString() ?? string.Empty,
					CustomerFirstName = row["CustomerName"]?.ToString() ?? string.Empty,
					CustomerLastName = row["CustomerFamily"]?.ToString() ?? string.Empty,
					CustomerId = Convert.ToInt32(row["CustomerId"])
				});
			}

			return processDTOs;
		}
	}
}
