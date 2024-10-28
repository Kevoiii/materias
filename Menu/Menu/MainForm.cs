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
			ingles.Show();
			
		}
		void BtnFisicaClick(object sender, EventArgs e)
		{ 
			Fisica1 fisica = new Fisica1();
			fisica.Show();
			
		}
		void BtnmateClick(object sender, EventArgs e)
		{
			Matematicas mate = new Matematicas();
			mate.Show();
			
		}
		void BtnhumanidadesClick(object sender, EventArgs e)
		{
			Humanidades huma = new Humanidades();
			huma.Show();
			
		}
		void BtnecoClick(object sender, EventArgs e)
		{
			ecosistemas eco = new ecosistemas();
			eco.Show();
			
		}
	}
}
