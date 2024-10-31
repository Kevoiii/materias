/*
 * Created by SharpDevelop.
 * User: CC2-PC15
 * Date: 24/10/2024
 * Time: 04:27 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu
{
	/// <summary>
	/// Description of Matematicas.
	/// </summary>
	public partial class Matematicas : Form
	{
		public Matematicas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnregresarClick(object sender, EventArgs e)
		{
			this.Close(); 
			
		}
		
		void BtncalcularClick(object sender, EventArgs e)
		{
			 	double Cal_1=double.Parse(txtCal_1.Text);
                double cal_2=double.Parse(txtcal_2.Text);
                double cal_3=double.Parse(txtcal_3.Text);
                double cal_4=double.Parse(txtcal_4.Text);
                double cal_5=double.Parse(txtcal_5.Text);
                double cal;
                cal=(Cal_1+cal_2+cal_3+cal_4+cal_5)/5;
		
			MessageBox.Show("El promedio es "+cal.ToString());
        }
	} 
}
