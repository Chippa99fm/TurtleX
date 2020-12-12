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
using TurtleX.Utility;

namespace TurtleX
{
	public partial class TurtleXForm : Form
	{
		ParserX parser;
		private FileDialog fileDialog = new OpenFileDialog();
		public TurtleXForm()
		{
			InitializeComponent();
			parser = new ParserX();
			ParserX.initOperators(); //госпади прости
			fileDialog.Filter = "Text|*.txt|All|*.*";
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

		private void button3_Click_1(object sender, EventArgs e)
		{
			listExpressions.Items.Clear();
			listResults.Items.Clear();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			String path;
			fileDialog.ShowDialog();
			path = fileDialog.FileName;
			if (path != null)
			{
				ExprsExporter exporter = new ExprsExporter(path, listboxToList(listExpressions.Items));
				if (!exporter.export())
				{
					MessageBox.Show("Something went wrong");
				}
				else
				{
					MessageBox.Show("Success");
				}
			}

		}

		private List<String> listboxToList(ListBox.ObjectCollection lisbox)
		{
			List<String> result = new List<String>();
			foreach (String expr in lisbox)
			{
				result.Add(expr);
			}

			return result;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String path;
			fileDialog.ShowDialog();
			path = fileDialog.FileName;
			if (path != null)
			{
				FileImporter importer = new FileImporter(path);
				if (!importer.import())
				{
					MessageBox.Show("Something went wrong");
				}
				else
				{
					listExpressions.Items.Clear();
					listResults.Items.Clear();
					foreach (String expr in importer.exprs)
					{
						listExpressions.Items.Add(expr);
					}

					MessageBox.Show("Success");
				}
			}
		}
	}
}
