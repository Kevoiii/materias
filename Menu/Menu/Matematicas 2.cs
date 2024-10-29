/*
 * Created by SharpDevelop.
 * User: CC2-PC08
 * Date: 29/10/2024
 * Time: 07:54 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu
{
	/// <summary>
	/// Description of Matematicas_2.
	/// </summary>
	public partial class Matematicas_2 : Form
	{
		public Matematicas_2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void LblregresarClick(object sender, EventArgs e)
		{
			Matematicas Matematicas = new Matematicas();
            Matematicas.Show(); // Muestra Form1
            this.Close(); // Cierra Form2
		}
	}
}
