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
		
		void BtncalcularClick(object sender, EventArgs e)
		{
			double Cal_1=double.Parse(txtCal_1.Text);
                double Cal_2=double.Parse(txtCal_2.Text);
                double Cal_3=double.Parse(txtCal_3.Text);
                double Cal_4=double.Parse(txtCal_4.Text);
                double Cal_5=double.Parse(txtCal_5.Text);
                double Cal;
                Cal=(Cal_1+Cal_2+Cal_3+Cal_4+Cal_5)/5;
        
            MessageBox.Show("El promedio es "+Cal.ToString());
		}
	} 
}
