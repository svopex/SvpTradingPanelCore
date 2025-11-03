namespace SvpTradingPanel
{
	partial class FormEquity
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEquity));
			labelIncome = new Label();
			labelTaxForm = new Label();
			labelYear = new Label();
			textBoxYear = new TextBox();
			SuspendLayout();
			// 
			// labelIncome
			// 
			labelIncome.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			labelIncome.AutoSize = true;
			labelIncome.Location = new Point(26, 1302);
			labelIncome.Margin = new Padding(7, 0, 7, 0);
			labelIncome.Name = "labelIncome";
			labelIncome.Size = new Size(78, 32);
			labelIncome.TabIndex = 1;
			labelIncome.Text = "label1";
			// 
			// labelTaxForm
			// 
			labelTaxForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			labelTaxForm.AutoSize = true;
			labelTaxForm.Location = new Point(26, 1354);
			labelTaxForm.Margin = new Padding(7, 0, 7, 0);
			labelTaxForm.Name = "labelTaxForm";
			labelTaxForm.Size = new Size(78, 32);
			labelTaxForm.TabIndex = 2;
			labelTaxForm.Text = "label1";
			// 
			// labelYear
			// 
			labelYear.AutoSize = true;
			labelYear.Location = new Point(26, 28);
			labelYear.Margin = new Padding(4, 0, 4, 0);
			labelYear.Name = "labelYear";
			labelYear.Size = new Size(58, 32);
			labelYear.TabIndex = 3;
			labelYear.Text = "Year";
			// 
			// textBoxYear
			// 
			textBoxYear.Location = new Point(96, 24);
			textBoxYear.Margin = new Padding(4);
			textBoxYear.Name = "textBoxYear";
			textBoxYear.Size = new Size(117, 39);
			textBoxYear.TabIndex = 4;
			textBoxYear.KeyPress += textBoxYear_KeyPress;
			textBoxYear.Leave += textBoxYear_Leave;
			// 
			// FormEquity
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1943, 1415);
			Controls.Add(textBoxYear);
			Controls.Add(labelYear);
			Controls.Add(labelTaxForm);
			Controls.Add(labelIncome);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(7, 8, 7, 8);
			Name = "FormEquity";
			Text = "Equity";
			Load += Form1_Load;
			SizeChanged += FormEquity_SizeChanged;
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelIncome;
		private System.Windows.Forms.Label labelTaxForm;
		private System.Windows.Forms.Label labelYear;
		private System.Windows.Forms.TextBox textBoxYear;
	}
}

