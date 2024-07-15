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
            plotViewHistogram = new OxyPlot.WindowsForms.PlotView();
            plotViewScatter = new OxyPlot.WindowsForms.PlotView();
            plotViewDensity = new OxyPlot.WindowsForms.PlotView();
            plotViewHeatMap = new OxyPlot.WindowsForms.PlotView();
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
            LoadDataset.Location = new Point(464, 20);
            LoadDataset.Name = "LoadDataset";
            LoadDataset.Size = new Size(136, 29);
            LoadDataset.TabIndex = 5;
            LoadDataset.Text = "LoadDataset";
            LoadDataset.UseVisualStyleBackColor = true;
            LoadDataset.Click += button1_Click;
            // 
            // CalculateStatistics
            // 
            CalculateStatistics.Location = new Point(709, 24);
            CalculateStatistics.Name = "CalculateStatistics";
            CalculateStatistics.Size = new Size(146, 29);
            CalculateStatistics.TabIndex = 6;
            CalculateStatistics.Text = "CalculateStatistics";
            CalculateStatistics.UseVisualStyleBackColor = true;
            CalculateStatistics.Click += button2_Click;
            // 
            // plotViewHistogram
            // 
            plotViewHistogram.Location = new Point(55, 79);
            plotViewHistogram.Name = "plotViewHistogram";
            plotViewHistogram.PanCursor = Cursors.Hand;
            plotViewHistogram.Size = new Size(619, 324);
            plotViewHistogram.TabIndex = 7;
            plotViewHistogram.Text = "plotViewHistogram";
            plotViewHistogram.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewHistogram.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewHistogram.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotViewScatter
            // 
            plotViewScatter.Location = new Point(696, 79);
            plotViewScatter.Name = "plotViewScatter";
            plotViewScatter.PanCursor = Cursors.Hand;
            plotViewScatter.Size = new Size(584, 326);
            plotViewScatter.TabIndex = 8;
            plotViewScatter.Text = "plotViewScatter";
            plotViewScatter.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewScatter.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewScatter.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotViewDensity
            // 
            plotViewDensity.Location = new Point(55, 402);
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
            plotViewHeatMap.Location = new Point(653, 294);
            plotViewHeatMap.Name = "plotViewHeatMap";
            plotViewHeatMap.PanCursor = Cursors.Hand;
            plotViewHeatMap.Size = new Size(606, 439);
            plotViewHeatMap.TabIndex = 10;
            plotViewHeatMap.Text = "plotViewHeatMap";
            plotViewHeatMap.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewHeatMap.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewHeatMap.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 738);
            Controls.Add(plotViewHeatMap);
            Controls.Add(plotViewDensity);
            Controls.Add(plotViewScatter);
            Controls.Add(plotViewHistogram);
            Controls.Add(CalculateStatistics);
            Controls.Add(LoadDataset);
            Controls.Add(AverageAge);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AverageAge;
        private Button LoadDataset;
        private Button CalculateStatistics;
        private OxyPlot.WindowsForms.PlotView plotViewHistogram;
        private OxyPlot.WindowsForms.PlotView plotViewScatter;
        private OxyPlot.WindowsForms.PlotView plotViewDensity;
        private OxyPlot.WindowsForms.PlotView plotViewHeatMap;
    }
}
