/*
 * Created by SharpDevelop.
 * User: CC2_PC11
 * Date: 24/10/2024
 * Time: 08:31 a. m.
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
	/// Description of ecosistemas.
	/// </summary>
	public partial class ecosistemas : Form
		
	{
		SpeechSynthesizer audio;
		public ecosistemas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			audio = new SpeechSynthesizer();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
	
		void BtnvolverClick(object sender, EventArgs e)
		{
			this.Close();  
		}
		void Button1Click(object sender, EventArgs e)
		{
			string audio1 ="En resumen, la ecología busca comprender cómo funciona la naturaleza y cómo los seres humanos pueden vivir en armonía con el planeta, nuestro hogar, y al mismo tiempo es como cuidarlo. Siendo el estudio de cómo los seres vivos interactúan entre sí y con su entorno, abarcando: Relaciones entre organismos, Interacciones con el medio ambiente, Dinámicas de poblaciones y ecosistemas, Impactos humanos en la naturaleza, Conservación y gestión de recursos";
			audio.Speak(audio1);
		}
	}
}
