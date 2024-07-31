using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManagement.Data.DTOs;

namespace TimeManagement.Data.DL
{
    public class CustomerDL
    {
		private readonly SqlHelper sqlHelper;

		public CustomerDL(SqlHelper sqlHelper)
		{
			this.sqlHelper = sqlHelper;
		}
        public int CustomerSet(CustomerDTO dto)
        {
            if (dto == null)
                return 0;

            List<ParameterDTO> parameters = new List<ParameterDTO>()
            {
                new ParameterDTO()
                {
                    Key = "@id",
                    Value = dto.CustomerId,
                    Type = System.Data.SqlDbType.Int
                },
                new ParameterDTO()
                {
                    Key = "@customerName",
                    Value = dto.CustomerFirstName,
                    Type = System.Data.SqlDbType.NVarChar
                },
                new ParameterDTO()
                {
                    Key = "@customerLastName",
                    Value = dto.CustomerLastName,
                    Type = System.Data.SqlDbType.NVarChar
                },
                new ParameterDTO()
                {
                    Key = "@mobileNum",
                    Value = dto.MobileNumber,
                    Type = System.Data.SqlDbType.NVarChar
                },
                new ParameterDTO()
                {
                    Key = "@phoneNum",
                    Value = dto.TelNumber,
                    Type = System.Data.SqlDbType.NVarChar
                },
                new ParameterDTO()
                {
                    Key = "@address",
                    Value = dto.Address,
                    Type = System.Data.SqlDbType.NVarChar
                }
            };

            int result = sqlHelper.ExecuteNonQuery("spCustomerSet", parameters);
            return result;
        }

        public List<CustomerDTO> CustomerReport(string customerFullName)
        {
            ParameterDTO parameter = new ParameterDTO()
            {
                Key = "@customerFullName",
                Value = customerFullName,
                Type = System.Data.SqlDbType.NVarChar
            };

            var result = sqlHelper.ExecuteSP("spCustomerReport", new List<ParameterDTO> { parameter });
            return Map(result);
        }

        private List<CustomerDTO> Map(DataTable table)
        {
            List<CustomerDTO> lstCustomers = new List<CustomerDTO>();

            foreach (DataRow row in table.Rows)
            {
                lstCustomers.Add(new CustomerDTO()
                {
                    CustomerId = Convert.ToInt32(row["CustomerId"]),
                    CustomerFirstName = row["customerName"]?.ToString() ?? "",
                    CustomerLastName = row["CustomerFamily"]?.ToString() ?? "",
                    MobileNumber = row["PhoneNumber"]?.ToString() ?? "",
                    TelNumber = row["TelNumber"]?.ToString() ?? "",
                    Address = row["CustomerAddress"]?.ToString() ?? ""
                });
            }

            return lstCustomers;

        }


    }
}
