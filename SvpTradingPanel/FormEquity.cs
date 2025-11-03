using Mt5Api;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Data;
using Utils;

namespace SvpTradingPanel
{
	public partial class FormEquity : System.Windows.Forms.Form
	{
		public bool MainWindowTopMost { get; set; }

		private PlotView plotView;

		public FormEquity()
		{
			InitializeComponent();

			plotView = new PlotView
			{
				Dock = DockStyle.Top,
				Width = this.ClientSize.Width,
				Height = (int)(this.ClientSize.Height * 0.9)
			};
			this.Controls.Add(plotView);

			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
		}

		public int GetYear()
		{
			if (int.TryParse(textBoxYear.Text, out int result))
			{
				return result;
			}
			else
			{
				return DateTime.Now.Year;
			}
		}

		private double RoundUpToNiceStep(double value)
		{
			double exponent = Math.Floor(Math.Log10(value));
			double baseStep = Math.Pow(10, exponent);

			// Pokud je value výrazně větší než baseStep, posuň na další vyšší základ
			if (value > baseStep * 5)
				baseStep *= 10;
			else if (value > baseStep * 2)
				baseStep *= 5;
			else if (value > baseStep)
				baseStep *= 2;

			return baseStep;
		}

		private void RefreshData()
		{
			List<History> results = MetatraderInstance.Instance.GetLatestProfitHistory(new DateTime(GetYear(), 1, 1, 0, 0, 0), new DateTime(GetYear(), 12, 31, 23, 59, 59));

			results = results.Where(x => !String.IsNullOrWhiteSpace(x.comment) && (Utilities.StrategyName == null || x.comment.StartsWith(Utilities.StrategyName) || Utilities.StrategyName.ToLower() == "none")).ToList();

			// chart1.Series.Clear();
			plotView.Model?.Series.Clear();
			plotView.InvalidatePlot(true);

			labelIncome.Text = String.Empty;
			labelTaxForm.Text = String.Empty;

			if (results.Count() == 0)
			{
				return;
			}

			//var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
			//{
			//	Name = "Equity",
			//	Color = System.Drawing.Color.Green,
			//	IsVisibleInLegend = false,
			//	IsXValueIndexed = true,
			//	ChartType = SeriesChartType.Line,
			//	BorderWidth = 2
			//};
			//this.chart1.Series.Add(series1);

			//var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
			//{
			//	Name = "Equity with commission and swap",
			//	Color = System.Drawing.Color.Red,
			//	IsVisibleInLegend = false,
			//	IsXValueIndexed = true,
			//	ChartType = SeriesChartType.Line,
			//	BorderWidth = 2
			//};
			//this.chart1.Series.Add(series2);

			//series1.Points.AddXY(0, 0);
			//series2.Points.AddXY(0, 0);

			var plotModel = new PlotModel { Title = "Equity" };
			var series1 = new LineSeries { Title = "Equity", Color = OxyColors.Green, StrokeThickness = 2 };
			var series2 = new LineSeries { Title = "Equity with commission and swap", Color = OxyColors.Red, StrokeThickness = 2 };

			series1.Points.Add(new DataPoint(0, 0));
			series2.Points.Add(new DataPoint(0, 0));

			double profit = 0;
			double income = 0;
			double spending = 0;
			double commission = 0;
			double swap = 0;
			double minProfit = 0;
			double maxProfit = 0;
			for (int i = 0; i < results.Count(); i++)
			{
				if (results[i].profit >= 0)
				{
					income += results[i].profit;
					commission += results[i].commission;
					swap += results[i].swap;
				}
				else
				{
					spending += results[i].profit;
					commission += results[i].commission;
					swap += results[i].swap;
				}
				profit += results[i].profit;

				minProfit = Math.Min(minProfit, profit);
				maxProfit = Math.Max(maxProfit, profit);
				minProfit = Math.Min(minProfit, profit + commission + swap);
				maxProfit = Math.Max(maxProfit, profit + commission + swap);


				// series1.Points.AddXY(i + 1, profit);
				// series2.Points.AddXY(i + 1, profit + commission + swap);
				series1.Points.Add(new DataPoint(i + 1, profit));
				series2.Points.Add(new DataPoint(i + 1, profit + commission + swap));
			}
			int desiredTicks = 20; // požadovaný počet hlavních čárek

			double rawStep = (maxProfit - minProfit) / (desiredTicks - 1);
			double majorStep = RoundUpToNiceStep(rawStep);

			// Přidej osu Y s menším krokem pro popisky
			plotModel.Axes.Add(new LinearAxis
			{
				Position = AxisPosition.Left,
				MajorStep = majorStep, // nastav podle potřeby (např. 100, 500, 1000)
				MinorStep = majorStep / 2,  // volitelné, pro menší čárky
				StringFormat = "F0", // formátování popisků
				MajorGridlineStyle = LineStyle.Solid,
				MinorGridlineStyle = LineStyle.Dot,
				Minimum = minProfit - majorStep,
				Maximum = maxProfit + majorStep,
			});

			// Přidej osu Y s menším krokem pro popisky
			plotModel.Axes.Add(new LinearAxis
			{
				Position = AxisPosition.Bottom,
				Minimum = 0,
				MajorGridlineStyle = LineStyle.Solid,
				MinorGridlineStyle = LineStyle.Dot,
			});

			plotModel.Series.Add(series1);
			plotModel.Series.Add(series2);
			plotView.Model = plotModel;

			labelIncome.Text = $"Profit: {income + spending + commission + swap}, prijmy: {income}, vydaje: {spending}, commision = {commission}, swap = {swap}.";
			labelTaxForm.Text = $"Pro danove priznani, celkove prijmy: {income}, celkove vydaje (prijmy - commission - swap): {spending + commission + swap}.";

			// ...existing code...
			labelIncome.Text = $"Profit: {(income + spending + commission + swap):N2}, prijmy: {income:N2}, vydaje: {spending:N2}, commision = {commission:N2}, swap = {swap:N2}.";
			labelTaxForm.Text = $"Pro danove priznani, celkove prijmy: {income:N2}, celkove vydaje (prijmy - commission - swap): {(spending + commission + swap):N2}.";
			// ...existing code...
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

			bool connected = MetatraderInstance.Connect();

			int counter = 0;
			while (!MetatraderInstance.IsConnectedConsole())
			{
				Thread.Sleep(100);
				if (counter++ == 10)
				{
					System.Environment.Exit(0);
				}
			}

			this.TopMost = MainWindowTopMost;

			this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

			textBoxYear.Text = DateTime.Now.Year.ToString();

			RefreshData();

			this.Text = "SvpTradingPanel - strategy " + Utilities.StrategyName;
		}

		private void textBoxYear_Leave(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void FormEquity_SizeChanged(object sender, EventArgs e)
		{
			if (plotView != null)
			{
				plotView.Width = this.ClientSize.Width;
				plotView.Height = (int)(this.ClientSize.Height * 0.9);
			}
		}

		private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				RefreshData();
			}
		}
	}
}
