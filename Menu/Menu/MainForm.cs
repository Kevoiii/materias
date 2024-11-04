/*
 * Created by SharpDevelop.
 * User: CC2-PC13
 * Date: 24/10/2024
 * Time: 04:21 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Menu 
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtninglesClick(object sender, EventArgs e)
		{
			English ingles = new English();
			this.Hide();
			ingles.ShowDialog();
			this.Close();
			
		}
		void BtnFisicaClick(object sender, EventArgs e)
		{ 
			Fisica1 ingles = new Fisica1();
			this.Hide();
			ingles.ShowDialog();
			this.Close();
			
		}
		void BtnmateClick(object sender, EventArgs e)
		{
			Matematicas ingles = new Matematicas();
			this.Hide();
			ingles.ShowDialog();
			this.Close();
			
		}
		void BtnhumanidadesClick(object sender, EventArgs e)
		{
			Humanidades ingles = new Humanidades();
			this.Hide();
			ingles.ShowDialog();
			this.Close();
			
		}
		void BtnecoClick(object sender, EventArgs e)
		{
			ecosistemas ingles = new ecosistemas();
			this.Hide();
			ingles.ShowDialog();
			this.Close();
			
		}
	}
}
