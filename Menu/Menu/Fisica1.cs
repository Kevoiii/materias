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
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double vo = double.Parse(Txtvo.Text);
			double t = double.Parse(Txtt.Text);
			double a = double.Parse(Txta.Text);
			double vel;
			vel = vo-a*t;
			MessageBox.Show("La velocidad fue: "+ vel.ToString());
		}
		//kkkk
	} 
}
