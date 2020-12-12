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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
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
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(157, 15);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(133, 28);
			this.button1.TabIndex = 3;
			this.button1.Text = "Импортировать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(299, 15);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(133, 28);
			this.button2.TabIndex = 4;
			this.button2.Text = "Экспортировать";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// calculate
			// 
			this.calculate.Location = new System.Drawing.Point(16, 15);
			this.calculate.Margin = new System.Windows.Forms.Padding(4);
			this.calculate.Name = "calculate";
			this.calculate.Size = new System.Drawing.Size(133, 28);
			this.calculate.TabIndex = 5;
			this.calculate.Text = "Расчитать";
			this.calculate.UseVisualStyleBackColor = true;
			this.calculate.Click += new System.EventHandler(this.button3_Click);
			// 
			// listExpressions
			// 
			this.listExpressions.FormattingEnabled = true;
			this.listExpressions.ItemHeight = 16;
			this.listExpressions.Location = new System.Drawing.Point(16, 62);
			this.listExpressions.Margin = new System.Windows.Forms.Padding(4);
			this.listExpressions.Name = "listExpressions";
			this.listExpressions.Size = new System.Drawing.Size(273, 308);
			this.listExpressions.TabIndex = 6;
			this.listExpressions.SelectedIndexChanged += new System.EventHandler(this.listExpressions_SelectedIndexChanged);
			this.listExpressions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listExpressions_KeyDown);
			// 
			// listResults
			// 
			this.listResults.FormattingEnabled = true;
			this.listResults.ItemHeight = 16;
			this.listResults.Location = new System.Drawing.Point(465, 62);
			this.listResults.Margin = new System.Windows.Forms.Padding(4);
			this.listResults.Name = "listResults";
			this.listResults.Size = new System.Drawing.Size(476, 308);
			this.listResults.TabIndex = 7;
			// 
			// addExpression
			// 
			this.addExpression.Location = new System.Drawing.Point(299, 59);
			this.addExpression.Margin = new System.Windows.Forms.Padding(4);
			this.addExpression.Name = "addExpression";
			this.addExpression.Size = new System.Drawing.Size(133, 28);
			this.addExpression.TabIndex = 8;
			this.addExpression.Text = "Add expression";
			this.addExpression.UseVisualStyleBackColor = true;
			this.addExpression.Click += new System.EventHandler(this.addExpression_Click);
			// 
			// valueBox
			// 
			this.valueBox.Location = new System.Drawing.Point(299, 95);
			this.valueBox.Margin = new System.Windows.Forms.Padding(4);
			this.valueBox.Name = "valueBox";
			this.valueBox.Size = new System.Drawing.Size(132, 22);
			this.valueBox.TabIndex = 9;
			// 
			// edit
			// 
			this.edit.Location = new System.Drawing.Point(299, 127);
			this.edit.Margin = new System.Windows.Forms.Padding(4);
			this.edit.Name = "edit";
			this.edit.Size = new System.Drawing.Size(133, 28);
			this.edit.TabIndex = 10;
			this.edit.Text = "Edit expression";
			this.edit.UseVisualStyleBackColor = true;
			this.edit.Click += new System.EventHandler(this.edit_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(299, 162);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(132, 23);
			this.button3.TabIndex = 11;
			this.button3.Text = "Clear";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click_1);
			// 
			// TurtleXForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(959, 439);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.edit);
			this.Controls.Add(this.valueBox);
			this.Controls.Add(this.addExpression);
			this.Controls.Add(this.listResults);
			this.Controls.Add(this.listExpressions);
			this.Controls.Add(this.calculate);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TurtleXForm";
			this.Text = "TurtleX";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Button button3;

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

