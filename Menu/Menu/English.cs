/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 28/10/2024
 * Time: 08:25 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Menu
{
	/// <summary>
	/// Description of English.
	/// </summary>
	public partial class English : Form
	{
		private SpeechSynthesizer synthesier;
		public English()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			synthesier = new SpeechSynthesizer(); 
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			string texto= "El verbo, to be es fundamental en inglés y se utiliza para identificar, describir y situar personas o cosas. Este verbo permite afirmar quién o qué es alguien, expresar características y ubicar elementos en un espacio determinado. Por ejemplo, se puede usar para identificar a una persona: He is a doctor, (Él es un médico), o para describir características, como en. She is happy, (Ella está feliz). También se utiliza para indicar la ubicación, como en. The book is on the table, (El libro está sobre la mesa).";

            synthesier.Speak(texto);
           
		}
	}
}
