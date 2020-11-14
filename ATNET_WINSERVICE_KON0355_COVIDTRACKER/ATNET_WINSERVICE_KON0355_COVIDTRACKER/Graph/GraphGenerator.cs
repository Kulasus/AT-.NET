using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATNET_WINSERVICE_KON0355_COVIDTRACKER.Graph
{
    class GraphGenerator
    {

        public static void GenerateGraph(int width, int height, int[] values)
        {
            int valuesLength = values.Length;
            int axisStartPointX = width / 10;
            int axisStartPointY = (height / 10) * 9;
            int axisTopPointY = height / 10;
            int axisTopPointX = (width / 10) * 9;

            Image img = new Bitmap(width, height);
            Graphics drawing = Graphics.FromImage(img);

            Point axisStartPoint = new Point(axisStartPointX, axisStartPointY);
            Point yAxisEndPoint = new Point(axisStartPointX, axisTopPointY);
            Point xAxisEndPoint = new Point(axisTopPointX, axisStartPointY);

            Brush redBrush = new SolidBrush(Color.Red);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush whiteBrush = new SolidBrush(Color.White);
            Pen blackPen = new Pen(blackBrush);
            Pen redPen = new Pen(redBrush);

            drawing.Clear(Color.White);

            drawing.DrawLine(blackPen, axisStartPoint, yAxisEndPoint);
            drawing.DrawLine(blackPen, axisStartPoint, xAxisEndPoint);

            Point[] graphPoints = new Point[valuesLength];
            double percentageOne = values.Max()/100;

            for(int i = 0; i < valuesLength; i++)
            {
                double percentageTwo = values[i] / percentageOne;
                int offset = (int)((axisStartPointY - axisTopPointY) / 100 * percentageTwo);

                graphPoints[i] = new Point(
                    axisStartPointX + (axisTopPointX - axisStartPointX) / (valuesLength - 1) * i,
                    axisStartPointY - offset);
                //drawing.FillEllipse(redBrush, new Rectangle(graphPoints[i], new Size(10, 10)));
                //Console.WriteLine(values[i]);
            }

            for (int i = 0; i < graphPoints.Length - 1; i++)
            {
                drawing.DrawLine(redPen, graphPoints[i], graphPoints[i + 1]);
            }
            for (int i = 0; i < graphPoints.Length; i++)
            {

                drawing.DrawLine(blackPen, graphPoints[i], new Point(graphPoints[i].X, axisStartPointY));
            }



            drawing.Save();
            img.Save("testImg.jpg");



        }
    }
}
