﻿
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using Xamarin.Forms;
using SQLiteSample;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections;

namespace SQLiteSample
{
    class LineChart
    {
        public PlotModel Model { get; private set; }

        public  LineChart()
        {

            TodoItemDatabase itemDataBase = TodoItemDatabase.getDatabase();
            List<TodoItem> itemList  =  itemDataBase.GetItemsAsync();
            this.Model = new PlotModel { Title = "LineChart" };

            var X_line = new LineSeries();
            X_line.Color = OxyColors.Red;
            foreach(TodoItem item in itemList)
            {
                DataPoint dp = new DataPoint(item.ID, item.Count);
                X_line.Points.Add(dp);

            }


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
