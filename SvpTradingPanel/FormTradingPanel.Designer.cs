namespace SvpTradingPanel
{
	partial class FormTradingPanel
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTradingPanel));
            buttonOrderBuy1 = new Button();
            textBoxSlDistance = new TextBox();
            LabelPositionSize = new Label();
            buttonSlUp = new Button();
            buttonSlDown = new Button();
            buttonJoinSl = new Button();
            buttonSlUpMini = new Button();
            buttonSlDownMini = new Button();
            checkBoxAlwaysOnTop = new CheckBox();
            buttonOrderSell1 = new Button();
            buttonBuy60 = new Button();
            buttonBuy30 = new Button();
            buttonBuy10 = new Button();
            buttonBuy100 = new Button();
            buttonSell100 = new Button();
            buttonSell60 = new Button();
            buttonSell30 = new Button();
            buttonSell10 = new Button();
            labelConnected = new Label();
            buttonOrderBuy2 = new Button();
            buttonOrderSell2 = new Button();
            buttonCloseAll = new Button();
            buttonSlDownMax = new Button();
            buttonSlUpMax = new Button();
            labelRrr = new Label();
            timerRefreshLabels = new System.Windows.Forms.Timer(components);
            labelLoss = new Label();
            labelProfit = new Label();
            buttonOrderSell3 = new Button();
            buttonOrderBuy3 = new Button();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            checkBoxPendingOrder = new CheckBox();
            checkBoxMovePendingOrder = new CheckBox();
            buttonSetTp = new Button();
            trackBarPositionUsing = new TrackBar();
            labelPositionUsing = new Label();
            labelPositionUsingPercent = new Label();
            labelSlLoss = new Label();
            buttonSlToBeAutomation = new Button();
            progressBarSlToBeAutomation = new ProgressBar();
            buttonSlPtMonitoring = new Button();
            progressBarSlPtMonitoring = new ProgressBar();
            buttonEquity = new Button();
            labelSymbol = new Label();
            checkBoxBlink = new CheckBox();
            progressBarSlToHalfAutomation = new ProgressBar();
            buttonSlToHalfAutomation = new Button();
            buttonCallHueTest = new Button();
            labelPs = new Label();
            labelTickValue = new Label();
            labelUsdCzk = new Label();
            labelContractSize = new Label();
            buttonSetTp15 = new Button();
            checkBoxAutoCloseTrades = new CheckBox();
            labelSvpTradingPanel = new Label();
            buttonSetTp20 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBarPositionUsing).BeginInit();
            SuspendLayout();
            // 
            // buttonOrderBuy1
            // 
            buttonOrderBuy1.Location = new Point(10, 849);
            buttonOrderBuy1.Margin = new Padding(4, 5, 4, 5);
            buttonOrderBuy1.Name = "buttonOrderBuy1";
            buttonOrderBuy1.Size = new Size(213, 101);
            buttonOrderBuy1.TabIndex = 50;
            buttonOrderBuy1.Text = "Buy 40% 35% 25%";
            buttonOrderBuy1.UseVisualStyleBackColor = true;
            buttonOrderBuy1.Click += buttonOrderBuy1_Click;
            // 
            // textBoxSlDistance
            // 
            textBoxSlDistance.Location = new Point(170, 248);
            textBoxSlDistance.Margin = new Padding(4, 5, 4, 5);
            textBoxSlDistance.Name = "textBoxSlDistance";
            textBoxSlDistance.Size = new Size(157, 39);
            textBoxSlDistance.TabIndex = 1;
            // 
            // LabelPositionSize
            // 
            LabelPositionSize.AutoSize = true;
            LabelPositionSize.Location = new Point(4, 249);
            LabelPositionSize.Margin = new Padding(4, 0, 4, 0);
            LabelPositionSize.Name = "LabelPositionSize";
            LabelPositionSize.Size = new Size(133, 32);
            LabelPositionSize.TabIndex = 0;
            LabelPositionSize.Text = "&SL distance";
            // 
            // buttonSlUp
            // 
            buttonSlUp.Location = new Point(638, 469);
            buttonSlUp.Margin = new Padding(4, 5, 4, 5);
            buttonSlUp.Name = "buttonSlUp";
            buttonSlUp.Size = new Size(172, 101);
            buttonSlUp.TabIndex = 73;
            buttonSlUp.Text = "SL up";
            buttonSlUp.UseVisualStyleBackColor = true;
            buttonSlUp.Click += buttonSlUp_Click;
            // 
            // buttonSlDown
            // 
            buttonSlDown.Location = new Point(638, 578);
            buttonSlDown.Margin = new Padding(4, 5, 4, 5);
            buttonSlDown.Name = "buttonSlDown";
            buttonSlDown.Size = new Size(172, 101);
            buttonSlDown.TabIndex = 74;
            buttonSlDown.Text = "SL down";
            buttonSlDown.UseVisualStyleBackColor = true;
            buttonSlDown.Click += buttonSlDown_Click;
            // 
            // buttonJoinSl
            // 
            buttonJoinSl.Location = new Point(638, 689);
            buttonJoinSl.Margin = new Padding(4, 5, 4, 5);
            buttonJoinSl.Name = "buttonJoinSl";
            buttonJoinSl.Size = new Size(172, 101);
            buttonJoinSl.TabIndex = 82;
            buttonJoinSl.Text = "Join SL";
            buttonJoinSl.UseVisualStyleBackColor = true;
            buttonJoinSl.Click += buttonJoinSl_Click;
            // 
            // buttonSlUpMini
            // 
            buttonSlUpMini.Location = new Point(822, 469);
            buttonSlUpMini.Margin = new Padding(4, 5, 4, 5);
            buttonSlUpMini.Name = "buttonSlUpMini";
            buttonSlUpMini.Size = new Size(169, 101);
            buttonSlUpMini.TabIndex = 75;
            buttonSlUpMini.Text = "SL up mini";
            buttonSlUpMini.UseVisualStyleBackColor = true;
            buttonSlUpMini.Click += buttonSlUpMini_Click;
            // 
            // buttonSlDownMini
            // 
            buttonSlDownMini.Location = new Point(822, 578);
            buttonSlDownMini.Margin = new Padding(4, 5, 4, 5);
            buttonSlDownMini.Name = "buttonSlDownMini";
            buttonSlDownMini.Size = new Size(169, 101);
            buttonSlDownMini.TabIndex = 76;
            buttonSlDownMini.Text = "SL down mini";
            buttonSlDownMini.UseVisualStyleBackColor = true;
            buttonSlDownMini.Click += buttonSlDownMini_Click;
            // 
            // checkBoxAlwaysOnTop
            // 
            checkBoxAlwaysOnTop.AutoSize = true;
            checkBoxAlwaysOnTop.Location = new Point(787, 193);
            checkBoxAlwaysOnTop.Margin = new Padding(4, 5, 4, 5);
            checkBoxAlwaysOnTop.Name = "checkBoxAlwaysOnTop";
            checkBoxAlwaysOnTop.Size = new Size(196, 36);
            checkBoxAlwaysOnTop.TabIndex = 13;
            checkBoxAlwaysOnTop.Text = "Always on top";
            checkBoxAlwaysOnTop.UseVisualStyleBackColor = true;
            checkBoxAlwaysOnTop.CheckedChanged += checkBoxAlwaysOnTop_CheckedChanged;
            // 
            // buttonOrderSell1
            // 
            buttonOrderSell1.Location = new Point(230, 849);
            buttonOrderSell1.Margin = new Padding(4, 5, 4, 5);
            buttonOrderSell1.Name = "buttonOrderSell1";
            buttonOrderSell1.Size = new Size(214, 101);
            buttonOrderSell1.TabIndex = 53;
            buttonOrderSell1.Text = "Sell 40% 35% 25%";
            buttonOrderSell1.UseVisualStyleBackColor = true;
            buttonOrderSell1.Click += buttonOrderSell1_Click;
            // 
            // buttonBuy60
            // 
            buttonBuy60.Location = new Point(10, 521);
            buttonBuy60.Margin = new Padding(4, 5, 4, 5);
            buttonBuy60.Name = "buttonBuy60";
            buttonBuy60.Size = new Size(213, 101);
            buttonBuy60.TabIndex = 21;
            buttonBuy60.Text = "Buy 60%";
            buttonBuy60.UseVisualStyleBackColor = true;
            buttonBuy60.Click += buttonBuy60_Click;
            // 
            // buttonBuy30
            // 
            buttonBuy30.Location = new Point(10, 627);
            buttonBuy30.Margin = new Padding(4, 5, 4, 5);
            buttonBuy30.Name = "buttonBuy30";
            buttonBuy30.Size = new Size(213, 101);
            buttonBuy30.TabIndex = 22;
            buttonBuy30.Text = "Buy 30%";
            buttonBuy30.UseVisualStyleBackColor = true;
            buttonBuy30.Click += buttonBuy30_Click;
            // 
            // buttonBuy10
            // 
            buttonBuy10.Location = new Point(10, 737);
            buttonBuy10.Margin = new Padding(4, 5, 4, 5);
            buttonBuy10.Name = "buttonBuy10";
            buttonBuy10.Size = new Size(213, 101);
            buttonBuy10.TabIndex = 23;
            buttonBuy10.Text = "Buy 10%";
            buttonBuy10.UseVisualStyleBackColor = true;
            buttonBuy10.Click += buttonBuy10_Click;
            // 
            // buttonBuy100
            // 
            buttonBuy100.Location = new Point(10, 412);
            buttonBuy100.Margin = new Padding(4, 5, 4, 5);
            buttonBuy100.Name = "buttonBuy100";
            buttonBuy100.Size = new Size(213, 101);
            buttonBuy100.TabIndex = 20;
            buttonBuy100.Text = "Buy 100%";
            buttonBuy100.UseVisualStyleBackColor = true;
            buttonBuy100.Click += buttonBuy100_Click;
            // 
            // buttonSell100
            // 
            buttonSell100.Location = new Point(230, 410);
            buttonSell100.Margin = new Padding(4, 5, 4, 5);
            buttonSell100.Name = "buttonSell100";
            buttonSell100.Size = new Size(213, 101);
            buttonSell100.TabIndex = 24;
            buttonSell100.Text = "Sell 100%";
            buttonSell100.UseVisualStyleBackColor = true;
            buttonSell100.Click += buttonSell100_Click;
            // 
            // buttonSell60
            // 
            buttonSell60.Location = new Point(230, 521);
            buttonSell60.Margin = new Padding(4, 5, 4, 5);
            buttonSell60.Name = "buttonSell60";
            buttonSell60.Size = new Size(214, 101);
            buttonSell60.TabIndex = 25;
            buttonSell60.Text = "Sell 60%";
            buttonSell60.UseVisualStyleBackColor = true;
            buttonSell60.Click += buttonSell60_Click;
            // 
            // buttonSell30
            // 
            buttonSell30.Location = new Point(230, 627);
            buttonSell30.Margin = new Padding(4, 5, 4, 5);
            buttonSell30.Name = "buttonSell30";
            buttonSell30.Size = new Size(214, 101);
            buttonSell30.TabIndex = 26;
            buttonSell30.Text = "Sell 30%";
            buttonSell30.UseVisualStyleBackColor = true;
            buttonSell30.Click += buttonSell30_Click;
            // 
            // buttonSell10
            // 
            buttonSell10.Location = new Point(230, 737);
            buttonSell10.Margin = new Padding(4, 5, 4, 5);
            buttonSell10.Name = "buttonSell10";
            buttonSell10.Size = new Size(214, 101);
            buttonSell10.TabIndex = 27;
            buttonSell10.Text = "Sell 10%";
            buttonSell10.UseVisualStyleBackColor = true;
            buttonSell10.Click += buttonSell10_Click;
            // 
            // labelConnected
            // 
            labelConnected.AutoSize = true;
            labelConnected.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelConnected.Location = new Point(842, 89);
            labelConnected.Margin = new Padding(4, 0, 4, 0);
            labelConnected.Name = "labelConnected";
            labelConnected.Size = new Size(145, 36);
            labelConnected.TabIndex = 11;
            labelConnected.Text = "**********";
            labelConnected.TextAlign = ContentAlignment.TopRight;
            // 
            // buttonOrderBuy2
            // 
            buttonOrderBuy2.Location = new Point(10, 1074);
            buttonOrderBuy2.Margin = new Padding(4, 5, 4, 5);
            buttonOrderBuy2.Name = "buttonOrderBuy2";
            buttonOrderBuy2.Size = new Size(213, 101);
            buttonOrderBuy2.TabIndex = 52;
            buttonOrderBuy2.Text = "Buy 60% 40%";
            buttonOrderBuy2.UseVisualStyleBackColor = true;
            buttonOrderBuy2.Click += buttonOrderBuy2_Click;
            // 
            // buttonOrderSell2
            // 
            buttonOrderSell2.Location = new Point(230, 1074);
            buttonOrderSell2.Margin = new Padding(4, 5, 4, 5);
            buttonOrderSell2.Name = "buttonOrderSell2";
            buttonOrderSell2.Size = new Size(213, 101);
            buttonOrderSell2.TabIndex = 55;
            buttonOrderSell2.Text = "Sell 60% 40%";
            buttonOrderSell2.UseVisualStyleBackColor = true;
            buttonOrderSell2.Click += buttonOrderSell2_Click;
            // 
            // buttonCloseAll
            // 
            buttonCloseAll.Location = new Point(822, 689);
            buttonCloseAll.Margin = new Padding(4, 5, 4, 5);
            buttonCloseAll.Name = "buttonCloseAll";
            buttonCloseAll.Size = new Size(166, 101);
            buttonCloseAll.TabIndex = 80;
            buttonCloseAll.Text = "Close All";
            buttonCloseAll.UseVisualStyleBackColor = true;
            buttonCloseAll.Click += buttonCloseAll_Click;
            // 
            // buttonSlDownMax
            // 
            buttonSlDownMax.Location = new Point(457, 578);
            buttonSlDownMax.Margin = new Padding(4, 5, 4, 5);
            buttonSlDownMax.Name = "buttonSlDownMax";
            buttonSlDownMax.Size = new Size(173, 101);
            buttonSlDownMax.TabIndex = 72;
            buttonSlDownMax.Text = "SL down max";
            buttonSlDownMax.UseVisualStyleBackColor = true;
            buttonSlDownMax.Click += buttonSlDownMax_Click;
            // 
            // buttonSlUpMax
            // 
            buttonSlUpMax.Location = new Point(457, 469);
            buttonSlUpMax.Margin = new Padding(4, 5, 4, 5);
            buttonSlUpMax.Name = "buttonSlUpMax";
            buttonSlUpMax.Size = new Size(173, 101);
            buttonSlUpMax.TabIndex = 71;
            buttonSlUpMax.Text = "SL up max";
            buttonSlUpMax.UseVisualStyleBackColor = true;
            buttonSlUpMax.Click += buttonSlUpMax_Click;
            // 
            // labelRrr
            // 
            labelRrr.AutoSize = true;
            labelRrr.Location = new Point(4, 45);
            labelRrr.Margin = new Padding(4, 0, 4, 0);
            labelRrr.Name = "labelRrr";
            labelRrr.Size = new Size(56, 32);
            labelRrr.TabIndex = 7;
            labelRrr.Text = "RRR";
            // 
            // timerRefreshLabels
            // 
            timerRefreshLabels.Enabled = true;
            timerRefreshLabels.Interval = 1000;
            timerRefreshLabels.Tick += timerRefreshLabels_Tick;
            // 
            // labelLoss
            // 
            labelLoss.AutoSize = true;
            labelLoss.Location = new Point(300, 45);
            labelLoss.Margin = new Padding(4, 0, 4, 0);
            labelLoss.Name = "labelLoss";
            labelLoss.Size = new Size(59, 32);
            labelLoss.TabIndex = 8;
            labelLoss.Text = "Loss";
            // 
            // labelProfit
            // 
            labelProfit.AutoSize = true;
            labelProfit.Location = new Point(644, 45);
            labelProfit.Margin = new Padding(4, 0, 4, 0);
            labelProfit.Name = "labelProfit";
            labelProfit.Size = new Size(71, 32);
            labelProfit.TabIndex = 9;
            labelProfit.Text = "Profit";
            // 
            // buttonOrderSell3
            // 
            buttonOrderSell3.Location = new Point(230, 961);
            buttonOrderSell3.Margin = new Padding(4, 5, 4, 5);
            buttonOrderSell3.Name = "buttonOrderSell3";
            buttonOrderSell3.Size = new Size(214, 101);
            buttonOrderSell3.TabIndex = 54;
            buttonOrderSell3.Text = "Sell 50% 40% 10%";
            buttonOrderSell3.UseVisualStyleBackColor = true;
            buttonOrderSell3.Click += buttonOrderSell3_Click;
            // 
            // buttonOrderBuy3
            // 
            buttonOrderBuy3.Location = new Point(10, 961);
            buttonOrderBuy3.Margin = new Padding(4, 5, 4, 5);
            buttonOrderBuy3.Name = "buttonOrderBuy3";
            buttonOrderBuy3.Size = new Size(213, 101);
            buttonOrderBuy3.TabIndex = 51;
            buttonOrderBuy3.Text = "Buy 50% 40% 10%";
            buttonOrderBuy3.UseVisualStyleBackColor = true;
            buttonOrderBuy3.Click += buttonOrderBuy3_Click;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(4, 198);
            labelPrice.Margin = new Padding(4, 0, 4, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(65, 32);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "&Price";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(170, 193);
            textBoxPrice.Margin = new Padding(4, 5, 4, 5);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(157, 39);
            textBoxPrice.TabIndex = 3;
            // 
            // checkBoxPendingOrder
            // 
            checkBoxPendingOrder.AutoSize = true;
            checkBoxPendingOrder.Location = new Point(786, 239);
            checkBoxPendingOrder.Margin = new Padding(4, 5, 4, 5);
            checkBoxPendingOrder.Name = "checkBoxPendingOrder";
            checkBoxPendingOrder.Size = new Size(197, 36);
            checkBoxPendingOrder.TabIndex = 14;
            checkBoxPendingOrder.Text = "Pending order";
            checkBoxPendingOrder.UseVisualStyleBackColor = true;
            checkBoxPendingOrder.CheckedChanged += checkBoxPendingOrder_CheckedChanged;
            // 
            // checkBoxMovePendingOrder
            // 
            checkBoxMovePendingOrder.AutoSize = true;
            checkBoxMovePendingOrder.Location = new Point(457, 423);
            checkBoxMovePendingOrder.Margin = new Padding(4, 5, 4, 5);
            checkBoxMovePendingOrder.Name = "checkBoxMovePendingOrder";
            checkBoxMovePendingOrder.Size = new Size(346, 36);
            checkBoxMovePendingOrder.TabIndex = 70;
            checkBoxMovePendingOrder.Text = "Move pending order, not SL";
            checkBoxMovePendingOrder.UseVisualStyleBackColor = true;
            // 
            // buttonSetTp
            // 
            buttonSetTp.Location = new Point(457, 800);
            buttonSetTp.Margin = new Padding(4, 5, 4, 5);
            buttonSetTp.Name = "buttonSetTp";
            buttonSetTp.Size = new Size(173, 101);
            buttonSetTp.TabIndex = 81;
            buttonSetTp.Text = "Set TP";
            buttonSetTp.UseVisualStyleBackColor = true;
            buttonSetTp.Click += buttonSetTp_Click;
            // 
            // trackBarPositionUsing
            // 
            trackBarPositionUsing.LargeChange = 50;
            trackBarPositionUsing.Location = new Point(171, 294);
            trackBarPositionUsing.Margin = new Padding(4, 5, 4, 5);
            trackBarPositionUsing.Maximum = 300;
            trackBarPositionUsing.Minimum = 10;
            trackBarPositionUsing.Name = "trackBarPositionUsing";
            trackBarPositionUsing.Size = new Size(840, 90);
            trackBarPositionUsing.SmallChange = 10;
            trackBarPositionUsing.TabIndex = 6;
            trackBarPositionUsing.Value = 100;
            trackBarPositionUsing.ValueChanged += trackBarPositionUsing_ValueChanged;
            // 
            // labelPositionUsing
            // 
            labelPositionUsing.AutoSize = true;
            labelPositionUsing.Location = new Point(5, 307);
            labelPositionUsing.Margin = new Padding(4, 0, 4, 0);
            labelPositionUsing.Name = "labelPositionUsing";
            labelPositionUsing.Size = new Size(167, 32);
            labelPositionUsing.TabIndex = 4;
            labelPositionUsing.Text = "&Pos. utilization";
            // 
            // labelPositionUsingPercent
            // 
            labelPositionUsingPercent.AutoSize = true;
            labelPositionUsingPercent.Location = new Point(41, 352);
            labelPositionUsingPercent.Margin = new Padding(4, 0, 4, 0);
            labelPositionUsingPercent.Name = "labelPositionUsingPercent";
            labelPositionUsingPercent.Size = new Size(73, 32);
            labelPositionUsingPercent.TabIndex = 5;
            labelPositionUsingPercent.Text = "100%";
            // 
            // labelSlLoss
            // 
            labelSlLoss.AutoSize = true;
            labelSlLoss.Location = new Point(4, 93);
            labelSlLoss.Margin = new Padding(4, 0, 4, 0);
            labelSlLoss.Name = "labelSlLoss";
            labelSlLoss.Size = new Size(71, 32);
            labelSlLoss.TabIndex = 10;
            labelSlLoss.Text = "Profit";
            // 
            // buttonSlToBeAutomation
            // 
            buttonSlToBeAutomation.Location = new Point(457, 913);
            buttonSlToBeAutomation.Margin = new Padding(4, 5, 4, 5);
            buttonSlToBeAutomation.Name = "buttonSlToBeAutomation";
            buttonSlToBeAutomation.Size = new Size(531, 74);
            buttonSlToBeAutomation.TabIndex = 86;
            buttonSlToBeAutomation.Text = "SL to BE automation after PT";
            buttonSlToBeAutomation.UseVisualStyleBackColor = true;
            buttonSlToBeAutomation.Click += buttonSlToBeAutomation_Click;
            // 
            // progressBarSlToBeAutomation
            // 
            progressBarSlToBeAutomation.Location = new Point(462, 998);
            progressBarSlToBeAutomation.Margin = new Padding(4, 5, 4, 5);
            progressBarSlToBeAutomation.Name = "progressBarSlToBeAutomation";
            progressBarSlToBeAutomation.Size = new Size(526, 61);
            progressBarSlToBeAutomation.TabIndex = 87;
            // 
            // buttonSlPtMonitoring
            // 
            buttonSlPtMonitoring.Location = new Point(457, 1225);
            buttonSlPtMonitoring.Margin = new Padding(4, 5, 4, 5);
            buttonSlPtMonitoring.Name = "buttonSlPtMonitoring";
            buttonSlPtMonitoring.Size = new Size(534, 74);
            buttonSlPtMonitoring.TabIndex = 88;
            buttonSlPtMonitoring.Text = "SL/PT monitoring";
            buttonSlPtMonitoring.UseVisualStyleBackColor = true;
            buttonSlPtMonitoring.Click += buttonSlPtMonitoring_Click;
            // 
            // progressBarSlPtMonitoring
            // 
            progressBarSlPtMonitoring.Location = new Point(462, 1308);
            progressBarSlPtMonitoring.Margin = new Padding(4, 5, 4, 5);
            progressBarSlPtMonitoring.Name = "progressBarSlPtMonitoring";
            progressBarSlPtMonitoring.Size = new Size(529, 61);
            progressBarSlPtMonitoring.TabIndex = 89;
            // 
            // buttonEquity
            // 
            buttonEquity.Location = new Point(570, 191);
            buttonEquity.Margin = new Padding(4, 5, 4, 5);
            buttonEquity.Name = "buttonEquity";
            buttonEquity.Size = new Size(208, 88);
            buttonEquity.TabIndex = 12;
            buttonEquity.Text = "Equity";
            buttonEquity.UseVisualStyleBackColor = true;
            buttonEquity.Click += buttonEquity_Click;
            // 
            // labelSymbol
            // 
            labelSymbol.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelSymbol.ForeColor = Color.Blue;
            labelSymbol.Location = new Point(338, 196);
            labelSymbol.Margin = new Padding(4, 0, 4, 0);
            labelSymbol.Name = "labelSymbol";
            labelSymbol.Size = new Size(226, 109);
            labelSymbol.TabIndex = 90;
            labelSymbol.Text = "? Symbol ?";
            // 
            // checkBoxBlink
            // 
            checkBoxBlink.AutoSize = true;
            checkBoxBlink.Location = new Point(10, 1230);
            checkBoxBlink.Margin = new Padding(5, 8, 5, 8);
            checkBoxBlink.Name = "checkBoxBlink";
            checkBoxBlink.Size = new Size(237, 36);
            checkBoxBlink.TabIndex = 91;
            checkBoxBlink.Text = "Blink by Hue bulb";
            checkBoxBlink.UseVisualStyleBackColor = true;
            // 
            // progressBarSlToHalfAutomation
            // 
            progressBarSlToHalfAutomation.Location = new Point(462, 1153);
            progressBarSlToHalfAutomation.Margin = new Padding(4, 5, 4, 5);
            progressBarSlToHalfAutomation.Name = "progressBarSlToHalfAutomation";
            progressBarSlToHalfAutomation.Size = new Size(526, 61);
            progressBarSlToHalfAutomation.TabIndex = 93;
            // 
            // buttonSlToHalfAutomation
            // 
            buttonSlToHalfAutomation.Location = new Point(457, 1066);
            buttonSlToHalfAutomation.Margin = new Padding(4, 5, 4, 5);
            buttonSlToHalfAutomation.Name = "buttonSlToHalfAutomation";
            buttonSlToHalfAutomation.Size = new Size(534, 74);
            buttonSlToHalfAutomation.TabIndex = 92;
            buttonSlToHalfAutomation.Text = "SL to half automation after PT";
            buttonSlToHalfAutomation.UseVisualStyleBackColor = true;
            buttonSlToHalfAutomation.Click += buttonSlToHalfAutomation_Click;
            // 
            // buttonCallHueTest
            // 
            buttonCallHueTest.Location = new Point(10, 1277);
            buttonCallHueTest.Name = "buttonCallHueTest";
            buttonCallHueTest.Size = new Size(213, 92);
            buttonCallHueTest.TabIndex = 94;
            buttonCallHueTest.Text = "Call Hue Test";
            buttonCallHueTest.UseVisualStyleBackColor = true;
            buttonCallHueTest.Click += buttonCallHueTest_Click;
            // 
            // labelPs
            // 
            labelPs.AutoSize = true;
            labelPs.Location = new Point(300, 93);
            labelPs.Margin = new Padding(4, 0, 4, 0);
            labelPs.Name = "labelPs";
            labelPs.Size = new Size(145, 32);
            labelPs.TabIndex = 95;
            labelPs.Text = "Position size";
            // 
            // labelTickValue
            // 
            labelTickValue.AutoSize = true;
            labelTickValue.Location = new Point(4, 142);
            labelTickValue.Margin = new Padding(4, 0, 4, 0);
            labelTickValue.Name = "labelTickValue";
            labelTickValue.Size = new Size(120, 32);
            labelTickValue.TabIndex = 96;
            labelTickValue.Text = "Tick value";
            // 
            // labelUsdCzk
            // 
            labelUsdCzk.AutoSize = true;
            labelUsdCzk.Location = new Point(300, 142);
            labelUsdCzk.Margin = new Padding(4, 0, 4, 0);
            labelUsdCzk.Name = "labelUsdCzk";
            labelUsdCzk.Size = new Size(103, 32);
            labelUsdCzk.TabIndex = 97;
            labelUsdCzk.Text = "USDCZK";
            // 
            // labelContractSize
            // 
            labelContractSize.AutoSize = true;
            labelContractSize.Location = new Point(644, 142);
            labelContractSize.Margin = new Padding(4, 0, 4, 0);
            labelContractSize.Name = "labelContractSize";
            labelContractSize.Size = new Size(154, 32);
            labelContractSize.TabIndex = 98;
            labelContractSize.Text = "Contract Size";
            // 
            // buttonSetTp15
            // 
            buttonSetTp15.Location = new Point(638, 800);
            buttonSetTp15.Margin = new Padding(4, 5, 4, 5);
            buttonSetTp15.Name = "buttonSetTp15";
            buttonSetTp15.Size = new Size(172, 101);
            buttonSetTp15.TabIndex = 99;
            buttonSetTp15.Text = "Set TP 1.5";
            buttonSetTp15.UseVisualStyleBackColor = true;
            buttonSetTp15.Click += buttonSetTp15_Click;
            // 
            // checkBoxAutoCloseTrades
            // 
            checkBoxAutoCloseTrades.AutoSize = true;
            checkBoxAutoCloseTrades.Location = new Point(11, 1183);
            checkBoxAutoCloseTrades.Margin = new Padding(5, 8, 5, 8);
            checkBoxAutoCloseTrades.Name = "checkBoxAutoCloseTrades";
            checkBoxAutoCloseTrades.Size = new Size(321, 36);
            checkBoxAutoCloseTrades.TabIndex = 100;
            checkBoxAutoCloseTrades.Text = "Auto close trades at 22:30";
            checkBoxAutoCloseTrades.UseVisualStyleBackColor = true;
            // 
            // labelSvpTradingPanel
            // 
            labelSvpTradingPanel.AutoSize = true;
            labelSvpTradingPanel.Location = new Point(4, 0);
            labelSvpTradingPanel.Margin = new Padding(4, 0, 4, 0);
            labelSvpTradingPanel.Name = "labelSvpTradingPanel";
            labelSvpTradingPanel.Size = new Size(29, 32);
            labelSvpTradingPanel.TabIndex = 101;
            labelSvpTradingPanel.Text = "...";
            // 
            // buttonSetTp20
            // 
            buttonSetTp20.Location = new Point(822, 800);
            buttonSetTp20.Margin = new Padding(4, 5, 4, 5);
            buttonSetTp20.Name = "buttonSetTp20";
            buttonSetTp20.Size = new Size(165, 101);
            buttonSetTp20.TabIndex = 102;
            buttonSetTp20.Text = "Set TP 2.0";
            buttonSetTp20.UseVisualStyleBackColor = true;
            buttonSetTp20.Click += buttonSetTp20_Click;
            // 
            // FormTradingPanel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 1379);
            Controls.Add(buttonSetTp20);
            Controls.Add(labelSvpTradingPanel);
            Controls.Add(checkBoxAutoCloseTrades);
            Controls.Add(buttonSetTp15);
            Controls.Add(labelContractSize);
            Controls.Add(labelUsdCzk);
            Controls.Add(labelTickValue);
            Controls.Add(labelPs);
            Controls.Add(buttonCallHueTest);
            Controls.Add(progressBarSlToHalfAutomation);
            Controls.Add(buttonSlToHalfAutomation);
            Controls.Add(checkBoxBlink);
            Controls.Add(labelSymbol);
            Controls.Add(buttonEquity);
            Controls.Add(progressBarSlPtMonitoring);
            Controls.Add(buttonSlPtMonitoring);
            Controls.Add(progressBarSlToBeAutomation);
            Controls.Add(buttonSlToBeAutomation);
            Controls.Add(labelSlLoss);
            Controls.Add(labelPositionUsingPercent);
            Controls.Add(labelPositionUsing);
            Controls.Add(trackBarPositionUsing);
            Controls.Add(buttonSetTp);
            Controls.Add(checkBoxMovePendingOrder);
            Controls.Add(checkBoxPendingOrder);
            Controls.Add(textBoxPrice);
            Controls.Add(labelPrice);
            Controls.Add(buttonOrderSell3);
            Controls.Add(buttonOrderBuy3);
            Controls.Add(labelProfit);
            Controls.Add(labelLoss);
            Controls.Add(labelRrr);
            Controls.Add(buttonSlDownMax);
            Controls.Add(buttonSlUpMax);
            Controls.Add(buttonCloseAll);
            Controls.Add(buttonOrderSell2);
            Controls.Add(buttonOrderBuy2);
            Controls.Add(labelConnected);
            Controls.Add(buttonSell10);
            Controls.Add(buttonSell30);
            Controls.Add(buttonSell60);
            Controls.Add(buttonSell100);
            Controls.Add(buttonBuy100);
            Controls.Add(buttonBuy10);
            Controls.Add(buttonBuy30);
            Controls.Add(buttonBuy60);
            Controls.Add(buttonOrderSell1);
            Controls.Add(checkBoxAlwaysOnTop);
            Controls.Add(buttonSlDownMini);
            Controls.Add(buttonSlUpMini);
            Controls.Add(buttonJoinSl);
            Controls.Add(buttonSlDown);
            Controls.Add(buttonSlUp);
            Controls.Add(LabelPositionSize);
            Controls.Add(textBoxSlDistance);
            Controls.Add(buttonOrderBuy1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormTradingPanel";
            Text = "SvpTradingPanel Core";
            FormClosing += FormTradingPanel_FormClosing;
            Load += FormTradingPanel_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarPositionUsing).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOrderBuy1;
		private System.Windows.Forms.TextBox textBoxSlDistance;
		private System.Windows.Forms.Label LabelPositionSize;
		private System.Windows.Forms.Button buttonSlUp;
		private System.Windows.Forms.Button buttonSlDown;
		private System.Windows.Forms.Button buttonJoinSl;
		private System.Windows.Forms.Button buttonSlUpMini;
		private System.Windows.Forms.Button buttonSlDownMini;
		private System.Windows.Forms.CheckBox checkBoxAlwaysOnTop;
		private System.Windows.Forms.Button buttonOrderSell1;
		private System.Windows.Forms.Button buttonBuy60;
		private System.Windows.Forms.Button buttonBuy30;
		private System.Windows.Forms.Button buttonBuy10;
		private System.Windows.Forms.Button buttonBuy100;
		private System.Windows.Forms.Button buttonSell100;
		private System.Windows.Forms.Button buttonSell60;
		private System.Windows.Forms.Button buttonSell30;
		private System.Windows.Forms.Button buttonSell10;
		private System.Windows.Forms.Label labelConnected;
		private System.Windows.Forms.Button buttonOrderBuy2;
		private System.Windows.Forms.Button buttonOrderSell2;
		private System.Windows.Forms.Button buttonCloseAll;
		private System.Windows.Forms.Button buttonSlDownMax;
		private System.Windows.Forms.Button buttonSlUpMax;
		private System.Windows.Forms.Label labelRrr;
		private System.Windows.Forms.Timer timerRefreshLabels;
		private System.Windows.Forms.Label labelLoss;
		private System.Windows.Forms.Label labelProfit;
		private System.Windows.Forms.Button buttonOrderSell3;
		private System.Windows.Forms.Button buttonOrderBuy3;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.CheckBox checkBoxPendingOrder;
		private System.Windows.Forms.CheckBox checkBoxMovePendingOrder;
		private System.Windows.Forms.Button buttonSetTp;
		private System.Windows.Forms.TrackBar trackBarPositionUsing;
		private System.Windows.Forms.Label labelPositionUsing;
		private System.Windows.Forms.Label labelPositionUsingPercent;
		private System.Windows.Forms.Label labelSlLoss;
		private System.Windows.Forms.Button buttonSlToBeAutomation;
		private System.Windows.Forms.ProgressBar progressBarSlToBeAutomation;
		private System.Windows.Forms.Button buttonSlPtMonitoring;
		private System.Windows.Forms.ProgressBar progressBarSlPtMonitoring;
		private System.Windows.Forms.Button buttonEquity;
		private System.Windows.Forms.Label labelSymbol;
		private System.Windows.Forms.CheckBox checkBoxBlink;
		private System.Windows.Forms.ProgressBar progressBarSlToHalfAutomation;
		private System.Windows.Forms.Button buttonSlToHalfAutomation;
		private System.Windows.Forms.Button buttonCallHueTest;
		private System.Windows.Forms.Label labelPs;
		private System.Windows.Forms.Label labelTickValue;
		private System.Windows.Forms.Label labelUsdCzk;
		private System.Windows.Forms.Label labelContractSize;
		private Button buttonSetTp15;
		private CheckBox checkBoxAutoCloseTrades;
		private Label labelSvpTradingPanel;
        private Button buttonSetTp20;
    }
}

