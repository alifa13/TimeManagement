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
	public partial class FrmStuffes : Form
	{
		StuffBL _stuffBL;
		private IServiceProvider _serviceProvider;

		public FrmStuffes(StuffBL stuffBL, IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_stuffBL = stuffBL;
			_serviceProvider = serviceProvider;
		}

		private void InitGridColumns()
		{
			gvStuffes.AutoGenerateColumns = false;

			gvStuffes.Columns.Add(new DataGridViewTextBoxColumn
			{
				HeaderText = "عنوان",
				DataPropertyName = "Title",
				MinimumWidth = 70,
			});
			
		}

		private void ResetGrid()
		{
			gvStuffes.DataSource = null;
		}

		private void InitData()
		{
			ResetGrid();
			gvStuffes.DataSource = _stuffBL.ReportStuffes(null);
		}

		protected override void OnClosed(EventArgs e)
		{
			_stuffBL = null;
			base.OnClosed(e);
		}

		private void FrmStuffes_Load(object sender, EventArgs e)
		{
			InitGridColumns();
			InitData();
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			ResetGrid();
			gvStuffes.DataSource = _stuffBL.ReportStuffes(txtFilter.Text);
		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			if (txtFilter.Text == String.Empty)
				InitData();
		}

		private void gvStuffes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var activeRow = gvStuffes.Rows[e.RowIndex].DataBoundItem as StuffDTO;
			var _scope = _serviceProvider.CreateScope();
			var form = _scope.ServiceProvider.GetService<FrmStuffSet>();
			form.Stuff = activeRow;
			form.ShowDialog();
		}

		private void gvStuffes_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}

		private void gvStuffes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var activeRow = gvStuffes.Rows[e.RowIndex].DataBoundItem as StuffDTO;
			var _scope = _serviceProvider.CreateScope();
			var form = _scope.ServiceProvider.GetService<FrmStuffSet>();
			form.Stuff = activeRow;
			form.ShowDialog();
		}
	}
}
