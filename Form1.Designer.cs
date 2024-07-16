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
            plotViewDensity = new OxyPlot.WindowsForms.PlotView();
            plotViewHeatMap = new OxyPlot.WindowsForms.PlotView();
            tabControl1 = new TabControl();
            DataAnalysis = new TabPage();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            plotViewAgeDistribution = new OxyPlot.WindowsForms.PlotView();
            tabControl1.SuspendLayout();
            DataAnalysis.SuspendLayout();
            tabPage2.SuspendLayout();
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
            plotViewGenderCount.Location = new Point(66, 92);
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
            plotViewHasDiseaseCount.Location = new Point(499, 92);
            plotViewHasDiseaseCount.Name = "plotViewHasDiseaseCount";
            plotViewHasDiseaseCount.PanCursor = Cursors.Hand;
            plotViewHasDiseaseCount.Size = new Size(390, 321);
            plotViewHasDiseaseCount.TabIndex = 8;
            plotViewHasDiseaseCount.Text = "plotViewHasDiseaseCount";
            plotViewHasDiseaseCount.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewHasDiseaseCount.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewHasDiseaseCount.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotViewDensity
            // 
            plotViewDensity.BackColor = SystemColors.ButtonFace;
            plotViewDensity.Location = new Point(22, 21);
            plotViewDensity.Name = "plotViewDensity";
            plotViewDensity.PanCursor = Cursors.Hand;
            plotViewDensity.Size = new Size(619, 324);
            plotViewDensity.TabIndex = 9;
            plotViewDensity.Text = "plotViewDensity";
            plotViewDensity.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewDensity.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewDensity.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotViewHeatMap
            // 
            plotViewHeatMap.BackColor = SystemColors.ButtonFace;
            plotViewHeatMap.Location = new Point(216, 419);
            plotViewHeatMap.Name = "plotViewHeatMap";
            plotViewHeatMap.PanCursor = Cursors.Hand;
            plotViewHeatMap.Size = new Size(673, 534);
            plotViewHeatMap.TabIndex = 10;
            plotViewHeatMap.Text = "plotViewHeatMap";
            plotViewHeatMap.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewHeatMap.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewHeatMap.ZoomVerticalCursor = Cursors.SizeNS;
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
            DataAnalysis.Controls.Add(plotViewAgeDistribution);
            DataAnalysis.Controls.Add(label1);
            DataAnalysis.Controls.Add(plotViewGenderCount);
            DataAnalysis.Controls.Add(plotViewHeatMap);
            DataAnalysis.Controls.Add(plotViewHasDiseaseCount);
            DataAnalysis.Location = new Point(4, 29);
            DataAnalysis.Name = "DataAnalysis";
            DataAnalysis.Padding = new Padding(3);
            DataAnalysis.Size = new Size(1550, 959);
            DataAnalysis.TabIndex = 0;
            DataAnalysis.Text = "DataAnalysis";
            DataAnalysis.UseVisualStyleBackColor = true;
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
            tabPage2.Controls.Add(plotViewDensity);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1550, 959);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
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
            // plotViewAgeDistribution
            // 
            plotViewAgeDistribution.Location = new Point(959, 92);
            plotViewAgeDistribution.Name = "plotViewAgeDistribution";
            plotViewAgeDistribution.PanCursor = Cursors.Hand;
            plotViewAgeDistribution.Size = new Size(534, 321);
            plotViewAgeDistribution.TabIndex = 12;
            plotViewAgeDistribution.Text = "plotViewAgeDistribution";
            plotViewAgeDistribution.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewAgeDistribution.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewAgeDistribution.ZoomVerticalCursor = Cursors.SizeNS;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AverageAge;
        private Button LoadDataset;
        private Button CalculateStatistics;
        private OxyPlot.WindowsForms.PlotView plotViewGenderCount;
        private OxyPlot.WindowsForms.PlotView plotViewHasDiseaseCount;
        private OxyPlot.WindowsForms.PlotView plotViewDensity;
        private OxyPlot.WindowsForms.PlotView plotViewHeatMap;
        private TabControl tabControl1;
        private TabPage DataAnalysis;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label label1;
        private OxyPlot.WindowsForms.PlotView plotViewAgeDistribution;
    }
}
