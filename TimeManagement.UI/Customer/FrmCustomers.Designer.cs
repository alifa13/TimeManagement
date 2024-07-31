namespace TimeManagement.UI
{
	partial class FrmCustomers
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnFilter = new System.Windows.Forms.Button();
			this.txtFilter = new DevExpress.XtraEditors.TextEdit();
			this.gvCustomers = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtFilter.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnFilter);
			this.groupBox1.Controls.Add(this.txtFilter);
			this.groupBox1.Location = new System.Drawing.Point(203, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(434, 96);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "فیلتر";
			// 
			// btnFilter
			// 
			this.btnFilter.BackColor = System.Drawing.SystemColors.Control;
			this.btnFilter.FlatAppearance.BorderSize = 0;
			this.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFilter.Image = global::TimeManagement.UI.Properties.Resources.icons8_search_32;
			this.btnFilter.Location = new System.Drawing.Point(315, 30);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(63, 44);
			this.btnFilter.TabIndex = 1;
			this.btnFilter.UseVisualStyleBackColor = false;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// txtFilter
			// 
			this.txtFilter.Location = new System.Drawing.Point(46, 42);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(252, 22);
			this.txtFilter.TabIndex = 0;
			this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
			// 
			// gvCustomers
			// 
			this.gvCustomers.AllowUserToAddRows = false;
			this.gvCustomers.AllowUserToDeleteRows = false;
			this.gvCustomers.AllowUserToOrderColumns = true;
			this.gvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvCustomers.Location = new System.Drawing.Point(12, 130);
			this.gvCustomers.Name = "gvCustomers";
			this.gvCustomers.ReadOnly = true;
			this.gvCustomers.RowHeadersWidth = 51;
			this.gvCustomers.RowTemplate.Height = 29;
			this.gvCustomers.Size = new System.Drawing.Size(625, 515);
			this.gvCustomers.TabIndex = 1;
			this.gvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCustomers_CellDoubleClick);
			// 
			// FrmCustomers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(655, 657);
			this.Controls.Add(this.gvCustomers);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmCustomers";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "مشتریان";
			this.Load += new System.EventHandler(this.FrmCustomers_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtFilter.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupBox1;
		private Button btnFilter;
		private DevExpress.XtraEditors.TextEdit txtFilter;
		private DataGridView gvCustomers;
	}
}