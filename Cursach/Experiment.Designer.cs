namespace Cursach
{
	partial class Experiment
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.explore = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(12, 60);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(236, 41);
			this.button1.TabIndex = 0;
			this.button1.Text = "Провести эксперимент";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Текстовые файлы|*.txt";
			this.openFileDialog1.Multiselect = true;
			// 
			// explore
			// 
			this.explore.Location = new System.Drawing.Point(12, 12);
			this.explore.Name = "explore";
			this.explore.Size = new System.Drawing.Size(103, 42);
			this.explore.TabIndex = 1;
			this.explore.Text = "Выбрать файлы";
			this.explore.UseVisualStyleBackColor = true;
			this.explore.Click += new System.EventHandler(this.explore_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(121, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(127, 42);
			this.button2.TabIndex = 2;
			this.button2.Text = "Сгенерировать последовательность";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Experiment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(255, 113);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.explore);
			this.Controls.Add(this.button1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(263, 140);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(263, 140);
			this.Name = "Experiment";
			this.ShowIcon = false;
			this.Text = "Experiment";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button explore;
		private System.Windows.Forms.Button button2;
	}
}