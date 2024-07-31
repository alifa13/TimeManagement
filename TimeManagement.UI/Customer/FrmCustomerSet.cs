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
	public partial class FrmCustomerSet : Form
	{
		private CustomerBL _customerBL;
		private CustomerDTO _customerDTO;
		
		public CustomerDTO Customer
		{
			set
			{
				_customerDTO = value;
			}
		}

		public FrmCustomerSet(CustomerBL customerBL)
		{
			InitializeComponent();
			_customerBL = customerBL;
		}

		private void FillControls()
		{
			if(_customerDTO != null)
			{
				txtCustomerName.Text = _customerDTO.CustomerFirstName;
				txtCustomerFamily.Text = _customerDTO.CustomerLastName;
				txtTelNumber.Text = _customerDTO.TelNumber;
				txtMobileNum.Text = _customerDTO.MobileNumber;
				txtAddress.Text = _customerDTO.Address;
			}
		}

		private void FillDTO()
		{
			if(_customerDTO == null)
				_customerDTO=new CustomerDTO();

			_customerDTO.CustomerFirstName = txtCustomerName.Text;
			_customerDTO.CustomerLastName = txtCustomerFamily.Text;
			_customerDTO.TelNumber = txtTelNumber.Text;
			_customerDTO.MobileNumber = txtMobileNum.Text;
			_customerDTO.Address = txtAddress.Text;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			FillDTO();
			var result = _customerBL.SetCustomer(_customerDTO);
			if(result > -1)
				DialogResult = DialogResult.OK;
		}

		private void FrmCustomerSet_Load(object sender, EventArgs e)
		{
			FillControls();
		}
	}
}
