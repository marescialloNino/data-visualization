namespace data_visualization
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LoadDataset = new Button();
            CalculateStatistics = new Button();
            plotViewGenderCount = new OxyPlot.WindowsForms.PlotView();
            plotViewHasDiseaseCount = new OxyPlot.WindowsForms.PlotView();
            plotViewHeatMap = new OxyPlot.WindowsForms.PlotView();
            tabControl1 = new TabControl();
            DataAnalysis = new TabPage();
            label5 = new Label();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            plotView9 = new OxyPlot.WindowsForms.PlotView();
            plotView7 = new OxyPlot.WindowsForms.PlotView();
            plotView8 = new OxyPlot.WindowsForms.PlotView();
            plotView6 = new OxyPlot.WindowsForms.PlotView();
            plotViewAgeDistribution = new OxyPlot.WindowsForms.PlotView();
            label1 = new Label();
            tabPage2 = new TabPage();
            label2 = new Label();
            dataGridCorrelationMatrix = new DataGridView();
            tabPage3 = new TabPage();
            label3 = new Label();
            plotView5 = new OxyPlot.WindowsForms.PlotView();
            plotView2 = new OxyPlot.WindowsForms.PlotView();
            plotView4 = new OxyPlot.WindowsForms.PlotView();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            plotView3 = new OxyPlot.WindowsForms.PlotView();
            tabControl1.SuspendLayout();
            DataAnalysis.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCorrelationMatrix).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // LoadDataset
            // 
            LoadDataset.Location = new Point(815, 15);
            LoadDataset.Name = "LoadDataset";
            LoadDataset.Size = new Size(136, 29);
            LoadDataset.TabIndex = 5;
            LoadDataset.Text = "LoadDataset";
            LoadDataset.UseVisualStyleBackColor = true;
            LoadDataset.Click += button1_Click;
            // 
            // CalculateStatistics
            // 
            CalculateStatistics.Location = new Point(957, 15);
            CalculateStatistics.Name = "CalculateStatistics";
            CalculateStatistics.Size = new Size(146, 29);
            CalculateStatistics.TabIndex = 6;
            CalculateStatistics.Text = "CalculateStatistics";
            CalculateStatistics.UseVisualStyleBackColor = true;
            CalculateStatistics.Click += button2_Click;
            // 
            // plotViewGenderCount
            // 
            plotViewGenderCount.BackColor = SystemColors.ButtonFace;
            plotViewGenderCount.Location = new Point(21, 58);
            plotViewGenderCount.Name = "plotViewGenderCount";
            plotViewGenderCount.PanCursor = Cursors.Hand;
            plotViewGenderCount.Size = new Size(419, 291);
            plotViewGenderCount.TabIndex = 7;
            plotViewGenderCount.Text = "plotViewGenderCount";
            plotViewGenderCount.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewGenderCount.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewGenderCount.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotViewHasDiseaseCount
            // 
            plotViewHasDiseaseCount.BackColor = SystemColors.ButtonFace;
            plotViewHasDiseaseCount.Location = new Point(446, 58);
            plotViewHasDiseaseCount.Name = "plotViewHasDiseaseCount";
            plotViewHasDiseaseCount.PanCursor = Cursors.Hand;
            plotViewHasDiseaseCount.Size = new Size(398, 291);
            plotViewHasDiseaseCount.TabIndex = 8;
            plotViewHasDiseaseCount.Text = "plotViewHasDiseaseCount";
            plotViewHasDiseaseCount.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewHasDiseaseCount.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewHasDiseaseCount.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotViewHeatMap
            // 
            plotViewHeatMap.BackColor = SystemColors.ButtonFace;
            plotViewHeatMap.Location = new Point(10, 3);
            plotViewHeatMap.Name = "plotViewHeatMap";
            plotViewHeatMap.PanCursor = Cursors.Hand;
            plotViewHeatMap.Size = new Size(647, 454);
            plotViewHeatMap.TabIndex = 10;
            plotViewHeatMap.Text = "plotViewHeatMap";
            plotViewHeatMap.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewHeatMap.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewHeatMap.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(DataAnalysis);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(35, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1494, 1009);
            tabControl1.TabIndex = 12;
            // 
            // DataAnalysis
            // 
            DataAnalysis.Controls.Add(label5);
            DataAnalysis.Controls.Add(label4);
            DataAnalysis.Controls.Add(tableLayoutPanel1);
            DataAnalysis.Controls.Add(CalculateStatistics);
            DataAnalysis.Controls.Add(plotViewAgeDistribution);
            DataAnalysis.Controls.Add(LoadDataset);
            DataAnalysis.Controls.Add(label1);
            DataAnalysis.Controls.Add(plotViewGenderCount);
            DataAnalysis.Controls.Add(plotViewHasDiseaseCount);
            DataAnalysis.Location = new Point(4, 29);
            DataAnalysis.Name = "DataAnalysis";
            DataAnalysis.Padding = new Padding(3);
            DataAnalysis.Size = new Size(1486, 976);
            DataAnalysis.TabIndex = 0;
            DataAnalysis.Text = "Dataset Analysis";
            DataAnalysis.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1134, 551);
            label5.Name = "label5";
            label5.Size = new Size(264, 100);
            label5.TabIndex = 14;
            label5.Text = "Only \"gender\" is non-numeric variable.\r\n All others are numeric. There are 10\r\n features and 1 output: \"dataset\".\r\n\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1134, 358);
            label4.Name = "label4";
            label4.Size = new Size(266, 140);
            label4.TabIndex = 13;
            label4.Text = resources.GetString("label4.Text");
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(plotView9, 1, 1);
            tableLayoutPanel1.Controls.Add(plotView7, 1, 0);
            tableLayoutPanel1.Controls.Add(plotView8, 0, 1);
            tableLayoutPanel1.Controls.Add(plotView6, 0, 0);
            tableLayoutPanel1.Location = new Point(21, 355);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1107, 598);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // plotView9
            // 
            plotView9.Location = new Point(556, 302);
            plotView9.Name = "plotView9";
            plotView9.PanCursor = Cursors.Hand;
            plotView9.Size = new Size(548, 293);
            plotView9.TabIndex = 3;
            plotView9.Text = "plotView9";
            plotView9.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView9.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView9.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView7
            // 
            plotView7.Location = new Point(556, 3);
            plotView7.Name = "plotView7";
            plotView7.PanCursor = Cursors.Hand;
            plotView7.Size = new Size(548, 293);
            plotView7.TabIndex = 1;
            plotView7.Text = "plotView7";
            plotView7.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView7.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView7.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView8
            // 
            plotView8.Location = new Point(3, 302);
            plotView8.Name = "plotView8";
            plotView8.PanCursor = Cursors.Hand;
            plotView8.Size = new Size(547, 293);
            plotView8.TabIndex = 2;
            plotView8.Text = "plotView8";
            plotView8.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView8.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView8.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView6
            // 
            plotView6.Location = new Point(3, 3);
            plotView6.Name = "plotView6";
            plotView6.PanCursor = Cursors.Hand;
            plotView6.Size = new Size(547, 293);
            plotView6.TabIndex = 0;
            plotView6.Text = "plotView6";
            plotView6.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView6.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView6.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotViewAgeDistribution
            // 
            plotViewAgeDistribution.Location = new Point(850, 58);
            plotViewAgeDistribution.Name = "plotViewAgeDistribution";
            plotViewAgeDistribution.PanCursor = Cursors.Hand;
            plotViewAgeDistribution.Size = new Size(600, 291);
            plotViewAgeDistribution.TabIndex = 12;
            plotViewAgeDistribution.Text = "plotViewAgeDistribution";
            plotViewAgeDistribution.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewAgeDistribution.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewAgeDistribution.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 15);
            label1.Name = "label1";
            label1.Size = new Size(763, 40);
            label1.TabIndex = 11;
            label1.Text = "Feataure Available : Age, Gender, Total Bilirubin, Direct Birilubin, Alkaline Phosphotase, Alamine Aminotransferase,\r\nTotal Proteins, Albumin, Albumin/Globulin Ratio, Dataset\r\n";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(dataGridCorrelationMatrix);
            tabPage2.Controls.Add(plotViewHeatMap);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1415, 976);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "CorrelationAnalysis";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(724, 31);
            label2.Name = "label2";
            label2.Size = new Size(563, 60);
            label2.TabIndex = 12;
            label2.Text = resources.GetString("label2.Text");
            label2.Click += label2_Click;
            // 
            // dataGridCorrelationMatrix
            // 
            dataGridCorrelationMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCorrelationMatrix.Location = new Point(10, 477);
            dataGridCorrelationMatrix.Name = "dataGridCorrelationMatrix";
            dataGridCorrelationMatrix.RowHeadersWidth = 51;
            dataGridCorrelationMatrix.Size = new Size(1385, 377);
            dataGridCorrelationMatrix.TabIndex = 11;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(plotView5);
            tabPage3.Controls.Add(plotView2);
            tabPage3.Controls.Add(plotView4);
            tabPage3.Controls.Add(plotView1);
            tabPage3.Controls.Add(plotView3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1415, 976);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Scatter Plots";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(782, 554);
            label3.Name = "label3";
            label3.Size = new Size(544, 40);
            label3.TabIndex = 4;
            label3.Text = "Scatter plots of the couples of features with high correlation, in order to assess if \r\nin fact a linear relation is present and one of the two could be removed";
            // 
            // plotView5
            // 
            plotView5.Location = new Point(16, 6);
            plotView5.Name = "plotView5";
            plotView5.PanCursor = Cursors.Hand;
            plotView5.Size = new Size(703, 252);
            plotView5.TabIndex = 0;
            plotView5.Text = "plotView5";
            plotView5.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView5.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView5.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView2
            // 
            plotView2.Location = new Point(16, 530);
            plotView2.Name = "plotView2";
            plotView2.PanCursor = Cursors.Hand;
            plotView2.Size = new Size(712, 261);
            plotView2.TabIndex = 1;
            plotView2.Text = "plotView2";
            plotView2.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView2.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView4
            // 
            plotView4.Location = new Point(732, 264);
            plotView4.Name = "plotView4";
            plotView4.PanCursor = Cursors.Hand;
            plotView4.Size = new Size(675, 260);
            plotView4.TabIndex = 3;
            plotView4.Text = "plotView4";
            plotView4.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView4.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView4.ZoomVerticalCursor = Cursors.SizeNS;
            plotView4.Click += plotView4_Click;
            // 
            // plotView1
            // 
            plotView1.Location = new Point(732, 6);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(681, 252);
            plotView1.TabIndex = 0;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView3
            // 
            plotView3.Location = new Point(16, 264);
            plotView3.Name = "plotView3";
            plotView3.PanCursor = Cursors.Hand;
            plotView3.Size = new Size(703, 260);
            plotView3.TabIndex = 2;
            plotView3.Text = "plotView3";
            plotView3.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView3.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView3.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1582, 1055);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            DataAnalysis.ResumeLayout(false);
            DataAnalysis.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCorrelationMatrix).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button LoadDataset;
        private Button CalculateStatistics;
        private OxyPlot.WindowsForms.PlotView plotViewGenderCount;
        private OxyPlot.WindowsForms.PlotView plotViewHasDiseaseCount;
        private OxyPlot.WindowsForms.PlotView plotViewHeatMap;
        private TabControl tabControl1;
        private TabPage DataAnalysis;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private OxyPlot.WindowsForms.PlotView plotViewAgeDistribution;
        private DataGridView dataGridCorrelationMatrix;
        private OxyPlot.WindowsForms.PlotView plotView4;
        private OxyPlot.WindowsForms.PlotView plotView3;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private OxyPlot.WindowsForms.PlotView plotView5;
        private TableLayoutPanel tableLayoutPanel1;
        private OxyPlot.WindowsForms.PlotView plotView9;
        private OxyPlot.WindowsForms.PlotView plotView8;
        private OxyPlot.WindowsForms.PlotView plotView7;
        private OxyPlot.WindowsForms.PlotView plotView6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
