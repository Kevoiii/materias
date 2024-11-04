/*
 * Created by SharpDevelop.
 * User: CC2_PC11
 * Date: 28/10/2024
 * Time: 08:29 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu
{
	/// <summary>
	/// Description of Fisica1.
	/// </summary>
	public partial class Fisica1 : Form  
	{
		public Fisica1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			// 
		}
		void Button1Click(object sender, EventArgs e)
		{
			  double vo = double.Parse(txtvo.Text);
			  double t = double.Parse(txtt.Text);
			  double a = double.Parse(txta.Text);
			  double vel= vo-a*t;
			  MessageBox.Show("La velocidad fue: "+ vel.ToString());
		}
		void BtnvolverClick(object sender, EventArgs e) 
		{
			MainForm ingles = new MainForm();
			this.Hide();
			ingles.ShowDialog();
			this.Close();
		}
			
		}
	}

