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
	public partial class FrmStuffSet : Form
	{
		private StuffBL _stuffBL;
		private StuffDTO _stuff;

		public StuffDTO Stuff
		{
			set
			{
				_stuff = value;
			}
		}

		public FrmStuffSet(StuffBL stuffBL)
		{
			InitializeComponent();
			_stuffBL = stuffBL;
		}

		private void FillControl()
		{
			txtStuff.Text = _stuff.Title;
		}

		private void FillDTO()
		{
			if (_stuff == null)
				_stuff = new StuffDTO();

			_stuff.Title = txtStuff.Text;
		}

		private void FrmStuffSet_Load(object sender, EventArgs e)
		{
			if(_stuff != null)
			{
				Text = "بروزرسانی کالا";
				FillControl();
			}

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			FillDTO();
			var result = _stuffBL.SetStuff(_stuff);
			if(result > -1)
				DialogResult = DialogResult.OK;
		}
	}
}
