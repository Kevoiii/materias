/*
 * Created by SharpDevelop.
 * User: CC2-PC14
 * Date: 24/10/2024
 * Time: 08:28 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu
{
	/// <summary>
	/// Description of Humanidades.
	/// </summary>
	public partial class Humanidades : Form
	{
		public Humanidades()
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
			adivinanza adivina = new adivinanza();
				adivina.Show();
		}
		
		void BtnVolverClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
} 
