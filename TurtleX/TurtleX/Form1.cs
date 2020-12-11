using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurtleLibrary;
using TurtleX.ParsersX;

namespace TurtleX
{
	public partial class TurtleXForm : Form
	{
		ParserX parser;
		public TurtleXForm()
		{
			InitializeComponent();
			parser = new ParserX();
			ParserX.kostil(); //госпади прости
		}

		private void button3_Click(object sender, EventArgs e)
		{
			listResults.Items.Clear();
			List<IExpression> expressions = new List<IExpression>();
			foreach (String s in listExpressions.Items)
			{
				try
				{
					listResults.Items.Add(parser.parse(s.ToString()).eval());
				}catch(ArgumentException ar)
				{
					listResults.Items.Add(ar.Message);
				} catch(Exception err)
				{
					MessageBox.Show(err.ToString(), "Error");
				}
			}
		}

		private void addExpression_Click(object sender, EventArgs e)
		{
			if (valueBox.Text != "")	
				listExpressions.Items.Add(valueBox.Text);
		}

		private void listExpressions_KeyDown(object sender, KeyEventArgs e)
		{
			int index = listExpressions.SelectedIndex;
			if (e.KeyCode == Keys.Back && listExpressions.Items[index].ToString().Length > 0)
				listExpressions.Items[index] = listExpressions.Items[index].ToString().Substring(0, listExpressions.Items[index].ToString().Length-1);
			else if (e.KeyCode == Keys.Space) listExpressions.Items[listExpressions.SelectedIndex] += " ";
			else
			{		
				char key = (e.KeyValue == 187) ? '=' : Convert.ToChar(e.KeyValue);
				listExpressions.Items[listExpressions.SelectedIndex] += key.ToString().ToLower();
			}
		}

		private void listExpressions_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listExpressions.SelectedItem != null)
				valueBox.Text = listExpressions.SelectedItem.ToString();
		}

		private void edit_Click(object sender, EventArgs e)
		{
			listExpressions.Items[listExpressions.SelectedIndex] = valueBox.Text;
		}
	}
}
