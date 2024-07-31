using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManagement.Data.DL;
using TimeManagement.Data.DTOs;

namespace TimeManagement.Data.BL
{
	public class CustomerBL
	{

		private readonly CustomerDL customerDL;

		public CustomerBL(CustomerDL customerDL)
		{
			this.customerDL = customerDL;
		}

		public List<CustomerDTO> ReportCustomers(string customerFullName)
		{
			return customerDL.CustomerReport(customerFullName);
		}

		public int SetCustomer(CustomerDTO customer)
		{
			return customerDL.CustomerSet(customer);
		}
	}
}
