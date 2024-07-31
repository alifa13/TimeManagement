using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManagement.Data.DTOs;

namespace TimeManagement.Data
{
	public class SqlHelper
	{
		private string connectionString => $"Server ={_server};Database=TimeManagementDB;User Id = sa; Password={_password}";
		private readonly string _server;
		private readonly string _password;
		private SqlConnection connection;
		private SqlDataAdapter adapter;
		private SqlCommand command;
		private DataTable response;

		private void CreateConnection()
		{
			connection = new SqlConnection(connectionString);
			command = new SqlCommand();
			adapter = new SqlDataAdapter();
			command.Connection = connection;
		}

		public SqlHelper(string server, string password)
		{
			_server = server;
			_password = password;
		}

		internal DataTable ExecuteSP(string nameSP, List<ParameterDTO> parameters)
		{
			response = new DataTable();

			CreateConnection();
			connection.Open();
			var sqlParameters = CreateParameters(parameters);
			command.CommandText = nameSP;
			command.CommandType = CommandType.StoredProcedure;
			command.Parameters.AddRange(sqlParameters.ToArray());
			adapter.SelectCommand = command;
			adapter.Fill(response);
			connection.Close();
			return response;

		}
		internal int ExecuteNonQuery(string nameSP, List<ParameterDTO> parameters)
		{
			CreateConnection();
			connection.Open();
			var sqlParameters = CreateParameters(parameters);
			command.CommandText = nameSP;
			command.CommandType = CommandType.StoredProcedure;
			command.Parameters.AddRange(sqlParameters.ToArray());
			var result = command.ExecuteNonQuery();
			connection.Close();
			return result;
		}

		private List<SqlParameter> CreateParameters(List<ParameterDTO> parameters)
		{
			List<SqlParameter> sqlParameters = new List<SqlParameter>();

			parameters.ForEach(p =>
			{
				sqlParameters.Add(new SqlParameter
				{
					ParameterName = p.Key,
					SqlDbType = p.Type,
					Value = p.Value,
					Direction = ParameterDirection.Input,
				});

			});

			return sqlParameters;
		}
	}
}
