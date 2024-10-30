/*
 * Created by SharpDevelop.
 * User: CC2_PC45
 * Date: 30/10/2024
 * Time: 06:39 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu
{
	/// <summary>
	/// Description of Matematicas_calculo.
	/// </summary>
	public partial class Matematicas_calculo : Form
	{
		public Matematicas_calculo()
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
			Matematicas_calculo Matematicas_calculo = new Matematicas_calculo();
    		Matematicas_calculo.Show();
   			this.Hide(); 
		}
	}
}
