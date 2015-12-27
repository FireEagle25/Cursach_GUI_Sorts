using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Cursach
{
	public partial class Experiment : Form
	{
		List<String> filesNames = new List<string>();
		List<string[]> data = new List<string[]>();
		
		public Experiment()
		{
			InitializeComponent();
			openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Multiselect = true;
		}

		private void explore_Click(object sender, EventArgs e)
		{
			filesNames = new List<string>();
			data = new List<string[]>();

			openFileDialog1.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			List<String> shortFilesNames = new List<string>();
			if (openFileDialog1.SafeFileNames.Length > 0)
				for (int i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
				{
					try
					{
						string fileName = Path.GetDirectoryName(openFileDialog1.FileName) + "\\" + openFileDialog1.SafeFileNames[i];
						shortFilesNames.Add(openFileDialog1.SafeFileNames[i]);
						filesNames.Add(fileName);
						String[] lines = new String[3];
						System.IO.StreamReader file = new System.IO.StreamReader(@fileName);
						for (int j = 0; j < 3; j++)
						{
							String line = file.ReadLine();
							lines[j] = line;
						}
						file.Close();
						data.Add(lines);
					}
					catch (Exception exc)
					{
					}
				}
			filesNames = shortFilesNames;



			 if (data.Count > 0)
			{
				bool isSameSize = !(data[0][1] == "");
				bool isSameType = !(data[0][2] == "");

				string type = data[0][1];
				string size = data[0][2];

				for (int i = 0; i < data.Count; i++) {
					if (data[i][1] != type)
						isSameType = false;
					if (data[i][2] != size)
						isSameSize = false;
				}
				if (isSameSize || isSameType)
				{
					//Изменить количество аргументов на нужное
					int[,] sortsRes = new int[data.Count, 8];
					try
					{
						bool isFileOk = true;
						for (int i = 0; i < data.Count; i++)
						{
							int compares = 0;
							int barters = 0;
							int time = 0;
							string[] curArrStr = data[i][0].Split(' ');
							if (curArrStr.Length != Convert.ToInt32(data[i][2]))
								isFileOk = false;
							int[] arr = new int[curArrStr.Length];
							for (int j = 0; j < curArrStr.Length; j++)
							{
								arr[j] = Convert.ToInt32(curArrStr[j]);

							}
							sortsRes[i, 6] = (data[i][1] == "Возрастающая" ? 0 : data[i][1] == "Убывающая" ? 1 : data[i][1] == "Рандомная" ? 2 : data[i][1] == "По формуле" ? 3 : -1);
							//if (sortsRes[i, 6] == -1)
							//	isFileOk = false;
							sortsRes[i, 7] = Convert.ToInt32(data[i][2]);

							int[] arr2 = new int[curArrStr.Length];
							for (int j = 0; j < curArrStr.Length; j++)
							{
								arr2[j] = Convert.ToInt32(curArrStr[j]);

							}

							//Добавь свой код
							Pyramid_Sort(arr, curArrStr.Length, ref compares, ref barters, ref time);
							sortsRes[i, 0] = compares;
							sortsRes[i, 1] = barters;
							sortsRes[i, 2] = time;

							QuickSort(arr2, curArrStr.Length - 1, ref compares, ref barters, ref time);
							sortsRes[i, 3] = compares;
							sortsRes[i, 4] = barters;
							sortsRes[i, 5] = time;
						}

						if (isFileOk)
						{
							//ShowGraphs showGraphs = new ShowGraphs(sortsRes, filesNames);
							//showGraphs.ShowDialog();
							Worker worker = new Worker(sortsRes, filesNames);
							worker.Do();
						}
						else
							MessageBox.Show("Один из входных файлов имел неверное представление");
					}

					catch (Exception exc)
					{
						MessageBox.Show("Ошибка. " + exc.Message);
					}
				}
				else
				{
					MessageBox.Show("Ошибка. Эксперимент можно проводить только если файлы имеют равное количество элементов или одинаковый тип последовательности.");
				}

			}
			else
				MessageBox.Show("Ошибка. Ни выбрано ни одного файла");

			filesNames = new List<string>();
			data = new List<string[]>();
			openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Multiselect = true;
		}

		static Int32 add2pyramid(int[] arr, Int32 i, Int32 N, ref Int32 com, ref Int32 bar)
		{
			Int32 imax;
			Int32 buf;
			if ((2 * i + 2) < N)
			{
				com++;
				if (arr[2 * i + 1] < arr[2 * i + 2]) imax = 2 * i + 2;
				else imax = 2 * i + 1;
			}
			else imax = 2 * i + 1;
			if (imax >= N) return i;
			com++;
			if (arr[i] < arr[imax])
			{
				bar++;
				buf = arr[i];
				arr[i] = arr[imax];
				arr[imax] = buf;
				if (imax < N / 2) i = imax;
			}
			return i;
		}

		static void Pyramid_Sort(int[] arrInp, Int32 len, ref Int32 com, ref Int32 bar, ref Int32 time)
		{
			Int32[] arr = arrInp;
			com = 0;
			bar = 0;
			System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch();
			swatch.Start();

			//step 1: building the pyramid
			for (Int32 i = len / 2 - 1; i >= 0; --i)
			{
				long prev_i = i;
				i = add2pyramid(arr, i, len, ref com, ref bar);
				if (prev_i != i) ++i;
			}

			//step 2: sorting
			Int32 buf;
			for (Int32 k = len - 1; k > 0; --k)
			{
				bar++;
				buf = arr[0];
				arr[0] = arr[k];
				arr[k] = buf;
				Int32 i = 0, prev_i = -1;
				while (i != prev_i)
				{
					prev_i = i;
					i = add2pyramid(arr, i, k, ref com, ref bar);
				}
			}
			swatch.Stop();
			time = (int) swatch.Elapsed.Ticks;
		}

		void QuickSort(int[] arrInp, int n, ref int com, ref int bar, ref int time)
		{
			int[] array = arrInp;
			com = 0;
			bar = 0;
			System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch();
			swatch.Start();
			QuickSort(array, 0, n - 1, ref com, ref bar);
			swatch.Stop();
			time = (int)swatch.Elapsed.Ticks;
		}

		void QuickSort(int[] array, int a, int b, ref int com, ref int bar)
		{
			int A = a;
			int B = b;
			int mid;

			if (b > a)
			{

				// Находим разделительный элемент в середине массива
				mid = array[(a + b) / 2];

				// Обходим массив
				while (A <= B)
				{
					/* Находим элемент, который больше или равен
					* разделительному элементу от левого индекса.
					*/
					com +=2 ;
					while ((A < b) && (array[A] < mid))
					{
						++A;
						com++;
					}

					/* Находим элемент, который меньше или равен
					 * разделительному элементу от правого индекса.
					 */
					while ((B > a) && (array[B] > mid)) {
						--B;
						com++;
					}

					// Если индексы не пересекаются, меняем
					if (A <= B)
					{
						int T;
						T = array[A];
						array[A] = array[B];
						array[B] = T;
						bar++;
						++A;
						--B;
					}
				}

				/* Если правый индекс не достиг левой границы массива,
				 * нужно повторить сортировку левой части.
				 */
				if (a < B) QuickSort(array, a, B, ref com, ref bar);

				/* Если левый индекс не достиг правой границы массива,
				 * нужно повторить сортировку правой части.
				 */
				if (A < b) QuickSort(array, A, b, ref com, ref bar);

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			filesNames = new List<string>();
			data = new List<string[]>();
			openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Multiselect = true;
			Generating gen = new Generating();
			gen.ShowDialog();
		}
	}

	class Worker
	{
		public Worker(int[,] sortsRes, List<String> filesNames)
		{
			showGraphs = new ShowGraphs(sortsRes, filesNames);
		}

		static private ShowGraphs showGraphs;

		Thread formThread;

		public void Do()
		{
			formThread = new Thread(ShowForm);
			formThread.Start();
		}

		void ShowForm()
		{
			showGraphs.ShowDialog();
		}
	}
}