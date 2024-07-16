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
            AverageAge = new Label();
            LoadDataset = new Button();
            CalculateStatistics = new Button();
            plotViewGenderCount = new OxyPlot.WindowsForms.PlotView();
            plotViewHasDiseaseCount = new OxyPlot.WindowsForms.PlotView();
            plotViewHeatMap = new OxyPlot.WindowsForms.PlotView();
            tabControl1 = new TabControl();
            DataAnalysis = new TabPage();
            plotViewAgeDistribution = new OxyPlot.WindowsForms.PlotView();
            label1 = new Label();
            tabPage2 = new TabPage();
            dataGridCorrelationMatrix = new DataGridView();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            plotView2 = new OxyPlot.WindowsForms.PlotView();
            plotView3 = new OxyPlot.WindowsForms.PlotView();
            plotView4 = new OxyPlot.WindowsForms.PlotView();
            plotView5 = new OxyPlot.WindowsForms.PlotView();
            plotView6 = new OxyPlot.WindowsForms.PlotView();
            plotView7 = new OxyPlot.WindowsForms.PlotView();
            plotView8 = new OxyPlot.WindowsForms.PlotView();
            plotView9 = new OxyPlot.WindowsForms.PlotView();
            plotView10 = new OxyPlot.WindowsForms.PlotView();
            plotView11 = new OxyPlot.WindowsForms.PlotView();
            plotView12 = new OxyPlot.WindowsForms.PlotView();
            plotView13 = new OxyPlot.WindowsForms.PlotView();
            plotView14 = new OxyPlot.WindowsForms.PlotView();
            plotView15 = new OxyPlot.WindowsForms.PlotView();
            tabControl1.SuspendLayout();
            DataAnalysis.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCorrelationMatrix).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // AverageAge
            // 
            AverageAge.AutoSize = true;
            AverageAge.Location = new Point(37, 24);
            AverageAge.Name = "AverageAge";
            AverageAge.Size = new Size(95, 20);
            AverageAge.TabIndex = 0;
            AverageAge.Text = "Average Age";
            // 
            // LoadDataset
            // 
            LoadDataset.Location = new Point(328, 24);
            LoadDataset.Name = "LoadDataset";
            LoadDataset.Size = new Size(136, 29);
            LoadDataset.TabIndex = 5;
            LoadDataset.Text = "LoadDataset";
            LoadDataset.UseVisualStyleBackColor = true;
            LoadDataset.Click += button1_Click;
            // 
            // CalculateStatistics
            // 
            CalculateStatistics.Location = new Point(485, 24);
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
            plotViewGenderCount.Location = new Point(21, 77);
            plotViewGenderCount.Name = "plotViewGenderCount";
            plotViewGenderCount.PanCursor = Cursors.Hand;
            plotViewGenderCount.Size = new Size(417, 321);
            plotViewGenderCount.TabIndex = 7;
            plotViewGenderCount.Text = "plotViewGenderCount";
            plotViewGenderCount.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewGenderCount.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewGenderCount.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotViewHasDiseaseCount
            // 
            plotViewHasDiseaseCount.BackColor = SystemColors.ButtonFace;
            plotViewHasDiseaseCount.Location = new Point(484, 77);
            plotViewHasDiseaseCount.Name = "plotViewHasDiseaseCount";
            plotViewHasDiseaseCount.PanCursor = Cursors.Hand;
            plotViewHasDiseaseCount.Size = new Size(390, 321);
            plotViewHasDiseaseCount.TabIndex = 8;
            plotViewHasDiseaseCount.Text = "plotViewHasDiseaseCount";
            plotViewHasDiseaseCount.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewHasDiseaseCount.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewHasDiseaseCount.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotViewHeatMap
            // 
            plotViewHeatMap.BackColor = SystemColors.ButtonFace;
            plotViewHeatMap.Location = new Point(7, 458);
            plotViewHeatMap.Name = "plotViewHeatMap";
            plotViewHeatMap.PanCursor = Cursors.Hand;
            plotViewHeatMap.Size = new Size(824, 431);
            plotViewHeatMap.TabIndex = 10;
            plotViewHeatMap.Text = "plotViewHeatMap";
            plotViewHeatMap.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewHeatMap.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewHeatMap.ZoomVerticalCursor = Cursors.SizeNS;
            plotViewHeatMap.Click += plotViewHeatMap_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(DataAnalysis);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(12, 59);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1558, 992);
            tabControl1.TabIndex = 12;
            // 
            // DataAnalysis
            // 
            DataAnalysis.Controls.Add(plotViewHeatMap);
            DataAnalysis.Controls.Add(plotViewAgeDistribution);
            DataAnalysis.Controls.Add(dataGridCorrelationMatrix);
            DataAnalysis.Controls.Add(label1);
            DataAnalysis.Controls.Add(plotViewGenderCount);
            DataAnalysis.Controls.Add(plotViewHasDiseaseCount);
            DataAnalysis.Location = new Point(4, 29);
            DataAnalysis.Name = "DataAnalysis";
            DataAnalysis.Padding = new Padding(3);
            DataAnalysis.Size = new Size(1550, 959);
            DataAnalysis.TabIndex = 0;
            DataAnalysis.Text = "DataAnalysis";
            DataAnalysis.UseVisualStyleBackColor = true;
            // 
            // plotViewAgeDistribution
            // 
            plotViewAgeDistribution.Location = new Point(901, 77);
            plotViewAgeDistribution.Name = "plotViewAgeDistribution";
            plotViewAgeDistribution.PanCursor = Cursors.Hand;
            plotViewAgeDistribution.Size = new Size(581, 321);
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
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1550, 959);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridCorrelationMatrix
            // 
            dataGridCorrelationMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCorrelationMatrix.Location = new Point(849, 419);
            dataGridCorrelationMatrix.Name = "dataGridCorrelationMatrix";
            dataGridCorrelationMatrix.RowHeadersWidth = 51;
            dataGridCorrelationMatrix.Size = new Size(695, 534);
            dataGridCorrelationMatrix.TabIndex = 11;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel4);
            tabPage3.Controls.Add(tableLayoutPanel3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1550, 959);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tableLayoutPanel5);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1550, 959);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1550, 959);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(plotView3, 2, 0);
            tableLayoutPanel1.Controls.Add(plotView2, 1, 0);
            tableLayoutPanel1.Controls.Add(plotView1, 0, 0);
            tableLayoutPanel1.Location = new Point(21, 48);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1471, 366);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(plotView6, 0, 0);
            tableLayoutPanel2.Controls.Add(plotView5, 0, 0);
            tableLayoutPanel2.Controls.Add(plotView4, 0, 0);
            tableLayoutPanel2.Location = new Point(21, 444);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1471, 366);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(plotView9, 0, 0);
            tableLayoutPanel3.Controls.Add(plotView8, 0, 0);
            tableLayoutPanel3.Controls.Add(plotView7, 0, 0);
            tableLayoutPanel3.Location = new Point(21, 30);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1471, 366);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(plotView12, 0, 0);
            tableLayoutPanel4.Controls.Add(plotView11, 0, 0);
            tableLayoutPanel4.Controls.Add(plotView10, 0, 0);
            tableLayoutPanel4.Location = new Point(21, 424);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1471, 366);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(plotView15, 0, 0);
            tableLayoutPanel5.Controls.Add(plotView14, 0, 0);
            tableLayoutPanel5.Controls.Add(plotView13, 0, 0);
            tableLayoutPanel5.Location = new Point(21, 40);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1471, 366);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // plotView1
            // 
            plotView1.Location = new Point(3, 3);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(484, 360);
            plotView1.TabIndex = 0;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView2
            // 
            plotView2.Location = new Point(493, 3);
            plotView2.Name = "plotView2";
            plotView2.PanCursor = Cursors.Hand;
            plotView2.Size = new Size(484, 360);
            plotView2.TabIndex = 1;
            plotView2.Text = "plotView2";
            plotView2.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView2.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView3
            // 
            plotView3.Location = new Point(983, 3);
            plotView3.Name = "plotView3";
            plotView3.PanCursor = Cursors.Hand;
            plotView3.Size = new Size(484, 360);
            plotView3.TabIndex = 2;
            plotView3.Text = "plotView3";
            plotView3.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView3.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView3.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView4
            // 
            plotView4.Location = new Point(3, 3);
            plotView4.Name = "plotView4";
            plotView4.PanCursor = Cursors.Hand;
            plotView4.Size = new Size(484, 360);
            plotView4.TabIndex = 1;
            plotView4.Text = "plotView4";
            plotView4.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView4.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView4.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView5
            // 
            plotView5.Location = new Point(493, 3);
            plotView5.Name = "plotView5";
            plotView5.PanCursor = Cursors.Hand;
            plotView5.Size = new Size(484, 360);
            plotView5.TabIndex = 2;
            plotView5.Text = "plotView5";
            plotView5.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView5.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView5.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView6
            // 
            plotView6.Location = new Point(983, 3);
            plotView6.Name = "plotView6";
            plotView6.PanCursor = Cursors.Hand;
            plotView6.Size = new Size(484, 360);
            plotView6.TabIndex = 3;
            plotView6.Text = "plotView6";
            plotView6.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView6.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView6.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView7
            // 
            plotView7.Location = new Point(3, 3);
            plotView7.Name = "plotView7";
            plotView7.PanCursor = Cursors.Hand;
            plotView7.Size = new Size(484, 360);
            plotView7.TabIndex = 1;
            plotView7.Text = "plotView7";
            plotView7.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView7.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView7.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView8
            // 
            plotView8.Location = new Point(493, 3);
            plotView8.Name = "plotView8";
            plotView8.PanCursor = Cursors.Hand;
            plotView8.Size = new Size(484, 360);
            plotView8.TabIndex = 2;
            plotView8.Text = "plotView8";
            plotView8.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView8.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView8.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView9
            // 
            plotView9.Location = new Point(983, 3);
            plotView9.Name = "plotView9";
            plotView9.PanCursor = Cursors.Hand;
            plotView9.Size = new Size(484, 360);
            plotView9.TabIndex = 3;
            plotView9.Text = "plotView9";
            plotView9.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView9.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView9.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView10
            // 
            plotView10.Location = new Point(3, 3);
            plotView10.Name = "plotView10";
            plotView10.PanCursor = Cursors.Hand;
            plotView10.Size = new Size(484, 360);
            plotView10.TabIndex = 1;
            plotView10.Text = "plotView10";
            plotView10.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView10.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView10.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView11
            // 
            plotView11.Location = new Point(493, 3);
            plotView11.Name = "plotView11";
            plotView11.PanCursor = Cursors.Hand;
            plotView11.Size = new Size(484, 360);
            plotView11.TabIndex = 2;
            plotView11.Text = "plotView11";
            plotView11.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView11.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView11.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView12
            // 
            plotView12.Location = new Point(983, 3);
            plotView12.Name = "plotView12";
            plotView12.PanCursor = Cursors.Hand;
            plotView12.Size = new Size(484, 360);
            plotView12.TabIndex = 3;
            plotView12.Text = "plotView12";
            plotView12.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView12.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView12.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView13
            // 
            plotView13.Location = new Point(3, 3);
            plotView13.Name = "plotView13";
            plotView13.PanCursor = Cursors.Hand;
            plotView13.Size = new Size(484, 360);
            plotView13.TabIndex = 1;
            plotView13.Text = "plotView13";
            plotView13.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView13.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView13.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView14
            // 
            plotView14.Location = new Point(493, 3);
            plotView14.Name = "plotView14";
            plotView14.PanCursor = Cursors.Hand;
            plotView14.Size = new Size(484, 360);
            plotView14.TabIndex = 2;
            plotView14.Text = "plotView14";
            plotView14.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView14.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView14.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView15
            // 
            plotView15.Location = new Point(983, 3);
            plotView15.Name = "plotView15";
            plotView15.PanCursor = Cursors.Hand;
            plotView15.Size = new Size(484, 360);
            plotView15.TabIndex = 3;
            plotView15.Text = "plotView15";
            plotView15.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView15.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView15.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1572, 1055);
            Controls.Add(tabControl1);
            Controls.Add(CalculateStatistics);
            Controls.Add(LoadDataset);
            Controls.Add(AverageAge);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            DataAnalysis.ResumeLayout(false);
            DataAnalysis.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridCorrelationMatrix).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AverageAge;
        private Button LoadDataset;
        private Button CalculateStatistics;
        private OxyPlot.WindowsForms.PlotView plotViewGenderCount;
        private OxyPlot.WindowsForms.PlotView plotViewHasDiseaseCount;
        private OxyPlot.WindowsForms.PlotView plotViewHeatMap;
        private TabControl tabControl1;
        private TabPage DataAnalysis;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label label1;
        private OxyPlot.WindowsForms.PlotView plotViewAgeDistribution;
        private DataGridView dataGridCorrelationMatrix;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private OxyPlot.WindowsForms.PlotView plotView6;
        private OxyPlot.WindowsForms.PlotView plotView5;
        private OxyPlot.WindowsForms.PlotView plotView4;
        private OxyPlot.WindowsForms.PlotView plotView3;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private TableLayoutPanel tableLayoutPanel4;
        private OxyPlot.WindowsForms.PlotView plotView12;
        private OxyPlot.WindowsForms.PlotView plotView11;
        private OxyPlot.WindowsForms.PlotView plotView10;
        private TableLayoutPanel tableLayoutPanel3;
        private OxyPlot.WindowsForms.PlotView plotView9;
        private OxyPlot.WindowsForms.PlotView plotView8;
        private OxyPlot.WindowsForms.PlotView plotView7;
        private TableLayoutPanel tableLayoutPanel5;
        private OxyPlot.WindowsForms.PlotView plotView15;
        private OxyPlot.WindowsForms.PlotView plotView14;
        private OxyPlot.WindowsForms.PlotView plotView13;
    }
}
