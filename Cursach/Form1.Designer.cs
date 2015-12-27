namespace Cursach
{
	partial class Generating
	{
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.fileName = new System.Windows.Forms.TextBox();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.seqSize = new System.Windows.Forms.NumericUpDown();
			this.minValue = new System.Windows.Forms.NumericUpDown();
			this.maxValue = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.firstNum = new System.Windows.Forms.NumericUpDown();
			this.formulaBox = new System.Windows.Forms.TextBox();
			this.seqSizeF = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.seqSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxValue)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.firstNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.seqSizeF)).BeginInit();
			this.SuspendLayout();
			// 
			// fileName
			// 
			this.fileName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.fileName.Location = new System.Drawing.Point(73, 98);
			this.fileName.Name = "fileName";
			this.fileName.Size = new System.Drawing.Size(268, 20);
			this.fileName.TabIndex = 0;
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
            "Возрастающая",
            "По формуле",
            "Рандомная",
            "Убывающая"});
			this.checkedListBox1.Location = new System.Drawing.Point(6, 28);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(100, 64);
			this.checkedListBox1.Sorted = true;
			this.checkedListBox1.TabIndex = 1;
			this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
			this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(347, 98);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(102, 20);
			this.button1.TabIndex = 2;
			this.button1.Text = "Генерация";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// seqSize
			// 
			this.seqSize.Location = new System.Drawing.Point(235, 8);
			this.seqSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.seqSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.seqSize.Name = "seqSize";
			this.seqSize.Size = new System.Drawing.Size(99, 20);
			this.seqSize.TabIndex = 3;
			this.seqSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// minValue
			// 
			this.minValue.Location = new System.Drawing.Point(89, 41);
			this.minValue.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
			this.minValue.Name = "minValue";
			this.minValue.Size = new System.Drawing.Size(73, 20);
			this.minValue.TabIndex = 4;
			// 
			// maxValue
			// 
			this.maxValue.Location = new System.Drawing.Point(261, 41);
			this.maxValue.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
			this.maxValue.Name = "maxValue";
			this.maxValue.Size = new System.Drawing.Size(73, 20);
			this.maxValue.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.seqSize);
			this.groupBox1.Controls.Add(this.maxValue);
			this.groupBox1.Controls.Add(this.minValue);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(112, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(337, 64);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(168, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Макс. значение";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Мин. значение";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Размер последовательности";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.firstNum);
			this.groupBox2.Controls.Add(this.formulaBox);
			this.groupBox2.Controls.Add(this.seqSizeF);
			this.groupBox2.Location = new System.Drawing.Point(112, 28);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(337, 64);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Visible = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 43);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Первый элемент";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(141, 43);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Формула";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(155, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Размер последовательности";
			// 
			// firstNum
			// 
			this.firstNum.Location = new System.Drawing.Point(99, 41);
			this.firstNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.firstNum.Name = "firstNum";
			this.firstNum.Size = new System.Drawing.Size(38, 20);
			this.firstNum.TabIndex = 9;
			this.firstNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// formulaBox
			// 
			this.formulaBox.Location = new System.Drawing.Point(202, 40);
			this.formulaBox.MaxLength = 40;
			this.formulaBox.Name = "formulaBox";
			this.formulaBox.Size = new System.Drawing.Size(129, 20);
			this.formulaBox.TabIndex = 8;
			// 
			// seqSizeF
			// 
			this.seqSizeF.Location = new System.Drawing.Point(234, 11);
			this.seqSizeF.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.seqSizeF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.seqSizeF.Name = "seqSizeF";
			this.seqSizeF.Size = new System.Drawing.Size(99, 20);
			this.seqSizeF.TabIndex = 3;
			this.seqSizeF.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Тип:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(109, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 13);
			this.label8.TabIndex = 12;
			this.label8.Text = "Параметры:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 101);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 13);
			this.label9.TabIndex = 13;
			this.label9.Text = "Имя файла";
			// 
			// Generating
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 123);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.fileName);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(469, 150);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(469, 150);
			this.Name = "Generating";
			this.Text = "Генерация последовательности";
			((System.ComponentModel.ISupportInitialize)(this.seqSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxValue)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.firstNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.seqSizeF)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox fileName;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown seqSize;
		private System.Windows.Forms.NumericUpDown minValue;
		private System.Windows.Forms.NumericUpDown maxValue;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.NumericUpDown firstNum;
		private System.Windows.Forms.TextBox formulaBox;
		private System.Windows.Forms.NumericUpDown seqSizeF;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
	}
}

