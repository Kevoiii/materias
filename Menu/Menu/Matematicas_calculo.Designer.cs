/*
 * Created by SharpDevelop.
 * User: CC2_PC45
 * Date: 30/10/2024
 * Time: 06:39 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Menu
{
	partial class Matematicas_calculo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblpromedio = new System.Windows.Forms.Label();
			this.lbldesviacion = new System.Windows.Forms.Label();
			this.lblreprobados = new System.Windows.Forms.Label();
			this.lblaprobados = new System.Windows.Forms.Label();
			this.lblmenor = new System.Windows.Forms.Label();
			this.lblmayor = new System.Windows.Forms.Label();
			this.lblmoda = new System.Windows.Forms.Label();
			this.lblmedia = new System.Windows.Forms.Label();
			this.lblp_aprobados = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.btnregresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblpromedio
			// 
			this.lblpromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblpromedio.Location = new System.Drawing.Point(12, 40);
			this.lblpromedio.Name = "lblpromedio";
			this.lblpromedio.Size = new System.Drawing.Size(77, 25);
			this.lblpromedio.TabIndex = 3;
			this.lblpromedio.Text = "Promedio";
			// 
			// lbldesviacion
			// 
			this.lbldesviacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbldesviacion.Location = new System.Drawing.Point(12, 215);
			this.lbldesviacion.Name = "lbldesviacion";
			this.lbldesviacion.Size = new System.Drawing.Size(111, 25);
			this.lbldesviacion.TabIndex = 4;
			this.lbldesviacion.Text = "Desviacion";
			// 
			// lblreprobados
			// 
			this.lblreprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblreprobados.Location = new System.Drawing.Point(12, 190);
			this.lblreprobados.Name = "lblreprobados";
			this.lblreprobados.Size = new System.Drawing.Size(111, 25);
			this.lblreprobados.TabIndex = 5;
			this.lblreprobados.Text = "Reprobados";
			// 
			// lblaprobados
			// 
			this.lblaprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblaprobados.Location = new System.Drawing.Point(12, 165);
			this.lblaprobados.Name = "lblaprobados";
			this.lblaprobados.Size = new System.Drawing.Size(111, 25);
			this.lblaprobados.TabIndex = 6;
			this.lblaprobados.Text = "Aprobados";
			// 
			// lblmenor
			// 
			this.lblmenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblmenor.Location = new System.Drawing.Point(12, 140);
			this.lblmenor.Name = "lblmenor";
			this.lblmenor.Size = new System.Drawing.Size(111, 25);
			this.lblmenor.TabIndex = 7;
			this.lblmenor.Text = "Menor";
			// 
			// lblmayor
			// 
			this.lblmayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblmayor.Location = new System.Drawing.Point(12, 115);
			this.lblmayor.Name = "lblmayor";
			this.lblmayor.Size = new System.Drawing.Size(111, 25);
			this.lblmayor.TabIndex = 8;
			this.lblmayor.Text = "Mayor";
			// 
			// lblmoda
			// 
			this.lblmoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblmoda.Location = new System.Drawing.Point(12, 90);
			this.lblmoda.Name = "lblmoda";
			this.lblmoda.Size = new System.Drawing.Size(111, 25);
			this.lblmoda.TabIndex = 9;
			this.lblmoda.Text = "Moda";
			// 
			// lblmedia
			// 
			this.lblmedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblmedia.Location = new System.Drawing.Point(12, 65);
			this.lblmedia.Name = "lblmedia";
			this.lblmedia.Size = new System.Drawing.Size(111, 25);
			this.lblmedia.TabIndex = 10;
			this.lblmedia.Text = "Media";
			// 
			// lblp_aprobados
			// 
			this.lblp_aprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblp_aprobados.Location = new System.Drawing.Point(12, 240);
			this.lblp_aprobados.Name = "lblp_aprobados";
			this.lblp_aprobados.Size = new System.Drawing.Size(178, 25);
			this.lblp_aprobados.TabIndex = 13;
			this.lblp_aprobados.Text = "Promedio de aprobados";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(95, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(326, 20);
			this.textBox1.TabIndex = 14;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(95, 164);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(326, 20);
			this.textBox2.TabIndex = 15;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(95, 139);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(326, 20);
			this.textBox3.TabIndex = 16;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(95, 114);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(326, 20);
			this.textBox4.TabIndex = 17;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(95, 89);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(326, 20);
			this.textBox5.TabIndex = 18;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(95, 64);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(326, 20);
			this.textBox6.TabIndex = 19;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(106, 189);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(315, 20);
			this.textBox7.TabIndex = 20;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(187, 239);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(234, 20);
			this.textBox8.TabIndex = 21;
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(106, 214);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(315, 20);
			this.textBox9.TabIndex = 22;
			// 
			// btnregresar
			// 
			this.btnregresar.Location = new System.Drawing.Point(14, 312);
			this.btnregresar.Name = "btnregresar";
			this.btnregresar.Size = new System.Drawing.Size(75, 23);
			this.btnregresar.TabIndex = 23;
			this.btnregresar.Text = "Regresar";
			this.btnregresar.UseVisualStyleBackColor = true;
			this.btnregresar.Click += new System.EventHandler(this.BtnregresarClick);
			// 
			// Matematicas_calculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(431, 361);
			this.Controls.Add(this.btnregresar);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblp_aprobados);
			this.Controls.Add(this.lblmedia);
			this.Controls.Add(this.lblmoda);
			this.Controls.Add(this.lblmayor);
			this.Controls.Add(this.lblmenor);
			this.Controls.Add(this.lblaprobados);
			this.Controls.Add(this.lblreprobados);
			this.Controls.Add(this.lbldesviacion);
			this.Controls.Add(this.lblpromedio);
			this.Name = "Matematicas_calculo";
			this.Text = "Matematicas_calculo";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnregresar;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblp_aprobados;
		private System.Windows.Forms.Label lblmedia;
		private System.Windows.Forms.Label lblmoda;
		private System.Windows.Forms.Label lblmayor;
		private System.Windows.Forms.Label lblmenor;
		private System.Windows.Forms.Label lblaprobados;
		private System.Windows.Forms.Label lblreprobados;
		private System.Windows.Forms.Label lbldesviacion;
		private System.Windows.Forms.Label lblpromedio;
	}
}
