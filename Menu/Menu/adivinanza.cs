/*
 * Created by SharpDevelop.
 * User: CC2_PC29
 * Date: 30/10/2024
 * Time: 07:41 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu
{
	/// <summary>
	/// Description of adivinanza.
	/// </summary>
	public partial class adivinanza : Form
	{
		public adivinanza()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnVerificarClick(object sender, EventArgs e)
		{
			string respuestaCorrecta1 = "Literatura";
			string respuestaCorrecta2 = "Historia";
			
			string respuestaUsuario1 = txtRespuesta1.Text.Trim();
            string respuestaUsuario2 = txtRespuesta2.Text.Trim();
            
		 if (respuestaUsuario1.Equals(respuestaCorrecta1, StringComparison.OrdinalIgnoreCase) &&
        respuestaUsuario2.Equals(respuestaCorrecta2, StringComparison.OrdinalIgnoreCase))
    {
        MessageBox.Show("¡Ambas respuestas son correctas!");
    }
    else
    {
        MessageBox.Show("Una o ambas respuestas son incorrectas, intenta de nuevo.");
    }  
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	} 
} 
