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
	public partial class FrmProcessSet : Form
	{
		private readonly IServiceProvider _serviceProvider;
		private readonly CustomerBL _customerBL;
		private readonly ProcessBL _processBL;
		private readonly StuffBL _stuffBL;
		private ProcessDTO _process;

		public ProcessDTO Process
		{
			set
			{
				_process = value;
			}
		}

		public FrmProcessSet(IServiceProvider serviceProvider,
							 CustomerBL customerBL,
							 ProcessBL processBL,
							 StuffBL stuffBL)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
			_customerBL = customerBL;
			_processBL = processBL;
			_stuffBL = stuffBL;
		}

		private void ResetCmbCustomers()
		{
			cmbCustomers.DataSource = null;
		}

		private void ResetClbStuff()
		{
			clbStuffes.DataSource = null;
		}

		private void InitCustomerData()
		{
			ResetCmbCustomers();
			cmbCustomers.DisplayMember = "CustomerFullName";
			cmbCustomers.ValueMember = "CustomerId";
			cmbCustomers.DataSource = _customerBL.ReportCustomers(null);
		}

		private void InitStuffData()
		{
			ResetClbStuff();
			((ListBox)clbStuffes).DisplayMember = "Title";
			((ListBox)clbStuffes).ValueMember = "StuffId";
			clbStuffes.DataSource = _stuffBL.ReportStuffes(null);
		}

		private void FillControls()
		{
			if (_process != null)
			{
				txtTitle.Text = _process.ProcessTitle;
				txtComment.Text = _process.Comment;

				cmbCustomers.SelectedValue = _process.CustomerId;
				
			}
		}

		private void FrmProcessSet_Load(object sender, EventArgs e)
		{
			InitCustomerData();
			InitStuffData();
		}
	}
}
