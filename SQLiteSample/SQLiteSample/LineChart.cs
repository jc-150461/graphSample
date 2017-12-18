using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OxyPlot;
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

        }
    }
}
