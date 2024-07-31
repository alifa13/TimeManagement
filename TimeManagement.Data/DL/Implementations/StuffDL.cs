using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManagement.Data.DTOs;

namespace TimeManagement.Data.DL
{
	public class StuffDL
	{
		private readonly SqlHelper _sqlHelper;

		public StuffDL(SqlHelper sqlHelper)
		{
			_sqlHelper = sqlHelper;
		}

		public int StuffSet(StuffDTO dto)
		{
			List<ParameterDTO> parameters = new List<ParameterDTO>()
			{
				new ParameterDTO()
				{
					Key = "@id",
					Value = dto.StuffId,
					Type = System.Data.SqlDbType.Int,
				},
				new ParameterDTO()
				{
					Key = "@title",
					Value = dto.Title,
					Type = System.Data.SqlDbType.NVarChar
				}

			};

			var result = _sqlHelper.ExecuteNonQuery("spStuffSet", parameters);

			return result;
		}

		public List<StuffDTO> StuffReport(string title)
		{
			ParameterDTO parameter = new ParameterDTO()
			{
				Key = "@title",
				Value = title,
				Type = System.Data.SqlDbType.NVarChar
			};

			var result = _sqlHelper.ExecuteSP("spStuffReport", new List<ParameterDTO> { parameter });
			return Map(result);
		}

		private List<StuffDTO> Map(DataTable table)
		{
			List<StuffDTO> stuffes = new List<StuffDTO>();

			foreach (DataRow row in table.Rows)
			{
				stuffes.Add(new StuffDTO
				{
					StuffId = Convert.ToInt32(row["StuffId"]),
					Title = row["StuffTitle"]?.ToString() ?? ""
				});

			}

			return stuffes;
		}
	}
}
