using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursach
{
	public partial class Generating : Form
	{
		public Generating()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				List<int> seq = new List<int>();
				String type = "";
				int count = 0;
				bool err = false;
				foreach (string chklb in checkedListBox1.CheckedItems) {

					if (chklb != "По формуле" && (Convert.ToInt32(minValue.Value) > Convert.ToInt32(maxValue.Value))) {
						MessageBox.Show("Друг, ты чего? У тебя макс. значение меньше минимального. Давай по-новой.");
						err = true;
						break;
					}

					switch (chklb) {
						case "Возрастающая":
							seq = GenerateIncSeq(Convert.ToInt32(seqSize.Value), Convert.ToInt32(minValue.Value), Convert.ToInt32(maxValue.Value));
							count = Convert.ToInt32(seqSize.Value);
							break;
						case "Убывающая":
							seq = GenerateDecSeq(Convert.ToInt32(seqSize.Value), Convert.ToInt32(minValue.Value), Convert.ToInt32(maxValue.Value));
							count = Convert.ToInt32(seqSize.Value);
							break;
						case "Рандомная":
							seq = GenerateRandSeq(Convert.ToInt32(seqSize.Value), Convert.ToInt32(minValue.Value), Convert.ToInt32(maxValue.Value));
							count = Convert.ToInt32(seqSize.Value);
							break;
						case "По формуле":
							seq = GenerateSeqByFormula(Convert.ToInt32(seqSizeF.Value), Convert.ToInt32(firstNum.Value), formulaBox.Text);
							count = Convert.ToInt32(seqSizeF.Value);
							break;
					}
					type = chklb;
				}

				if (checkedListBox1.CheckedItems.Count == 1 && !err) {
					String seqStr = "";
					if (seq.Count < 1000)
					{
						foreach (int item in seq)
							seqStr += item.ToString() + " ";
						seqStr = seqStr.Substring(0, seqStr.Length - 1);
					}
					else
					{
						seqStr = "Довольно большая для вывода на экран";
					}
					DialogResult dialogResult = MessageBox.Show("Ваша последовательность: \n'" + seqStr + "'\nВы хотите сохранить её в файл " + fileName.Text + ".txt?\nЕсли файл с таким именем уже существует, он будет перезаписан.", 
																"Some Title", 
																MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						if (seq.Count >= 1000)
						{
							seqStr = "";
							foreach (int item in seq)
								seqStr += item.ToString() + " ";
							seqStr = seqStr.Substring(0, seqStr.Length - 1);
						}

						string[] lines = { seqStr, type, count.ToString()};
						System.IO.File.WriteAllLines(@fileName.Text + ".txt", lines);
					}
				}
				else if (!err){
					MessageBox.Show("Ошибка. Не выбран тип последовательности.");
				}
			}
			catch (Exception exc) {
				MessageBox.Show("Ошибка в формуле. Читай документацию, друг." + Environment.NewLine + exc.Message);
			}
		}

		private List<int> GenerateRandSeq(Int32 seqSize, Int32 minValue, Int32 maxValue)
		{
			List<int> res = new List<int>();
			Random rnd = new Random();
			for (int i = 0; i < seqSize; i++)
				res.Add(minValue + rnd.Next(maxValue - minValue + 1));
			return res;
		}

		private List<int> GenerateSeqByFormula(Int32 seqSize, Int32 firstNum, String formula)
		{
			List<int> res = new List<int>();
			res.Add(firstNum);
			for (int i = firstNum, j = 0; j < seqSize - 1; j++) {
				Dictionary<String, Double> variables = new Dictionary<string, double>();
				string formula1 = formula.Replace("x", i.ToString());
				var exp = new PostfixNotationExpression(formula1, variables).Calc().ToString();
				i = Convert.ToInt32(exp);
				res.Add(i);
			}
			return res;
			throw new Exception();
		}

		private List<int> GenerateDecSeq(Int32 seqSize, Int32 minValue, Int32 maxValue)
		{
			List<int> res = new List<int>();
			Int32 step = (maxValue - minValue) / seqSize == 0 ? 1 : (maxValue - minValue) / seqSize;
			for (int i = maxValue, j = 0; j < seqSize; j++) {
				res.Add(i);
				i = (i - step < minValue ? i : i - step);
			}
			return res;
		}

		private List<int> GenerateIncSeq(Int32 seqSize, Int32 minValue, Int32 maxValue)
		{
			List<int> res = new List<int>();
			Int32 step = (maxValue - minValue) / seqSize == 0 ? 1 : (maxValue - minValue) / seqSize;
			for (int i = minValue, j = 0; j < seqSize; j++) {
				res.Add(i);
				i = (i + step > maxValue ? i : i + step);
			}
			return res;
		}

		private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			for (int i = 0; i < checkedListBox1.Items.Count; i++)
			{
				if (i != e.Index)
				{
					checkedListBox1.SetItemChecked(i, false);
				}
			}
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (checkedListBox1.CheckedItems.Contains(checkedListBox1.Items[1]))
			{
				groupBox1.Visible = false;
				groupBox2.Visible = true;
			}
			else
			{
				groupBox1.Visible = true;
				groupBox2.Visible = false;
			}
		}
	}
}
