using Microsoft.Extensions.DependencyInjection;

namespace TimeManagement.UI
{
	public partial class MainForm : Form
	{
		private readonly IServiceProvider _serviceProvider;

		public MainForm(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			using (var _scope = _serviceProvider.CreateScope())
			{
				var form = _scope.ServiceProvider.GetService<FrmCustomers>();
				form.ShowDialog();
			}
		}

		private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			using (var _scope = _serviceProvider.CreateScope())
			{
				var form = _scope.ServiceProvider.GetService<FrmCustomerSet>();
				form.ShowDialog();
			}

		}

		private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			using (var _scope = _serviceProvider.CreateScope())
			{
				var form = _scope.ServiceProvider.GetService<FrmStuffes>();
				form.ShowDialog();
			}
		}

		private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			using (var _scope = _serviceProvider.CreateScope())
			{
				var form = _scope.ServiceProvider.GetService<FrmStuffSet>();
				form.ShowDialog();
			}
		}
	}
}