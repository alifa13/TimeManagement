using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeManagement.Data.BL;
using TimeManagement.Data.DTOs;

namespace TimeManagement.UI
{
	public partial class FrmCustomers : Form
	{
		private readonly IServiceProvider _serviceProvider;
		private CustomerBL customerBL;

		public FrmCustomers(IServiceProvider serviceProvider, CustomerBL customerBL)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			this.customerBL = customerBL;
		}

		private void InitGridColumns()
		{
			gvCustomers.AutoGenerateColumns = false;

			gvCustomers.Columns.Add(new DataGridViewTextBoxColumn
			{
				HeaderText = "نام",
				DataPropertyName = "CustomerFirstName",
				MinimumWidth = 70,
			});
			gvCustomers.Columns.Add(new DataGridViewTextBoxColumn
			{
				HeaderText = "نام خانوادگی",
				DataPropertyName = "CustomerLastName",
				MinimumWidth = 90,
			});
			gvCustomers.Columns.Add(new DataGridViewTextBoxColumn
			{
				HeaderText = "شماره تلفن",
				DataPropertyName = "TelNumber",
				MinimumWidth = 90,
			});
			gvCustomers.Columns.Add(new DataGridViewTextBoxColumn
			{
				HeaderText = "شماره همراه",
				DataPropertyName = "MobileNumber",
				MinimumWidth = 90,
			});
		}

		private void ResetGrid()
		{
			gvCustomers.DataSource = null;
		}

		private void InitData()
		{
			ResetGrid();
			gvCustomers.DataSource = customerBL.ReportCustomers(null);
		}

		protected override void OnClosed(EventArgs e)
		{
			customerBL = null;
			base.OnClosed(e);
		}

		private void FrmCustomers_Load(object sender, EventArgs e)
		{
			InitGridColumns();
			InitData();
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			ResetGrid();
			gvCustomers.DataSource = customerBL.ReportCustomers(txtFilter.Text);
		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			if(txtFilter.Text == String.Empty)
				InitData();
		}

		private void gvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var activeRow = gvCustomers.Rows[e.RowIndex].DataBoundItem as CustomerDTO;
			var _scope = _serviceProvider.CreateScope();
			var form = _scope.ServiceProvider.GetService<FrmCustomerSet>();
			form.Customer = activeRow;
			form.ShowDialog();
		}
	}
}
