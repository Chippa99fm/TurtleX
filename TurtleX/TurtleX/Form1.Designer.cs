namespace TurtleX
{
	partial class TurtleXForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
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
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurtleXForm));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.calculate = new System.Windows.Forms.Button();
			this.listExpressions = new System.Windows.Forms.ListBox();
			this.listResults = new System.Windows.Forms.ListBox();
			this.addExpression = new System.Windows.Forms.Button();
			this.valueBox = new System.Windows.Forms.TextBox();
			this.edit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(118, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Импортировать";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(224, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Экспортировать";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// calculate
			// 
			this.calculate.Location = new System.Drawing.Point(12, 12);
			this.calculate.Name = "calculate";
			this.calculate.Size = new System.Drawing.Size(100, 23);
			this.calculate.TabIndex = 5;
			this.calculate.Text = "Расчитать";
			this.calculate.UseVisualStyleBackColor = true;
			this.calculate.Click += new System.EventHandler(this.button3_Click);
			// 
			// listExpressions
			// 
			this.listExpressions.FormattingEnabled = true;
			this.listExpressions.Location = new System.Drawing.Point(12, 50);
			this.listExpressions.Name = "listExpressions";
			this.listExpressions.Size = new System.Drawing.Size(206, 251);
			this.listExpressions.TabIndex = 6;
			this.listExpressions.SelectedIndexChanged += new System.EventHandler(this.listExpressions_SelectedIndexChanged);
			this.listExpressions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listExpressions_KeyDown);
			// 
			// listResults
			// 
			this.listResults.FormattingEnabled = true;
			this.listResults.Location = new System.Drawing.Point(349, 50);
			this.listResults.Name = "listResults";
			this.listResults.Size = new System.Drawing.Size(358, 251);
			this.listResults.TabIndex = 7;
			// 
			// addExpression
			// 
			this.addExpression.Location = new System.Drawing.Point(224, 48);
			this.addExpression.Name = "addExpression";
			this.addExpression.Size = new System.Drawing.Size(100, 23);
			this.addExpression.TabIndex = 8;
			this.addExpression.Text = "Add expression";
			this.addExpression.UseVisualStyleBackColor = true;
			this.addExpression.Click += new System.EventHandler(this.addExpression_Click);
			// 
			// valueBox
			// 
			this.valueBox.Location = new System.Drawing.Point(224, 77);
			this.valueBox.Name = "valueBox";
			this.valueBox.Size = new System.Drawing.Size(100, 20);
			this.valueBox.TabIndex = 9;
			// 
			// edit
			// 
			this.edit.Location = new System.Drawing.Point(224, 103);
			this.edit.Name = "edit";
			this.edit.Size = new System.Drawing.Size(100, 23);
			this.edit.TabIndex = 10;
			this.edit.Text = "Edit expression";
			this.edit.UseVisualStyleBackColor = true;
			this.edit.Click += new System.EventHandler(this.edit_Click);
			// 
			// TurtleXForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 357);
			this.Controls.Add(this.edit);
			this.Controls.Add(this.valueBox);
			this.Controls.Add(this.addExpression);
			this.Controls.Add(this.listResults);
			this.Controls.Add(this.listExpressions);
			this.Controls.Add(this.calculate);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TurtleXForm";
			this.Text = "TurtleX";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button calculate;
		private System.Windows.Forms.ListBox listExpressions;
		private System.Windows.Forms.ListBox listResults;
		private System.Windows.Forms.Button addExpression;
		private System.Windows.Forms.TextBox valueBox;
		private System.Windows.Forms.Button edit;
	}
}

