using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Helpers;

namespace ATNET_WINSERVICE_KON0355_COVIDTRACKER.Graph
{
    class GraphGenerator
    {
        /// <summary>
        /// Class for generating graphs and saving them as images
        /// </summary>
        public static void GenerateGraph(int width, int height, int[] values)
        {
            int valuesLength = values.Length;
            int axisStartPointX = width / 10;
            int axisStartPointY = (height / 10) * 9;
            int axisTopPointY = height / 10;
            int axisTopPointX = (width / 10) * 9;
            int circleWidth = 10;
            int circleHeight = 10;

            Image img = new Bitmap(width, height);
            Graphics drawing = Graphics.FromImage(img);

            Point axisStartPoint = new Point(axisStartPointX, axisStartPointY);
            Point yAxisEndPoint = new Point(axisStartPointX, axisTopPointY);
            Point xAxisEndPoint = new Point(axisTopPointX, axisStartPointY);

            Brush redBrush = new SolidBrush(Color.Red);
            Brush blackBrush = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(blackBrush);
            Pen redPen = new Pen(redBrush);

            drawing.Clear(Color.White);

            //Axis
            drawing.DrawLine(blackPen, axisStartPoint, yAxisEndPoint);
            drawing.DrawLine(blackPen, axisStartPoint, xAxisEndPoint);

            Point[] graphPoints = new Point[valuesLength];
            double percentageOne = values.Max() / 100;

            for (int i = 0; i < valuesLength; i++)
            {
                double percentageTwo = values[i] / percentageOne;
                int offset = (int)((axisStartPointY - axisTopPointY) / 100 * percentageTwo);

                //Storing points to array for every value
                graphPoints[i] = new Point(
                    axisStartPointX + (axisTopPointX - axisStartPointX) / (valuesLength - 1) * i,
                    axisStartPointY - offset);

                //Drawing circle in point location
                drawing.FillEllipse(redBrush, new Rectangle(new Point(graphPoints[i].X - circleWidth / 2, graphPoints[i].Y - circleHeight / 2), new Size(10, 10)));

                //Drawing number to point location
                drawing.DrawString(values[i].ToString(), new Font("Arial", 16), blackBrush, new Point(graphPoints[i].X + 10, graphPoints[i].Y - 30));
            }

            //Drawing point to point lines (red)
            for (int i = 0; i < graphPoints.Length - 1; i++)
            {
                drawing.DrawLine(redPen, graphPoints[i], graphPoints[i + 1]);
            }
            //Drawing point to x axis lines (black)
            for (int i = 0; i < graphPoints.Length; i++)
            { 
                drawing.DrawLine(blackPen, graphPoints[i], new Point(graphPoints[i].X, axisStartPointY));
            }
            //Drawing dates 
            DateTime today = DateTime.Now;
            for (int i = values.Length-1; i >= 0; i--)
            {
                drawing.DrawString(today.Day.ToString() + "." + today.Month.ToString() + ".", new Font("Arial", 16), blackBrush, new Point(graphPoints[i].X-20, axisStartPointY+ 10));
                today = today.AddDays(-1);
            }


            //Saving
            drawing.Save();
            img.Save(Session.projectPath+@"\Resources\Graph.jpg");
        }
    }
}
