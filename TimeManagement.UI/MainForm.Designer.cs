namespace TimeManagement.UI
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
			this.btnItemCalledEvent = new DevExpress.XtraBars.BarButtonItem();
			this.btnItemAddEvent = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageProcess = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageEvent = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageCustomer = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageStuff = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageSetting = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.btnItemCalledEvent,
            this.btnItemAddEvent,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 12;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
			this.ribbonControl1.SearchItemPosition = DevExpress.XtraBars.Ribbon.SearchItemPosition.None;
			this.ribbonControl1.Size = new System.Drawing.Size(1188, 155);
			this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.barButtonItem1.Caption = "گزارش فرایند";
			this.barButtonItem1.Id = 2;
			this.barButtonItem1.ImageOptions.Image = global::TimeManagement.UI.Properties.Resources.icons8_process_32;
			this.barButtonItem1.Name = "barButtonItem1";
			this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			// 
			// barButtonItem2
			// 
			this.barButtonItem2.Caption = "افزودن فرایند";
			this.barButtonItem2.Id = 3;
			this.barButtonItem2.ImageOptions.SvgImage = global::TimeManagement.UI.Properties.Resources.actions_addcircled;
			this.barButtonItem2.Name = "barButtonItem2";
			// 
			// barButtonItem3
			// 
			this.barButtonItem3.Caption = "رویداد های امروز";
			this.barButtonItem3.Id = 4;
			this.barButtonItem3.ImageOptions.Image = global::TimeManagement.UI.Properties.Resources.icons8_event_32;
			this.barButtonItem3.Name = "barButtonItem3";
			this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			// 
			// btnItemCalledEvent
			// 
			this.btnItemCalledEvent.Caption = "رویدادهای فراخوانی شده";
			this.btnItemCalledEvent.Id = 5;
			this.btnItemCalledEvent.ImageOptions.Image = global::TimeManagement.UI.Properties.Resources.icons8_event_accepted_32;
			this.btnItemCalledEvent.Name = "btnItemCalledEvent";
			this.btnItemCalledEvent.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			// 
			// btnItemAddEvent
			// 
			this.btnItemAddEvent.Caption = "افزودن";
			this.btnItemAddEvent.Id = 6;
			this.btnItemAddEvent.ImageOptions.SvgImage = global::TimeManagement.UI.Properties.Resources.actions_addcircled;
			this.btnItemAddEvent.Name = "btnItemAddEvent";
			this.btnItemAddEvent.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			// 
			// barButtonItem4
			// 
			this.barButtonItem4.Caption = "گزارش مشتریان";
			this.barButtonItem4.Id = 7;
			this.barButtonItem4.ImageOptions.SvgImage = global::TimeManagement.UI.Properties.Resources.customers;
			this.barButtonItem4.Name = "barButtonItem4";
			this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
			// 
			// barButtonItem5
			// 
			this.barButtonItem5.Caption = "افزودن مشتری";
			this.barButtonItem5.Id = 8;
			this.barButtonItem5.ImageOptions.SvgImage = global::TimeManagement.UI.Properties.Resources.newcustomer;
			this.barButtonItem5.Name = "barButtonItem5";
			this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
			// 
			// barButtonItem6
			// 
			this.barButtonItem6.Caption = "گزارش کالا";
			this.barButtonItem6.Id = 9;
			this.barButtonItem6.ImageOptions.SvgImage = global::TimeManagement.UI.Properties.Resources.products;
			this.barButtonItem6.Name = "barButtonItem6";
			this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
			// 
			// barButtonItem7
			// 
			this.barButtonItem7.Caption = "افزودن کالا";
			this.barButtonItem7.Id = 10;
			this.barButtonItem7.ImageOptions.SvgImage = global::TimeManagement.UI.Properties.Resources.newproduct;
			this.barButtonItem7.Name = "barButtonItem7";
			this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
			// 
			// barButtonItem8
			// 
			this.barButtonItem8.Caption = "تنظیمات اولیه";
			this.barButtonItem8.Id = 11;
			this.barButtonItem8.ImageOptions.SvgImage = global::TimeManagement.UI.Properties.Resources.initialstate;
			this.barButtonItem8.Name = "barButtonItem8";
			this.barButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageProcess,
            this.ribbonPageEvent,
            this.ribbonPageCustomer,
            this.ribbonPageStuff,
            this.ribbonPageSetting});
			this.ribbonPage1.ImageOptions.SvgImage = global::TimeManagement.UI.Properties.Resources.menu;
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "منو";
			// 
			// ribbonPageProcess
			// 
			this.ribbonPageProcess.ItemLinks.Add(this.barButtonItem1);
			this.ribbonPageProcess.ItemLinks.Add(this.barButtonItem2);
			this.ribbonPageProcess.Name = "ribbonPageProcess";
			this.ribbonPageProcess.Tag = "ProcessPage";
			this.ribbonPageProcess.Text = "فرایند";
			// 
			// ribbonPageEvent
			// 
			this.ribbonPageEvent.ItemLinks.Add(this.barButtonItem3);
			this.ribbonPageEvent.ItemLinks.Add(this.btnItemCalledEvent);
			this.ribbonPageEvent.ItemLinks.Add(this.btnItemAddEvent);
			this.ribbonPageEvent.Name = "ribbonPageEvent";
			this.ribbonPageEvent.Tag = "EventPage";
			this.ribbonPageEvent.Text = "رویداد";
			// 
			// ribbonPageCustomer
			// 
			this.ribbonPageCustomer.ItemLinks.Add(this.barButtonItem4);
			this.ribbonPageCustomer.ItemLinks.Add(this.barButtonItem5);
			this.ribbonPageCustomer.Name = "ribbonPageCustomer";
			this.ribbonPageCustomer.Text = "مشتریان";
			// 
			// ribbonPageStuff
			// 
			this.ribbonPageStuff.ItemLinks.Add(this.barButtonItem6);
			this.ribbonPageStuff.ItemLinks.Add(this.barButtonItem7);
			this.ribbonPageStuff.Name = "ribbonPageStuff";
			this.ribbonPageStuff.Text = "کالا";
			// 
			// ribbonPageSetting
			// 
			this.ribbonPageSetting.ItemLinks.Add(this.barButtonItem8);
			this.ribbonPageSetting.Name = "ribbonPageSetting";
			this.ribbonPageSetting.Text = "تنظیمات";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1188, 648);
			this.Controls.Add(this.ribbonControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "مدیریت زمان";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageProcess;
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
		private DevExpress.XtraBars.BarButtonItem barButtonItem3;
		private DevExpress.XtraBars.BarButtonItem btnItemCalledEvent;
		private DevExpress.XtraBars.BarButtonItem btnItemAddEvent;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageEvent;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageCustomer;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageStuff;
		private DevExpress.XtraBars.BarButtonItem barButtonItem4;
		private DevExpress.XtraBars.BarButtonItem barButtonItem5;
		private DevExpress.XtraBars.BarButtonItem barButtonItem6;
		private DevExpress.XtraBars.BarButtonItem barButtonItem7;
		private DevExpress.XtraBars.BarButtonItem barButtonItem8;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageSetting;

	}
}