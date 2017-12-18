
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;


namespace SQLiteSample
{
    class LineChart
    {
        public PlotModel Model { get; private set; }

        public LineChart()
        {
            this.Model = new PlotModel { Title = "LineChart" };

            var X_line = new LineSeries();
            X_line.Color = OxyColors.Red;
            X_line.Points.Add(new DataPoint(0, 0));
            X_line.Points.Add(new DataPoint(1, 4));
            X_line.Points.Add(new DataPoint(2, 1));
            X_line.Points.Add(new DataPoint(3, 3));
            Model.Series.Add(X_line);

            var axisY = new LinearAxis()
            {
                Title = "datas",
                IsZoomEnabled = false,
                Position = AxisPosition.Left,
                Maximum = 150,
                Minimum = 50,
                MajorStep = 10,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                ExtraGridlines = new double[] { 1,2,3,8,9,10 },
                ExtraGridlineThickness = 3,
                ExtraGridlineColor = OxyColors.SkyBlue,
            };
            Model.Axes.Add(axisY);
        }
    }
}
