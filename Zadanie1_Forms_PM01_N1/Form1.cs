using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1_Forms_PM01_N1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				double x1 = double.Parse(textBox1.Text);
				double x2 = double.Parse(textBox2.Text);
				double x3 = double.Parse(textBox3.Text);
				double y1 = double.Parse(textBox6.Text);
				double y2 = double.Parse(textBox5.Text);
				double y3 = double.Parse(textBox4.Text);

				double A = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
				double B = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
				double C = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

				double P = A + B + C;

				textBox7.Text = string.Format("Периметр треугольника равен: {0,5:f3}.", P);
			}
			catch
			{
				textBox7.Text = string.Format("Координаты должны содержать только цифры!!");
			}
		}
	}
}
