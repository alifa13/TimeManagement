namespace TimeManagement.UI
{
	partial class FrmProcessSet
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtComment = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbCustomers = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnCustomerAdd = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.clbStuffes = new System.Windows.Forms.CheckedListBox();
			this.btnStuffAdd = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(334, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "عنوان";
			// 
			// txtTitle
			// 
			this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTitle.Location = new System.Drawing.Point(36, 64);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(343, 27);
			this.txtTitle.TabIndex = 1;
			// 
			// txtComment
			// 
			this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtComment.Location = new System.Drawing.Point(36, 136);
			this.txtComment.Multiline = true;
			this.txtComment.Name = "txtComment";
			this.txtComment.Size = new System.Drawing.Size(343, 144);
			this.txtComment.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(310, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "توضیحات";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCustomerAdd);
			this.groupBox1.Controls.Add(this.cmbCustomers);
			this.groupBox1.Location = new System.Drawing.Point(352, 361);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(404, 138);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "مشتری";
			// 
			// cmbCustomers
			// 
			this.cmbCustomers.FormattingEnabled = true;
			this.cmbCustomers.Location = new System.Drawing.Point(139, 50);
			this.cmbCustomers.Name = "cmbCustomers";
			this.cmbCustomers.Size = new System.Drawing.Size(230, 28);
			this.cmbCustomers.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtTitle);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtComment);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(352, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(404, 343);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "اطلاعات فرایند";
			// 
			// btnCustomerAdd
			// 
			this.btnCustomerAdd.FlatAppearance.BorderSize = 0;
			this.btnCustomerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustomerAdd.Image = global::TimeManagement.UI.Properties.Resources.icons8_plus_32;
			this.btnCustomerAdd.Location = new System.Drawing.Point(71, 46);
			this.btnCustomerAdd.Name = "btnCustomerAdd";
			this.btnCustomerAdd.Size = new System.Drawing.Size(35, 35);
			this.btnCustomerAdd.TabIndex = 1;
			this.btnCustomerAdd.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnStuffAdd);
			this.groupBox3.Controls.Add(this.clbStuffes);
			this.groupBox3.Location = new System.Drawing.Point(12, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(334, 487);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "کالا";
			// 
			// clbStuffes
			// 
			this.clbStuffes.Dock = System.Windows.Forms.DockStyle.Top;
			this.clbStuffes.FormattingEnabled = true;
			this.clbStuffes.Location = new System.Drawing.Point(3, 23);
			this.clbStuffes.Name = "clbStuffes";
			this.clbStuffes.Size = new System.Drawing.Size(328, 422);
			this.clbStuffes.TabIndex = 0;
			// 
			// btnStuffAdd
			// 
			this.btnStuffAdd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnStuffAdd.Location = new System.Drawing.Point(3, 445);
			this.btnStuffAdd.Name = "btnStuffAdd";
			this.btnStuffAdd.Size = new System.Drawing.Size(328, 39);
			this.btnStuffAdd.TabIndex = 1;
			this.btnStuffAdd.Text = "افزودن کالا";
			this.btnStuffAdd.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(15, 539);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(103, 29);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "ذخیره";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// FrmProcessSet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(768, 580);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmProcessSet";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "افزودن فرایند";
			this.Load += new System.EventHandler(this.FrmProcessSet_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Label label1;
		private TextBox txtTitle;
		private TextBox txtComment;
		private Label label2;
		private GroupBox groupBox1;
		private Button btnCustomerAdd;
		private ComboBox cmbCustomers;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private Button btnStuffAdd;
		private CheckedListBox clbStuffes;
		private Button btnSave;
	}
}