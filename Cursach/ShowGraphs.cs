using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cursach
{
	public partial class ShowGraphs : Form
	{
		int[,] arr;
		public ShowGraphs(int[,] inpArr, List<String> filesNames)
		{
			InitializeComponent();

			arr = inpArr;

			string[] labels = filesNames.ToArray<string>();

			chart1.Series.Clear();
			chart2.Series.Clear();
			chart3.Series.Clear();

			//Легенды
			chart3.Series.Add("Пирамидальная");
			chart3.Series.Add("Быстрая");
			chart2.Series.Add("Пирамидальная");
			chart2.Series.Add("Быстрая");
			chart1.Series.Add("Пирамидальная");
			chart1.Series.Add("Быстрая");
			
			for (int j = 0, i = 0; j < arr.GetLength(0); j++, i++)
			{
				//Добавление точек на первый график
				//Добавление красных точек на первый график
				chart1.Series[0].Points.AddY(arr[j, 0]);
				//Добавление желтых точек на первый график
				chart1.Series[1].Points.AddY(arr[j, 3]);
				chart1.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(i, i + 2, labels[j], 0, LabelMarkStyle.LineSideMark));

				chart2.Series[0].Points.AddY(arr[j, 1]);
				chart2.Series[1].Points.AddY(arr[j, 4]);
				chart2.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(i, i + 2, labels[j], 0, LabelMarkStyle.LineSideMark));

				chart3.Series[0].Points.AddY(arr[j, 2]);
				chart3.Series[1].Points.AddY(arr[j, 5]);
				chart3.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(i, i + 2, labels[j], 0, LabelMarkStyle.LineSideMark));
			}
		}
	}
}
