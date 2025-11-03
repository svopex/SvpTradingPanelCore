using System;
using System.Windows.Forms;

namespace SvpTradingPanel
{
	public class ConfirmDialog : Form
	{
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			// Např. zmenší celý formulář na 80 % původní velikosti
			float scaleFactor = 0.8f;
			this.Scale(new SizeF(scaleFactor, scaleFactor));

			// Volitelné: aby i fonty odpovídaly
			foreach (Control c in this.Controls)
			{
				c.Font = new Font(c.Font.FontFamily, c.Font.Size * scaleFactor, c.Font.Style);
			}
		}

		private void ConfirmDialog_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Y)
			{
				this.DialogResult = DialogResult.Yes;
				this.Close();
			}
			else if (e.KeyCode == Keys.N)
			{
				this.DialogResult = DialogResult.No;
				this.Close();
			}
		}

		public ConfirmDialog(bool buy)
		{
			this.Text = "Confirmation";
			this.StartPosition = FormStartPosition.CenterParent;
			this.Width = 650;
			this.Height = 260;
			this.TopMost = true;
			this.KeyPreview = true;
			this.KeyDown += ConfirmDialog_KeyDown;

			// Obrázek vlevo
			var pictureBox = new PictureBox
			{
				Image = System.Drawing.Image.FromFile("otaznik.png"), // upravte cestu k obrázku
				SizeMode = PictureBoxSizeMode.Zoom,
				Left = 20,
				Top = 20,
				Width = 100,
				Height = 100
			};
			this.Controls.Add(pictureBox);

			var label = new Label
			{
				Text = "Do you really open order " + (buy ? "to long" : "to short") + "?",
				AutoSize = false,
				Width = 450,
				Height = 60,
				Top = 30,
				Left = 140,
				// Font = new System.Drawing.Font("Segoe UI", 14)
			};
			this.Controls.Add(label);

			var btnYes = new Button
			{
				Text = "Yes",
				DialogResult = DialogResult.Yes,
				Left = 140,
				Width = 120,
				Top = 90,
				Height = 60,
				// Font = new System.Drawing.Font("Segoe UI", 12)
			};
			this.Controls.Add(btnYes);

			var btnNo = new Button
			{
				Text = "No",
				DialogResult = DialogResult.No,
				Left = 280,
				Width = 120,
				Top = 90,
				Height = 60,
				// Font = new System.Drawing.Font("Segoe UI", 12)
			};
			this.Controls.Add(btnNo);

			this.AcceptButton = btnYes;
			this.CancelButton = btnNo;
		}
	}
}